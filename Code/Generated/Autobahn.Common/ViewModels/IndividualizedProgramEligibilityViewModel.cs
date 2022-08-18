//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramEligibilityViewModel.cs
//* Name:       Consent to Evaluation Date
//* Definition: The date the consent to evaluation occurred.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The date the consent to evaluation occurred.
     /// </summary>
    public partial class IndividualizedProgramEligibilityViewModel : ViewModelBase, Interfaces.IIndividualizedProgramEligibility
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramEligibility";

        // ConsentToEvaluateDate -- (backing property for Consent to Evaluation Date)
        private System.DateTime? _ConsentToEvaluateDate;

        // ConsentToEvaluateIndicator -- (backing property for Consent to Evaluation Indicator)
        private System.Boolean? _ConsentToEvaluateIndicator;

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // ParentObservations -- (backing property for Eligibility Parent Observations Explanation)
        private System.String _ParentObservations;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Consent to Evaluation Date
        /// <para>
        /// The date the consent to evaluation occurred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20708">Consent to Evaluation Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ConsentToEvaluateDate { get => _ConsentToEvaluateDate; set => SetProperty(ref _ConsentToEvaluateDate, value); }

        /// <summary>
        /// Consent to Evaluation Indicator
        /// <para>
        /// Indication parent agreed to evaluate student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20707">Consent to Evaluation Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ConsentToEvaluateIndicator { get => _ConsentToEvaluateIndicator; set => SetProperty(ref _ConsentToEvaluateIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Eligibility Parent Observations Explanation
        /// <para>
        /// Explanation of parent's observations of student's characteristics and history used for determining eligibility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20713">Eligibility Parent Observations Explanation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ParentObservations { get => _ParentObservations; set => SetProperty(ref _ParentObservations, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramEligibility model)
        {
            IsBusy = true;
            Id = model.Id;
            ConsentToEvaluateDate = model.ConsentToEvaluateDate; // Consent to Evaluation Date
            ConsentToEvaluateIndicator = model.ConsentToEvaluateIndicator; // Consent to Evaluation Indicator
            IndividualizedProgramId = model.IndividualizedProgramId; // 
            ParentObservations = model.ParentObservations; // Eligibility Parent Observations Explanation
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
