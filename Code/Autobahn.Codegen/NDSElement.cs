namespace AutobahnCodeGen
{
    public class NDSElement
    {
        public string GlobalID { get; set; }
        public string ElementName { get; set; }
        public string AltName { get; set; }
        public string Definition { get; set; }
        public string Format { get; set; }
        public string HasOptionSet { get; set; }
        public string UsageNotes { get; set; }
        public string URL { get; set; }
        public string Version { get; set; }
        public string TermID { get; set; }
        public string ChangedInThisVersionInd { get; set; }
        public string ChangeNotes { get; set; }
        public string TechnicalName { get; set; }
        public string TableName { get; set; }
        public string Domain { get; set; }

        public NDSElement Clone()
        {
            return new NDSElement
            {
                GlobalID = GlobalID,
                ElementName = ElementName,
                AltName = AltName,
                Definition = Definition,
                Format = Format,
                HasOptionSet = HasOptionSet,
                UsageNotes = UsageNotes,
                URL = URL,
                Version = Version,
                TermID = TermID,
                ChangedInThisVersionInd = ChangedInThisVersionInd,
                ChangeNotes = ChangeNotes,
                TechnicalName = TechnicalName
            };
        }
    }
}
