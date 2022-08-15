//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonRelationshipModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonRelationship Model
     /// </summary>
    public partial class PersonRelationshipModel : AutobahnBase, Interfaces.IPersonRelationship
    {
        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public System.Boolean? CustodialRelationshipIndicator { get; set; }

    }
}
