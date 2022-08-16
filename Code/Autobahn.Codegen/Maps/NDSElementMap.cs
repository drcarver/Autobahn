using AutobahnCodeGen;
using CsvHelper.Configuration;

namespace Autobahn.Codegen.Maps
{
    public sealed class NDSElementMap : ClassMap<NDSElement>
    {
        public NDSElementMap()
        {
            Map(x => x.GlobalID).Name("GlobalID");
            Map(x => x.ElementName).Name("ElementName");
            Map(x => x.AltName).Name("AltName");
            Map(x => x.Definition).Name("Definition");
            Map(x => x.Format).Name("Format");
            Map(x => x.HasOptionSet).Name("HasOptionSet");
            Map(x => x.UsageNotes).Name("UsageNotes");
            Map(x => x.URL).Name("URL");
            Map(x => x.Version).Name("Version");
            Map(x => x.TermID).Name("TermID");
            Map(x => x.ChangedInThisVersionInd).Name("ChangedInThisVersionInd");
            Map(x => x.ChangeNotes).Name("ChangeNotes");
        }
    }
}
