//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAdministrationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentAdministration Model
     /// </summary>
    public partial class AssessmentAdministrationModel : AutobahnBase, Interfaces.IAssessmentAdministrationModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Assessment"/> model
        /// </summary>
        public Guid? AssessmentId { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.Name non nullable property
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.StartDate nullable property
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.StartTime nullable property
        /// </summary>
        public System.TimeSpan? StartTime { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.FinishDate nullable property
        /// </summary>
        public System.DateTime? FinishDate { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.FinishTime nullable property
        /// </summary>
        public System.TimeSpan? FinishTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReportingMethod"/> model
        /// </summary>
        public Guid? RefAssessmentReportingMethodId { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.AssessmentSecureIndicator nullable property
        /// </summary>
        public System.Boolean? AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentAdministration.AssessmentAdministrationPeriodDescription non nullable property
        /// </summary>
        public System.String AssessmentAdministrationPeriodDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
