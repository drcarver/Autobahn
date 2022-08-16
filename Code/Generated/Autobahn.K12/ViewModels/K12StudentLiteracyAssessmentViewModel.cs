//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentLiteracyAssessmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentLiteracyAssessmentViewModel
     /// </summary>
    public partial class K12StudentLiteracyAssessmentViewModel : ViewModelBase, Interfaces.IK12StudentLiteracyAssessment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentLiteracyAssessment";

        // member variable for the LiteracyGoalMetStatus property
        private  _LiteracyGoalMetStatus;

        // member variable for the LiteracyPostTestStatus property
        private  _LiteracyPostTestStatus;

        // member variable for the LiteracyPreTestStatus property
        private  _LiteracyPreTestStatus;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefLiteracyAssessmentId property
        private Guid? _RefLiteracyAssessmentId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  LiteracyGoalMetStatus { get => _LiteracyGoalMetStatus; set => SetProperty(ref _LiteracyGoalMetStatus, value); }

        /// <summary>
        /// </summary>
        public  LiteracyPostTestStatus { get => _LiteracyPostTestStatus; set => SetProperty(ref _LiteracyPostTestStatus, value); }

        /// <summary>
        /// </summary>
        public  LiteracyPreTestStatus { get => _LiteracyPreTestStatus; set => SetProperty(ref _LiteracyPreTestStatus, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLiteracyAssessment"/> model
        /// </summary>
        public Guid? RefLiteracyAssessmentId { get => _RefLiteracyAssessmentId; set => SetProperty(ref _RefLiteracyAssessmentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentLiteracyAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            LiteracyGoalMetStatus = model.LiteracyGoalMetStatus; // 
            LiteracyPostTestStatus = model.LiteracyPostTestStatus; // 
            LiteracyPreTestStatus = model.LiteracyPreTestStatus; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefLiteracyAssessmentId = model.RefLiteracyAssessmentId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
