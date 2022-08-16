//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramEligibilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramEligibilityViewModel
     /// </summary>
    public partial class IndividualizedProgramEligibilityViewModel : ViewModelBase, Interfaces.IIndividualizedProgramEligibility
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramEligibility";

        // member variable for the ConsentToEvaluateDate property
        private  _ConsentToEvaluateDate;

        // member variable for the ConsentToEvaluateIndicator property
        private Guid? _ConsentToEvaluateIndicator;

        // member variable for the ParentObservations property
        private  _ParentObservations;

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
        public  ConsentToEvaluateDate { get => _ConsentToEvaluateDate; set => SetProperty(ref _ConsentToEvaluateDate, value); }

        /// <summary>
        /// </summary>
        public Guid? ConsentToEvaluateIndicator { get => _ConsentToEvaluateIndicator; set => SetProperty(ref _ConsentToEvaluateIndicator, value); }

        /// <summary>
        /// </summary>
        public  ParentObservations { get => _ParentObservations; set => SetProperty(ref _ParentObservations, value); }

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
        public void Load(Interfaces.IIndividualizedProgramEligibility model)
        {
            IsBusy = true;
            Id = model.Id;
            ConsentToEvaluateDate = model.ConsentToEvaluateDate; // 
            ConsentToEvaluateIndicator = model.ConsentToEvaluateIndicator; // 
            ParentObservations = model.ParentObservations; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
