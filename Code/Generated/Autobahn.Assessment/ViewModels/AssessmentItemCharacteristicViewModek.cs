//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemCharacteristicViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentItemCharacteristicViewModel
     /// </summary>
    public partial class AssessmentItemCharacteristicViewModel : BindableBase, IAssessmentItemCharacteristic
    {
#region "Backing Fields"
        // member variable for the Value property
        private System.String _Value;

        // member variable for the ResponseChoicePattern property
        private System.String _ResponseChoicePattern;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemId"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemCharacteristicTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentItemCharacteristicTypeId { get; set; }

        public System.String Value  { get => _Value; set => SetProperty(ref _Value, value); }

        public System.String ResponseChoicePattern  { get => _ResponseChoicePattern; set => SetProperty(ref _ResponseChoicePattern, value); }

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
        public void Load(IAssessmentItemCharacteristic model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemId = model.AssessmentItemId;
            RefAssessmentItemCharacteristicTypeId = model.RefAssessmentItemCharacteristicTypeId;
            Value = model.Value;
            ResponseChoicePattern = model.ResponseChoicePattern;
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
