//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemCharacteristicViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentItemCharacteristicViewModel
     /// </summary>
    public partial class AssessmentItemCharacteristicViewModel : ViewModelBase, Interfaces.IAssessmentItemCharacteristic
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemCharacteristic";

        // member variable for the AssessmentItemId property
        private Guid _AssessmentItemId;

        // member variable for the RefAssessmentItemCharacteristicTypeId property
        private Guid? _RefAssessmentItemCharacteristicTypeId;

        // member variable for the Value property
        private System.String _Value;

        // member variable for the ResponseChoicePattern property
        private System.String _ResponseChoicePattern;

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
        /// The title of the AssessmentItemCharacteristicViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemId"/> model
        /// </summary>
        public Guid AssessmentItemId { get => _AssessmentItemId; set => SetProperty(ref _AssessmentItemId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemCharacteristicTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentItemCharacteristicTypeId { get => _RefAssessmentItemCharacteristicTypeId; set => SetProperty(ref _RefAssessmentItemCharacteristicTypeId, value); }

        public System.String Value  { get => _Value; set => SetProperty(ref _Value, value); }

        public System.String ResponseChoicePattern  { get => _ResponseChoicePattern; set => SetProperty(ref _ResponseChoicePattern, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemCharacteristic model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemId = model.AssessmentItemId;
            RefAssessmentItemCharacteristicTypeId = model.RefAssessmentItemCharacteristicTypeId;
            Value = model.Value;
            ResponseChoicePattern = model.ResponseChoicePattern;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
