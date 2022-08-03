//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedLanguageLearnerViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedLanguageLearnerViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedLanguageLearnerViewModel : BindableBase, IAssessmentPersonalNeedLanguageLearner
    {
#region "Backing Fields"
        // member variable for the AssignedSupport property
        private System.Boolean? _AssignedSupport;

        // member variable for the ActivateByDefault property
        private System.Boolean? _ActivateByDefault;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentNeedsProfileContentId"/> model
        /// </summary>
        public Guid AssessmentNeedsProfileContentId { get; set; }

        public System.Boolean? AssignedSupport { get => _AssignedSupport; set => SetProperty(ref _AssignedSupport, value); }

        public System.Boolean? ActivateByDefault { get => _ActivateByDefault; set => SetProperty(ref _ActivateByDefault, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentNeedsProfileContentLanguageLearnerTypeId"/> model
        /// </summary>
        public Guid RefAssessmentNeedsProfileContentLanguageLearnerTypeId { get; set; }

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
        public void Load(IAssessmentPersonalNeedLanguageLearner model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentNeedsProfileContentId = model.AssessmentNeedsProfileContentId;
            AssignedSupport = model.AssignedSupport;
            ActivateByDefault = model.ActivateByDefault;
            RefAssessmentNeedsProfileContentLanguageLearnerTypeId = model.RefAssessmentNeedsProfileContentLanguageLearnerTypeId;
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
