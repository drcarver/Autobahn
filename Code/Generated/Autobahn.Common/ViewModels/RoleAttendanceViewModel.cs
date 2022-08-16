//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleAttendanceViewModel
     /// </summary>
    public partial class RoleAttendanceViewModel : ViewModelBase, Interfaces.IRoleAttendance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleAttendance";

        // member variable for the AttendanceRate property
        private  _AttendanceRate;

        // member variable for the NumberOfDaysAbsent property
        private Guid? _NumberOfDaysAbsent;

        // member variable for the NumberOfDaysInAttendance property
        private  _NumberOfDaysInAttendance;

        // member variable for the NumberOfDaysTardy property
        private  _NumberOfDaysTardy;

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
        public  AttendanceRate { get => _AttendanceRate; set => SetProperty(ref _AttendanceRate, value); }

        /// <summary>
        /// </summary>
        public Guid? NumberOfDaysAbsent { get => _NumberOfDaysAbsent; set => SetProperty(ref _NumberOfDaysAbsent, value); }

        /// <summary>
        /// </summary>
        public  NumberOfDaysInAttendance { get => _NumberOfDaysInAttendance; set => SetProperty(ref _NumberOfDaysInAttendance, value); }

        /// <summary>
        /// </summary>
        public  NumberOfDaysTardy { get => _NumberOfDaysTardy; set => SetProperty(ref _NumberOfDaysTardy, value); }

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
        public void Load(Interfaces.IRoleAttendance model)
        {
            IsBusy = true;
            Id = model.Id;
            AttendanceRate = model.AttendanceRate; // 
            NumberOfDaysAbsent = model.NumberOfDaysAbsent; // 
            NumberOfDaysInAttendance = model.NumberOfDaysInAttendance; // 
            NumberOfDaysTardy = model.NumberOfDaysTardy; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
