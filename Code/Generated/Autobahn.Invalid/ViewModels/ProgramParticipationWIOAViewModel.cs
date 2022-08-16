//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationWIOAViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramParticipationWIOAViewModel
     /// </summary>
    public partial class ProgramParticipationWIOAViewModel : ViewModelBase, Interfaces.IProgramParticipationWIOA
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationWIOA";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private Guid? _RecordStartDateTime;

        // member variable for the WIOACareerServices property
        private  _WIOACareerServices;

        // member variable for the WIOATrainingServices property
        private  _WIOATrainingServices;

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
        public Guid? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  WIOACareerServices { get => _WIOACareerServices; set => SetProperty(ref _WIOACareerServices, value); }

        /// <summary>
        /// </summary>
        public  WIOATrainingServices { get => _WIOATrainingServices; set => SetProperty(ref _WIOATrainingServices, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationWIOA model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            WIOACareerServices = model.WIOACareerServices; // 
            WIOATrainingServices = model.WIOATrainingServices; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
