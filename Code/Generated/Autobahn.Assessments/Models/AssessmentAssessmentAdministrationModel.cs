//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssessmentAdministrationModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentAssessmentAdministration Model
     /// </summary>
    public partial class AssessmentAssessmentAdministrationModel : AutobahnBase, IAssessmentAssessmentAdministration
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
        /// </summary>
        public Guid AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessment"/> model
        /// </summary>
        public Guid AssessmentId { get; set; }

    }
}
