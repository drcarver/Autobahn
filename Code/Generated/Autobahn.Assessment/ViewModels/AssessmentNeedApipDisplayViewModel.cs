//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedApipDisplayViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentNeedApipDisplayViewModel
     /// </summary>
    public partial class AssessmentNeedApipDisplayViewModel : ViewModelBase, Interfaces.IAssessmentNeedApipDisplayViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedApipDisplay";

        // member variable for the AssessmentPersonalNeedsProfileDisplayId property
        private Guid _AssessmentPersonalNeedsProfileDisplayId;

        // member variable for the MaskingAssignedSupportIndicator property
        private System.Boolean? _MaskingAssignedSupportIndicator;

        // member variable for the MaskingActivateByDefaultIndicator property
        private System.Boolean? _MaskingActivateByDefaultIndicator;

        // member variable for the RefAssessmentNeedMaskingTypeId property
        private Guid? _RefAssessmentNeedMaskingTypeId;

        // member variable for the EncouragementAssignedSupportIndicator property
        private System.Boolean? _EncouragementAssignedSupportIndicator;

        // member variable for the EncouragementActivateByDefaultIndicator property
        private System.Boolean? _EncouragementActivateByDefaultIndicator;

        // member variable for the EncouragementTextMessagingString property
        private System.String _EncouragementTextMessagingString;

        // member variable for the EncouragementSoundFileUrl property
        private System.String _EncouragementSoundFileUrl;

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
        /// The title of the AssessmentNeedApipDisplayViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileDisplayId"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get => _AssessmentPersonalNeedsProfileDisplayId; set => SetProperty(ref _AssessmentPersonalNeedsProfileDisplayId, value); }

        public System.Boolean? MaskingAssignedSupportIndicator { get => _MaskingAssignedSupportIndicator; set => SetProperty(ref _MaskingAssignedSupportIndicator, value); }

        public System.Boolean? MaskingActivateByDefaultIndicator { get => _MaskingActivateByDefaultIndicator; set => SetProperty(ref _MaskingActivateByDefaultIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedMaskingTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedMaskingTypeId { get => _RefAssessmentNeedMaskingTypeId; set => SetProperty(ref _RefAssessmentNeedMaskingTypeId, value); }

        public System.Boolean? EncouragementAssignedSupportIndicator { get => _EncouragementAssignedSupportIndicator; set => SetProperty(ref _EncouragementAssignedSupportIndicator, value); }

        public System.Boolean? EncouragementActivateByDefaultIndicator { get => _EncouragementActivateByDefaultIndicator; set => SetProperty(ref _EncouragementActivateByDefaultIndicator, value); }

        public System.String EncouragementTextMessagingString  { get => _EncouragementTextMessagingString; set => SetProperty(ref _EncouragementTextMessagingString, value); }

        public System.String EncouragementSoundFileUrl  { get => _EncouragementSoundFileUrl; set => SetProperty(ref _EncouragementSoundFileUrl, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedApipDisplay model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId;
            MaskingAssignedSupportIndicator = model.MaskingAssignedSupportIndicator;
            MaskingActivateByDefaultIndicator = model.MaskingActivateByDefaultIndicator;
            RefAssessmentNeedMaskingTypeId = model.RefAssessmentNeedMaskingTypeId;
            EncouragementAssignedSupportIndicator = model.EncouragementAssignedSupportIndicator;
            EncouragementActivateByDefaultIndicator = model.EncouragementActivateByDefaultIndicator;
            EncouragementTextMessagingString = model.EncouragementTextMessagingString;
            EncouragementSoundFileUrl = model.EncouragementSoundFileUrl;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
