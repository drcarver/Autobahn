using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace AutobahnCodeGen
{
    public class MauiModule
    {
        //public static Autobahn.Entities.Autobahn { get; set; }
        public static void GenerateModule(string filePath, string moduleName, List<CEDSElement> elements)
        {
            GenerateTemplateProject(filePath, moduleName);
        }

        private static void GenerateTemplateProject(string filePath, string moduleName)
        {
            ZipFile.ExtractToDirectory($@"Reference\mauiproject.zip", filePath);
            File.Move($@"{filePath}\mauiproject\module.csproj", $@"{filePath}\mauiproject\{moduleName}.csproj");
            File.Move($@"{filePath}\mauiproject\mauimodule.cs", $@"{filePath}\mauiproject\{moduleName}Module.cs");
            Directory.Move($@"{filePath}\mauiproject", $@"{filePath}\{moduleName}");
        }
    }
}
