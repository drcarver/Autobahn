//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonRelationship.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonRelationship
     /// </summary>
    public partial interface IPersonRelationship : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RelatedPerson"/> model
        /// </summary>
        Guid RelatedPersonId { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.CustodialRelationshipIndicator nullable property
        /// </summary>
        System.Boolean? CustodialRelationshipIndicator { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.EmergencyContactInd nullable property
        /// </summary>
        System.Boolean? EmergencyContactInd { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.ContactPriorityNumber nullable property
        /// </summary>
        System.Int32? ContactPriorityNumber { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.ContactRestrictions non nullable property
        /// </summary>
        System.String ContactRestrictions { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.LivesWithIndicator nullable property
        /// </summary>
        System.Boolean? LivesWithIndicator { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.PrimaryContactIndicator nullable property
        /// </summary>
        System.Boolean? PrimaryContactIndicator { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonRelationshipType"/> model
        /// </summary>
        Guid RefPersonRelationshipTypeId { get; set; }

    }
}
