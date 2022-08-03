//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfileViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileViewModel : BindableBase, IAssessmentPersonalNeedsProfile
    {
#region "Backing Fields"
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

#endregion

#region Properties
        public System.String AssessmentNeedType  { get => _AssessmentNeedType; set => SetProperty(ref _AssessmentNeedType, value); }

        public System.Boolean? AssignedSupportFlag { get => _AssignedSupportFlag; set => SetProperty(ref _AssignedSupportFlag, value); }

        public System.Boolean? ActivateByDefault { get => _ActivateByDefault; set => SetProperty(ref _ActivateByDefault, value); }

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
        public void Load(IAssessmentPersonalNeedsProfile model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentNeedType = model.AssessmentNeedType;
            AssignedSupportFlag = model.AssignedSupportFlag;
            ActivateByDefault = model.ActivateByDefault;
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
