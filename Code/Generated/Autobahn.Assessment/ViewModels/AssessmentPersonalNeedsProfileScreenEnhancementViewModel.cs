//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfileScreenEnhancementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentPersonalNeedsProfileScreenEnhancementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileId"/> model
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
