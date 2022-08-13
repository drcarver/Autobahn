//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffEmploymentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StaffEmployment Model
     /// </summary>
    public partial class K12StaffEmploymentModel : AutobahnBase, Interfaces.IK12StaffEmployment
    {
        /// <summary>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// </summary>
        public System.Decimal? ContractDaysOfServicePerYear { get; set; }

        /// <summary>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// </summary>
        public System.Boolean? MepPersonnelIndicator { get; set; }

        /// <summary>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// </summary>
        public Guid? RefEmploymentStatusId { get; set; }

        /// <summary>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// </summary>
        public Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// </summary>
        public System.Boolean? SalaryForTeachingAssignmentOnlyIndicator { get; set; }

        /// <summary>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// </summary>
        public System.Boolean? TitleITargetedAssistanceStaffFunded { get; set; }

    }
}
