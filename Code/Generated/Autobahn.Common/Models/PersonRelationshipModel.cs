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
        /// 
        /// </summary>
        public  ContactPriorityNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ContactRestrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? CustodialRelationshipIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EmergencyContactInd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LivesWithIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PrimaryContactIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPersonRelationshipTypeId { get; set; }

    }
}
