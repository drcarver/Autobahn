//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEmploymentModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffEmployment Model
     /// </summary>
    public partial class StaffEmploymentModel : AutobahnBase, Interfaces.IStaffEmployment
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? FullTimeEquivalency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HireDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PositionTitle { get; set; }

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
        public  RefEmploymentSeparationReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefEmploymentSeparationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StandardOccupationalClassification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  UnionMembershipName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  WeeksEmployedPerYear { get; set; }

    }
}
