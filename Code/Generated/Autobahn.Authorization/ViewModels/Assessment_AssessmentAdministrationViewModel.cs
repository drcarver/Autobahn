//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   Assessment_AssessmentAdministrationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The Assessment_AssessmentAdministrationViewModel
     /// </summary>
    public partial class Assessment_AssessmentAdministrationViewModel : ViewModelBase, Interfaces.IAssessment_AssessmentAdministration
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Assessment_AssessmentAdministration";

        // member variable for the AssessmentAdministrationId property
        private Guid _AssessmentAdministrationId;

        // member variable for the AssessmentId property
        private Guid _AssessmentId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the Assessment_AssessmentAdministrationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        public Guid AssessmentAdministrationId { get => _AssessmentAdministrationId; set => SetProperty(ref _AssessmentAdministrationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Assessment"/> model
        /// </summary>
        public Guid AssessmentId { get => _AssessmentId; set => SetProperty(ref _AssessmentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessment_AssessmentAdministration model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentAdministrationId = model.AssessmentAdministrationId;
            AssessmentId = model.AssessmentId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
