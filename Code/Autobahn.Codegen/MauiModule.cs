using Autobahn.Codegen.Models;
using System.IO.Compression;
using System.Xml.Linq;

namespace Autobahn.Codegen;

/// <summary>
/// The types we can generate.  These are generated for .NET 6
/// and node as needed
/// </summary>
internal enum TypeBeingGeneratedEnum
{
    Entity,                         // Entity framework file 
    Interface,                      // .NET C# Interface file
    ViewModel,                      // .NET View Model
    Model,                          // .NET Model file
    ServiceCollectionExtensions,    // Extensions to .NET service collection
    MAUIXAML,                       // MAUI XAML file
    UserControlXAML,                // WPF UserControl XAML file
    BlazerView,
    ViewCodeBehind,
    MSUnitTest,
    TypescriptInterface,
    TypescriptPromise,
    TypescriptViewModel,
    AngularView,
    ReactView,
    TypescriptTest,
}

internal class MauiModule
{
    private static List<string> ModelsGenerated { get; set; } = new List<string>();

    internal static void GenerateModule(string location, 
        List<AutobahnEntity> entities, List<AutobahnDomain> domains)
    {
        foreach (var domain in domains)
        {
            Console.WriteLine($"Generating files for Autobahn {domain.Name} domain");
            var moduleName = $"Autobahn.Education.{domain.Module}";
            if (domain.Module == "Authorization")
            {
                continue;
            }

            var domainModels = entities.Where(e => e.Attributes?.TableAttribute?.Schema == domain.Module).ToList();
            GenerateTemplateProject(location, moduleName);
            GenerateGlobalUsings($@"{location}\{moduleName}\{moduleName}");
            AddAssemblyInfo($@"{location}\{moduleName}\{moduleName}\{moduleName}.csproj", domain);
            GenerateInterfaceFiles($@"{location}\{moduleName}\{moduleName}\Interfaces\", domain, entities.Where(t => !t.Name.StartsWith("Ref")).ToList());
            GenerateModelFiles($@"{location}\{moduleName}\{moduleName}\Models\", domain, domainModels.Where(m => !m.Name.StartsWith("Ref")).ToList());
            
            // Still todo - add virtuals for foreign keys.  Add the dbcontext for the domain
            GenerateEntityFiles($@"{location}\{moduleName}\{moduleName}\Entities\", domain, domainModels.Where(m => !m.Name.StartsWith("Ref")).ToList());
            
            // Still todo - add reference models and embeded reference lists, plus pick lists
            GenerateReferences($@"{location}\{moduleName}\{moduleName}\", domain, domainModels.Where(m => m.Name.StartsWith("Ref")).ToList());
            
            // Still todo - convert/add virtuals as navigation commands
            GenerateViewModelFiles($@"{location}\{moduleName}\{moduleName}\ViewModels\", domain, domainModels.ToList());
            ServiceCollectionExtensions($@"{location}\{moduleName}\{moduleName}\ServiceCollectionExtensions.cs", domain, domainModels.Where(t => !t.Name.StartsWith("Ref")).ToList());
            
            // Still todo - service collection extensions for view routes
            //GenerateViewFiles($@"{filePath}\{moduleName}\Views\", domain, domainModels.Where(m => !m.TableName.StartsWith("Ref")).ToList(), elements);
            //GenerateXAMLFiles($@"{filePath}\{moduleName}\Views\", domainModels.Where(m => !m.TableName.StartsWith("Ref")).ToList());
        }
    }

    /// <summary>
    /// Generate the global usings for the project
    /// </summary>
    /// <param name="location">The location of the file generated</param>
    private static void GenerateGlobalUsings(string location)
    {
        using (var stream = File.CreateText($@"{location}\GlobalUsings.cs"))
        {
            stream.WriteLine("global using System;");
            stream.WriteLine("global using System.ComponentModel;");
            stream.WriteLine("global using System.ComponentModel.DataAnnotations;");
            stream.WriteLine("global using System.ComponentModel.DataAnnotations.Schema;");
            stream.WriteLine("global using Microsoft.Extensions.DependencyInjection;");
            stream.WriteLine("global using CommunityToolkit.Mvvm;");
            stream.WriteLine("global using CommunityToolkit.Mvvm.ComponentModel;");
        }
    }

    /// <summary>
    /// Generate the file header and documentation
    /// </summary>
    /// <param name="stream">The stream to write on</param>
    /// <param name="domain">The domain being generated</param>
    /// <param name="model">The model we are generating</param>
    /// <param name="generatedType">The type of file</param>
    /// <returns>The filename</returns>
    public static string GenerateFileHeader(StreamWriter stream, AutobahnDomain domain, AutobahnEntity model, TypeBeingGeneratedEnum generatedType)
    {
        string filename = $"{model.Name}ViewModel";
        switch (generatedType)
        {
            case TypeBeingGeneratedEnum.Interface:
                filename = $"I{model.Name}";
                break;
            case TypeBeingGeneratedEnum.Model:
                filename = $"{model.Name}Model";
                break;
            case TypeBeingGeneratedEnum.Entity:
                filename = $"{model.Name}Entity";
                break;
            case TypeBeingGeneratedEnum.MAUIXAML:
                filename = $"{model.Name}View.xaml.cs";
                break;
            case TypeBeingGeneratedEnum.ViewCodeBehind:
                filename = $"{model.Name}View.cs";
                break;
        }
        stream.WriteLine($"//***************************************************************************");
        stream.WriteLine($"//* DomainName: {domain.Name}");
        stream.WriteLine($"//* FileName:   {filename}.g.cs");
        if (model.AutobahnElement != null)
        {
            stream.WriteLine($"//* Name:       {model.AutobahnElement.ElementName}");
            stream.WriteLine($"//* Definition: {model.AutobahnElement.Definition}");
        }
        stream.WriteLine($"//***************************************************************************");
        stream.WriteLine("");
        stream.WriteLine($"/// <summary>");
        if (model.AutobahnElement != null)
        {
            stream.WriteLine($"/// {model.AutobahnElement.ElementName} <see cref=\"{model.Name}\"/>");
            stream.WriteLine($"/// <para>");
            stream.WriteLine($"/// {model.AutobahnElement.Definition}");
            stream.WriteLine($"/// </para>");
            stream.WriteLine($"/// <para>");
            stream.WriteLine($"/// <a href=\"{model.AutobahnElement.URL}\">{model.AutobahnElement.ElementName}</a>");
            stream.WriteLine($"/// </para>");
        }
        else
        {
            stream.WriteLine($"/// The I{model.Name} file");
        }
        stream.WriteLine($"/// </summary>");
        return filename;
    }

    /// <summary>
    /// Generate the servicecollection extensions for this assembly
    /// </summary>
    /// <param name="filePath">The path to the generated file</param>
    /// <param name="domain">The domain</param>
    /// <param name="models">The models to include</param>
    private static void ServiceCollectionExtensions(string filePath, AutobahnDomain domain, List<AutobahnEntity> models)
    {
        using (var stream = File.CreateText($@"{filePath}"))
        {
            stream.WriteLine($"//**********************************************************");
            stream.WriteLine($"//* DomainName: {domain.Name}");
            stream.WriteLine($"//* FileName:   {domain.Module}.ServiceCollectionExtensions.cs");
            stream.WriteLine($"//**********************************************************");
            stream.WriteLine();
            stream.WriteLine($"/// <summary>");
            stream.WriteLine($"/// The Service Collection Extensions for the {domain.Name} domain");
            stream.WriteLine($"/// </summary>");
            stream.WriteLine($"public static partial class ServiceCollectionExtensions");
            stream.WriteLine($"{{");
            stream.WriteLine($"    /// <summary>");
            stream.WriteLine($"    /// Known {domain.Name} Services to add to the services Collection");
            stream.WriteLine($"    /// </summary>");
            stream.WriteLine($"    public static IServiceCollection Add{domain.Module}Services(this IServiceCollection serviceCollection)");
            stream.WriteLine($"    {{");
            stream.WriteLine($"        // First the known view models");
            var modelsGenerated = new List<string>();
            foreach (var model in models.OrderBy(o => o.Name))
            {
                if (modelsGenerated.Contains(model.Name))
                {
                    continue;
                }
                modelsGenerated.Add(model.Name);
                stream.WriteLine($"        serviceCollection.AddTransient<I{model.Name}, {model.Name}ViewModel>();");
            }
            stream.WriteLine();
            stream.WriteLine($"        return serviceCollection;");
            stream.WriteLine("    }");
            stream.WriteLine("}");
        }
    }

    /// <summary>
    /// Generate the reference files
    /// </summary>
    /// <param name="filePath">The path to generate files</param>
    /// <param name="domain">The domain we are generating for</param>
    /// <param name="models">The models to be generated</param>
    private static void GenerateReferences(string filePath, AutobahnDomain domain, List<AutobahnEntity> models)
    {
        foreach (var model in models)
        {
            GenerateReferenceEntity($@"{filePath}\Entities\", domain, model);
            //GenerateReferenceList($@"{filePath}Autobahn.Education.{domain.Module}\Models\", domain, model);
        }
    }

    /// <summary>
    /// Generate a reference entity
    /// </summary>
    /// <param name="filePath">The file the refence entity is generated on</param>
    /// <param name="domain">The domain we are generationg for</param>
    /// <param name="model">The model we are generating</param>
    private static void GenerateReferenceEntity(string filePath, AutobahnDomain domain, AutobahnEntity model)
    {
        using (var stream = File.CreateText($"{filePath}{model.Name}Entity.g.cs"))
        {
            GenerateFileHeader(stream, domain, model, TypeBeingGeneratedEnum.Entity);
            stream.WriteLine($@"public partial class {model.Name}Entity : ReferenceBaseEntity, IReferenceBase");
            stream.WriteLine($@"{{");
            GenerateProperties(stream, model, TypeBeingGeneratedEnum.Entity);
            stream.WriteLine($@"}}");
        }
    }

    //        private static void GenerateReferenceList(string filePath, AutobahnDomain domain, AutobahnTable model)
    //        {
    //            using (var stream = File.CreateText($"{filePath}{model.TableName}List.cs"))
    //            {
    //                stream.WriteLine($"//**********************************************************");
    //                stream.WriteLine($"//* DomainName: {domain.Name}");
    //                stream.WriteLine($"//* FileName:   {model.TableName}List.cs");
    //                stream.WriteLine($"//**********************************************************");
    //                stream.WriteLine("");
    //                stream.WriteLine($"using Autobahn.Education.Common.ViewModels;");
    //                stream.WriteLine("");
    //                stream.WriteLine($"namespace {domain.Module}.Models");
    //                stream.WriteLine("{");
    //                stream.WriteLine($"     /// <summary>");
    //                stream.WriteLine($"     /// The list of {model.TableName} Models");
    //                stream.WriteLine($"     /// </summary>");
    //                stream.WriteLine($@"    public static partial class ReferenceLists");
    //                stream.WriteLine($@"    {{");
    //                stream.WriteLine($@"        /// <summary>");
    //                stream.WriteLine($@"        /// The complete <see cref=""{model.TableName}Model""> List");
    //                stream.WriteLine($"         /// </summary>");
    //                stream.WriteLine($@"        public static List<{model.TableName}Model> {model.TableName}List = new List<{model.TableName}Model>");
    //                stream.WriteLine($@"        {{");
    //                var quote = "\"";
    //                //foreach (var item in refernceModelList)
    //                //{
    //                //    var fixedId = $"Guid.Parse({quote}{item.Id}{quote})";
    //                //    var fixedCode = $"{quote}{item.Code?.Replace("\u0022", "\\u0022")}{quote}";
    //                //    var fixedDescription = $"{quote}{item.Description?.Replace("\u0022", "\\u0022")}{quote}";
    //                //    var fixedDefinition = $"{quote}{item.Definition?.Replace("\u0022", "\\u0022")}{quote}";
    //                //    stream.WriteLine($@"            new {model.ModelName}Model {{ Id={fixedId}, Code={fixedCode}, Description={fixedDescription}, Definition={fixedDefinition}, SortOrder=Convert.ToDecimal({quote}{item.SortOrder}{quote}) }},");
    //                //}
    //                stream.WriteLine($@"        }};");
    //                stream.WriteLine();
    //                stream.WriteLine($@"        /// <summary>");
    //                stream.WriteLine($@"        /// The Reference {model.TableName} Pick List");
    //                stream.WriteLine($"         /// </summary>");
    //                stream.WriteLine($@"        public static List<ReferencePickListItemViewModel> {model.TableName}ViewModelPickerList = new List<ReferencePickListItemViewModel>");
    //                stream.WriteLine($@"        {{");
    //                //foreach (var item in referenceModelList)
    //                //{
    //                //    var fixedId = $"Guid.Parse({quote}{item.Id}{quote})";
    //                //    var fixedDescription = $"{quote}{item.Description?.Replace("\u0022", "\\u0022")}{quote}";
    //                //    stream.WriteLine($@"            new ReferencePickListItemViewModel {{ Id={fixedId}, Description={fixedDescription}, SortOrder=Convert.ToDecimal({quote}{item.SortOrder}{quote}) }},");
    //                //}
    //                stream.WriteLine($@"       }};");
    //                stream.WriteLine("   }");
    //                stream.WriteLine("}");
    //            }
    //        }

    //        private static void GenerateXAMLFiles(string filePath, AutobahnDomain domain, List<AutobahnTable> tables, List<AutobahnElement> elements)
    //        {
    //            var modelsGenerated = new List<AutobahnTable>();
    //            foreach (var model in tables)
    //            {
    //                if (modelsGenerated.Contains(model))
    //                {
    //                    continue;
    //                }
    //                modelsGenerated.Add(model);
    //                using (var stream = File.CreateText($@"{filePath}\{model.TableName}View.xaml"))
    //                {
    //                    stream.WriteLine($"<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
    //                    stream.WriteLine($"<!--");
    //                    stream.WriteLine($" DomainName: {domain.Name}");
    //                    stream.WriteLine($" FileName:   {model.TableName}View.cs");
    //                    stream.WriteLine($"-->");
    //                    stream.WriteLine($"<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"");
    //                    stream.WriteLine($"             xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"");
    //                    stream.WriteLine($"             xmlns:toolkit=\"http://schemas.microsoft.com/dotnet/2022/maui/toolkit\"");
    //                    stream.WriteLine($"             xmlns:vm= \"clr-namespace:Autobahn.Education.{domain.Module}.ViewModels\"");
    //                    stream.WriteLine($"             x:Class=\"Autobahn.Education.{domain.Module}.Views.{model.TableName}View\"");
    //                    stream.WriteLine($"             x:DataType=\"vm:{model.TableName}ViewModel\"");
    //                    stream.WriteLine($"             Title=\"{{Binding ViewTitle}}\">");
    //                    stream.WriteLine("    <VerticalStackLayout>");
    //                    stream.WriteLine("        <Label");
    //                    stream.WriteLine("           Text=\"Welcome to .NET MAUI!\"");
    //                    stream.WriteLine("           VerticalOptions=\"Center\"");
    //                    stream.WriteLine("           HorizontalOptions=\"Center\" />");
    //                    stream.WriteLine("    </VerticalStackLayout>");
    //                    stream.WriteLine("</ContentPage>");
    //                }
    //            }
    //        }

    //        private static void GenerateViewFiles(string filePath, AutobahnDomain domain, List<AutobahnTable> models, List<AutobahnElement> elements)
    //        {
    //            var modelsGenerated = new List<string>();
    //            foreach (var model in models)
    //            {
    //                if (modelsGenerated.Contains(model.TableName))
    //                {
    //                    continue;
    //                }
    //                modelsGenerated.Add(model.TableName);
    //                Console.WriteLine($"Generating code behind file for {domain.Module}.{model.TableName}View.xaml");
    //                using (var stream = File.CreateText($@"{filePath}\{model.TableName}View.xaml.cs"))
    //                {
    //                    stream.WriteLine($"//**********************************************************");
    //                    stream.WriteLine($"//* DomainName: {domain.Name}");
    //                    stream.WriteLine($"//* FileName:   {model.TableName}View.cs");
    //                    stream.WriteLine($"//**********************************************************");
    //                    stream.WriteLine("");
    //                    stream.WriteLine($"namespace Autobahn.Education.{domain.Module}.Views");
    //                    stream.WriteLine("{");
    //                    stream.WriteLine($"     /// <summary>");
    //                    stream.WriteLine($"     /// The {model.TableName}View");
    //                    stream.WriteLine($"     /// </summary>");
    //                    stream.WriteLine($"     [XamlCompilation(XamlCompilationOptions.Compile)]");
    //                    stream.WriteLine($@"    public partial class {model.TableName}View : ContentPage");
    //                    stream.WriteLine($@"    {{");
    //                    stream.WriteLine($@"        /// <summary>");
    //                    stream.WriteLine($@"        /// Inject the I{model.TableName} View Model as the data context for the view");
    //                    stream.WriteLine($@"        /// </summary>");
    //                    stream.WriteLine($@"        public {model.TableName}View(Interfaces.I{model.TableName} vm)");
    //                    stream.WriteLine($@"        {{");
    //                    stream.WriteLine($@"            BindingContext  = vm;");
    //                    stream.WriteLine($@"        }}");
    //                    stream.WriteLine($@"    }}");
    //                    stream.WriteLine("}");
    //                }
    //            }
    //        }

    /// <summary>
    /// Generate the view models for the domain
    /// </summary>
    /// <param name="filePath">The path to generate in</param>
    /// <param name="domain">The domain we are generating for</param>
    /// <param name="models">The models to generate</param>
    private static void GenerateViewModelFiles(
        string filePath, 
        AutobahnDomain domain,
        List<AutobahnEntity> models)
    {
        var ModelsGenerated = new List<string>();
        foreach (var model in models.Where(m => !m.Name.StartsWith("Ref")))
        {
            if (ModelsGenerated.Contains(model.Name))
            {
                continue;
            }
            ModelsGenerated.Add(model.Name);
            Console.WriteLine($"Generating view model for {domain.Module}.{model.Name}ViewModel");
            
            // First generate the .g.cs view model file that implements
            // the known interface.
            using (var stream = File.CreateText($@"{filePath}\{model.Name}ViewModel.g.cs"))
            {
                GenerateFileHeader(stream, domain, model, TypeBeingGeneratedEnum.ViewModel);
                stream.WriteLine($@"public partial class {model.Name}ViewModel : ObservableValidator, I{model.Name}");
                stream.WriteLine($@"{{");
                GenerateViewModelConstructor(stream, model);
                GenerateBindableProperties(stream, model);
                //GenerateEmbeddedReferences(stream, model, models.Where(m => m.TableName == model.TableName).ToList(), elements);
                stream.WriteLine($@"}}");
            }
        }
    }

    /// <summary>
    /// Generate the entities for the domain
    /// </summary>
    /// <param name="filePath">The path to generate in</param>
    /// <param name="domain">The domain we are generating for</param>
    /// <param name="models">The models to generate</param>
    private static void GenerateEntityFiles(
        string filePath,
        AutobahnDomain domain,
        List<AutobahnEntity> models)
    {
        var ModelsGenerated = new List<string>();
        foreach (var model in models.Where(m => !m.Name.StartsWith("Ref")))
        {
            if (ModelsGenerated.Contains(model.Name))
            {
                continue;
            }
            ModelsGenerated.Add(model.Name);
            Console.WriteLine($"Generating entity for {domain.Module}.{model.Name}ViewModel");

            // First generate the .g.cs enitity file that implements
            // the known interface.
            using (var stream = File.CreateText($@"{filePath}\{model.Name}Entity.g.cs"))
            {
                GenerateFileHeader(stream, domain, model, TypeBeingGeneratedEnum.Entity);
                stream.WriteLine($@"[Table(""{model.Name}"", Schema = ""{domain.Module}"")]");
                stream.WriteLine($@"public partial class {model.Name}Entity : EntityBase, I{model.Name}");
                stream.WriteLine($@"{{");
                GenerateProperties(stream, model, TypeBeingGeneratedEnum.Entity);
                stream.WriteLine($@"}}");
            }
        }
    }

    /// <summary>
    /// Generate a  constructor for the view model. 
    /// </summary>
    /// <param name="stream">The stream to write to</param>
    /// <param name="model">The view model to construct</param>
    private static void GenerateViewModelConstructor(StreamWriter stream, AutobahnEntity model)
    {
        stream.WriteLine($"    #region \"{model.Name}ViewModel Constructor\"");
        stream.WriteLine($"    /// </summary>");
        stream.WriteLine($"    /// The service provider instance.");
        stream.WriteLine($"    /// <summary>");
        stream.WriteLine($"    private System.IServiceProvider? serviceProvider;");
        stream.WriteLine();
        stream.WriteLine($"    /// <summary>");
        stream.WriteLine($"    /// {model.Name}ViewModel Constructor");
        stream.WriteLine($"    /// </summary>");
        stream.WriteLine($"    public {model.Name}ViewModel(System.IServiceProvider provider)");
        stream.WriteLine($"    {{");
        stream.WriteLine($"        serviceProvider = provider;");
        stream.WriteLine($"        On{model.Name}ViewModelConstruction();");
        stream.WriteLine($"    }}");
        stream.WriteLine();
        stream.WriteLine($"    /// <summary>");
        stream.WriteLine($"    /// {model.Name}ViewModel Constructor partial method");
        stream.WriteLine($"    /// <para>");
        stream.WriteLine($"    /// This method is called by the view model constructor");
        stream.WriteLine($"    /// to allow the inclusion of custom processing in");
        stream.WriteLine($"    /// the view models construction");
        stream.WriteLine($"    /// </para>");
        stream.WriteLine($"    /// </summary>");
        stream.WriteLine($"    partial void On{model.Name}ViewModelConstruction();");
        stream.WriteLine($"    #endregion\"");
        stream.WriteLine();
    }

    /// <summary>
    /// Generate the model files for the MVVM pattern. These
    /// are based on using interfaes to construct proper DTO's
    /// </summary>
    /// <param name="filePath">The filepath for the models</param>
    /// <param name="domain">The domain we are generating for</param>
    /// <param name="entities">The entites to be generated</param>
    private static void GenerateModelFiles(
        string filePath, 
        AutobahnDomain domain,
        List<AutobahnEntity> models)
    {
        var modelsGenerated = new List<string>();
        foreach (var model in models)
        {
            if (modelsGenerated.Contains(model.Name))
            {
                continue;
            }
            modelsGenerated.Add(model.Name);
            Console.WriteLine($"Generating model for {domain.Module}.{model.Name}Model");
            using (var stream = File.CreateText($@"{filePath}\{model.Name}Model.g.cs"))
            {
                GenerateFileHeader(stream, domain, model, TypeBeingGeneratedEnum.Entity);
                stream.WriteLine($@"public partial class {model.Name}Model : AutobahnBaseModel, I{model.Name}");
                stream.WriteLine($@"{{");
                GenerateProperties(stream, model, TypeBeingGeneratedEnum.Model);
                stream.WriteLine($@"}}");
            }
        }
    }

    /// <summary>
    /// Generate the Interface files for the Application
    /// </summary>
    /// <param name="filePath">The location where the files are written</param>
    /// <param name="domain">The autobahn domains for the interfaces</param>
    /// <param name="models">The models used to generate interfaces</param>
    private static void GenerateInterfaceFiles(
        string filePath, 
        AutobahnDomain domain, 
        List<AutobahnEntity> models)
    {
        foreach (var model in models.Where(m => m.Attributes.TableAttribute?.Schema == domain.Module).ToList())
        {
            Console.WriteLine($"Generating interface I{model.Name}");
            using (var stream = File.CreateText($@"{filePath}\I{model.Name}.g.cs"))
            {
                GenerateFileHeader(stream, domain, model, TypeBeingGeneratedEnum.Interface);
                stream.WriteLine($@"public partial interface I{model.Name}");
                stream.WriteLine($@"{{");
                GenerateProperties(stream, model, TypeBeingGeneratedEnum.Interface);
                stream.WriteLine($@"}}");
            }
        }
    }

    /// <summary>
    /// Generate automatic properties for Inerfaces, entities
    /// and models
    /// </summary>
    /// <param name="stream">The file stream to write to</param>
    /// <param name="model">The model we are generating code for</param>
    /// <param name="generatedProperty">The type being generated</param>
    private static void GenerateProperties(
        StreamWriter stream, 
        AutobahnEntity model,
        TypeBeingGeneratedEnum generatedType)
    {
        var propertiesGenerated = new List<string>();

        // Concrete implementation of IAutobahnBase
        if (generatedType != TypeBeingGeneratedEnum.Interface
            && generatedType != TypeBeingGeneratedEnum.Entity
            && generatedType != TypeBeingGeneratedEnum.Model)
        {
            stream.WriteLine($"    // Concrete implementation of IAutobahnBase");
            stream.WriteLine($"    #region IAutobahnBase");
            stream.WriteLine($"    /// <summary>");
            stream.WriteLine($"    /// Gets the model's changed status.");
            stream.WriteLine($"    /// </summary>");
            stream.WriteLine($"    public bool IsChanged {{ get; private set; }} = false;");
            stream.WriteLine();
            stream.WriteLine($"    /// <summary>");
            stream.WriteLine($"    /// Resets the model's state to unchanged by accepting the modifications.");
            stream.WriteLine($"    /// </summary>");
            stream.WriteLine($"    public void AcceptChanges()");
            stream.WriteLine($"    {{");
            stream.WriteLine($"        IsChanged = false;");
            stream.WriteLine($"        IsNew = false;");
            stream.WriteLine($"    }}");
            stream.WriteLine();
            stream.WriteLine($"    /// <summary>");
            stream.WriteLine($"    /// True if the model is new and unsaved.");
            stream.WriteLine($"    /// </summary>");
            stream.WriteLine($"    public bool IsNew {{ get; set; }}");
            stream.WriteLine();
            stream.WriteLine($"    /// <summary>");
            stream.WriteLine($"    /// Is it a deleted model?");
            stream.WriteLine($"    /// </summary>");
            stream.WriteLine($"    public bool IsDeleted {{ get; set; }}");
            stream.WriteLine();
            stream.WriteLine($"    /// <summary>");
            stream.WriteLine($"    /// The Id of the Model");
            stream.WriteLine($"    /// </summary>");
            stream.WriteLine($"    public Guid Id {{ get; set; }}");
            stream.WriteLine($"    #endregion");
            stream.WriteLine();
        }
        if (generatedType == TypeBeingGeneratedEnum.Interface)
        {
            stream.WriteLine($"    #region \"I{model.Name} Properties\"");
            stream.WriteLine($"    /// <summary>");
            stream.WriteLine($"    /// The Id of the Model");
            stream.WriteLine($"    /// </summary>");
            stream.WriteLine($"    Guid Id {{ get; set; }}");
            stream.WriteLine();
            propertiesGenerated.Add("Id");
        }

        foreach (var prop in model.AutobahnProperties.OrderBy(o => o.Name))
        {
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
                        "DataCollectionId",
                        $"{model.Name}Id"
                    };
            if (propertiesGenerated.Contains(prop.Name)
                || propertiesToIgnore.Contains(prop.Name)
                || prop.IsVirtual == true)
            {
                continue;
            }
            propertiesGenerated.Add(prop.Name);
            if (propertiesGenerated.Count == 1)
            {
                stream.WriteLine($"    #region \"I{model.Name} Properties\"");
            }
            var modifier = string.Empty;
            if (generatedType != TypeBeingGeneratedEnum.Interface)
            {
                modifier = "public ";
            }

            if (prop.Name.EndsWith("Id") && prop.AutobahnElement == null)
            {
                stream.WriteLine($"    /// <summary>");
                if (!string.IsNullOrEmpty(prop.Attributes.CommentAttribute?.Comment))
                {
                    stream.WriteLine($"    /// {prop.Attributes.CommentAttribute.Comment}");
                }
                else
                {
                    if (prop.Name.StartsWith("Ref"))
                    {
                        stream.WriteLine($"    /// Reference to an optional instance of the <see cref=\"{prop.Name.Replace("Id", string.Empty)}\"/> model");
                    }
                    else
                    {
                        stream.WriteLine($"    /// Reference to an optional instance of the <see cref=\"I{prop.Name.Replace("Id", string.Empty)}\"/> model");
                    }
                }
                stream.WriteLine($"    /// </summary>");
            }

            if (prop.AutobahnElement != null)
            {
                stream.WriteLine($"    /// <summary>");
                stream.WriteLine($"    /// {prop.AutobahnElement.ElementName}");
                stream.WriteLine($"    /// <para>");
                stream.WriteLine($"    /// {prop.AutobahnElement.Definition}");
                stream.WriteLine($"    /// </para>");
                stream.WriteLine($"    /// <para>");
                stream.WriteLine($"    /// <a href=\"{prop.AutobahnElement.URL}\">{prop.AutobahnElement.ElementName}</a>");
                stream.WriteLine($"    /// </para>");
                stream.WriteLine($"    /// </summary>");
            }

            else if (!string.IsNullOrEmpty(prop.Attributes.CommentAttribute?.Comment))
            {
                stream.WriteLine($"    /// <summary>");
                stream.WriteLine($"    /// {prop.Attributes.CommentAttribute?.Comment}");
                stream.WriteLine($"    /// </summary>");
            }

            if (generatedType == TypeBeingGeneratedEnum.Entity)
            {
                GenerateDataAnnotations(stream, prop, TypeBeingGeneratedEnum.Entity);
            }

            if (generatedType == TypeBeingGeneratedEnum.Interface)
            {
                stream.WriteLine($"    {prop.PropertyType} {prop.Name} {{ get; set; }}");
            }
            else
            {
                stream.WriteLine($"    {modifier}{prop.PropertyType} {prop.Name} {{ get; set; }}");
            }
            stream.WriteLine();
        }

        if (propertiesGenerated.Any())
        {
            stream.WriteLine($"    #endregion");
        }
    }

    /// <summary>
    /// Generate data annotations based on the type being generated
    /// </summary>
    /// <param name="stream">The stream to generate on</param>
    /// <param name="prop">The property to generate for</param>
    /// <param name="generatedType">The type being generated</param>
    private static void GenerateDataAnnotations(
        StreamWriter stream,
        AutobahnProperty prop,
        TypeBeingGeneratedEnum generatedType)
    {
        if (prop.Attributes.RequiredAttribute != null)
        {
            var errormsg = "{0} is required.";
            stream.WriteLine($"    [Required(ErrorMessage=\"{errormsg}\")]");
        }
        if (prop.Name.EndsWith("Id")
            && generatedType == TypeBeingGeneratedEnum.Entity)
        {
            stream.WriteLine($"    [ForeignKey(\"{prop.Name.Replace("Id", string.Empty)}\")]");
        }
        if (prop.Attributes.MaxLengthAttribute != null)
        {
            var errormsg = "The {0} value cannot exceed {1} characters.";
            stream.WriteLine($"    [{prop.Attributes.MaxLengthAttribute.Length},ErrorMessage=\"{errormsg}\")]");
        }
        if (prop.Attributes.StringLengthAttribute != null)
        {
            if (prop.Attributes.StringLengthAttribute.MinimumLength > 0)
            {
                var errormsg = "The {0} value must exceed {1} characters.";
                stream.WriteLine($"    [StringLength({prop.Attributes.StringLengthAttribute.MaximumLength},ErrorMessage=\"{errormsg}\",{prop.Attributes.StringLengthAttribute.MinimumLength})]");
            }
            else if (prop.Attributes.StringLengthAttribute.MaximumLength > 0)
            {
                var errormsg = "The {0} must be less then {1} characters.";
                stream.WriteLine($"    [StringLength({prop.Attributes.StringLengthAttribute.MaximumLength},ErrorMessage=\"{errormsg}\")]");
            }
        }
    }

    private static void GenerateBindableProperties(
        StreamWriter stream, 
        AutobahnEntity model)
    {
        GenerateBackingFields(stream, model);

        stream.WriteLine($"    #region \"IAutobahnBase Properties\"");
        stream.WriteLine($"    /// <summary>");
        stream.WriteLine($"    /// The title of the View Model");
        stream.WriteLine($"    /// </summary>");
        stream.WriteLine($"    public string ViewTitle {{ get => viewTitle; set => SetProperty(ref viewTitle, value, false); }}");
        stream.WriteLine();
        stream.WriteLine($"    /// <summary>");
        stream.WriteLine($"    /// The IsNew property is set if the view model has been created but not saved to the database");
        stream.WriteLine($"    /// </summary>");
        stream.WriteLine($"    public bool IsNew {{ get => isNew; set => SetProperty(ref isNew, value, false); }}");
        stream.WriteLine();
        stream.WriteLine($"    /// <summary>");
        stream.WriteLine($"    /// The IsDeleted property is set if the view model is to be delted from the database");
        stream.WriteLine($"    /// </summary>");
        stream.WriteLine($"    public bool IsDeleted {{ get => isDeleted; set => SetProperty(ref isDeleted, value, false); }}");
        stream.WriteLine();
        stream.WriteLine($"    /// <summary>");
        stream.WriteLine($"    /// The primary key of the view model");
        stream.WriteLine($"    /// </summary>");
        stream.WriteLine($"    public Guid Id {{ get; set; }}");
        stream.WriteLine();
        stream.WriteLine($"    /// <summary>");
        stream.WriteLine($"    /// The view model is changed and needs to be save to the database.");
        stream.WriteLine($"    /// </summary>");
        stream.WriteLine($"    public bool IsChanged {{ get => isChanged; private set => SetProperty(ref isChanged, value, false); }}");
        stream.WriteLine();
        stream.WriteLine($"    /// <summary>");
        stream.WriteLine($"    /// The view model is performing a long running task");
        stream.WriteLine($"    /// </summary>");
        stream.WriteLine($"    public bool IsBusy {{ get => isBusy; private set => SetProperty(ref isBusy, value, false); }}");
        stream.WriteLine();
        stream.WriteLine($"    /// <summary>");
        stream.WriteLine($"    /// The view model's changes have been save so update its tracking properties");
        stream.WriteLine($"    /// </summary>");
        stream.WriteLine($"    public void AcceptChanges()");
        stream.WriteLine($"    {{");
        stream.WriteLine($"        IsNew = false;");
        stream.WriteLine($"        IsChanged = false;");
        stream.WriteLine($"    }}");
        stream.WriteLine($"    #endregion");
        stream.WriteLine();
        stream.WriteLine($"    #region \"I{model.Name} Properties\"");

        var propertiesGenerated = new List<string>();
        foreach (var prop in model.AutobahnProperties.OrderBy(m => m.Name))
        {
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
                        "DataCollectionId",
                        "RecordStatus",
                        "DataCollection",
                        $"{model.Name}Id"
                    };
            if (propertiesGenerated.Contains(prop.Name)
                || propertiesToIgnore.Contains(prop.Name)
                || prop.IsVirtual)
            {
                continue;
            }
            propertiesGenerated.Add(prop.Name);
            if (prop.AutobahnElement == null && prop.Name.EndsWith("Id"))
            {
                stream.WriteLine($"    /// <summary>");
                if (prop.Name.StartsWith("Ref"))
                {
                    stream.WriteLine($"    /// Reference to an optional instance of the <see cref=\"{prop.Name.Replace("Id", string.Empty)}\"/> model");
                }
                else
                {
                    stream.WriteLine($"    /// Reference to an optional instance of the <see cref=\"I{prop.Name.Replace("Id", string.Empty)}\"/> model");
                }
                stream.WriteLine($"    /// </summary>");
                stream.WriteLine($"    public {prop.PropertyType} {prop.Name} {{ get; set; }}");
                stream.WriteLine();
                continue;
            }
            if (prop.AutobahnElement != null)
            {
                stream.WriteLine($"    /// <summary>");
                stream.WriteLine($"    /// {prop.AutobahnElement.ElementName}");
                stream.WriteLine($"    /// <para>");
                stream.WriteLine($"    /// {prop.AutobahnElement.Definition}");
                stream.WriteLine($"    /// </para>");
                stream.WriteLine($"    /// <para>");
                stream.WriteLine($"    /// <a href=\"{prop.AutobahnElement.URL}\">{prop.AutobahnElement.ElementName}</a>");
                stream.WriteLine($"    /// </para>");
                stream.WriteLine($"    /// </summary>");
                stream.WriteLine($"    [DisplayName(\"{prop.AutobahnElement.ElementName}\")]");
            }

            GenerateDataAnnotations(stream, prop, TypeBeingGeneratedEnum.ViewModel);

            if (prop.Name.EndsWith("Id"))
            {
                stream.WriteLine($"    public {prop.PropertyType} {prop.Name} {{ get; set; }}");
            }
            else
            {
                stream.WriteLine($"    public {prop.PropertyType} {prop.Name} {{ get => {Program.FirstCharToLower(prop.Name)}; set => SetProperty(ref {Program.FirstCharToLower(prop.Name)}, value, {prop.NeedsValidation.ToString().ToLower()}); }}");
            }
            stream.WriteLine();
        }
        stream.WriteLine($"    #endregion");

        // Create the Load() method
        stream.WriteLine();
        stream.WriteLine($"    /// <summary>");
        stream.WriteLine($"    /// Load the viewmodel from a model");
        stream.WriteLine($"    /// </summary>");
        stream.WriteLine($"    public void Load(I{model.Name} model)");
        stream.WriteLine($"    {{");
        stream.WriteLine($"        IsBusy = true;");
        stream.WriteLine($"        Id = model.Id;");
        propertiesGenerated.Clear();
        foreach (var prop in model.AutobahnProperties.OrderBy(m => m.Name))
        {
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
                        "DataCollectionId",
                        "RecordStatus",
                        "DataCollection",
                        $"{model.Name}Id"
                    };
            
            if (propertiesGenerated.Contains(prop.Name)
                || propertiesToIgnore.Contains(prop.Name)
                || prop.IsVirtual)
            {
                continue;
            }
            propertiesGenerated.Add(prop.Name);
            stream.WriteLine($"        {prop.Name} = model.{prop.Name}; // {prop.AutobahnElement?.ElementName}");
        }
        stream.WriteLine($"        IsChanged = false;");
        stream.WriteLine($"        IsNew = false;");
        stream.WriteLine($"        IsBusy = false;");
        stream.WriteLine($"    }}");
        //GenerateVirtualProperties(stream, model, columns, elements);
        //GenerateEmbeddedReferenceList(stream, columns, elements);
    }

    //        private static void GenerateEmbeddedReferences(StreamWriter stream, AutobahnTable model, List<AutobahnTable> columns, List<AutobahnElement> elements)
    //        {
    //            var csv = new CSVServices();
    //            foreach (var table in columns.Where(c => c.ColumnName.StartsWith("Ref") && c.ColumnName.EndsWith("Id")))
    //            {
    //                var refName = table.ColumnName.Replace("Id", string.Empty);

    //                // embed the reference list if this is the only table it is in. Otherwise
    //                // we wil generate it in a separate partial file
    //                if (ModelsGenerated.Contains(refName) || DomainReferenceList[refName].Count > 1)
    //                {
    //                    continue;
    //                }
    //                ModelsGenerated.Add(refName);

    //                //List<ReferenceModel> refData;
    //                //try
    //                //{
    //                //    refData = csv.ReadReferenceFile(@$"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\{refName}.csv");
    //                //}
    //                //catch
    //                //{
    //                //    refData = new List<ReferenceModel>();
    //                //}

    //                var element = GetTableMeta(model.TableName, string.Empty, elements);
    //                stream.WriteLine("");
    //                stream.WriteLine($"        #region {refName} List");
    //                stream.WriteLine($@"        /// <summary>");
    //                if (element == null)
    //                {
    //                    stream.WriteLine($@"        /// The complete <see cref=""{refName}""> List");
    //                }
    //                else
    //                {
    //                    stream.WriteLine($@"        /// The complete {element.ElementName} List");
    //                }
    //                stream.WriteLine($@"        /// </summary>");
    //                stream.WriteLine($@"        private static List<ReferenceModelBase> {refName}List = new List<ReferenceModelBase>");
    //                stream.WriteLine($@"        {{");
    //                var quote = "\"";
    //                //foreach (var item in refData)
    //                //{
    //                //    var fixedId = $"Guid.Parse({quote}{item.Id}{quote})";
    //                //    var fixedCode = $"{quote}{item.Code?.Replace("\u0022", "\\u0022")}{quote}";
    //                //    var fixedDescription = $"{quote}{item.Description?.Replace("\u0022", "\\u0022")}{quote}";
    //                //    var fixedDefinition = $"{quote}{item.Definition?.Replace("\u0022", "\\u0022")}{quote}";
    //                //    stream.WriteLine($@"            new ReferenceModelBase {{ Id={fixedId}, Code={fixedCode}, Description={fixedDescription}, Definition={fixedDefinition}, SortOrder=Convert.ToDecimal({quote}{item.SortOrder}{quote}) }},");
    //                //}
    //                stream.WriteLine($@"        }};");
    //                stream.WriteLine($"        #endregion");
    //            }
    //        }

    //        private static void GenerateVirtualProperties(StreamWriter stream, AutobahnTable model, List<AutobahnTable> columns, List<AutobahnElement> elements)
    //        {
    //            if (!elements.Any(e => e.TechnicalName.EndsWith("Id") && !e.TechnicalName.StartsWith("Ref")))
    //            {
    //                return;
    //            }
    //            stream.WriteLine();
    //            stream.WriteLine($"        #region \"ICommands for Navigation Properties\"");
    //            foreach (var prop in elements.Where(e => e.TechnicalName.EndsWith("Id") && !e.TechnicalName.StartsWith("Ref")))
    //            {
    //                stream.WriteLine($"        /// <summary>");
    //                if (prop.TechnicalName.EndsWith("Id"))
    //                {
    //                    if (string.IsNullOrEmpty(prop.Definition))
    //                    {
    //                        stream.WriteLine($"        /// Reference to an optional instance of the <see cref=\"{prop.TechnicalName.Replace("Id", string.Empty)}\"/> model");
    //                    }
    //                    else
    //                    {
    //                        stream.WriteLine($"        /// {prop.Definition}");
    //                    }
    //                }
    //                if (prop.URL != null)
    //                {
    //                    stream.WriteLine($"        /// <para>");
    //                    stream.WriteLine($"        /// <a href=\"{prop.URL}\">{prop.ElementName}</a>");
    //                    stream.WriteLine($"        /// </para>");
    //                }
    //                stream.WriteLine($"        /// </summary>");
    //                stream.WriteLine($"        public ICommand {prop.TechnicalName.Replace("Id", string.Empty)}Command {{ get; set; }}");
    //                stream.WriteLine();
    //            }
    //            stream.WriteLine($"        #endregion");
    //        }

    /// <summary>
    /// Generate the backing fields for a view model
    /// </summary>
    /// <param name="stream">The stream to write to</param>
    /// <param name="model">The model that contins the properties we want to generate backing fields for</param>
    private static void GenerateBackingFields(StreamWriter stream, AutobahnEntity model)
    {
        Console.WriteLine($"Generating backing fields for {model.Name}Model");
        stream.WriteLine($"    #region \"Backing Fields\"");
        stream.WriteLine($"    // Every viewmodel has a Title property");
        stream.WriteLine($"    private string viewTitle = \"Hello from {model.Name}\";");
        stream.WriteLine();
        stream.WriteLine($"    // The isNew property is set if the view model has been created but not saved to the database");
        stream.WriteLine($"    private bool isNew = false;");
        stream.WriteLine();
        stream.WriteLine($"    /// The isDeleted property is set if the view model is to be deleted from the database");
        stream.WriteLine($"    private bool isDeleted = false;");
        stream.WriteLine();
        stream.WriteLine($"    /// The view model is changed and needs to be save to the database.");
        stream.WriteLine($"    public bool isChanged = false;");
        stream.WriteLine();
        stream.WriteLine($"    /// The view model is performing a long running task");
        stream.WriteLine($"    public bool isBusy = false;");
        stream.WriteLine();
        var propertiesGenerated = new List<string>();
        foreach (var prop in model.AutobahnProperties.OrderBy(p => p.Name))
        {
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
                        "DataCollectionId",
                        "DataCollection",
                        "RecordStatus",
                        $"{model.Name}Id"
                    };
            if (propertiesGenerated.Contains(prop.Name)
                || propertiesToIgnore.Contains(prop.Name)
                || prop.Name.EndsWith("Id")
                || prop.IsVirtual)
            {
                continue;
            }
            propertiesGenerated.Add(prop.Name);
            if (prop.AutobahnElement == null)
            {
                stream.WriteLine($"    // member variable for the {prop.Name} property");
            }
            else
            {
                stream.WriteLine($"    // {prop.Name} -- (backing property for {prop.AutobahnElement.ElementName})");
            }
            stream.WriteLine($"    private {prop.PropertyType} {Program.FirstCharToLower(prop.Name)};");
            stream.WriteLine();
        }
        stream.WriteLine($"    #endregion");
        stream.WriteLine();
    }

    /// <summary>
    /// Add the assembly version info the the project file
    /// </summary>
    /// <param name="filePath">The path to the project file</param>
    /// <param name="domain">The domain (name of) the project file</param>
    private static void AddAssemblyInfo(
        string filePath, 
        AutobahnDomain domain)
    {
        var fi = new FileInfo(filePath);
        var project = XDocument.Load(filePath);

        var assemblyInfoNode = new XElement("PropertyGroup");
        assemblyInfoNode.Add(new XAttribute("Condition", $@"'$(Configuration)|$(TargetFramework)|$(Platform)'=='Debug|net6.0|AnyCPU'"));
        assemblyInfoNode.Add(new XElement("ApplicationId", $"com.drcarver.Autobahn.Education.{domain.Module}".ToLower()));
        assemblyInfoNode.Add(new XElement("ApplicationDisplayVersion", "1.0.0"));
        assemblyInfoNode.Add(new XElement("ApplicationVersion", "1.0"));
        assemblyInfoNode.Add(new XElement("ApplicationIdGuid", domain.Id));

        //Gets the title associated with the application.
        assemblyInfoNode.Add(new XElement("ApplicationTitle", domain.Name));

        //Gets the name, without the extension, of the assembly file for the application.
        assemblyInfoNode.Add(new XElement("AssemblyName", $"Autobahn.Education.{domain.Module}"));

        //Gets the company name associated with the application.
        assemblyInfoNode.Add(new XElement("CompanyName", $"dcarver.com"));

        //Gets the copyright notice associated with the application.
        assemblyInfoNode.Add(new XElement("Copyright", $"(c)Darrel Carver, 2021-{DateTime.Now.Year}"));

        //Gets the description associated with the application.
        assemblyInfoNode.Add(new XElement("Description", $"{domain.Description}"));

        //Gets the description associated with the application.
        assemblyInfoNode.Add(new XElement("ProductName", $"Autobahn"));

        // Add the new entries
        project?.Root?.LastNode?.AddBeforeSelf(assemblyInfoNode);

        project?.Save(filePath);
    }

    /// <summary>
    /// Generate the Xaml groups for the project file
    /// </summary>
    /// <param name="filePath">The path to the project file</param>
    /// <param name="models">The views (models) in the project</param>
    private static void AddProjectXAMLGroupsInfo(string filePath, List<AutobahnEntity> models)
    {
        var fi = new FileInfo(filePath);
        var project = XDocument.Load(filePath);

        // first add the xaml item groups
        Console.WriteLine($"Generating XAML ItemGroups for {fi.Name}");
        var itemgroup = new XElement("ItemGroup");
        var itemgrouplist = new List<string>();
        foreach (var model in models)
        {
            if (itemgrouplist.Contains(model.Name))
            {
                continue;
            }
            itemgrouplist.Add(model.Name);
            var mauixaml = new XElement("MauiXaml");
            mauixaml.Add(new XAttribute("Update", $@"Views\{model.Name}View.xaml"));
            mauixaml.Add(new XElement("Generator", "MSBuild:Compile"));
            itemgroup.Add(mauixaml);
        }

        // Add the new entries
        project?.Root?.LastNode?.AddAfterSelf(itemgroup);

        // Save off the project file
        project?.Save(filePath);
    }

    /// <summary>
    /// Generate a project file from a template
    /// </summary>
    /// <param name="filePath">The path to the project file</param>
    /// <param name="moduleName">The name of the project file to generate</param>
    private static void GenerateTemplateProject(string filePath, string moduleName)
    {
        Console.WriteLine($"Generating project file for {moduleName}");
        DirectoryInfo di = new DirectoryInfo($@"{filePath}\{moduleName}");
        RecursiveDelete(di);

        // Now create the Maui project for the views
        ZipFile.ExtractToDirectory($@"Reference\mauiproject.zip", $@"{filePath}\{moduleName}");
        File.Move($@"{filePath}\{moduleName}\mauiproject\module.csproj", $@"{filePath}\{moduleName}\mauiproject\{moduleName}.Maui.csproj");
        Directory.Move($@"{filePath}\{moduleName}\mauiproject", $@"{filePath}\{moduleName}\{moduleName}.Maui");
        
        // Next the .net library for the entites, interfaces, models and view models of the module
        ZipFile.ExtractToDirectory($@"Reference\Autobahn.Library.zip", $@"{filePath}\{moduleName}");
        File.Move($@"{filePath}\{moduleName}\Autobahn.Library\Autobahn.Library.csproj", $@"{filePath}\{moduleName}\Autobahn.Library\{moduleName}.csproj");
        Directory.Move($@"{filePath}\{moduleName}\Autobahn.Library", $@"{filePath}\{moduleName}\{moduleName}");
    }

    /// <summary>
    /// A utility function to recursively delete a directory
    /// </summary>
    /// <param name="baseDir">The directory to be deleted</param>
    private static void RecursiveDelete(DirectoryInfo baseDir)
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