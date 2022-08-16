//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDisabilityModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDisability Model
     /// </summary>
    public partial class PersonDisabilityModel : AutobahnBase, Interfaces.IPersonDisability
    {
        /// <summary>
        /// 
        /// </summary>
        public  DisabilityStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? PrimaryDisabilityTypeId { get; set; }

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
        public  RefAccommodationsNeededTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefDisabilityConditionStatusCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefDisabilityConditionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefDisabilityDeterminationSourceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIDEADisabilityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SignificantCognitiveDisabilityIndicator { get; set; }

    }
}
