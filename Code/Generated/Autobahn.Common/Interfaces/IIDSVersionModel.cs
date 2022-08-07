//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIDSVersionModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIDSVersionModel Interface
     /// </summary>
    public partial interface IIDSVersionModel : IAutobahnBase
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
