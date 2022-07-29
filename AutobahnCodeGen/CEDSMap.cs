using CsvHelper.Configuration;

namespace AutobahnCodeGen
{
    public sealed class CEDSMap : ClassMap<CEDSElement>
    {
        public CEDSMap()
{
            Map(x => x.ElementName).Name("Element Name");
            Map(x => x.Definition).Name("Definition");
            Map(x => x.OptionSet).Name("Option Set");
            Map(x => x.DomainEntityCategory).Name("Domain -> Entity -> Category");
            Map(x => x.Status).Name("Status");
            Map(x => x.Format).Name("Format");
            Map(x => x.ChangeNotes).Name("Change Notes");
            Map(x => x.UsageNotes).Name("Usage Notes");
            Map(x => x.GlobalID).Name("Global ID");
            Map(x => x.AlternateName).Name("Alternate Name");
            Map(x => x.TechnicalName).Name("Technical Name");
            Map(x => x.UseCaseConnection).Name("Use Case/Connection");
            Map(x => x.URL).Name("URL");
            Map(x => x.SubmitAComment).Name("Submit a Comment");
        }
    }
}
