using CsvHelper.Configuration;

namespace Autobahn.Codegen.Maps
{
    public sealed class _CEDSElementMap : ClassMap<_CEDSElement>
    {
        public _CEDSElementMap()
        {
            Map(x => x.GlobalID).Index(0);
            Map(x => x.ElementName).Index(1);
            Map(x => x.AltName).Index(2);
            Map(x => x.Definition).Index(3);
            Map(x => x.Format).Index(4);
            Map(x => x.HasOptionSet).Index(5);
            Map(x => x.UsageNotes).Index(6);
            Map(x => x.URL).Index(7);
            Map(x => x.Version).Index(8);
            Map(x => x.TermID).Index(9);
            Map(x => x.ChangedInThisVersionInd).Index(10);
            Map(x => x.ChangeNotes).Index(11);
        }
    }
}
