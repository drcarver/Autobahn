//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaGradeLevelsApprovedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaGradeLevelsApprovedViewModel
     /// </summary>
    public partial class K12LeaGradeLevelsApprovedViewModel : ViewModelBase, Interfaces.IK12LeaGradeLevelsApproved
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaGradeLevelsApproved";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private Guid? _RecordStartDateTime;

        // member variable for the RefGradeLevelId property
        private  _RefGradeLevelId;

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
        /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
        /// </summary>
        public  RefGradeLevelId { get => _RefGradeLevelId; set => SetProperty(ref _RefGradeLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaGradeLevelsApproved model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefGradeLevelId = model.RefGradeLevelId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
