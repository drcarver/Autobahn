//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonMilitaryViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonMilitaryViewModel
     /// </summary>
    public partial class PersonMilitaryViewModel : ViewModelBase, Interfaces.IPersonMilitary
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonMilitary";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefMilitaryActiveStudentIndicatorId property
        private  _RefMilitaryActiveStudentIndicatorId;

        // member variable for the RefMilitaryBranchId property
        private  _RefMilitaryBranchId;

        // member variable for the RefMilitaryConnectedStudentIndicatorId property
        private Guid? _RefMilitaryConnectedStudentIndicatorId;

        // member variable for the RefMilitaryVeteranStudentIndicatorId property
        private  _RefMilitaryVeteranStudentIndicatorId;

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
        /// Reference to an optional instance of the <see cref="RefMilitaryActiveStudentIndicator"/> model
        /// </summary>
        public  RefMilitaryActiveStudentIndicatorId { get => _RefMilitaryActiveStudentIndicatorId; set => SetProperty(ref _RefMilitaryActiveStudentIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryBranch"/> model
        /// </summary>
        public  RefMilitaryBranchId { get => _RefMilitaryBranchId; set => SetProperty(ref _RefMilitaryBranchId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryConnectedStudentIndicator"/> model
        /// </summary>
        public Guid? RefMilitaryConnectedStudentIndicatorId { get => _RefMilitaryConnectedStudentIndicatorId; set => SetProperty(ref _RefMilitaryConnectedStudentIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryVeteranStudentIndicator"/> model
        /// </summary>
        public  RefMilitaryVeteranStudentIndicatorId { get => _RefMilitaryVeteranStudentIndicatorId; set => SetProperty(ref _RefMilitaryVeteranStudentIndicatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonMilitary model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefMilitaryActiveStudentIndicatorId = model.RefMilitaryActiveStudentIndicatorId; // 
            RefMilitaryBranchId = model.RefMilitaryBranchId; // 
            RefMilitaryConnectedStudentIndicatorId = model.RefMilitaryConnectedStudentIndicatorId; // 
            RefMilitaryVeteranStudentIndicatorId = model.RefMilitaryVeteranStudentIndicatorId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
