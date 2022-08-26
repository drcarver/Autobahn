//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12staffEmployment.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12staffEmployment Interface
     /// </summary>
    public partial interface IK12staffEmployment : IAutobahnBase
    {
        Decimal? ContractDaysOfServicePerYear { get; set; }

        Boolean? MepPersonnelIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
        /// </summary>
        Guid? RefEmploymentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12staffClassification"/> model
        /// </summary>
        Guid? RefK12staffClassificationId { get; set; }

        Boolean? SalaryForTeachingAssignmentOnlyIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
        /// </summary>
        Guid StaffEmploymentId { get; set; }

        Boolean? TitleItargetedAssistanceStaffFunded { get; set; }

    }
}
