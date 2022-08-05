//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIEPAuthorizationRejected.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIEPAuthorizationRejected
     /// </summary>
    public partial interface IIEPAuthorizationRejected : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IEPAuthorization"/> model
        /// </summary>
        Guid IEPAuthorizationId { get; set; }

        /// <summary>
        /// Defines the IEPAuthorizationRejected.PortionDescription non nullable property
        /// </summary>
        System.String PortionDescription { get; set; }

        /// <summary>
        /// Defines the IEPAuthorizationRejected.PortionExplanation non nullable property
        /// </summary>
        System.String PortionExplanation { get; set; }

    }
}
