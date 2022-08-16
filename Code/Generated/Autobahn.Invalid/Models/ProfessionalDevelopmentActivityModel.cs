//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProfessionalDevelopmentActivityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProfessionalDevelopmentActivity Model
     /// </summary>
    public partial class ProfessionalDevelopmentActivityModel : AutobahnBase, Interfaces.IProfessionalDevelopmentActivity
    {
        /// <summary>
        /// 
        /// </summary>
        public  ActivityCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ActivityIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ApprovalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Objective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ProfessionalDevelopmentActivityStateApprovedStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PublishIndicator { get; set; }

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
        public  RefPDActivityApprovedPurposeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPDActivityCreditTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPDActivityLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPDActivityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPDAudienceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ScholarshipStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Title { get; set; }

    }
}
