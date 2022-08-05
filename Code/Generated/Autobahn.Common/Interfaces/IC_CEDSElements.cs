//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IC_CEDSElements.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IC_CEDSElements
     /// </summary>
    public partial interface IC_CEDSElements : IAutobahnBase
    {
        /// <summary>
        /// Defines the C_CEDSElements.GlobalID non nullable property
        /// </summary>
        System.String GlobalID { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.ElementName non nullable property
        /// </summary>
        System.String ElementName { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.AltName non nullable property
        /// </summary>
        System.String AltName { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.Format non nullable property
        /// </summary>
        System.String Format { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.HasOptionSet non nullable property
        /// </summary>
        System.Boolean HasOptionSet { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.UsageNotes non nullable property
        /// </summary>
        System.String UsageNotes { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.URL non nullable property
        /// </summary>
        System.String URL { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.Version non nullable property
        /// </summary>
        System.String Version { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.TermID non nullable property
        /// </summary>
        System.Int32 TermID { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.ChangedInThisVersionInd non nullable property
        /// </summary>
        System.String ChangedInThisVersionInd { get; set; }

        /// <summary>
        /// Defines the C_CEDSElements.ChangeNotes non nullable property
        /// </summary>
        System.String ChangeNotes { get; set; }

    }
}
