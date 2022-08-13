//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramAssessmentAccommodationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAssessmentAccommodationViewModel
     /// </summary>
    public partial class IndividualizedProgramAssessmentAccommodationViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAssessmentAccommodation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAssessmentAccommodation";

        // member variable for the AssessmentAccommodationId property
        private Guid _AssessmentAccommodationId;

        // member variable for the IndividualizedProgramAssessmentId property
        private Guid _IndividualizedProgramAssessmentId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramAssessmentAccommodationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAccommodation"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get => _AssessmentAccommodationId; set => SetProperty(ref _AssessmentAccommodationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgramAssessment"/> model
        /// </summary>
        public Guid IndividualizedProgramAssessmentId { get => _IndividualizedProgramAssessmentId; set => SetProperty(ref _IndividualizedProgramAssessmentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAssessmentAccommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentAccommodationId = model.AssessmentAccommodationId;
            IndividualizedProgramAssessmentId = model.IndividualizedProgramAssessmentId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
