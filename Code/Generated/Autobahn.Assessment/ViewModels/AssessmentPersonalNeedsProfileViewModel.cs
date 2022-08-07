//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfileViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedsProfileViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedsProfile";

        // member variable for the AssessmentNeedType property
        private System.String _AssessmentNeedType;

        // member variable for the AssignedSupportFlag property
        private System.Boolean? _AssignedSupportFlag;

        // member variable for the ActivateByDefault property
        private System.Boolean? _ActivateByDefault;

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
        /// The title of the AssessmentPersonalNeedsProfileViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String AssessmentNeedType  { get => _AssessmentNeedType; set => SetProperty(ref _AssessmentNeedType, value); }

        public System.Boolean? AssignedSupportFlag { get => _AssignedSupportFlag; set => SetProperty(ref _AssignedSupportFlag, value); }

        public System.Boolean? ActivateByDefault { get => _ActivateByDefault; set => SetProperty(ref _ActivateByDefault, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedsProfile model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentNeedType = model.AssessmentNeedType;
            AssignedSupportFlag = model.AssignedSupportFlag;
            ActivateByDefault = model.ActivateByDefault;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
