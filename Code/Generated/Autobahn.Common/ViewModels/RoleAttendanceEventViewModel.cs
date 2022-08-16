//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceEventViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleAttendanceEventViewModel
     /// </summary>
    public partial class RoleAttendanceEventViewModel : ViewModelBase, Interfaces.IRoleAttendanceEvent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleAttendanceEvent";

        // member variable for the Date property
        private  _Date;

        // member variable for the EndTime property
        private  _EndTime;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAbsentAttendanceCategoryId property
        private  _RefAbsentAttendanceCategoryId;

        // member variable for the RefAttendanceEventTypeId property
        private  _RefAttendanceEventTypeId;

        // member variable for the RefAttendanceStatusId property
        private Guid? _RefAttendanceStatusId;

        // member variable for the RefLeaveEventTypeId property
        private  _RefLeaveEventTypeId;

        // member variable for the RefPresentAttendanceCategoryId property
        private  _RefPresentAttendanceCategoryId;

        // member variable for the StartTime property
        private  _StartTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  Date { get => _Date; set => SetProperty(ref _Date, value); }

        /// <summary>
        /// </summary>
        public  EndTime { get => _EndTime; set => SetProperty(ref _EndTime, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAbsentAttendanceCategory"/> model
        /// </summary>
        public  RefAbsentAttendanceCategoryId { get => _RefAbsentAttendanceCategoryId; set => SetProperty(ref _RefAbsentAttendanceCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAttendanceEventType"/> model
        /// </summary>
        public  RefAttendanceEventTypeId { get => _RefAttendanceEventTypeId; set => SetProperty(ref _RefAttendanceEventTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAttendanceStatus"/> model
        /// </summary>
        public Guid? RefAttendanceStatusId { get => _RefAttendanceStatusId; set => SetProperty(ref _RefAttendanceStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaveEventType"/> model
        /// </summary>
        public  RefLeaveEventTypeId { get => _RefLeaveEventTypeId; set => SetProperty(ref _RefLeaveEventTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPresentAttendanceCategory"/> model
        /// </summary>
        public  RefPresentAttendanceCategoryId { get => _RefPresentAttendanceCategoryId; set => SetProperty(ref _RefPresentAttendanceCategoryId, value); }

        /// <summary>
        /// </summary>
        public  StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRoleAttendanceEvent model)
        {
            IsBusy = true;
            Id = model.Id;
            Date = model.Date; // 
            EndTime = model.EndTime; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAbsentAttendanceCategoryId = model.RefAbsentAttendanceCategoryId; // 
            RefAttendanceEventTypeId = model.RefAttendanceEventTypeId; // 
            RefAttendanceStatusId = model.RefAttendanceStatusId; // 
            RefLeaveEventTypeId = model.RefLeaveEventTypeId; // 
            RefPresentAttendanceCategoryId = model.RefPresentAttendanceCategoryId; // 
            StartTime = model.StartTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
