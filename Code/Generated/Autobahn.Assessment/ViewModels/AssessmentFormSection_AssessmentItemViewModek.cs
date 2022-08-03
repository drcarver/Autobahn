//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormSection_AssessmentItemViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentItemViewModel
     /// </summary>
    public partial class AssessmentFormSection_AssessmentItemViewModel : BindableBase, IAssessmentFormSection_AssessmentItem
    {
#region "Backing Fields"
        // member variable for the SequenceNumber property
        private System.Int32 _SequenceNumber;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSectionItemId"/> model
        /// </summary>
        public Guid AssessmentFormSectionItemId { get; set; }

        public System.Int32 SequenceNumber  { get => _SequenceNumber; set => SetProperty(ref _SequenceNumber, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSectionId"/> model
        /// </summary>
        public Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemId"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

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
        public void Load(IAssessmentFormSection_AssessmentItem model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentFormSectionItemId = model.AssessmentFormSectionItemId;
            SequenceNumber = model.SequenceNumber;
            AssessmentFormSectionId = model.AssessmentFormSectionId;
            AssessmentItemId = model.AssessmentItemId;
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
