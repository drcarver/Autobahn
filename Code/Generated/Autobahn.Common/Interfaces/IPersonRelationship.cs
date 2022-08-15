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
        System.Boolean? CustodialRelationshipIndicator { get; set; }

    }
}
