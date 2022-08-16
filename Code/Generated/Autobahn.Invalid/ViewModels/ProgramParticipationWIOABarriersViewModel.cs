//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationWIOABarriersViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramParticipationWIOABarriersViewModel
     /// </summary>
    public partial class ProgramParticipationWIOABarriersViewModel : ViewModelBase, Interfaces.IProgramParticipationWIOABarriers
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationWIOABarriers";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private Guid? _RecordStartDateTime;

        // member variable for the RefWIOABarrierstoEmploymentId property
        private  _RefWIOABarrierstoEmploymentId;

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
        /// Reference to an optional instance of the <see cref="RefWIOABarrierstoEmployment"/> model
        /// </summary>
        public  RefWIOABarrierstoEmploymentId { get => _RefWIOABarrierstoEmploymentId; set => SetProperty(ref _RefWIOABarrierstoEmploymentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationWIOABarriers model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefWIOABarrierstoEmploymentId = model.RefWIOABarrierstoEmploymentId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
