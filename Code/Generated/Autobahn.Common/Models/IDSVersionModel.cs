//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IDSVersionModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IDSVersion Model
     /// </summary>
    public partial class IDSVersionModel : AutobahnBase, Interfaces.IIDSVersionModel
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
