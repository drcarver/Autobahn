//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffProfessionalDevelopmentActivityModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffProfessionalDevelopmentActivity Model
     /// </summary>
    public partial class StaffProfessionalDevelopmentActivityModel : AutobahnBase, Interfaces.IStaffProfessionalDevelopmentActivity
    {
        /// <summary>
        /// 
        /// </summary>
        public  ActivityCompletionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ActivityIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ActivityStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ActivityTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfCreditsEarned { get; set; }

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
        public Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ScholarshipStatus { get; set; }

    }
}
