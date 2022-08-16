//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StaffEmployment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StaffEmployment Interface
     /// </summary>
    public partial interface IK12StaffEmployment : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? ContractDaysOfServicePerYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MepPersonnelIndicator { get; set; }

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
         RefEmploymentStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SalaryForTeachingAssignmentOnlyIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TitleITargetedAssistanceStaffFunded { get; set; }

    }
}
