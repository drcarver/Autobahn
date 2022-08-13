//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonRelationship.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonRelationship Interface
     /// </summary>
    public partial interface IPersonRelationship : IAutobahnBase
    {
        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        System.Int32? ContactPriorityNumber { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        System.String ContactRestrictions { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        System.Boolean? CustodialRelationshipIndicator { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        System.Boolean? EmergencyContactInd { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        System.Boolean? LivesWithIndicator { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        System.Boolean? PrimaryContactIndicator { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        Guid RefPersonRelationshipTypeId { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        Guid RelatedPersonId { get; set; }

    }
}
