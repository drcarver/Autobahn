//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemCharacteristicViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the AssessmentItemId property
        private Guid _AssessmentItemId;

        // member variable for the RefAssessmentItemCharacteristicTypeId property
        private Guid? _RefAssessmentItemCharacteristicTypeId;

        // member variable for the ResponseChoicePattern property
        private System.String _ResponseChoicePattern;

        // member variable for the Value property
        private System.String _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemCharacteristicViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get => _AssessmentItemId; set => SetProperty(ref _AssessmentItemId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemCharacteristicType"/> model
        /// </summary>
        public Guid? RefAssessmentItemCharacteristicTypeId { get => _RefAssessmentItemCharacteristicTypeId; set => SetProperty(ref _RefAssessmentItemCharacteristicTypeId, value); }

        /// <summary>
        /// The type of psychometric measure provided for assessment item.
        /// </summary>
        public System.String ResponseChoicePattern { get => _ResponseChoicePattern; set => SetProperty(ref _ResponseChoicePattern, value); }

        /// <summary>
        /// The type of psychometric measure provided for assessment item.
        /// </summary>
        public System.String Value { get => _Value; set => SetProperty(ref _Value, value); }

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
            ResponseChoicePattern = model.ResponseChoicePattern;
            Value = model.Value;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
