namespace AutobahnCodeGen
{
    public class CEDSElement
    {
        public string ElementName { get; set; }
        public string Definition { get; set; }
        public string OptionSet { get; set; }
        public string DomainEntityCategory { get; set; }
        public string Status { get; set; }
        public string Format { get; set; }
        public string ChangeNotes { get; set; }
        public string UsageNotes { get; set; }
        public string GlobalID { get; set; }
        public string AlternateName { get; set; }
        public string TechnicalName { get; set; }
        public string UseCaseConnection { get; set; }
        public string URL { get; set; }
        public string SubmitAComment { get; set; }
        public string TableName { get; set; }
        public string DomainName { get; set; }

        public CEDSElement Clone()
        {
            return new CEDSElement
            {
                ElementName = ElementName,
                Definition = Definition,
                OptionSet = OptionSet,
                DomainEntityCategory = DomainEntityCategory,
                Status = Status,
                Format = Format,
                ChangeNotes = ChangeNotes,
                UsageNotes = UsageNotes,
                GlobalID = GlobalID,
                AlternateName = AlternateName,
                TechnicalName = TechnicalName,
                UseCaseConnection = UseCaseConnection,
                URL = URL,
                SubmitAComment = SubmitAComment,
                TableName = TableName,
                DomainName = DomainName
            };
        }
}
}
