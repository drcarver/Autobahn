using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace AutobahnCodeGen
{
    public class MauiModule
    {
        public static Autobahn.Entities.Autobahn AutobahnContext { get; set; } =
            new Autobahn.Entities.Autobahn("data source=DESKTOP-6CQUBDS\\SQLEXPRESS;initial catalog=CEDS-IDS-V10_0_0_0;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public static Dictionary<string, List<string>> RefModels { get; set; } = new Dictionary<string, List<string>>();

        public static void GenerateModule(Dictionary<string, List<string>> CEDDomains,
            List<CEDSTable> tables, List<Type> types, List<NDSElement> elements)
        {
            foreach (var dir in CEDDomains.Keys)
            {
                var fname = dir.Replace(" ", string.Empty);
                var filePath = $@"C:\Users\drcarver\Desktop\codegen\Autobahn\Code\Generated\";
                var moduleName = $"Autobahn.{fname}";

                GenerateTemplateProject(filePath, moduleName);
                GenerateModels(filePath, moduleName, tables.Where(t => t.Domain == fname).OrderBy(o => o.TableName).ToList(), types.OrderBy(o => o.Name).ToList(), elements);
                GenerateInterfaces(filePath, moduleName, tables.Where(t => t.Domain == fname).OrderBy(o => o.TableName).ToList(), types.OrderBy(o => o.Name).ToList(), elements);
                GenerateViewModels(filePath, moduleName, tables.Where(t => t.Domain == fname).OrderBy(o => o.TableName).ToList(), types.OrderBy(o => o.Name).ToList(), elements);
            }
            //GenerateReferenceFiles(filePath, moduleName, types.Where(t => t.Name.StartsWith("Ref")));
        }

        private static void GenerateViewModels(string filePath, string moduleName,
            List<CEDSTable> tables, List<Type> classes, List<NDSElement> elements)
        {
            var vmlist = new List<Type>();
            var fpath = string.Empty;
            foreach (var model in classes)
            {
                if (!model.IsClass)
                {
                    continue;
                }

                var file = tables.FirstOrDefault(f => f.TableName == model.Name);
                if (file != null)
                {
                    if (!vmlist.Contains(model))
                    {
                        vmlist.Add(model);
                        file.FilePath = $@"{filePath}\{moduleName}\ViewModels\{model.Name}ViewModel.cs";
                    }
                }
            }
            GenerateViewModelFile($@"{filePath}\{moduleName}\ViewModels\", moduleName, tables, vmlist, elements);
        }

        private static void GenerateViewModelFile(string filePath, string moduleName,
            List<CEDSTable> tables, List<Type> classes, List<NDSElement> elements)
        {
            foreach (var model in classes)
            {
                var fullFilePath = $"{filePath}{model.Name}ViewModek.cs";
                using (var stream = File.CreateText(fullFilePath))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {moduleName}");
                    stream.WriteLine($"//* FileName:   {model.Name}ViewModel.cs");
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine("");
                    stream.WriteLine("using Prism.Mvvm;");
                    stream.WriteLine($"using Autobahn.Common.Interfaces;");
                    stream.WriteLine($"using Autobahn.{moduleName}.Interfaces;");
                    stream.WriteLine("");
                    stream.WriteLine($"namespace {moduleName}.ViewModels");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The {model.Name}ViewModel");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($@"    public partial class {model.Name}ViewModel : BindableBase, I{model.Name}");
                    stream.WriteLine($@"    {{");
                    GenerateBindableProperties(stream, model, elements, moduleName, false);
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateInterfaces(string filePath, string moduleName,
            List<CEDSTable> tables, List<Type> classes, List<NDSElement> elements)
        {
            var interfacelist = new List<Type>();
            foreach (var model in classes)
            {
                if (!model.IsClass)
                {
                    continue;
                }

                var file = tables.FirstOrDefault(f => f.TableName == model.Name);
                if (file != null)
                {
                    interfacelist.Add(model);
                    file.FilePath = $@"{filePath}\{moduleName}\Interfaces\";
                }
            }
            var fpath = $@"{filePath}\{moduleName}\Interfaces\";
            GenerateInterfaceFiles(fpath, moduleName, interfacelist, elements);
        }

        private static void GenerateModels(string filePath, string moduleName,
            List<CEDSTable> tables, List<Type> classes, List<NDSElement> elements)
        {
            var classlist = new List<Type>();
            foreach (var model in classes)
            {
                if (!model.IsClass)
                {
                    continue;
                }

                var file = tables.FirstOrDefault(f => f.TableName == model.Name);
                if (file != null)
                {
                    classlist.Add(model);
                    file.FilePath = $@"{filePath}\{moduleName}\ViewModels\";
                }
                else
                {
                    continue;
                }
            }
            var fpath = $@"{filePath}\{moduleName}\Models\";
            GenerateModelFiles(fpath, moduleName, classlist, elements);
        }

        private static void GenerateModelFiles(string filePath, string moduleName, 
            List<Type> models, List<NDSElement> elements)
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

        private static void GenerateInterfaceFiles(string filePath, string moduleName, 
            List<Type> models, List<NDSElement> elements)
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
                    stream.WriteLine($@"    public partial interface I{model.Name}");
                    stream.WriteLine($@"    {{"); 
                    GenerateProperties(stream, model, elements, moduleName, true);
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateProperties(StreamWriter stream, Type model,
            List<NDSElement> elements, string moduleName, bool isInterface = false)
        {
            foreach (var prop in model.GetProperties())
            {
                // no virtual properties.  We will handle those later as service calls
                if (prop.GetAccessors()[0].IsVirtual)
                {
                    continue;
                }
                if (prop.Name == $"{model.Name}Id")
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
                        stream.WriteLine($"    {modifier}{Nullable.GetUnderlyingType(prop.PropertyType)}? {prop.Name} {{ get => _{prop.Name}; set => SetProperty(_{prop.Name}, value); }}");
                    }
                    else
                    {
                        stream.WriteLine($"    {modifier}{prop.PropertyType} {prop.Name}  {{ get => _{prop.Name}; set => SetProperty(_{prop.Name}, value); }}");
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

        private static void GenerateBindableProperties(StreamWriter stream, Type model,
            List<NDSElement> elements, string moduleName, bool isInterface = false)
        {
            if (!isInterface)
            {
                GenerateBackingFields(stream, model);
            }

            var proplist = new List<PropertyInfo>();
            stream.WriteLine($"#region Properties");
            foreach (var prop in model.GetProperties())
            {
                // no virtual properties.  We will handle those later as service calls
                if (prop.GetAccessors()[0].IsVirtual)
                {
                    continue;
                }

                if (prop.Name == $"{model.Name}Id")
                {
                    continue;
                }

                var modifier = string.Empty;
                if (!isInterface)
                {
                    modifier = "public ";
                }

                if (prop.Name.EndsWith("Id"))
                {
                    if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                    {
                        stream.WriteLine($"        /// <summary>");
                        stream.WriteLine($"        /// Reference to an optional instance of the <see cref=\"{prop.Name}\"/> model");
                        stream.WriteLine($"        /// </summary>");
                        stream.WriteLine($"        {modifier}Guid? {prop.Name} {{ get; set; }}");
                    }
                    else
                    {
                        stream.WriteLine($"        /// <summary>");
                        stream.WriteLine($"        /// Reference to a required instance of the <see cref=\"{prop.Name}\"/> model");
                        stream.WriteLine($"        /// </summary>");
                        stream.WriteLine($"        {modifier}Guid {prop.Name} {{ get; set; }}");
                    }
                    stream.WriteLine();
                    proplist.Add(prop);
                    continue;
                }

                var element = elements.FirstOrDefault(e => e.TableName == model.Name && e.TechnicalName == prop.Name);
                if (element != null)
                {
                    stream.WriteLine($"        /// <summary>");
                    stream.WriteLine($"        /// {element.Definition}");
                    stream.WriteLine($"        /// </summary>");
                }

                if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                {
                    stream.WriteLine($"        {modifier}{Nullable.GetUnderlyingType(prop.PropertyType)}? {prop.Name} {{ get => _{prop.Name}; set => SetProperty(ref _{prop.Name}, value); }}");
                }
                else
                {
                    stream.WriteLine($"        {modifier}{prop.PropertyType} {prop.Name}  {{ get => _{prop.Name}; set => SetProperty(ref _{prop.Name}, value); }}");
                }
                proplist.Add(prop);
                stream.WriteLine();
            }
            stream.WriteLine($"#endregion");
            stream.WriteLine();

            // Create the Load() method
            stream.WriteLine();
            stream.WriteLine($"        /// <summary>");
            stream.WriteLine($"        /// Load the viewmodel from a model");
            stream.WriteLine($"        /// </summary>");
            stream.WriteLine($"        public void Load(I{model.Name} model)");
            stream.WriteLine($"        {{");
            stream.WriteLine($"            IsBusy = true;");
            stream.WriteLine($"            Id = model.Id;");
            foreach (var prop in proplist)
            {
                stream.WriteLine($"            {prop.Name} = model.{prop.Name};");
            }
            stream.WriteLine($"            IsChanged = false;");
            stream.WriteLine($"            IsNew = false;");
            stream.WriteLine($"            IsBusy = false;");
            stream.WriteLine($"        }}");
        }

        private static void GenerateBackingFields(StreamWriter stream, Type model)
        {
            stream.WriteLine($"#region \"Backing Fields\"");
            foreach (var prop in model.GetProperties())
            {
                // no virtual properties.  We will handle those later as service calls
                // the id property of the class is inherited
                // Id properties are automatic properties
                if (prop.GetAccessors()[0].IsVirtual
                    || prop.Name == $"{model.Name}Id"
                    || prop.Name.EndsWith("Id"))
                {
                    continue;
                }

                // Nullable regular property backing field.
                if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                {
                    stream.WriteLine($"        // member variable for the {prop.Name} property");
                    stream.WriteLine($"        private {Nullable.GetUnderlyingType(prop.PropertyType)}? _{prop.Name};");
                    stream.WriteLine();
                }
                else
                {
                    stream.WriteLine($"        // member variable for the {prop.Name} property");
                    stream.WriteLine($"        private {prop.PropertyType} _{prop.Name};");
                    stream.WriteLine();
                }
            }
            stream.WriteLine($"#endregion");
            stream.WriteLine();
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
