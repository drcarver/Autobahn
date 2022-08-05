//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormSection_AssessmentItemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentItemViewModel
     /// </summary>
    public partial class AssessmentFormSection_AssessmentItemViewModel : ViewModelBase, Interfaces.IAssessmentFormSection_AssessmentItem
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentFormSection_AssessmentItem";

        // member variable for the AssessmentFormSectionItemId property
        private Guid _AssessmentFormSectionItemId;

        // member variable for the SequenceNumber property
        private System.Int32 _SequenceNumber;

        // member variable for the AssessmentFormSectionId property
        private Guid _AssessmentFormSectionId;

        // member variable for the AssessmentItemId property
        private Guid _AssessmentItemId;

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
        /// The title of the AssessmentFormSection_AssessmentItemViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSectionItemId"/> model
        /// </summary>
        public Guid AssessmentFormSectionItemId { get => _AssessmentFormSectionItemId; set => SetProperty(ref _AssessmentFormSectionItemId, value); }

        public System.Int32 SequenceNumber  { get => _SequenceNumber; set => SetProperty(ref _SequenceNumber, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSectionId"/> model
        /// </summary>
        public Guid AssessmentFormSectionId { get => _AssessmentFormSectionId; set => SetProperty(ref _AssessmentFormSectionId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemId"/> model
        /// </summary>
        public Guid AssessmentItemId { get => _AssessmentItemId; set => SetProperty(ref _AssessmentItemId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentFormSection_AssessmentItem model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentFormSectionItemId = model.AssessmentFormSectionItemId;
            SequenceNumber = model.SequenceNumber;
            AssessmentFormSectionId = model.AssessmentFormSectionId;
            AssessmentItemId = model.AssessmentItemId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
