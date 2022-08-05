//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIDSVersion.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIDSVersion
     /// </summary>
    public partial interface IIDSVersion : IAutobahnBase
    {
        /// <summary>
        /// Defines the IDSVersion.CurrentVersion non nullable property
        /// </summary>
        System.Boolean CurrentVersion { get; set; }

        /// <summary>
        /// Defines the IDSVersion.IDSVersionDate non nullable property
        /// </summary>
        System.DateTime IDSVersionDate { get; set; }

        /// <summary>
        /// Defines the IDSVersion.IDSVersionNumber non nullable property
        /// </summary>
        System.String IDSVersionNumber { get; set; }

    }
}
