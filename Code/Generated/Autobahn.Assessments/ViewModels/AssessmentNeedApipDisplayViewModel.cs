//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipDisplayViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentNeedApipDisplayViewModel
     /// </summary>
    public partial class AssessmentNeedApipDisplayViewModel : ViewModelBase, Interfaces.IAssessmentNeedApipDisplay
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedApipDisplay";

        // member variable for the EncouragementActivateByDefaultIndicator property
        private  _EncouragementActivateByDefaultIndicator;

        // member variable for the EncouragementAssignedSupportIndicator property
        private Guid? _EncouragementAssignedSupportIndicator;

        // member variable for the EncouragementSoundFileUrl property
        private  _EncouragementSoundFileUrl;

        // member variable for the EncouragementTextMessagingString property
        private  _EncouragementTextMessagingString;

        // member variable for the MaskingActivateByDefaultIndicator property
        private  _MaskingActivateByDefaultIndicator;

        // member variable for the MaskingAssignedSupportIndicator property
        private  _MaskingAssignedSupportIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentNeedMaskingTypeId property
        private  _RefAssessmentNeedMaskingTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  EncouragementActivateByDefaultIndicator { get => _EncouragementActivateByDefaultIndicator; set => SetProperty(ref _EncouragementActivateByDefaultIndicator, value); }

        /// <summary>
        /// </summary>
        public Guid? EncouragementAssignedSupportIndicator { get => _EncouragementAssignedSupportIndicator; set => SetProperty(ref _EncouragementAssignedSupportIndicator, value); }

        /// <summary>
        /// </summary>
        public  EncouragementSoundFileUrl { get => _EncouragementSoundFileUrl; set => SetProperty(ref _EncouragementSoundFileUrl, value); }

        /// <summary>
        /// </summary>
        public  EncouragementTextMessagingString { get => _EncouragementTextMessagingString; set => SetProperty(ref _EncouragementTextMessagingString, value); }

        /// <summary>
        /// </summary>
        public  MaskingActivateByDefaultIndicator { get => _MaskingActivateByDefaultIndicator; set => SetProperty(ref _MaskingActivateByDefaultIndicator, value); }

        /// <summary>
        /// </summary>
        public  MaskingAssignedSupportIndicator { get => _MaskingAssignedSupportIndicator; set => SetProperty(ref _MaskingAssignedSupportIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedMaskingType"/> model
        /// </summary>
        public  RefAssessmentNeedMaskingTypeId { get => _RefAssessmentNeedMaskingTypeId; set => SetProperty(ref _RefAssessmentNeedMaskingTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedApipDisplay model)
        {
            IsBusy = true;
            Id = model.Id;
            EncouragementActivateByDefaultIndicator = model.EncouragementActivateByDefaultIndicator; // 
            EncouragementAssignedSupportIndicator = model.EncouragementAssignedSupportIndicator; // 
            EncouragementSoundFileUrl = model.EncouragementSoundFileUrl; // 
            EncouragementTextMessagingString = model.EncouragementTextMessagingString; // 
            MaskingActivateByDefaultIndicator = model.MaskingActivateByDefaultIndicator; // 
            MaskingAssignedSupportIndicator = model.MaskingAssignedSupportIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentNeedMaskingTypeId = model.RefAssessmentNeedMaskingTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
