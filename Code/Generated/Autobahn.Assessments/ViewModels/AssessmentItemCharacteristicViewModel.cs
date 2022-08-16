//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemCharacteristicViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentItemCharacteristicViewModel
     /// </summary>
    public partial class AssessmentItemCharacteristicViewModel : ViewModelBase, Interfaces.IAssessmentItemCharacteristic
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemCharacteristic";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentItemCharacteristicTypeId property
        private Guid? _RefAssessmentItemCharacteristicTypeId;

        // member variable for the ResponseChoicePattern property
        private  _ResponseChoicePattern;

        // member variable for the Value property
        private  _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemCharacteristicType"/> model
        /// </summary>
        public Guid? RefAssessmentItemCharacteristicTypeId { get => _RefAssessmentItemCharacteristicTypeId; set => SetProperty(ref _RefAssessmentItemCharacteristicTypeId, value); }

        /// <summary>
        /// </summary>
        public  ResponseChoicePattern { get => _ResponseChoicePattern; set => SetProperty(ref _ResponseChoicePattern, value); }

        /// <summary>
        /// </summary>
        public  Value { get => _Value; set => SetProperty(ref _Value, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemCharacteristic model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentItemCharacteristicTypeId = model.RefAssessmentItemCharacteristicTypeId; // 
            ResponseChoicePattern = model.ResponseChoicePattern; // 
            Value = model.Value; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
