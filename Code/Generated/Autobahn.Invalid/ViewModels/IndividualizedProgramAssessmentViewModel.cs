//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramAssessmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAssessmentViewModel
     /// </summary>
    public partial class IndividualizedProgramAssessmentViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAssessment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAssessment";

        // member variable for the IEPAlternativeAssessmentRationale property
        private System.String _IEPAlternativeAssessmentRationale;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramAssessmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A statement of why-
        /// </summary>
        [DisplayName("IEP Alternative Assessment Rationale")]
        public System.String IEPAlternativeAssessmentRationale { get => _IEPAlternativeAssessmentRationale; set => SetProperty(ref _IEPAlternativeAssessmentRationale, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            IEPAlternativeAssessmentRationale = model.IEPAlternativeAssessmentRationale; // IEP Alternative Assessment Rationale
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
