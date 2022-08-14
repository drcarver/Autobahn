//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipDisplayViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the AssessmentPersonalNeedsProfileDisplayId property
        private Guid _AssessmentPersonalNeedsProfileDisplayId;

        // member variable for the EncouragementActivateByDefaultIndicator property
        private System.Boolean? _EncouragementActivateByDefaultIndicator;

        // member variable for the EncouragementAssignedSupportIndicator property
        private System.Boolean? _EncouragementAssignedSupportIndicator;

        // member variable for the EncouragementSoundFileUrl property
        private System.String _EncouragementSoundFileUrl;

        // member variable for the EncouragementTextMessagingString property
        private System.String _EncouragementTextMessagingString;

        // member variable for the MaskingActivateByDefaultIndicator property
        private System.Boolean? _MaskingActivateByDefaultIndicator;

        // member variable for the MaskingAssignedSupportIndicator property
        private System.Boolean? _MaskingAssignedSupportIndicator;

        // member variable for the RefAssessmentNeedMaskingTypeId property
        private Guid? _RefAssessmentNeedMaskingTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentNeedApipDisplayViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileDisplay"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get => _AssessmentPersonalNeedsProfileDisplayId; set => SetProperty(ref _AssessmentPersonalNeedsProfileDisplayId, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? EncouragementActivateByDefaultIndicator { get => _EncouragementActivateByDefaultIndicator; set => SetProperty(ref _EncouragementActivateByDefaultIndicator, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? EncouragementAssignedSupportIndicator { get => _EncouragementAssignedSupportIndicator; set => SetProperty(ref _EncouragementAssignedSupportIndicator, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.String EncouragementSoundFileUrl { get => _EncouragementSoundFileUrl; set => SetProperty(ref _EncouragementSoundFileUrl, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.String EncouragementTextMessagingString { get => _EncouragementTextMessagingString; set => SetProperty(ref _EncouragementTextMessagingString, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? MaskingActivateByDefaultIndicator { get => _MaskingActivateByDefaultIndicator; set => SetProperty(ref _MaskingActivateByDefaultIndicator, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? MaskingAssignedSupportIndicator { get => _MaskingAssignedSupportIndicator; set => SetProperty(ref _MaskingAssignedSupportIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedMaskingType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedMaskingTypeId { get => _RefAssessmentNeedMaskingTypeId; set => SetProperty(ref _RefAssessmentNeedMaskingTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedApipDisplay model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId;
            EncouragementActivateByDefaultIndicator = model.EncouragementActivateByDefaultIndicator;
            EncouragementAssignedSupportIndicator = model.EncouragementAssignedSupportIndicator;
            EncouragementSoundFileUrl = model.EncouragementSoundFileUrl;
            EncouragementTextMessagingString = model.EncouragementTextMessagingString;
            MaskingActivateByDefaultIndicator = model.MaskingActivateByDefaultIndicator;
            MaskingAssignedSupportIndicator = model.MaskingAssignedSupportIndicator;
            RefAssessmentNeedMaskingTypeId = model.RefAssessmentNeedMaskingTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
