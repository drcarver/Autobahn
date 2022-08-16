//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAllergyModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAllergy Model
     /// </summary>
    public partial class PersonAllergyModel : AutobahnBase, Interfaces.IPersonAllergy
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? ReactionDescription { get; set; }

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
        public  RefAllergySeverityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAllergyTypeId { get; set; }

    }
}
