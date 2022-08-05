//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIEPAuthorization.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIEPAuthorization
     /// </summary>
    public partial interface IIEPAuthorization : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AuthorizationDocument"/> model
        /// </summary>
        Guid AuthorizationDocumentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPAuthorizationDocumentType"/> model
        /// </summary>
        Guid? RefIEPAuthorizationDocumentTypeId { get; set; }

    }
}
