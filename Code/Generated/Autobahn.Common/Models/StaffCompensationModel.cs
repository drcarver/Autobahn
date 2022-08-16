//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCompensationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffCompensation Model
     /// </summary>
    public partial class StaffCompensationModel : AutobahnBase, Interfaces.IStaffCompensation
    {
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
        public  RefStaffCompensationSourceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StaffCompensationAnnualSupplement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? StaffCompensationBaseSalary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StaffCompensationHealthBenefits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StaffCompensationLongevity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StaffCompensationOtherBenefits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StaffCompensationRetirementBenefits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StaffCompensationTotalBenefits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StaffCompensationTotalSalary { get; set; }

    }
}
