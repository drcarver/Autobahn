using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using Autobahn.Entities;
using File = System.IO.File;

namespace AutobahnCodeGen
{
    public class MauiModule
    {
        public static Autobahn.Entities.Autobahn AutobahnContext { get; set; } =
            new Autobahn.Entities.Autobahn("data source=DESKTOP-6CQUBDS\\SQLEXPRESS;initial catalog=CEDS-IDS-V10_0_0_0;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public static Dictionary<string, List<string>> RefModels { get; set; } = new Dictionary<string, List<string>>();

        public static void GenerateModule(Dictionary<string, List<string>> CEDDomains,
            List<CEDSTable> tables, List<Type> types, List<CEDSElement> elements)
        {
            var filePath = $@"C:\Users\drcarver\Desktop\codegen\Autobahn\Code\Generated\";
            foreach (var dir in CEDDomains.Keys)
            {
                var fname = dir.Replace(" ", string.Empty);
                var moduleName = $"Autobahn.{fname}";

                GenerateTemplateProject(filePath, moduleName, tables.Where(t => t.Domain == fname).OrderBy(o => o.TableName).ToList());
                GenerateModels(filePath, moduleName, tables.Where(t => t.Domain == fname).OrderBy(o => o.TableName).ToList(), types.OrderBy(o => o.Name).ToList(), elements);
                GenerateInterfaces(filePath, moduleName, tables.Where(t => t.Domain == fname).OrderBy(o => o.TableName).ToList(), types.OrderBy(o => o.Name).ToList(), elements);
                GenerateViewModels(filePath, moduleName, tables.Where(t => t.Domain == fname).OrderBy(o => o.TableName).ToList(), types.OrderBy(o => o.Name).ToList(), elements);
                GenerateViews(filePath, moduleName, tables.Where(t => t.Domain == fname).OrderBy(o => o.TableName).ToList(), types.OrderBy(o => o.Name).ToList(), elements);
                FindReferenceProperties(types.ToList(), moduleName, tables.Where(t => t.Domain == fname).ToList());
            }
            GenerateReferenceModels(filePath, tables, types.OrderBy(o => o.Name).ToList(), elements);
        }

        private static void FindReferenceProperties(List<Type> types, string moduleName, List<CEDSTable> tables)
        {
            foreach (var model in types)
            {
                if (!model.IsClass 
                    || tables.All(t => t.TableName != model.Name))
                {
                    continue;
                }
                foreach(var prop in model.GetProperties())
                {
                    if (prop.Name.StartsWith("Ref"))
                    {
                        var refmodelname = prop.Name.Replace("Id", string.Empty);
                        if (refmodelname.EndsWith("Statu"))
                        {
                            refmodelname = refmodelname.Replace("Statu", "Status");
                        }
                        if (!RefModels.ContainsKey(refmodelname))
                        {
                            var vals = new List<string> { moduleName };
                            RefModels.Add(refmodelname, vals);
                        }
                        else
                        {
                            if (!RefModels[refmodelname].Contains(moduleName))
                            {
                                RefModels[refmodelname].Add(moduleName);
                            }
                        }
                    }
                }
            }
        }

        private static void GenerateReferenceModels(string filePath, List<CEDSTable> tables, List<Type> models, List<CEDSElement> elements)
        {
            foreach (var refmodel in RefModels.Keys)
            {
                var model = models.FirstOrDefault(m => m.Name == refmodel);
                if (model != null)
                {
                    var currentdomain = RefModels[refmodel].Count > 1 ? "Autobahn.Common" : RefModels[refmodel][0];
                    GenerateReferenceFile($@"{filePath}{currentdomain}\Models\", currentdomain, model, tables, elements);
                    GenerateReferenceInterfaceFile($@"{filePath}{currentdomain}\Interfaces\", currentdomain, model, tables, elements);
                    GenerateReferenceList($@"{filePath}{currentdomain}\Models\", currentdomain, model);
                }
            }
        }

        private static void GenerateReferenceList(string filePath, string moduleName, Type model)
        {
            var csv = new CEDSService();
            var refernceModelList = csv.ReadReferenceFile($@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\{model.Name}.csv");
            var fullFilePath = $"{filePath}{model.Name}List.cs";
            using (var stream = File.CreateText(fullFilePath))
            {
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine($"//* DomainName: {moduleName}");
                stream.WriteLine($"//* FileName:   {model.Name}List.cs");
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine("");
                stream.WriteLine($"using Autobahn.Common.Models;");
                stream.WriteLine("");
                stream.WriteLine($"namespace {moduleName}.Models");
                stream.WriteLine("{");
                stream.WriteLine($"     /// <summary>");
                stream.WriteLine($"     /// The list of {model.Name} Models");
                stream.WriteLine($"     /// </summary>");
                stream.WriteLine($@"    public static partial class ReferenceLists");
                stream.WriteLine($@"    {{");
                stream.WriteLine($@"        /// <summary>");
                stream.WriteLine($@"        /// The complete <see cref=""{model.Name}""> List");
                stream.WriteLine($"         /// </summary>");
                stream.WriteLine($@"        public static List<{model.Name}> {model.Name}List = new List<{model.Name}>");
                stream.WriteLine($@"        {{");
                var quote = "\"";
                foreach (var item in refernceModelList)
                {
                    var fixedId = $"Guid.Parse({quote}{item.Id}{quote})";
                    var fixedCode = $"{quote}{item.Code?.Replace("\u0022", "\\u0022")}{quote}";
                    var fixedDescription = $"{quote}{item.Description?.Replace("\u0022", "\\u0022")}{quote}";
                    var fixedDefinition = $"{quote}{item.Definition?.Replace("\u0022", "\\u0022")}{quote}";
                    stream.WriteLine($@"            new {model.Name} {{ Id={fixedId}, Code={fixedCode}, Description={fixedDescription}, Definition={fixedDefinition}, SortOrder=Convert.ToDecimal({quote}{item.SortOrder}{quote}) }},");
                }
                stream.WriteLine($@"        }};");
                stream.WriteLine();
                stream.WriteLine($@"        /// <summary>");
                stream.WriteLine($@"        /// The {model.Name} Pick List");
                stream.WriteLine($"         /// </summary>");
                stream.WriteLine($@"        public static List<{model.Name}> {model.Name}PickList = new List<{model.Name}>");
                stream.WriteLine($@"        {{");
                foreach (var item in refernceModelList)
                {
                    var fixedId = $"Guid.Parse({quote}{item.Id}{quote})";
                    var fixedCode = $"{quote}{item.Code?.Replace("\u0022", "\\u0022")}{quote}";
                    var fixedDescription = $"{quote}{item.Description?.Replace("\u0022", "\\u0022")}{quote}";
                    stream.WriteLine($@"            new {model.Name} {{ Id={fixedId}, Code={fixedCode}, Description={fixedDescription}, SortOrder=Convert.ToDecimal({quote}{item.SortOrder}{quote}) }},");
                }
                stream.WriteLine($@"       }};");
                stream.WriteLine("   }");
                stream.WriteLine("}");
            }
        }

        private static void GenerateReferenceFile(string filePath, string moduleName, Type model, List<CEDSTable> tables, List<CEDSElement> elements)
        {
            var fullFilePath = $"{filePath}{model.Name}.cs";
            using (var stream = File.CreateText(fullFilePath))
            {
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine($"//* DomainName: {moduleName}");
                stream.WriteLine($"//* FileName:   {model.Name}.cs");
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine("");
                stream.WriteLine($"using Autobahn.Common.Models;");
                stream.WriteLine($"using {moduleName}.Interfaces;");
                stream.WriteLine("");
                stream.WriteLine($"namespace {moduleName}.Models");
                stream.WriteLine("{");
                stream.WriteLine($"     /// <summary>");
                stream.WriteLine($"     /// The {model.Name} Model");
                stream.WriteLine($"     /// </summary>");
                stream.WriteLine($@"    public partial class {model.Name} : ReferenceModelBase, I{model.Name}");
                stream.WriteLine($@"    {{");
                List<string> propertiesToIgnore = new List<string>
                {
                    "RecordStartDateTime",
                    "RecordEndDateTime",
                    "RecordStatusId",
                    "Description",
                    "Code",
                    "Definition",
                    "RefJurisdictionId",
                    "SortOrder",
                    "DataCollectionId"
                };
                GenerateProperties(stream, model, elements, moduleName, propertiesToIgnore, false);
                stream.WriteLine($@"    }}");
                stream.WriteLine("}");
            }
        }

        private static void GenerateReferenceInterfaceFile(string filePath, string moduleName, Type model, List<CEDSTable> tables, List<CEDSElement> elements)
        {
            var fullFilePath = $"{filePath}I{model.Name}.cs";
            using (var stream = File.CreateText(fullFilePath))
            {
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine($"//* DomainName: {moduleName}");
                stream.WriteLine($"//* FileName:   I{model.Name}.cs");
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine("");
                stream.WriteLine($"using Autobahn.Common.Interfaces;");
                stream.WriteLine("");
                stream.WriteLine($"namespace {moduleName}.Interfaces");
                stream.WriteLine("{");
                stream.WriteLine($"     /// <summary>");
                stream.WriteLine($"     /// The {model.Name} Interface");
                stream.WriteLine($"     /// </summary>");
                stream.WriteLine($@"    public partial interface I{model.Name} : IReferenceModel");
                stream.WriteLine($@"    {{");
                List<string> propertiesToIgnore = new List<string>
                {
                    "RecordStartDateTime",
                    "RecordEndDateTime",
                    "RecordStatusId",
                    "Description",
                    "Code",
                    "Definition",
                    "RefJurisdictionId",
                    "SortOrder",
                    "DataCollectionId"
                };
                GenerateProperties(stream, model, elements, moduleName, propertiesToIgnore, true);
                stream.WriteLine($@"    }}");
                stream.WriteLine("}");
            }
        }

        private static void GenerateViews(string filePath, string moduleName, List<CEDSTable> tables, List<Type> classes, List<CEDSElement> elements)
        {
            var viewlist = new List<Type>();
            foreach (var model in classes.Where(m => !m.Name.StartsWith("Ref")))
            {
                if (!model.IsClass)
                {
                    continue;
                }

                var file = tables.FirstOrDefault(f => f.TableName == model.Name);
                if (file != null)
                {
                    if (!viewlist.Contains(model))
                    {
                        viewlist.Add(model);
                        file.FilePath = $@"{filePath}\{moduleName}\Views\{model.Name}View.cs";
                    }
                }
            }
            GenerateViewFile($@"{filePath}\{moduleName}\Views\", moduleName, tables, viewlist, elements);
            GenerateXAMLFile($@"{filePath}\{moduleName}\Views\", moduleName, tables, viewlist, elements);
        }

        private static void GenerateXAMLFile(string filePath, string moduleName, List<CEDSTable> tables, List<Type> models, List<CEDSElement> elements)
        {
            foreach (var model in models.Where(m => !m.Name.StartsWith("Ref")))
            {
                var fname = $@"{filePath}\{model.Name}View.xaml";
                using (var stream = File.CreateText(fname))
                {
                    stream.WriteLine($"<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                    stream.WriteLine($"<!--");
                    stream.WriteLine($" DomainName: {moduleName}");
                    stream.WriteLine($" FileName:   {model.Name}View.cs");
                    stream.WriteLine($"-->");
                    stream.WriteLine($"<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"");
                    stream.WriteLine($"             xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"");
                    stream.WriteLine($"             xmlns:vm= \"clr-namespace:{moduleName}.ViewModels\"");
                    stream.WriteLine($"             x:Class=\"{moduleName}.Views.{model.Name}View\"");
                    stream.WriteLine($"             x:DataType=\"vm:{model.Name}ViewModel\"");
                    stream.WriteLine($"             Title=\"{{Binding ViewTitle}}\">");
                    stream.WriteLine("    <VerticalStackLayout>");
                    stream.WriteLine("        <Label");
                    stream.WriteLine("           Text=\"Welcome to .NET MAUI!\"");
                    stream.WriteLine("           VerticalOptions=\"Center\"");
                    stream.WriteLine("           HorizontalOptions=\"Center\" />");
                    stream.WriteLine("    </VerticalStackLayout>");
                    stream.WriteLine("</ContentPage>");
                }
            }
        }

        private static void GenerateViewFile(string filePath, string moduleName, List<CEDSTable> tables, List<Type> models, List<CEDSElement> elements)
        {
            foreach (var model in models.Where(m => !m.Name.StartsWith("Ref")))
            {
                var fname = $@"{filePath}\{model.Name}View.xaml.cs";
                using (var stream = File.CreateText(fname))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {moduleName}");
                    stream.WriteLine($"//* FileName:   {model.Name}View.cs");
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine("");
                    stream.WriteLine($"using {moduleName}.ViewModels;");
                    stream.WriteLine("");
                    stream.WriteLine($"namespace {moduleName}.Views");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The {model.Name}View");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($"     [XamlCompilation(XamlCompilationOptions.Compile)]");
                    stream.WriteLine($@"    public partial class {model.Name}View : ContentPage");
                    stream.WriteLine($@"    {{");
                    stream.WriteLine($@"        /// <summary>");
                    stream.WriteLine($@"        /// Inject the {model.Name}ViewModel as the data context for the view");
                    stream.WriteLine($@"        /// </summary>");
                    stream.WriteLine($@"        public {model.Name}View({model.Name}ViewModel vm)");
                    stream.WriteLine($@"        {{");
                    stream.WriteLine($@"            BindingContext  = vm;");
                    stream.WriteLine($@"        }}");
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateViewModels(string filePath, string moduleName,
            List<CEDSTable> tables, List<Type> classes, List<CEDSElement> elements)
        {
            var vmlist = new List<Type>();
            var fpath = string.Empty;
            foreach (var model in classes.Where(m => !m.Name.StartsWith("Ref")))
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
            List<CEDSTable> tables, List<Type> classes, List<CEDSElement> elements)
        {
            foreach (var model in classes.Where(m => !m.Name.StartsWith("Ref")))
            {
                var fullFilePath = $"{filePath}{model.Name}ViewModel.cs";
                using (var stream = File.CreateText(fullFilePath))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {moduleName}");
                    stream.WriteLine($"//* FileName:   {model.Name}ViewModel.cs");
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine("");
                    if (moduleName != "Autobahn.Common")
                    {
                        stream.WriteLine($"using Autobahn.Common.Interfaces;");
                        stream.WriteLine($"using Autobahn.Common.ViewModels;");
                    }
                    stream.WriteLine("");
                    stream.WriteLine($"namespace {moduleName}.ViewModels");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The {model.Name}ViewModel");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($@"    public partial class {model.Name}ViewModel : ViewModelBase, Interfaces.I{model.Name}");
                    stream.WriteLine($@"    {{");
                    List<string> propertiesToIgnore = new List<string>
                    {
                        "RecordStartDateTime",
                        "RecordEndDateTime",
                        "RecordStatusId",
                        "DataCollectionId"
                    };
                    GenerateBindableProperties(stream, model, elements, moduleName, propertiesToIgnore);
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateInterfaces(string filePath, string moduleName,
            List<CEDSTable> tables, List<Type> classes, List<CEDSElement> elements)
        {
            var interfacelist = new List<Type>();
            foreach (var model in classes.Where(m => !m.Name.StartsWith("Ref")))
            {
                if (!model.IsClass)
                {
                    continue;
                }

                var file = tables.FirstOrDefault(f => f.TableName == model.Name);
                if (file != null)
                {
                    interfacelist.Add(model);
                    file.FilePath = $@"{filePath}\{moduleName}\Interfaces\I{model.Namespace}.cs";
                }
            }
            var fpath = $@"{filePath}\{moduleName}\Interfaces\";
            GenerateInterfaceFiles(fpath, moduleName, interfacelist, elements);
        }

        private static void GenerateModels(string filePath, string moduleName,
            List<CEDSTable> tables, List<Type> classes, List<CEDSElement> elements)
        {
            var classlist = new List<Type>();
            foreach (var model in classes.Where(m => !m.Name.StartsWith("Ref")))
            {
                if (!model.IsClass)
                {
                    continue;
                }

                var file = tables.FirstOrDefault(f => f.TableName == model.Name);
                if (file != null)
                {
                    classlist.Add(model);
                    file.FilePath = $@"{filePath}\{moduleName}\Models\{model.Namespace}.cs";
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
            List<Type> models, List<CEDSElement> elements)
        {
            foreach (var model in models.Where(m => !m.Name.StartsWith("Ref")))
            {
                var fname = $@"{filePath}\{model.Name}.cs";
                using (var stream = File.CreateText(fname))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {moduleName}");
                    stream.WriteLine($"//* FileName:   {model.Name}.cs");
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine("");
                    if (moduleName != "Autobahn.Common")
                    {
                        stream.WriteLine($"using Autobahn.Common.Interfaces;");
                        stream.WriteLine($"using Autobahn.Common.Models;");
                    }
                    stream.WriteLine("");
                    stream.WriteLine($"namespace {moduleName}.Models");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The {model.Name}");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($@"    public partial class {model.Name} : AutobahnBase, Interfaces.I{model.Name}");
                    stream.WriteLine($@"    {{");
                    List<string> propertiesToIgnore = new List<string>
                    {
                        "RecordStartDateTime",
                        "RecordEndDateTime",
                        "RecordStatusId"
                    };
                    GenerateProperties(stream, model, elements, moduleName, propertiesToIgnore);
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateInterfaceFiles(string filePath, string moduleName, 
            List<Type> models, List<CEDSElement> elements)
        {
            foreach (var model in models.Where(m => !m.Name.StartsWith("Ref")))
            {
                var fname = $@"{filePath}\I{model.Name}.cs";
                using (var stream = File.CreateText(fname))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {moduleName}");
                    stream.WriteLine($"//* FileName:   I{model.Name}.cs");
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine("");
                    if (moduleName != "Autobahn.Common")
                    {
                        stream.WriteLine($"using Autobahn.Common.Interfaces;");
                    }
                    stream.WriteLine("");
                    stream.WriteLine($"namespace {moduleName}.Interfaces");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The I{model.Name}");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($@"    public partial interface I{model.Name} : IAutobahnBase");
                    stream.WriteLine($@"    {{");
                    List<string> propertiesToIgnore = new List<string>
                    {
                        "RecordStartDateTime",
                        "RecordEndDateTime",
                        "RecordStatusId",
                        "DataCollectionId"
                    };
                    GenerateProperties(stream, model, elements, moduleName, propertiesToIgnore, true);
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateProperties(StreamWriter stream, Type model,
            List<CEDSElement> elements, string moduleName, List<string> propertiesToIgnore, 
            bool isInterface = false)
        {
            foreach (var prop in model.GetProperties())
            {
                // no virtual properties.  We will handle those later as service calls
                if (prop.GetAccessors()[0].IsVirtual
                    || prop.Name == $"{model.Name}Id"
                    || propertiesToIgnore.Contains(prop.Name))
                {
                    continue;
                }

                var propName = prop.Name;
                if (propName.EndsWith("Statu"))
                {
                    propName = propName.Replace("Statu", "Status");
                }

                var modifier = string.Empty;
                if (!isInterface)
                {
                    modifier = "public ";
                }
                var element = elements.FirstOrDefault(e => e.TableName == model.Name && e.TechnicalName == propName);
                if (element != null)
                {
                    stream.WriteLine($"        /// <summary>");
                    stream.WriteLine($"        /// {element.Definition}");
                    stream.WriteLine($"        /// </summary>");
                    if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                    {
                        stream.WriteLine($"    {modifier}{Nullable.GetUnderlyingType(prop.PropertyType)}? {propName} {{ get; set; }}");
                    }
                    else
                    {
                        stream.WriteLine($"    {modifier}{prop.PropertyType} {propName}  {{ get; set; }}");
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
                        stream.WriteLine($"        {modifier}Guid? {propName} {{ get; set; }}");
                    }
                    else
                    {
                        stream.WriteLine($"        /// Reference to a required instance of the <see cref=\"{nospacesprop}\"/> model");
                        stream.WriteLine($"        /// </summary>");
                        stream.WriteLine($"        {modifier}Guid {propName} {{ get; set; }}");
                    }
                    stream.WriteLine();
                    continue;
                }

                if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                {
                    stream.WriteLine($"        /// <summary>");
                    stream.WriteLine($"        /// Defines the {model.Name}.{propName} nullable property");
                    stream.WriteLine($"        /// </summary>");
                    stream.WriteLine($"        {modifier}{Nullable.GetUnderlyingType(prop.PropertyType)}? {propName} {{ get; set; }}");
                }
                else
                {
                    stream.WriteLine($"        /// <summary>");
                    stream.WriteLine($"        /// Defines the {model.Name}.{propName} non nullable property");
                    stream.WriteLine($"        /// </summary>");
                    stream.WriteLine($"        {modifier}{prop.PropertyType} {propName} {{ get; set; }}");
                }
                stream.WriteLine();
            }
        }

        private static void GenerateBindableProperties(StreamWriter stream, Type model,
            List<CEDSElement> elements, string moduleName, List<string> propertiesToIgnore, bool isInterface = false)
        {
            if (!isInterface)
            {
                GenerateBackingFields(stream, model);
            }

            var proplist = new List<PropertyInfo>();
            stream.WriteLine($"        #region Properties");
            stream.WriteLine($"        /// <summary>");
            stream.WriteLine($"        /// The title of the {model.Name}ViewModel");
            stream.WriteLine($"        /// </summary>");
            stream.WriteLine($"        public string ViewTitle {{ get => _viewTitle; set => SetProperty(ref _viewTitle, value); }}");
            stream.WriteLine();
            foreach (var prop in model.GetProperties())
            {
                // no virtual properties.  We will handle those later as service calls
                if (prop.GetAccessors()[0].IsVirtual
                    || prop.Name == $"{model.Name}Id"
                    || propertiesToIgnore.Contains(prop.Name))
                {
                    continue;
                }

                var propName = prop.Name;
                if (propName.EndsWith("Statu"))
                {
                    propName = propName.Replace("Statu", "Status");
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
                        stream.WriteLine($"        {modifier}Guid? {propName} {{ get => _{propName}; set => SetProperty(ref _{propName}, value); }}");
                    }
                    else
                    {
                        stream.WriteLine($"        /// <summary>");
                        stream.WriteLine($"        /// Reference to a required instance of the <see cref=\"{propName}\"/> model");
                        stream.WriteLine($"        /// </summary>");
                        stream.WriteLine($"        {modifier}Guid {propName} {{ get => _{propName}; set => SetProperty(ref _{propName}, value); }}");
                    }
                    stream.WriteLine();
                    proplist.Add(prop);
                    continue;
                }

                var element = elements.FirstOrDefault(e => e.TableName == model.Name && e.TechnicalName == propName);
                if (element != null)
                {
                    stream.WriteLine($"        /// <summary>");
                    stream.WriteLine($"        /// {element.Definition}");
                    stream.WriteLine($"        /// </summary>");
                }

                if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                {
                    stream.WriteLine($"        {modifier}{Nullable.GetUnderlyingType(prop.PropertyType)}? {propName} {{ get => _{propName}; set => SetProperty(ref _{propName}, value); }}");
                }
                else
                {
                    stream.WriteLine($"        {modifier}{prop.PropertyType} {propName}  {{ get => _{propName}; set => SetProperty(ref _{propName}, value); }}");
                }
                proplist.Add(prop);
                stream.WriteLine();
            }
            stream.WriteLine($"        #endregion");

            // Create the Load() method
            stream.WriteLine();
            stream.WriteLine($"        /// <summary>");
            stream.WriteLine($"        /// Load the viewmodel from a model");
            stream.WriteLine($"        /// </summary>");
            stream.WriteLine($"        public void Load(Interfaces.I{model.Name} model)");
            stream.WriteLine($"        {{");
            stream.WriteLine($"            IsBusy = true;");
            stream.WriteLine($"            Id = model.Id;");
            foreach (var prop in proplist)
            {
                var propName = prop.Name;
                if (propName.EndsWith("Statu"))
                {
                    propName = propName.Replace("Statu", "Status");
                }
                if (propertiesToIgnore.Contains(propName))
                {
                    continue;
                }
                stream.WriteLine($"            {propName} = model.{propName};");
            }
            stream.WriteLine($"            _isChanged = false;");
            stream.WriteLine($"            IsNew = false;");
            stream.WriteLine($"            IsBusy = false;");
            stream.WriteLine($"        }}");
        }

        private static void GenerateBackingFields(StreamWriter stream, Type model)
        {
            stream.WriteLine($"#region \"Backing Fields\"");
            stream.WriteLine($"        // Every viewmodel has a Title property");
            stream.WriteLine($"        private string _viewTitle = \"Hello from {model.Name}\";");
            stream.WriteLine();
            foreach (var prop in model.GetProperties())
            {
                // no virtual properties.  We will handle those later as service calls
                // the id property of the class is inherited
                if (prop.GetAccessors()[0].IsVirtual || prop.Name == $"{model.Name}Id")
                {
                    continue;
                }

                var propName = prop.Name;
                if (propName.EndsWith("Statu"))
                {
                    propName = propName.Replace("Statu", "Status");
                }

                if (prop.Name.EndsWith("Id"))
                {
                    // Nullable regular property backing field.
                    if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                    {
                        stream.WriteLine($"        // member variable for the {propName} property");
                        stream.WriteLine($"        private Guid? _{propName};");
                        stream.WriteLine();
                    }
                    else
                    {
                        stream.WriteLine($"        // member variable for the {propName} property");
                        stream.WriteLine($"        private Guid _{propName};");
                        stream.WriteLine();
                    }
                    continue;
                }

                // Nullable regular property backing field.
                if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                {
                    stream.WriteLine($"        // member variable for the {propName} property");
                    stream.WriteLine($"        private {Nullable.GetUnderlyingType(prop.PropertyType)}? _{propName};");
                    stream.WriteLine();
                }
                else
                {
                    stream.WriteLine($"        // member variable for the {propName} property");
                    stream.WriteLine($"        private {prop.PropertyType} _{propName};");
                    stream.WriteLine();
                }
            }
            stream.WriteLine($"#endregion");
            stream.WriteLine();
        }

        private static void GenerateTemplateProject(string filePath, string moduleName, List<CEDSTable> tables)
        {
            DirectoryInfo di = new DirectoryInfo($@"{filePath}\{moduleName}");
            RecursiveDelete(di);
            if (moduleName == "Autobahn.Common")
            {
                ZipFile.ExtractToDirectory($@"Reference\Autobahn.Common.zip", filePath);
                GenerateViewItemGroups($@"{filePath}\Autobahn.Common\Autobahn.Common.csproj", tables);
            }
            else
            {
                ZipFile.ExtractToDirectory($@"Reference\mauiproject.zip", filePath);
                File.Move($@"{filePath}\mauiproject\module.csproj", $@"{filePath}\mauiproject\{moduleName}.csproj");
                GenerateViewItemGroups($@"{filePath}\mauiproject\{moduleName}.csproj", tables);
                File.Move($@"{filePath}\mauiproject\mauimodule.cs", $@"{filePath}\mauiproject\{moduleName}Module.cs");
                Directory.Move($@"{filePath}\mauiproject", $@"{filePath}\{moduleName}");
            }
        }

        private static void GenerateViewItemGroups(string filePath, List<CEDSTable> tables)
        {
            var project = XDocument.Load(filePath);
            var itemgroup = new XElement("ItemGroup");
            var itemgrouplist = new List<string>();
            foreach (var model in tables.Where(t => !t.TableName.StartsWith("Ref")))
            {
                if (itemgrouplist.Contains(model.TableName))
                {
                    continue;
                }
                itemgrouplist.Add(model.TableName);
                var mauixaml = new XElement("MauiXaml");
                var updateattrib = new XAttribute("Update", $@"Views\{model.TableName}View.xaml");
                var buildaction = new XElement("Generator", "MSBuild:Compile"); 
                mauixaml.Add(updateattrib);
                mauixaml.Add(buildaction);
                itemgroup.Add(mauixaml);
            }
            project.Root.LastNode.AddBeforeSelf(itemgroup);
            project.Save(filePath);
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
