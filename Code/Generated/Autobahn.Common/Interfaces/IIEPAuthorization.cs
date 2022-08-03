//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIEPAuthorization.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIEPAuthorization
     /// </summary>
    public partial interface IIEPAuthorization
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

        /// <summary>
        /// Defines the IEPAuthorization.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IEPAuthorization.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
