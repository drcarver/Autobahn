//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAssessmentAccommodationViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAssessmentAccommodation View Model
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
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
        /// </summary>
        public Guid AssessmentAccommodationId { get => _AssessmentAccommodationId; set => SetProperty(ref _AssessmentAccommodationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgramAssessment"/> model
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
            AssessmentAccommodationId = model.AssessmentAccommodationId; // 
            IndividualizedProgramAssessmentId = model.IndividualizedProgramAssessmentId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
