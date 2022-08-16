//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProfessionalDevelopmentActivity.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProfessionalDevelopmentActivity Interface
     /// </summary>
    public partial interface IProfessionalDevelopmentActivity : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ActivityCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ActivityIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ApprovalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Objective { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ProfessionalDevelopmentActivityStateApprovedStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PublishIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPDActivityApprovedPurposeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPDActivityCreditTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPDActivityLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPDActivityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPDAudienceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ScholarshipStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Title { get; set; }

    }
}
