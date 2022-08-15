//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationAccommodationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentRegistrationAccommodationViewModel
     /// </summary>
    public partial class AssessmentRegistrationAccommodationViewModel : ViewModelBase, Interfaces.IAssessmentRegistrationAccommodation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentRegistrationAccommodation";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentRegistrationAccommodationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentRegistrationAccommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
