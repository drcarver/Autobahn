//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramAssessmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAssessmentViewModel
     /// </summary>
    public partial class IndividualizedProgramAssessmentViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAssessment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAssessment";

        // member variable for the AssessmentId property
        private Guid _AssessmentId;

        // member variable for the IEPAlternativeAssessmentRationale property
        private System.String _IEPAlternativeAssessmentRationale;

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramAssessmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Assessment"/> model
        /// </summary>
        public Guid AssessmentId { get => _AssessmentId; set => SetProperty(ref _AssessmentId, value); }

        /// <summary>
        /// A statement of why-
        /// </summary>
        public System.String IEPAlternativeAssessmentRationale { get => _IEPAlternativeAssessmentRationale; set => SetProperty(ref _IEPAlternativeAssessmentRationale, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentId = model.AssessmentId;
            IEPAlternativeAssessmentRationale = model.IEPAlternativeAssessmentRationale;
            IndividualizedProgramId = model.IndividualizedProgramId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
