//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramAssessmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAssessmentViewModel
     /// </summary>
    public partial class IndividualizedProgramAssessmentViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAssessment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAssessment";

        // member variable for the IEPAlternativeAssessmentRationale property
        private Guid? _IEPAlternativeAssessmentRationale;

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
        public Guid? IEPAlternativeAssessmentRationale { get => _IEPAlternativeAssessmentRationale; set => SetProperty(ref _IEPAlternativeAssessmentRationale, value); }

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
        public void Load(Interfaces.IIndividualizedProgramAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            IEPAlternativeAssessmentRationale = model.IEPAlternativeAssessmentRationale; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
