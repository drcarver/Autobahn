//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   Assessment_AssessmentAdministration.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The Assessment_AssessmentAdministration
     /// </summary>
    public partial class Assessment_AssessmentAdministration : AutobahnBase, Interfaces.IAssessment_AssessmentAdministration
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        public Guid AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
