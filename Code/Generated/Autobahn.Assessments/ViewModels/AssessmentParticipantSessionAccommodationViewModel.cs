//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentParticipantSessionAccommodationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentParticipantSessionAccommodationViewModel
     /// </summary>
    public partial class AssessmentParticipantSessionAccommodationViewModel : ViewModelBase, Interfaces.IAssessmentParticipantSessionAccommodation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentParticipantSessionAccommodation";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentParticipantSessionAccommodationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentParticipantSessionAccommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
