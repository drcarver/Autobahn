//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedApipDisplayViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentNeedApipDisplayViewModel
     /// </summary>
    public partial class AssessmentNeedApipDisplayViewModel : BindableBase, IAssessmentNeedApipDisplay
    {
#region "Backing Fields"
        // member variable for the MaskingAssignedSupportIndicator property
        private System.Boolean? _MaskingAssignedSupportIndicator;

        // member variable for the MaskingActivateByDefaultIndicator property
        private System.Boolean? _MaskingActivateByDefaultIndicator;

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

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileDisplayId"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        public System.Boolean? MaskingAssignedSupportIndicator { get => _MaskingAssignedSupportIndicator; set => SetProperty(ref _MaskingAssignedSupportIndicator, value); }

        public System.Boolean? MaskingActivateByDefaultIndicator { get => _MaskingActivateByDefaultIndicator; set => SetProperty(ref _MaskingActivateByDefaultIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedMaskingTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedMaskingTypeId { get; set; }

        public System.Boolean? EncouragementAssignedSupportIndicator { get => _EncouragementAssignedSupportIndicator; set => SetProperty(ref _EncouragementAssignedSupportIndicator, value); }

        public System.Boolean? EncouragementActivateByDefaultIndicator { get => _EncouragementActivateByDefaultIndicator; set => SetProperty(ref _EncouragementActivateByDefaultIndicator, value); }

        public System.String EncouragementTextMessagingString  { get => _EncouragementTextMessagingString; set => SetProperty(ref _EncouragementTextMessagingString, value); }

        public System.String EncouragementSoundFileUrl  { get => _EncouragementSoundFileUrl; set => SetProperty(ref _EncouragementSoundFileUrl, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IAssessmentNeedApipDisplay model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
