//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestEldevelopmentalDomainModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Assessments;

namespace Autobahn.Education.Assessments.Models
{
     /// <summary>
     /// The AssessmentSubtestEldevelopmentalDomain Model
     /// </summary>
    public partial class AssessmentSubtestEldevelopmentalDomainModel : IAssessmentSubtestEldevelopmentalDomain
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

        #region IAssessmentSubtestEldevelopmentalDomain
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
        /// </summary>
        public Guid RefAssessmentEldevelopmentalDomainId { get; set; }

        #endregion
    }
}
