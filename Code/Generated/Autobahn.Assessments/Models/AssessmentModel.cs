//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The Assessment Model
     /// </summary>
    public partial class AssessmentModel : AutobahnBase, Interfaces.IAssessment
    {
        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public Guid RefAcademicSubjectId { get; set; }

    }
}
