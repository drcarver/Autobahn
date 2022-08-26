//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12staffEmploymentModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12staffEmployment Model
     /// </summary>
    public partial class K12staffEmploymentModel : AutobahnBase, IK12staffEmployment
    {
        public Decimal? ContractDaysOfServicePerYear { get; set; }

        public Boolean? MepPersonnelIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
        /// </summary>
        public Guid? RefEmploymentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12staffClassification"/> model
        /// </summary>
        public Guid? RefK12staffClassificationId { get; set; }

        public Boolean? SalaryForTeachingAssignmentOnlyIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

        public Boolean? TitleItargetedAssistanceStaffFunded { get; set; }

    }
}
