//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IDSVersion.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IDSVersion
     /// </summary>
    public partial class IDSVersion : AutobahnBase, Interfaces.IIDSVersion
    {
        /// <summary>
        /// Defines the IDSVersion.CurrentVersion non nullable property
        /// </summary>
        public System.Boolean CurrentVersion { get; set; }

        /// <summary>
        /// Defines the IDSVersion.IDSVersionDate non nullable property
        /// </summary>
        public System.DateTime IDSVersionDate { get; set; }

        /// <summary>
        /// Defines the IDSVersion.IDSVersionNumber non nullable property
        /// </summary>
        public System.String IDSVersionNumber { get; set; }

    }
}
