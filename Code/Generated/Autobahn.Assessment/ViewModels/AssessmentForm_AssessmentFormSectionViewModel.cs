//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentForm_AssessmentFormSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentForm_AssessmentFormSectionViewModel
     /// </summary>
    public partial class AssessmentForm_AssessmentFormSectionViewModel : ViewModelBase, Interfaces.IAssessmentForm_AssessmentFormSection
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentForm_AssessmentFormSection";

        // member variable for the AssessmentFormId property
        private Guid _AssessmentFormId;

        // member variable for the AssessmentFormSectionId property
        private Guid _AssessmentFormSectionId;

        // member variable for the SequenceNumber property
        private System.Int32? _SequenceNumber;

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
        /// The title of the AssessmentForm_AssessmentFormSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormId"/> model
        /// </summary>
        public Guid AssessmentFormId { get => _AssessmentFormId; set => SetProperty(ref _AssessmentFormId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSectionId"/> model
        /// </summary>
        public Guid AssessmentFormSectionId { get => _AssessmentFormSectionId; set => SetProperty(ref _AssessmentFormSectionId, value); }

        public System.Int32? SequenceNumber { get => _SequenceNumber; set => SetProperty(ref _SequenceNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentForm_AssessmentFormSection model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentFormId = model.AssessmentFormId;
            AssessmentFormSectionId = model.AssessmentFormSectionId;
            SequenceNumber = model.SequenceNumber;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
