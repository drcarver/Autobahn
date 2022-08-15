//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentGraduationPlanModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentGraduationPlan Model
     /// </summary>
    public partial class K12StudentGraduationPlanModel : AutobahnBase, Interfaces.IK12StudentGraduationPlan
    {
        /// <summary>
        /// Student's grade level at time of course.
        /// </summary>
        public Guid? RefGradeLevelWhenCourseTakenId { get; set; }

    }
}
