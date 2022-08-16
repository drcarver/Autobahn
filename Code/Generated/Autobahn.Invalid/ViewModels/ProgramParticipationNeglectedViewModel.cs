//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationNeglectedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramParticipationNeglectedViewModel
     /// </summary>
    public partial class ProgramParticipationNeglectedViewModel : ViewModelBase, Interfaces.IProgramParticipationNeglected
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationNeglected";

        // member variable for the AchievementIndicator property
        private  _AchievementIndicator;

        // member variable for the ObtainedEmployment property
        private  _ObtainedEmployment;

        // member variable for the OutcomeIndicator property
        private  _OutcomeIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefNeglectedProgramTypeId property
        private Guid? _RefNeglectedProgramTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AchievementIndicator { get => _AchievementIndicator; set => SetProperty(ref _AchievementIndicator, value); }

        /// <summary>
        /// </summary>
        public  ObtainedEmployment { get => _ObtainedEmployment; set => SetProperty(ref _ObtainedEmployment, value); }

        /// <summary>
        /// </summary>
        public  OutcomeIndicator { get => _OutcomeIndicator; set => SetProperty(ref _OutcomeIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeglectedProgramType"/> model
        /// </summary>
        public Guid? RefNeglectedProgramTypeId { get => _RefNeglectedProgramTypeId; set => SetProperty(ref _RefNeglectedProgramTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationNeglected model)
        {
            IsBusy = true;
            Id = model.Id;
            AchievementIndicator = model.AchievementIndicator; // 
            ObtainedEmployment = model.ObtainedEmployment; // 
            OutcomeIndicator = model.OutcomeIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefNeglectedProgramTypeId = model.RefNeglectedProgramTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
