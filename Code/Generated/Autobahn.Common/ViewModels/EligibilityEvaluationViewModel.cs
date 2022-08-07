//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   EligibilityEvaluationViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The EligibilityEvaluationViewModel
     /// </summary>
    public partial class EligibilityEvaluationViewModel : ViewModelBase, Interfaces.IEligibilityEvaluationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from EligibilityEvaluation";

        // member variable for the Description property
        private System.String _Description;

        // member variable for the EvaluationDate property
        private System.DateTime? _EvaluationDate;

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
        /// The title of the EligibilityEvaluationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.DateTime? EvaluationDate { get => _EvaluationDate; set => SetProperty(ref _EvaluationDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IEligibilityEvaluation model)
        {
            IsBusy = true;
            Id = model.Id;
            Description = model.Description;
            EvaluationDate = model.EvaluationDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
