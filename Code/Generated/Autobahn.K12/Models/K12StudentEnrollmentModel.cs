//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentEnrollmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentEnrollment Model
     /// </summary>
    public partial class K12StudentEnrollmentModel : AutobahnBase, Interfaces.IK12StudentEnrollment
    {
        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid? RefFoodServiceEligibilityId { get; set; }

    }
}
