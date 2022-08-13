//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentPersonalNeedsProfileScreenEnhancementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileScreenEnhancementViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileScreenEnhancementViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedsProfileScreenEnhancement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedsProfileScreenEnhancement";

        // member variable for the AssessmentPersonalNeedsProfileId property
        private Guid _AssessmentPersonalNeedsProfileId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentPersonalNeedsProfileScreenEnhancementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfile"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get => _AssessmentPersonalNeedsProfileId; set => SetProperty(ref _AssessmentPersonalNeedsProfileId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedsProfileScreenEnhancement model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileId = model.AssessmentPersonalNeedsProfileId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
