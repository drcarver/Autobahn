//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEPAuthorization.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IEPAuthorization
     /// </summary>
    public partial class IEPAuthorization : AutobahnBase, Interfaces.IIEPAuthorization
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AuthorizationDocument"/> model
        /// </summary>
        public Guid AuthorizationDocumentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPAuthorizationDocumentType"/> model
        /// </summary>
        public Guid? RefIEPAuthorizationDocumentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
