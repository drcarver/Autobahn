﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Xml.Linq;
using Autobahn.Entities;
using File = System.IO.File;

namespace AutobahnCodeGen
{
    public class MauiModule
    {
        public static Autobahn.Entities.Autobahn AutobahnContext { get; set; } =
            new Autobahn.Entities.Autobahn("data source=DESKTOP-6CQUBDS\\SQLEXPRESS;initial catalog=CEDS-IDS-V10_0_0_0;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public static void GenerateModule(List<AutobahnDomain> domains, List<AutobahnTable> models,
                List<AutobahnElement> elements)
        {
            var filePath = $@"C:\Users\drcarver\Desktop\codegen\Autobahn\Code\Generated\";
            foreach (var domain in domains)
            {
                var moduleName = $"Autobahn.{domain.Module}";

                GenerateTemplateProject(filePath, moduleName);
                GenerateViewItemGroups($@"{filePath}\{moduleName}\{moduleName}.csproj", models.Where(t => t.ModelName.StartsWith("Ref") && t.AutobahnDomainId == domain.Id).ToList());
                GenerateModelFiles($@"{filePath}\Autobahn.{domain.Module}\Models\", domain, models.Where(t => !t.ModelName.StartsWith("Ref") && t.AutobahnDomainId == domain.Id).ToList(), elements);
                GenerateInterfaceFiles($@"{filePath}\Autobahn.{domain.Module}\Interfaces\", domain, models.Where(m => !m.ModelName.StartsWith("Ref") && m.AutobahnDomainId == domain.Id).ToList(), elements);
                GenerateViewModelFiles($@"{filePath}\Autobahn.{moduleName}\ViewModels\", domain, models.Where(m => !m.ModelName.StartsWith("Ref") && m.AutobahnDomainId == domain.Id).ToList(), elements);
                GenerateViewFiles($@"{filePath}\Autobahn.{moduleName}\Views\", domain, models.Where(m => !m.ModelName.StartsWith("Ref") && m.AutobahnDomainId == domain.Id).ToList().OrderBy(o => o.ModelName).ToList(), elements.Where(e => e.AutobahnDomainList.Contains(domain.Id)).OrderBy(e => e.TechnicalName).ToList());
                GenerateXAMLFiles($@"{filePath}\Autobahn.{moduleName}\Views\", domain, models.Where(m => !m.ModelName.StartsWith("Ref") && m.AutobahnDomainId == domain.Id).ToList().OrderBy(o => o.ModelName).ToList(), elements.Where(e => e.AutobahnDomainList.Contains(domain.Id)).OrderBy(e => e.TechnicalName).ToList());
                GenerateReferenceModels(filePath, domain, models.Where(m => m.AutobahnDomainId == domain.Id).OrderBy(o => o.ModelName).ToList(), elements.Where(e => e.AutobahnDomainList.Contains(domain.Id)).OrderBy(e => e.TechnicalName).ToList());
            }
        }

        private static void GenerateReferenceModels(string filePath, AutobahnDomain domin, List<AutobahnTable> models, List<AutobahnElement> elements)
        {
            //foreach (var refmodel in RefModels.Keys)
            //{
            //    var model = models.FirstOrDefault(m => m.Name == refmodel);
            //    if (model != null)
            //    {
            //        var currentdomain = RefModels[refmodel].Count > 1 ? "Autobahn.Common" : RefModels[refmodel][0];
            //        GenerateReferenceFile($@"{filePath}{currentdomain}\Models\", currentdomain, model, tables, elements);
            //        GenerateReferenceInterfaceFile($@"{filePath}{currentdomain}\Interfaces\", currentdomain, model, tables, elements);
            //        GenerateReferenceList($@"{filePath}{currentdomain}\Models\", currentdomain, model);
            //    }
            //}
        }

        private static void GenerateReferenceList(string filePath, AutobahnDomain domain, AutobahnTable model)
        {
            var csv = new CSVServices();
            var refernceModelList = csv.ReadReferenceFile($@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\{model.ModelName}.csv");
            using (var stream = File.CreateText($"{filePath}{model.ModelName}List.cs"))
            {
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine($"//* DomainName: {domain.Name}");
                stream.WriteLine($"//* FileName:   {model.ModelName}List.cs");
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine("");
                stream.WriteLine($"using Autobahn.Common.ViewModels;");
                stream.WriteLine("");
                stream.WriteLine($"namespace {domain.Module}.Models");
                stream.WriteLine("{");
                stream.WriteLine($"     /// <summary>");
                stream.WriteLine($"     /// The list of {model.ModelName} Models");
                stream.WriteLine($"     /// </summary>");
                stream.WriteLine($@"    public static partial class ReferenceLists");
                stream.WriteLine($@"    {{");
                stream.WriteLine($@"        /// <summary>");
                stream.WriteLine($@"        /// The complete <see cref=""{model.ModelName}Model""> List");
                stream.WriteLine($"         /// </summary>");
                stream.WriteLine($@"        public static List<{model.ModelName}Model> {model.ModelName}List = new List<{model.ModelName}Model>");
                stream.WriteLine($@"        {{");
                var quote = "\"";
                foreach (var item in refernceModelList)
                {
                    var fixedId = $"Guid.Parse({quote}{item.Id}{quote})";
                    var fixedCode = $"{quote}{item.Code?.Replace("\u0022", "\\u0022")}{quote}";
                    var fixedDescription = $"{quote}{item.Description?.Replace("\u0022", "\\u0022")}{quote}";
                    var fixedDefinition = $"{quote}{item.Definition?.Replace("\u0022", "\\u0022")}{quote}";
                    stream.WriteLine($@"            new {model.ModelName}Model {{ Id={fixedId}, Code={fixedCode}, Description={fixedDescription}, Definition={fixedDefinition}, SortOrder=Convert.ToDecimal({quote}{item.SortOrder}{quote}) }},");
                }
                stream.WriteLine($@"        }};");
                stream.WriteLine();
                stream.WriteLine($@"        /// <summary>");
                stream.WriteLine($@"        /// The Reference {model.ModelName} Pick List");
                stream.WriteLine($"         /// </summary>");
                stream.WriteLine($@"        public static List<ReferencePickListItemViewModel> {model.ModelName}ViewModelPickerList = new List<ReferencePickListItemViewModel>");
                stream.WriteLine($@"        {{");
                foreach (var item in refernceModelList)
                {
                    var fixedId = $"Guid.Parse({quote}{item.Id}{quote})";
                    var fixedDescription = $"{quote}{item.Description?.Replace("\u0022", "\\u0022")}{quote}";
                    stream.WriteLine($@"            new ReferencePickListItemViewModel {{ Id={fixedId}, Description={fixedDescription}, SortOrder=Convert.ToDecimal({quote}{item.SortOrder}{quote}) }},");
                }
                stream.WriteLine($@"       }};");
                stream.WriteLine("   }");
                stream.WriteLine("}");
            }
        }

        private static void GenerateReferenceFile(string filePath, AutobahnDomain domain, AutobahnTable model, List<AutobahnElement> elements)
        {
            using (var stream = File.CreateText($"{filePath}{model.ModelName}Model.cs"))
            {
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine($"//* DomainName: {domain.Name}");
                stream.WriteLine($"//* FileName:   {model.ModelName}Model.cs");
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine("");
                stream.WriteLine($"using Autobahn.Common.Models;");
                stream.WriteLine($"using {model.ModelName}.Interfaces;");
                stream.WriteLine("");
                stream.WriteLine($"namespace {model.ModelName}.Models");
                stream.WriteLine("{");
                stream.WriteLine($"     /// <summary>");
                stream.WriteLine($"     /// The {model.ModelName} Model");
                stream.WriteLine($"     /// </summary>");
                stream.WriteLine($@"    public partial class {model.ModelName}Model : ReferenceModelBase, I{model.ModelName}Model");
                stream.WriteLine($@"    {{");
                GenerateProperties(stream, model, elements, false);
                stream.WriteLine($@"    }}");
                stream.WriteLine("}");
            }
        }

        private static void GenerateReferenceInterfaceFile(string filePath, AutobahnDomain domain, AutobahnTable model, List<AutobahnElement> elements)
        {
            using (var stream = File.CreateText($"{filePath}I{model.ModelName}Model.cs"))
            {
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine($"//* DomainName: {domain.Name}");
                stream.WriteLine($"//* FileName:   I{model.ModelName}Model.cs");
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine("");
                stream.WriteLine($"using Autobahn.Common.Interfaces;");
                stream.WriteLine("");
                stream.WriteLine($"namespace Autobahn.{domain.Module}.Interfaces");
                stream.WriteLine("{");
                stream.WriteLine($"     /// <summary>");
                stream.WriteLine($"     /// The {model.ModelName} Interface Model");
                stream.WriteLine($"     /// </summary>");
                stream.WriteLine($@"    public partial interface I{model.ModelName}Model : IReferenceModel");
                stream.WriteLine($@"    {{");
                GenerateProperties(stream, model, elements, true);
                stream.WriteLine($@"    }}");
                stream.WriteLine("}");
            }
        }

        private static void GenerateXAMLFiles(string filePath, AutobahnDomain domain, List<AutobahnTable> tables, List<AutobahnElement> elements)
        {
            foreach (var model in tables)
            {
                using (var stream = File.CreateText($@"{filePath}\{model.ModelName}View.xaml"))
                {
                    stream.WriteLine($"<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                    stream.WriteLine($"<!--");
                    stream.WriteLine($" DomainName: {domain.Name}");
                    stream.WriteLine($" FileName:   {model.ModelName}View.cs");
                    stream.WriteLine($"-->");
                    stream.WriteLine($"<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"");
                    stream.WriteLine($"             xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"");
                    stream.WriteLine($"             xmlns:vm= \"clr-namespace:Autobahn.{domain.Module}.ViewModels\"");
                    stream.WriteLine($"             x:Class=\"Autobahn.{domain.Module}.Views.{model.ModelName}View\"");
                    stream.WriteLine($"             x:DataType=\"vm:{model.ModelName}ViewModel\"");
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

        private static void GenerateViewFiles(string filePath, AutobahnDomain domain, List<AutobahnTable> models, List<AutobahnElement> elements)
        {
            foreach (var model in models.Where(m => !m.ModelName.StartsWith("Ref")))
            {
                using (var stream = File.CreateText($@"{filePath}\{model.ModelName}View.xaml.cs"))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {domain.Name}");
                    stream.WriteLine($"//* FileName:   {model.ModelName}View.cs");
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine("");
                    stream.WriteLine($"using Autobahn.{domain.Module}.ViewModels;");
                    stream.WriteLine("");
                    stream.WriteLine($"namespace Autobahn.{domain.Module}.Views");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The {model.ModelName}View");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($"     [XamlCompilation(XamlCompilationOptions.Compile)]");
                    stream.WriteLine($@"    public partial class {model.ModelName}View : ContentPage");
                    stream.WriteLine($@"    {{");
                    stream.WriteLine($@"        /// <summary>");
                    stream.WriteLine($@"        /// Inject the I{model.ModelName}ViewModel as the data context for the view");
                    stream.WriteLine($@"        /// </summary>");
                    stream.WriteLine($@"        public {model.ModelName}View(I{model.ModelName}ViewModel vm)");
                    stream.WriteLine($@"        {{");
                    stream.WriteLine($@"            BindingContext  = vm;");
                    stream.WriteLine($@"        }}");
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateViewModelFiles(string filePath, AutobahnDomain domain,
            List<AutobahnTable> models, List<AutobahnElement> elements)
        {
            foreach (var model in models)
            {
                using (var stream = File.CreateText($@"{filePath}\{model.ModelName}"))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {domain.Name}");
                    stream.WriteLine($"//* FileName:   {model.ModelName}ViewModel.cs");
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine("");
                    if (domain.Module != "Common")
                    {
                        stream.WriteLine($"using Autobahn.Common.Interfaces;");
                        stream.WriteLine($"using Autobahn.Common.ViewModels;");
                    }
                    stream.WriteLine("");
                    stream.WriteLine($"namespace Autobahn.{domain.Module}.ViewModels");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The {model.ModelName}ViewModel");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($@"    public partial class {model.ModelName}ViewModel : ViewModelBase, Interfaces.I{model.ModelName}ViewModel");
                    stream.WriteLine($@"    {{");
                    GenerateBindableProperties(stream, model, elements);
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateModelFiles(string filePath, AutobahnDomain domain, 
            List<AutobahnTable> models, List<AutobahnElement> elements)
        {
            foreach (var model in models.Where(m => !m.ModelName.StartsWith("Ref")))
            {
                using (var stream = File.CreateText($@"{filePath}\{model.ModelName}Model.cs"))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {domain.Name}");
                    stream.WriteLine($"//* FileName:   {model.ModelName}Model.cs");
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine("");
                    if (domain.Module != "Common")
                    {
                        stream.WriteLine($"using Autobahn.Common.Interfaces;");
                        stream.WriteLine($"using Autobahn.Common.Models;");
                    }
                    stream.WriteLine("");
                    stream.WriteLine($"namespace Autobahn.{domain.Module}.Models");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The {model.ModelName} Model");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($@"    public partial class {model.ModelName}Model : AutobahnBase, Interfaces.I{model.ModelName}Model");
                    stream.WriteLine($@"    {{");
                    GenerateProperties(stream, model, elements.Where(e => e.AutobahnTableList.Contains(model.Id)).ToList());
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateInterfaceFiles(string filePath, AutobahnDomain domain, 
            List<AutobahnTable> models, List<AutobahnElement> elements)
        {
            foreach (var model in models.Where(m => !m.ModelName.StartsWith("Ref")))
            {
                using (var stream = File.CreateText($@"{filePath}\I{model.ModelName}Model.cs"))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {domain.Name}");
                    stream.WriteLine($"//* FileName:   I{model.ModelName}Model.cs");
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine("");
                    if (domain.Module != "Common")
                    {
                        stream.WriteLine($"using Autobahn.Common.Interfaces;");
                    }
                    stream.WriteLine("");
                    stream.WriteLine($"namespace Autobahn.{domain.Module}.Interfaces");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The I{model.ModelName}Model Interface");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($@"    public partial interface I{model.ModelName}Model : IAutobahnBase");
                    stream.WriteLine($@"    {{");
                    GenerateProperties(stream, model, elements.Where(e => e.AutobahnTableList.Contains(model.Id)).ToList(), true);
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateProperties(StreamWriter stream, AutobahnTable model, 
            List<AutobahnElement> elements, bool isInterface = false)
        {
            foreach (var prop in elements)
            {
                var modifier = string.Empty;
                if (!isInterface)
                {
                    modifier = "public ";
                }
                var element = elements.FirstOrDefault(e => e.Id == model.AutobahnElementId);
                if (element != null)
                {
                    stream.WriteLine($"        /// <summary>");
                    stream.WriteLine($"        /// {element.Definition}");
                    stream.WriteLine($"        /// </summary>");
                    stream.WriteLine($"        {modifier}{prop.PropertyType} {prop.TechnicalName} {{ get; set; }}");
                }
            }
        }

        private static void GenerateBindableProperties(StreamWriter stream, AutobahnTable model,
            List<AutobahnElement> elements)
        {
            GenerateBackingFields(stream, model, elements);

            stream.WriteLine($"        #region Properties");
            stream.WriteLine($"        /// <summary>");
            stream.WriteLine($"        /// The title of the {model.ModelName}ViewModel");
            stream.WriteLine($"        /// </summary>");
            stream.WriteLine($"        public string ViewTitle {{ get => _viewTitle; set => SetProperty(ref _viewTitle, value); }}");
            stream.WriteLine();
            foreach (var prop in elements)
            {
                var modifier = "private";
                stream.WriteLine($"        /// <summary>");
                if (prop.TechnicalName.EndsWith("Id"))
                {
                    stream.WriteLine($"        /// Reference to an optional instance of the <see cref=\"{prop.TechnicalName.Replace("Id", string.Empty)}\"/> model");
                }
                else
                {
                    stream.WriteLine($"        /// {prop.Definition}");
                }
                stream.WriteLine($"        /// </summary>");
                stream.WriteLine($"        {modifier}{prop.PropertyType} {prop.TechnicalName} {{ get => _{prop.TechnicalName}; set => SetProperty(ref _{prop.TechnicalName}, value); }}");
            }
            stream.WriteLine($"        #endregion");

            // Create the Load() method
            stream.WriteLine();
            stream.WriteLine($"        /// <summary>");
            stream.WriteLine($"        /// Load the viewmodel from a model");
            stream.WriteLine($"        /// </summary>");
            stream.WriteLine($"        public void Load(Interfaces.I{model.ModelName} model)");
            stream.WriteLine($"        {{");
            stream.WriteLine($"            IsBusy = true;");
            stream.WriteLine($"            Id = model.Id;");
            foreach (var prop in elements)
            {
                stream.WriteLine($"            {prop.TechnicalName} = model.{prop.TechnicalName};");
            }
            stream.WriteLine($"            _isChanged = false;");
            stream.WriteLine($"            IsNew = false;");
            stream.WriteLine($"            IsBusy = false;");
            stream.WriteLine($"        }}");
        }

        private static void GenerateBackingFields(StreamWriter stream, AutobahnTable model, List<AutobahnElement> elements)
        {
            stream.WriteLine($"#region \"Backing Fields\"");
            stream.WriteLine($"        // Every viewmodel has a Title property");
            stream.WriteLine($"        private string _viewTitle = \"Hello from {model.ModelName}\";");
            stream.WriteLine();
            foreach (var prop in elements)
            {
                    stream.WriteLine($"        // member variable for the {prop.TechnicalName} property");
                    stream.WriteLine($"        private {prop.PropertyType} _{prop.TechnicalName};");
                    stream.WriteLine();
            }
            stream.WriteLine($"#endregion");
            stream.WriteLine();
        }

        private static void GenerateTemplateProject(string filePath, string moduleName)
        {
            DirectoryInfo di = new DirectoryInfo($@"{filePath}\{moduleName}");
            RecursiveDelete(di);
            if (moduleName == "Autobahn.Common")
            {
                ZipFile.ExtractToDirectory($@"Reference\Autobahn.Common.zip", filePath);
            }
            else
            {
                ZipFile.ExtractToDirectory($@"Reference\mauiproject.zip", filePath);
                File.Move($@"{filePath}\mauiproject\module.csproj", $@"{filePath}\mauiproject\{moduleName}.csproj");
                File.Move($@"{filePath}\mauiproject\mauimodule.cs", $@"{filePath}\mauiproject\{moduleName}Module.cs");
                Directory.Move($@"{filePath}\mauiproject", $@"{filePath}\{moduleName}");
            }
        }

        private static void GenerateViewItemGroups(string filePath, List<AutobahnTable> models)
        {
            var project = XDocument.Load(filePath);
            var itemgroup = new XElement("ItemGroup");
            var itemgrouplist = new List<string>();
            foreach (var model in models.Where(t => !t.ModelName.StartsWith("Ref")))
            {
                if (itemgrouplist.Contains(model.ModelName))
                {
                    continue;
                }
                itemgrouplist.Add(model.ModelName);
                var mauixaml = new XElement("MauiXaml");
                var updateattrib = new XAttribute("Update", $@"Views\{model.ModelName}View.xaml");
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
