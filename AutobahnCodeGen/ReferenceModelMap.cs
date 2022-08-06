using CsvHelper.Configuration;

namespace AutobahnCodeGen
{
    public sealed class ReferenceModelMap : ClassMap<ReferenceModel>
    {
        public ReferenceModelMap()
        {
            Map(x => x.Description).Index(1);
            Map(x => x.Code).Index(2);
            Map(x => x.Definition).Index(3);
            Map(x => x.SortOrder).Index(5);
        }
    }
}
