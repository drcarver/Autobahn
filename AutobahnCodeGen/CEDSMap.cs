using CsvHelper.Configuration;

namespace AutobahnCodeGen
{
    public sealed class CEDSMap : ClassMap<CEDSElement>
    {
        public CEDSMap()
        {
            Map(x => x.GlobalID).Index(0);
            Map(x => x.ElementName).Index(1);
            Map(x => x.AlternateName).Index(2);
            Map(x => x.Definition).Index(3);
            Map(x => x.Format).Index(4);
            Map(x => x.OptionSet).Index(5);
            Map(x => x.UsageNotes).Index(6);
            Map(x => x.URL).Index(7);
            Map(x => x.Version).Index(8);
            Map(x => x.TermId).Index(9);
            Map(x => x.ChangeNotes).Index(11);
        }
    }
}
