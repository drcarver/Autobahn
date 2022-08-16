//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationFoodServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramParticipationFoodServiceViewModel
     /// </summary>
    public partial class ProgramParticipationFoodServiceViewModel : ViewModelBase, Interfaces.IProgramParticipationFoodService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationFoodService";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefSchoolFoodServiceProgramId property
        private Guid? _RefSchoolFoodServiceProgramId;

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
        /// Reference to an optional instance of the <see cref="RefSchoolFoodServiceProgram"/> model
        /// </summary>
        public Guid? RefSchoolFoodServiceProgramId { get => _RefSchoolFoodServiceProgramId; set => SetProperty(ref _RefSchoolFoodServiceProgramId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationFoodService model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefSchoolFoodServiceProgramId = model.RefSchoolFoodServiceProgramId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
