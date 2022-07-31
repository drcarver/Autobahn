using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace AutobahnCodeGen
{
    public class MauiModule
    {
        public static Autobahn.Entities.Autobahn AutobahnContext { get; set; } =
            new Autobahn.Entities.Autobahn("data source=DESKTOP-6CQUBDS\\SQLEXPRESS;initial catalog=CEDS-IDS-V10_0_0_0;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public static Dictionary<string, List<string>> RefModels { get; set; } = new Dictionary<string, List<string>>();

        /// <summary>
        /// Generate the Module <see Autobahn.Entity.Activity />
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="moduleName"></param>
        /// <param name="elements"></param>
        /// <param name="types"></param>
        public static void GenerateModule(string filePath, string moduleName, 
            List<CEDSElement> elements, Type[] types)
        {
            GenerateTemplateProject(filePath, moduleName);
            GenerateModels(filePath, moduleName, elements, types.Where(t => !t.Name.StartsWith("Ref")));
            GenerateInterfaces(filePath, moduleName, elements, types.Where(t => !t.Name.StartsWith("Ref")));
            //GenerateReferenceFiles(filePath, moduleName, types.Where(t => t.Name.StartsWith("Ref")));
        }

        private static void GenerateInterfaces(string filePath, string moduleName, List<CEDSElement> elements, IEnumerable<Type> nonreftypes)
        {
            var interfacelist = new List<Type>();
            foreach (var model in nonreftypes)
            {
                if (!model.IsClass)
                {
                    continue;
                }
                var element = elements.FirstOrDefault(e => e.TableName.ToLower().Trim() == model.Name.ToLower().Trim());
                if (element != null)
                {
                    interfacelist.Add(model);
                }
            }
            var fpath = $@"{filePath}\{moduleName}\Interfaces\";
            GenerateInterfaceFiles(fpath, moduleName, elements, interfacelist);
        }

        private static void GenerateModels(string filePath, string moduleName, List<CEDSElement> elements, IEnumerable<Type> nonreftypes)
        {
            var classlist = new List<Type>();
            foreach (var model in nonreftypes)
            {
                if (!model.IsClass)
                {
                    continue;
                }
                var element = elements.FirstOrDefault(e => e.TableName.ToLower().Trim() == model.Name.ToLower().Trim());
                if (element != null)
                {
                    classlist.Add(model);
                }
            }
            var fpath = $@"{filePath}\{moduleName}\Models\";
            GenerateModelFiles(fpath, moduleName, elements, classlist);
        }

        private static void GenerateModelFiles(string filePath, string moduleName, List<CEDSElement> elements, IEnumerable<Type> models)
        {
            foreach (var model in models)
            {
                var fname = $@"{filePath}\{model.Name}.cs";
                using (var stream = File.CreateText(fname))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {moduleName}");
                    stream.WriteLine($"//* FileName:   {model.Name}.cs");
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine("");
                    stream.WriteLine($"using {moduleName}.Interfaces;");
                    stream.WriteLine("");
                    stream.WriteLine($"namespace {moduleName}.Models");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The {model.Name}");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($@"    public partial class {model.Name} : I{model.Name}");
                    stream.WriteLine($@"    {{");
                    GenerateProperties(stream, model, elements, moduleName);
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateInterfaceFiles(string filePath, string moduleName, List<CEDSElement> elements, IEnumerable<Type> models)
        {
            foreach (var model in models)
            {
                var fname = $@"{filePath}\I{model.Name}.cs";
                using (var stream = File.CreateText(fname))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {moduleName}");
                    stream.WriteLine($"//* FileName:   I{model.Name}.cs");
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine("");
                    stream.WriteLine($"namespace {moduleName}.Interfaces");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The I{model.Name}");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($@"    public partial Interface I{model.Name}");
                    stream.WriteLine($@"    {{");
                    GenerateProperties(stream, model, elements, moduleName, true);
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateProperties(StreamWriter stream, Type model, 
            List<CEDSElement> elements, string moduleName, bool isInterface = false)
        {
            foreach (var prop in model.GetProperties())
            {
                // no virtual properties.  We will handle those later as service calls
                if (prop.GetAccessors()[0].IsVirtual)
                {
                    continue;
                }

                var modifier = string.Empty;
                if (!isInterface)
                {
                    modifier = "public ";
                }
                var element = elements.FirstOrDefault(e => e.TableName == model.Name && e.TechnicalName == prop.Name);
                if (element != null)
                {
                    stream.WriteLine($"        /// <summary>");
                    stream.WriteLine($"        /// {element.Definition}");
                    stream.WriteLine($"        /// </summary>");
                    if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                    {
                        stream.WriteLine($"    {modifier}{Nullable.GetUnderlyingType(prop.PropertyType)}? {prop.Name} {{ get; set; }}");
                    }
                    else
                    {
                        stream.WriteLine($"    {modifier}{prop.PropertyType} {prop.Name} {{ get; set; }}");
                    }
                    stream.WriteLine();
                    continue;
                }

                if (prop.Name.EndsWith("Id"))
                {
                    var nospacesprop = prop.Name.Replace("Id", string.Empty);
                    stream.WriteLine($"        /// <summary>");
                    if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                    {
                        stream.WriteLine($"        /// Reference to an optional instance of the <see cref=\"{nospacesprop}\"/> model");
                        stream.WriteLine($"        /// </summary>");
                        stream.WriteLine($"        {modifier}Guid? {prop.Name} {{ get; set; }}");
                    }
                    else
                    {
                        stream.WriteLine($"        /// Reference to a required instance of the <see cref=\"{nospacesprop}\"/> model");
                        stream.WriteLine($"        /// </summary>");
                        stream.WriteLine($"        {modifier}Guid {prop.Name} {{ get; set; }}");
                    }
                    stream.WriteLine();

                    if (nospacesprop.StartsWith("Ref") && !isInterface)
                    {
                        if (!RefModels.ContainsKey(nospacesprop))
                        {
                            var vals = new List<string> { moduleName };
                            RefModels.Add(nospacesprop, vals);
                        }
                        else
                        {
                            if (!RefModels[nospacesprop].Contains(moduleName))
                            {
                                RefModels[nospacesprop].Add(moduleName);
                            }
                        }
                    }
                    continue;
                }

                if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                {
                    stream.WriteLine($"        /// <summary>");
                    stream.WriteLine($"        /// Defines the {model.Name}.{prop.Name} nullable property");
                    stream.WriteLine($"        /// </summary>");
                    stream.WriteLine($"        {modifier}{Nullable.GetUnderlyingType(prop.PropertyType)}? {prop.Name} {{ get; set; }}");
                }
                else
                {
                    stream.WriteLine($"        /// <summary>");
                    stream.WriteLine($"        /// Defines the {model.Name}.{prop.Name} non nullable property");
                    stream.WriteLine($"        /// </summary>");
                    stream.WriteLine($"        {modifier}{prop.PropertyType} {prop.Name} {{ get; set; }}");
                }
                stream.WriteLine();
            }
        }

        private static void GenerateReferenceFiles(string filePath, string moduleName, IEnumerable<Type> reftypes)
        {
            foreach (var reftype in reftypes)
            {
                var fname = $@"{filePath}\{moduleName}\{reftype.Name}.cs";
                using (var stream = File.CreateText(fname))
                {
                    stream.WriteLine("using Autobahn.Core.Interface;");
                    stream.WriteLine("");
                    stream.WriteLine("namespace Autobahn.Core.Models");
                    stream.WriteLine("{");
                    stream.WriteLine($@"    public partial class {reftype.Name} : ReferencePickList");
                    stream.WriteLine($@"    {{");
                    stream.WriteLine($@"        ");
                    GetData(reftype, stream);
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateTemplateProject(string filePath, string moduleName)
        {
            DirectoryInfo di = new DirectoryInfo($@"{filePath}\{moduleName}");
            RecursiveDelete(di);
            ZipFile.ExtractToDirectory($@"Reference\mauiproject.zip", filePath);
            File.Move($@"{filePath}\mauiproject\module.csproj", $@"{filePath}\mauiproject\{moduleName}.csproj");
            File.Move($@"{filePath}\mauiproject\mauimodule.cs", $@"{filePath}\mauiproject\{moduleName}Module.cs");
            Directory.Move($@"{filePath}\mauiproject", $@"{filePath}\{moduleName}");
        }

        private static async void GetData(Type reftype, StreamWriter sw)
        {
            //var data = await AutobahnContext.RefAbsentAttendanceCategories
            //    .Select(new ReferenceModel());
            //foreach (RefAbsentAttendanceCategory item in data)
            //{
            //    sw.WriteLineAsync(item.Code);
            //}
        }

        public static void RecursiveDelete(DirectoryInfo baseDir)
        {
            if (!baseDir.Exists)
                return;

            foreach (var dir in baseDir.EnumerateDirectories())
            {
                RecursiveDelete(dir);
            }
            baseDir.Delete(true);
        }
    }
}
