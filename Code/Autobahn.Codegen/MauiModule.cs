using System;
using Autobahn.Entities;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using File = System.IO.File;

namespace AutobahnCodeGen
{
    public class MauiModule
    {
        public static void GenerateModule(List<AutobahnDomain> domains, List<AutobahnTable> models,
                List<AutobahnElement> elements, List<Type> types)
        {
            var filePath = $@"C:\Users\drcarver\Desktop\codegen\Autobahn\Code\Generated\";
            foreach (var domain in domains)
            {
                Console.WriteLine($"Generating files for Autobahn {domain.Name} domain");
                var moduleName = $"Autobahn.{domain.Module}";

                var domainModels = models.Where(t => t.AutobahnDomainId == domain.Id).ToList();
                GenerateTemplateProject(filePath, moduleName);
                GenerateViewItemGroups($@"{filePath}\{moduleName}\{moduleName}.csproj", 
                    domainModels.Where(m => !m.TableName.StartsWith("Ref")).ToList());
                ServiceCollectionExtensions($@"{filePath}\{moduleName}\{moduleName}.ServiceCollectionExtensions.cs", domain, 
                    domainModels.Where(t => !t.TableName.StartsWith("Ref")).ToList());
                GenerateModelFiles($@"{filePath}\{moduleName}\Models\", domain, 
                    domainModels.Where(t => !t.TableName.StartsWith("Ref")).OrderBy(o => o.TableName).ToList(),
                    elements.Where(e => e.AutobahnDomainList.Contains(domain.Id)).ToList());
                GenerateInterfaceFiles($@"{filePath}\{moduleName}\Interfaces\", domain,
                    domainModels.Where(m => !m.TableName.StartsWith("Ref")).OrderBy(o => o.TableName).ToList(),
                    elements.Where(e => e.AutobahnDomainList.Contains(domain.Id)).ToList());
                GenerateViewModelFiles($@"{filePath}\{moduleName}\ViewModels\", domain,
                    domainModels.Where(m => !m.TableName.StartsWith("Ref")).OrderBy(o => o.TableName).ToList(),
                    elements.Where(e => e.AutobahnDomainList.Contains(domain.Id)).ToList());
                GenerateViewFiles($@"{filePath}\{moduleName}\Views\", domain, 
                    domainModels.Where(m => !m.TableName.StartsWith("Ref")).OrderBy(o => o.TableName).ToList(), 
                    elements.Where(e => e.AutobahnDomainList.Contains(domain.Id)).ToList());
                GenerateXAMLFiles($@"{filePath}\{moduleName}\Views\", domain, 
                    domainModels.Where(m => !m.TableName.StartsWith("Ref")).OrderBy(o => o.TableName).ToList(), 
                    elements.Where(e => e.AutobahnDomainList.Contains(domain.Id)).ToList());
                GenerateReferenceModels(filePath, domain, 
                    domainModels.Where(m => m.TableName.StartsWith("Ref")).OrderBy(o => o.TableName).ToList(), 
                    elements.Where(e => e.AutobahnDomainList.Contains(domain.Id)).ToList());
            }
        }

        private static void ServiceCollectionExtensions(string filePath, AutobahnDomain domain, List<AutobahnTable> models)
        {
            using (var stream = File.CreateText($@"{filePath}"))
            {
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine($"//* DomainName: {domain.Name}");
                stream.WriteLine($"//* FileName:   {domain.Module}.ServiceCollectionExtensions.cs");
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine("");
                stream.WriteLine($"using Autobahn.{domain.Module}.Interfaces;");
                stream.WriteLine($"using Autobahn.{domain.Module}.ViewModels;");
                stream.WriteLine($"using Autobahn.{domain.Module}.Views;");
                stream.WriteLine();
                stream.WriteLine($"/// <summary>");
                stream.WriteLine($"/// The Service Collection Extensions for the {domain.Name} domain");
                stream.WriteLine($"/// </summary>");
                stream.WriteLine($"public static partial  class ServiceCollectionExtensions");
                stream.WriteLine($"{{");
                stream.WriteLine($"    /// <summary>");
                stream.WriteLine($"    /// Known {domain.Name} Services to add to the services Collection");
                stream.WriteLine($"    /// </summary>");
                stream.WriteLine($"    public static IServiceCollection Add{domain.Module}Services(this IServiceCollection serviceCollection)");
                stream.WriteLine($"    {{");
                stream.WriteLine($"        // First the known view models");
                var modelsGenerated = new List<string>();
                foreach (var model in models.OrderBy(o => o.TableName))
                {
                    if (modelsGenerated.Contains(model.TableName))
                    {
                        continue;
                    }
                    modelsGenerated.Add(model.TableName);
                    stream.WriteLine(domain.Module == "Common"
                        ? $"        serviceCollection.AddTransient<Autobahn.Common.Interfaces.I{model.TableName}, {model.TableName}ViewModel>();"
                        : $"        serviceCollection.AddTransient<I{model.TableName}, {model.TableName}ViewModel>();");
                }
                stream.WriteLine();
                stream.WriteLine($"        // Now the known views");
                modelsGenerated.Clear();
                foreach (var model in models.OrderBy(o => o.TableName))
                {
                    if (modelsGenerated.Contains(model.TableName))
                    {
                        continue;
                    }
                    modelsGenerated.Add(model.TableName);
                    stream.WriteLine($"        serviceCollection.AddTransient<{model.TableName}View>();");
                }
                stream.WriteLine();
                stream.WriteLine($"        return serviceCollection;");
                stream.WriteLine("    }");
                stream.WriteLine("}");
            }
        }
        
        private static void GenerateReferenceModels(string filePath, AutobahnDomain domain, List<AutobahnTable> models, List<AutobahnElement> elements)
        {
            foreach (var model in models)
            {
                // is this a reference list to be embedded in a view model file?
                if (elements.FirstOrDefault(e => e.AutobahnTableList.Count == 1) == null)
                {
                    continue;
                }
                GenerateReferenceFile($@"{filePath}Autobahn.{domain.Module}\Models\", domain, model, models.Where(m => m.TableName == model.TableName).ToList(), elements);
                GenerateReferenceInterfaceFile($@"{filePath}Autobahn.{domain.Module}\Interfaces\", domain, model, models.Where(m => m.TableName == model.TableName).ToList(), elements);
                GenerateReferenceList($@"{filePath}Autobahn.{domain.Module}\Models\", domain, model);
            }
        }

        private static void GenerateReferenceFile(string filePath, AutobahnDomain domain, AutobahnTable model, List<AutobahnTable> columns, List<AutobahnElement> elements)
        {
            using (var stream = File.CreateText($"{filePath}{model.TableName}Model.cs"))
            {
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine($"//* DomainName: {domain.Name}");
                stream.WriteLine($"//* FileName:   {model.TableName}Model.cs");
                stream.WriteLine($"//**********************************************************");
                if (domain.Module != "Common")
                {
                    stream.WriteLine("");
                    stream.WriteLine($"using Autobahn.Common.Interfaces;");
                }
                stream.WriteLine("");
                stream.WriteLine($"using Autobahn.{domain.Module}.Interfaces;");
                stream.WriteLine("");
                stream.WriteLine($"namespace Autobahn.{domain.Module}.Models");
                stream.WriteLine("{");
                stream.WriteLine($"     /// <summary>");
                stream.WriteLine($"     /// The {model.TableName} Model");
                stream.WriteLine($"     /// </summary>");
                stream.WriteLine($@"    public partial class {model.TableName} : ReferenceModelBase, Interfaces.I{model.TableName}");
                stream.WriteLine($@"    {{");
                GenerateProperties(stream, model, columns, elements, false);
                stream.WriteLine($@"    }}");
                stream.WriteLine("}");
            }
        }

        private static void GenerateReferenceInterfaceFile(string filePath, AutobahnDomain domain, AutobahnTable model, List<AutobahnTable> columns, List<AutobahnElement> elements)
        {
            using (var stream = File.CreateText($"{filePath}I{model.TableName}.cs"))
            {
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine($"//* DomainName: {domain.Name}");
                stream.WriteLine($"//* FileName:   I{model.TableName}.cs");
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
                stream.WriteLine($"     /// The {model.TableName} Interface Model");
                stream.WriteLine($"     /// </summary>");
                stream.WriteLine($@"    public partial interface I{model.TableName} : IReferenceModel");
                stream.WriteLine($@"    {{");
                GenerateProperties(stream, model, columns, elements, true);
                stream.WriteLine($@"    }}");
                stream.WriteLine("}");
            }
        }

        private static void GenerateReferenceList(string filePath, AutobahnDomain domain, AutobahnTable model)
        {
            using (var stream = File.CreateText($"{filePath}{model.TableName}List.cs"))
            {
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine($"//* DomainName: {domain.Name}");
                stream.WriteLine($"//* FileName:   {model.TableName}List.cs");
                stream.WriteLine($"//**********************************************************");
                stream.WriteLine("");
                stream.WriteLine($"using Autobahn.Common.ViewModels;");
                stream.WriteLine("");
                stream.WriteLine($"namespace {domain.Module}.Models");
                stream.WriteLine("{");
                stream.WriteLine($"     /// <summary>");
                stream.WriteLine($"     /// The list of {model.TableName} Models");
                stream.WriteLine($"     /// </summary>");
                stream.WriteLine($@"    public static partial class ReferenceLists");
                stream.WriteLine($@"    {{");
                stream.WriteLine($@"        /// <summary>");
                stream.WriteLine($@"        /// The complete <see cref=""{model.TableName}Model""> List");
                stream.WriteLine($"         /// </summary>");
                stream.WriteLine($@"        public static List<{model.TableName}Model> {model.TableName}List = new List<{model.TableName}Model>");
                stream.WriteLine($@"        {{");
                var quote = "\"";
                //foreach (var item in refernceModelList)
                //{
                //    var fixedId = $"Guid.Parse({quote}{item.Id}{quote})";
                //    var fixedCode = $"{quote}{item.Code?.Replace("\u0022", "\\u0022")}{quote}";
                //    var fixedDescription = $"{quote}{item.Description?.Replace("\u0022", "\\u0022")}{quote}";
                //    var fixedDefinition = $"{quote}{item.Definition?.Replace("\u0022", "\\u0022")}{quote}";
                //    stream.WriteLine($@"            new {model.ModelName}Model {{ Id={fixedId}, Code={fixedCode}, Description={fixedDescription}, Definition={fixedDefinition}, SortOrder=Convert.ToDecimal({quote}{item.SortOrder}{quote}) }},");
                //}
                stream.WriteLine($@"        }};");
                stream.WriteLine();
                stream.WriteLine($@"        /// <summary>");
                stream.WriteLine($@"        /// The Reference {model.TableName} Pick List");
                stream.WriteLine($"         /// </summary>");
                stream.WriteLine($@"        public static List<ReferencePickListItemViewModel> {model.TableName}ViewModelPickerList = new List<ReferencePickListItemViewModel>");
                stream.WriteLine($@"        {{");
                //foreach (var item in referenceModelList)
                //{
                //    var fixedId = $"Guid.Parse({quote}{item.Id}{quote})";
                //    var fixedDescription = $"{quote}{item.Description?.Replace("\u0022", "\\u0022")}{quote}";
                //    stream.WriteLine($@"            new ReferencePickListItemViewModel {{ Id={fixedId}, Description={fixedDescription}, SortOrder=Convert.ToDecimal({quote}{item.SortOrder}{quote}) }},");
                //}
                stream.WriteLine($@"       }};");
                stream.WriteLine("   }");
                stream.WriteLine("}");
            }
        }

        private static void GenerateXAMLFiles(string filePath, AutobahnDomain domain, List<AutobahnTable> tables, List<AutobahnElement> elements)
        {
            var modelsGenerated = new List<AutobahnTable>();
            foreach (var model in tables)
            {
                if (modelsGenerated.Contains(model))
                {
                    continue;
                }
                modelsGenerated.Add(model);
                using (var stream = File.CreateText($@"{filePath}\{model.TableName}View.xaml"))
                {
                    stream.WriteLine($"<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                    stream.WriteLine($"<!--");
                    stream.WriteLine($" DomainName: {domain.Name}");
                    stream.WriteLine($" FileName:   {model.TableName}View.cs");
                    stream.WriteLine($"-->");
                    stream.WriteLine($"<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"");
                    stream.WriteLine($"             xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"");
                    stream.WriteLine($"             xmlns:toolkit=\"http://schemas.microsoft.com/dotnet/2022/maui/toolkit\"");
                    stream.WriteLine($"             xmlns:vm= \"clr-namespace:Autobahn.{domain.Module}.ViewModels\"");
                    stream.WriteLine($"             x:Class=\"Autobahn.{domain.Module}.Views.{model.TableName}View\"");
                    stream.WriteLine($"             x:DataType=\"vm:{model.TableName}ViewModel\"");
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
            var modelsGenerated = new List<AutobahnTable>();
            foreach (var model in models)
            {
                if (modelsGenerated.Contains(model))
                {
                    continue;
                }
                modelsGenerated.Add(model);
                Console.WriteLine($"Generating code behind file for {domain.Module}.{model.TableName}View.xaml");
                using (var stream = File.CreateText($@"{filePath}\{model.TableName}View.xaml.cs"))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {domain.Name}");
                    stream.WriteLine($"//* FileName:   {model.TableName}View.cs");
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine("");
                    stream.WriteLine($"namespace Autobahn.{domain.Module}.Views");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The {model.TableName}View");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($"     [XamlCompilation(XamlCompilationOptions.Compile)]");
                    stream.WriteLine($@"    public partial class {model.TableName}View : ContentPage");
                    stream.WriteLine($@"    {{");
                    stream.WriteLine($@"        /// <summary>");
                    stream.WriteLine($@"        /// Inject the I{model.TableName} View Model as the data context for the view");
                    stream.WriteLine($@"        /// </summary>");
                    stream.WriteLine($@"        public {model.TableName}View(Interfaces.I{model.TableName} vm)");
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
            var modelsGenerated = new List<string>();
            foreach (var model in models)
            {
                if (modelsGenerated.Contains(model.TableName))
                {
                    continue;
                }
                modelsGenerated.Add(model.TableName);
                Console.WriteLine($"Generating view model for {domain.Module}.{model.TableName}ViewModel");
                using (var stream = File.CreateText($@"{filePath}\{model.TableName}ViewModel.cs"))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {domain.Name}");
                    stream.WriteLine($"//* FileName:   {model.TableName}ViewModel.cs");
                    stream.WriteLine($"//**********************************************************");
                    if (domain.Module != "Common")
                    {
                        stream.WriteLine("");
                        stream.WriteLine($"using Autobahn.Common.Interfaces;");
                        stream.WriteLine($"using Autobahn.Common.ViewModels;");
                    }
                    stream.WriteLine("");
                    stream.WriteLine("using System.ComponentModel;");
                    stream.WriteLine("using System.Windows.Input;");
                    stream.WriteLine("");
                    stream.WriteLine($"namespace Autobahn.{domain.Module}.ViewModels");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The {model.TableName}ViewModel");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($@"    public partial class {model.TableName}ViewModel : ViewModelBase, Interfaces.I{model.TableName}");
                    stream.WriteLine($@"    {{");
                    GenerateBindableProperties(stream, model, models.Where(m => m.TableName == model.TableName).ToList(), elements.Where(e => e.AutobahnDomainList.Contains(domain.Id) && e.AutobahnTableList.Contains(model.Id)).ToList(), false);
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateModelFiles(string filePath, AutobahnDomain domain, 
            List<AutobahnTable> models, List<AutobahnElement> elements)
        {
            var modelsGenerated = new List<string>();
            foreach (var model in models)
            {
                if (modelsGenerated.Contains(model.TableName))
                {
                    continue;
                }
                modelsGenerated.Add(model.TableName);
                Console.WriteLine($"Generating model for {domain.Module}.{model.TableName}Model");
                using (var stream = File.CreateText($@"{filePath}\{model.TableName}Model.cs"))
                {
                    stream.WriteLine($"//**********************************************************");
                    stream.WriteLine($"//* DomainName: {domain.Name}");
                    stream.WriteLine($"//* FileName:   {model.TableName}Model.cs");
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
                    stream.WriteLine($"     /// The {model.TableName} Model");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($@"    public partial class {model.TableName}Model : AutobahnBase, Interfaces.I{model.TableName}");
                    stream.WriteLine($@"    {{");
                    GenerateProperties(stream, model, models.Where(m => m.TableName == model.TableName).ToList(), elements);
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateInterfaceFiles(string filePath, AutobahnDomain domain, 
            List<AutobahnTable> models, List<AutobahnElement> elements)
        {
            var modelsGenerated = new List<string>();
            foreach (var model in models.Where(m => !m.TableName.StartsWith("Ref")))
            {
                if (modelsGenerated.Contains(model.TableName))
                {
                    continue;
                }
                modelsGenerated.Add(model.TableName);
                Console.WriteLine($"Generating interface {domain.Module}.I{model.TableName}");
                using (var stream = File.CreateText($@"{filePath}\I{model.TableName}.cs"))
                {
                    stream.WriteLine($"//***************************************************************************");
                    stream.WriteLine($"//* DomainName: {domain.Name} Interfaces (used by both models and View Models");
                    stream.WriteLine($"//* FileName:   I{model.TableName}.cs");
                    stream.WriteLine($"//***************************************************************************");
                    stream.WriteLine("");
                    if (domain.Module != "Common")
                    {
                        stream.WriteLine($"using Autobahn.Common.Interfaces;");
                    }
                    stream.WriteLine("");
                    stream.WriteLine($"namespace Autobahn.{domain.Module}.Interfaces");
                    stream.WriteLine("{");
                    stream.WriteLine($"     /// <summary>");
                    stream.WriteLine($"     /// The I{model.TableName} Interface");
                    stream.WriteLine($"     /// </summary>");
                    stream.WriteLine($@"    public partial interface I{model.TableName} : IAutobahnBase");
                    stream.WriteLine($@"    {{");
                    GenerateProperties(stream, model, models.Where(m => m.TableName == model.TableName).ToList(), elements, true);
                    stream.WriteLine($@"    }}");
                    stream.WriteLine("}");
                }
            }
        }

        private static void GenerateProperties(StreamWriter stream, AutobahnTable model, List<AutobahnTable> columns, 
            List<AutobahnElement> elements, bool isInterface = false)
        {
            var propertiesGenerated = new List<string>();
            foreach (var column in columns.OrderBy(o => o.ColumnName))
            {
                if (propertiesGenerated.Contains(column.ColumnName))
                {
                    continue;
                }
                propertiesGenerated.Add(column.ColumnName);

                var modifier = string.Empty;
                if (!isInterface)
                {
                    modifier = "public ";
                }

                var element = elements.FirstOrDefault(e => e.GlobalId == column.GlobalId);
                stream.WriteLine($"        /// <summary>");
                stream.WriteLine($"        /// {element?.Definition}");
                stream.WriteLine($"        /// </summary>");
                stream.WriteLine($"        {modifier}{column.ColumnType} {column.ColumnName} {{ get; set; }}");
                stream.WriteLine();
            }
        }

        private static void GenerateBindableProperties(StreamWriter stream, AutobahnTable model, List<AutobahnTable> columns,
            List<AutobahnElement> elements, bool isInterface)
        {
            GenerateBackingFields(stream, model, columns, elements);

            stream.WriteLine($"        #region Properties");
            stream.WriteLine($"        /// <summary>");
            stream.WriteLine($"        /// The title of the View Model");
            stream.WriteLine($"        /// </summary>");
            stream.WriteLine($"        public string ViewTitle {{ get => _viewTitle; set => SetProperty(ref _viewTitle, value); }}");
            stream.WriteLine();
            var propertiesGenerated = new List<string>();
            foreach (var column in columns.OrderBy(o => o.ColumnName))
            {
                if (propertiesGenerated.Contains(column.ColumnName))
                {
                    continue;
                }
                propertiesGenerated.Add(column.ColumnName);
                var element = elements.FirstOrDefault(e => e.GlobalId == column.GlobalId);
                stream.WriteLine($"        /// <summary>");
                if (column.ColumnName.EndsWith("Id"))
                {
                    stream.WriteLine($"        /// Reference to an optional instance of the <see cref=\"{column.ColumnName.Replace("Id", string.Empty)}\"/> model");
                }
                else if (!string.IsNullOrEmpty(element?.Definition))
                {
                    stream.WriteLine($"        /// {element.Definition}");
                }
                if (!string.IsNullOrEmpty(element?.URL))
                {
                    stream.WriteLine($"        /// <para>");
                    stream.WriteLine($"        /// <a href=\"{element.URL}\">{element?.ElementName}</a>");
                    stream.WriteLine($"        /// </para>");
                }
                stream.WriteLine($"        /// </summary>");
                if (!string.IsNullOrEmpty(element?.ElementName))
                {
                    stream.WriteLine($"        [DisplayName(\"{element.ElementName}\")]");
                }
                stream.WriteLine($"        public {column.ColumnType} {column.ColumnName} {{ get => _{column.ColumnName}; set => SetProperty(ref _{column.ColumnName}, value); }}");
                stream.WriteLine();
            }
            stream.WriteLine($"        #endregion");

            // Create the Load() method
            stream.WriteLine();
            stream.WriteLine($"        /// <summary>");
            stream.WriteLine($"        /// Load the viewmodel from a model");
            stream.WriteLine($"        /// </summary>");
            stream.WriteLine($"        public void Load(Interfaces.I{model.TableName} model)");
            stream.WriteLine($"        {{");
            stream.WriteLine($"            IsBusy = true;");
            stream.WriteLine($"            Id = model.Id;");
            propertiesGenerated.Clear();
            foreach (var column in columns.OrderBy(o => o.ColumnName))
            {
                if (propertiesGenerated.Contains(column.ColumnName))
                {
                    continue;
                }
                propertiesGenerated.Add(column.ColumnName);
                var element = elements.FirstOrDefault(e => e.GlobalId == column.GlobalId);
                stream.WriteLine($"            {column.ColumnName} = model.{column.ColumnName}; // {element?.ElementName}");
            }
            stream.WriteLine($"            _isChanged = false;");
            stream.WriteLine($"            IsNew = false;");
            stream.WriteLine($"            IsBusy = false;");
            stream.WriteLine($"        }}");
            GenerateVirtualProperties(stream, model, columns, elements);
            GenerateEmbeddedReferenceList(stream, columns, elements);
        }

        private static void GenerateEmbeddedReferenceList(StreamWriter stream, List<AutobahnTable> columns, List<AutobahnElement> elements)
        {
            foreach (var prop in elements.Where(e => e.TechnicalName.StartsWith("Ref")))
            {
                var refName = prop.TechnicalName.Replace("Id", string.Empty);
                stream.WriteLine($"        #region {refName} List");
                stream.WriteLine($@"        /// <summary>");
                stream.WriteLine($@"        /// The complete <see cref=""{refName}""> List");
                stream.WriteLine($"         /// </summary>");
                stream.WriteLine($@"        public static List<ReferenceModel> {refName}List = new List<ReferenceModel>");
                stream.WriteLine($@"        {{");
                var quote = "\"";
                //foreach (var item in referenceModelList)
                //{
                //    var fixedId = $"Guid.Parse({quote}{item.Id}{quote})";
                //    var fixedCode = $"{quote}{item.Code?.Replace("\u0022", "\\u0022")}{quote}";
                //    var fixedDescription = $"{quote}{item.Description?.Replace("\u0022", "\\u0022")}{quote}";
                //    var fixedDefinition = $"{quote}{item.Definition?.Replace("\u0022", "\\u0022")}{quote}";
                //    stream.WriteLine($@"            new {model.ModelName}Model {{ Id={fixedId}, Code={fixedCode}, Description={fixedDescription}, Definition={fixedDefinition}, SortOrder=Convert.ToDecimal({quote}{item.SortOrder}{quote}) }},");
                //}
                stream.WriteLine($@"        }};");
                stream.WriteLine($"        #endregion");
            }
        }

        private static void GenerateVirtualProperties(StreamWriter stream, AutobahnTable model, List<AutobahnTable> columns, List<AutobahnElement> elements)
        {
            if (!elements.Any(e => e.TechnicalName.EndsWith("Id") && !e.TechnicalName.StartsWith("Ref")))
            {
                return;
            }
            stream.WriteLine();
            stream.WriteLine($"        #region \"ICommands for Navigation Properties\"");
            foreach (var prop in elements.Where(e => e.TechnicalName.EndsWith("Id") && !e.TechnicalName.StartsWith("Ref")))
            {
                stream.WriteLine($"        /// <summary>");
                if (prop.TechnicalName.EndsWith("Id"))
                {
                    if (string.IsNullOrEmpty(prop.Definition))
                    {
                        stream.WriteLine($"        /// Reference to an optional instance of the <see cref=\"{prop.TechnicalName.Replace("Id", string.Empty)}\"/> model");
                    }
                    else
                    {
                        stream.WriteLine($"        /// {prop.Definition}");
                    }
                }
                if (prop.URL != null)
                {
                    stream.WriteLine($"        /// <para>");
                    stream.WriteLine($"        /// <a href=\"{prop.URL}\">{prop.ElementName}</a>");
                    stream.WriteLine($"        /// </para>");
                }
                stream.WriteLine($"        /// </summary>");
                stream.WriteLine($"        public ICommand {prop.TechnicalName.Replace("Id", string.Empty)}Command {{ get; set; }}");
                stream.WriteLine();
            }
            stream.WriteLine($"        #endregion");
        }

        private static void GenerateBackingFields(StreamWriter stream, AutobahnTable model, List<AutobahnTable> columns, List<AutobahnElement> elements)
        {
            Console.WriteLine($"Generating backing fields for {model.TableName}Model");
            stream.WriteLine($"        #region \"Backing Fields\"");
            stream.WriteLine($"        // Every viewmodel has a Title property");
            stream.WriteLine($"        private string _viewTitle = \"Hello from {model.TableName}\";");
            stream.WriteLine();
            var propertiesGenerated = new List<string>();
            foreach (var column in columns.OrderBy(c => c.ColumnName))
            {
                if (propertiesGenerated.Contains(column.ColumnName))
                {
                    continue;
                }
                propertiesGenerated.Add(column.ColumnName);
                var element = elements.FirstOrDefault(e => e.GlobalId == column.GlobalId);
                if (string.IsNullOrEmpty(element?.ElementName))
                {
                    stream.WriteLine($"        // member variable for the {column.ColumnName} property");
                }
                else
                {
                    stream.WriteLine($"        // {column.ColumnName} -- (backing property for {element.ElementName})");
                }
                stream.WriteLine($"        private {column.ColumnType} _{column.ColumnName};");
                stream.WriteLine();
            }
            stream.WriteLine($"        #endregion");
            stream.WriteLine();
        }

        private static void GenerateTemplateProject(string filePath, string moduleName)
        {
            Console.WriteLine($"Generating project file for {moduleName}");
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
                Directory.Move($@"{filePath}\mauiproject", $@"{filePath}\{moduleName}");
            }
        }

        private static void GenerateViewItemGroups(string filePath, List<AutobahnTable> models)
        {
            var fi = new FileInfo(filePath);
            Console.WriteLine($"Generating XAML ItemGroups for {fi.Name}");
            var project = XDocument.Load(filePath);
            var itemgroup = new XElement("ItemGroup");
            var itemgrouplist = new List<string>();
            foreach (var model in models.Where(t => !t.TableName.StartsWith("Ref")))
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
            project?.Root?.LastNode?.AddBeforeSelf(itemgroup);
            project?.Save(filePath);
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