//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   EligibilityEvaluationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The EligibilityEvaluationViewModel
     /// </summary>
    public partial class EligibilityEvaluationViewModel : ViewModelBase, Interfaces.IEligibilityEvaluation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from EligibilityEvaluation";

        // member variable for the Description property
        private Guid? _Description;

        // member variable for the EvaluationDate property
        private  _EvaluationDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  EvaluationDate { get => _EvaluationDate; set => SetProperty(ref _EvaluationDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IEligibilityEvaluation model)
        {
            IsBusy = true;
            Id = model.Id;
            Description = model.Description; // 
            EvaluationDate = model.EvaluationDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
