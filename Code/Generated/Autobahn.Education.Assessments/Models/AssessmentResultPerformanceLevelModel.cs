//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultPerformanceLevelModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Assessments;

namespace Autobahn.Education.Assessments.Models
{
     /// <summary>
     /// The AssessmentResultPerformanceLevel Model
     /// </summary>
    public partial class AssessmentResultPerformanceLevelModel : IAssessmentResultPerformanceLevel
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

        #region IAssessmentResultPerformanceLevel
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPerformanceLevel"/> model
        /// </summary>
        public Guid AssessmentPerformanceLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
        /// </summary>
        public Guid AssessmentResultId { get; set; }

        #endregion
    }
}
