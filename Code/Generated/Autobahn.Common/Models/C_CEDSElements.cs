//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   C_CEDSElements.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The C_CEDSElements
     /// </summary>
    public partial class C_CEDSElements : AutobahnBase, Interfaces.IC_CEDSElements
    {
        /// <summary>
        /// Defines the C_CEDSElements.GlobalID non nullable property
        /// </summary>
        public System.String GlobalID { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.ElementName non nullable property
        /// </summary>
        public System.String ElementName { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.AltName non nullable property
        /// </summary>
        public System.String AltName { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.Format non nullable property
        /// </summary>
        public System.String Format { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.HasOptionSet non nullable property
        /// </summary>
        public System.Boolean HasOptionSet { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.UsageNotes non nullable property
        /// </summary>
        public System.String UsageNotes { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.URL non nullable property
        /// </summary>
        public System.String URL { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.Version non nullable property
        /// </summary>
        public System.String Version { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.TermID non nullable property
        /// </summary>
        public System.Int32 TermID { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.ChangedInThisVersionInd non nullable property
        /// </summary>
        public System.String ChangedInThisVersionInd { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.ChangeNotes non nullable property
        /// </summary>
        public System.String ChangeNotes { get; set; }

    }
}
