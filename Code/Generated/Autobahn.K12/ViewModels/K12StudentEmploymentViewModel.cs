//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentEmploymentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentEmploymentViewModel
     /// </summary>
    public partial class K12StudentEmploymentViewModel : ViewModelBase, Interfaces.IK12StudentEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentEmployment";

        // member variable for the EmploymentNaicsCode property
        private  _EmploymentNaicsCode;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefEmployedAfterExitId property
        private  _RefEmployedAfterExitId;

        // member variable for the RefEmployedWhileEnrolledId property
        private Guid? _RefEmployedWhileEnrolledId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  EmploymentNaicsCode { get => _EmploymentNaicsCode; set => SetProperty(ref _EmploymentNaicsCode, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
        /// </summary>
        public  RefEmployedAfterExitId { get => _RefEmployedAfterExitId; set => SetProperty(ref _RefEmployedAfterExitId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get => _RefEmployedWhileEnrolledId; set => SetProperty(ref _RefEmployedWhileEnrolledId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            EmploymentNaicsCode = model.EmploymentNaicsCode; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefEmployedAfterExitId = model.RefEmployedAfterExitId; // 
            RefEmployedWhileEnrolledId = model.RefEmployedWhileEnrolledId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
