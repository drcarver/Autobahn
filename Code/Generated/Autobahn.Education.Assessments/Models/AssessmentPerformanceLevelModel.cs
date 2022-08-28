//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPerformanceLevelModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Assessments;

namespace Autobahn.Education.Assessments.Models
{
     /// <summary>
     /// The AssessmentPerformanceLevel Model
     /// </summary>
    public partial class AssessmentPerformanceLevelModel : IAssessmentPerformanceLevel
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IAssessmentPerformanceLevel
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
        /// </summary>
        public Guid? AssessmentSubtestId { get; set; }

        /// <summary>
        /// Assessment Performance Level Descriptive Feedback
        /// <para>
        /// A feedback message designed to be reported with the assessment performance level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20184">Assessment Performance Level Descriptive Feedback</a>
        /// </para>
        /// </summary>
        public System.String DescriptiveFeedback { get; set; }

        /// <summary>
        /// Assessment Performance Level Identifier
        /// <para>
        /// A unique number or alphanumeric code assigned to an assessment performance level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19693">Assessment Performance Level Identifier</a>
        /// </para>
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Assessment Performance Level Label
        /// <para>
        /// A label representing the performance level appropriate for use on a report.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19694">Assessment Performance Level Label</a>
        /// </para>
        /// </summary>
        public System.String Label { get; set; }

        /// <summary>
        /// Assessment Performance Level Lower Cut Score
        /// <para>
        /// Lowest possible score for the performance level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19408">Assessment Performance Level Lower Cut Score</a>
        /// </para>
        /// </summary>
        public System.String LowerCutScore { get; set; }

        /// <summary>
        /// Assessment Performance Level Score Metric
        /// <para>
        /// The metric or scale used for score reporting.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19407">Assessment Performance Level Score Metric</a>
        /// </para>
        /// </summary>
        public System.String ScoreMetric { get; set; }

        /// <summary>
        /// Assessment Performance Level Upper Cut Score
        /// <para>
        /// Highest possible score for the performance level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19409">Assessment Performance Level Upper Cut Score</a>
        /// </para>
        /// </summary>
        public System.String UpperCutScore { get; set; }

        #endregion
    }
}
