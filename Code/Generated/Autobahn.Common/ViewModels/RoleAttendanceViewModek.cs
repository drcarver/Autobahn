//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleAttendanceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleAttendanceViewModel
     /// </summary>
    public partial class RoleAttendanceViewModel : BindableBase, IRoleAttendance
    {
#region "Backing Fields"
        // member variable for the NumberOfDaysInAttendance property
        private System.Decimal? _NumberOfDaysInAttendance;

        // member variable for the NumberOfDaysAbsent property
        private System.Decimal? _NumberOfDaysAbsent;

        // member variable for the AttendanceRate property
        private System.Decimal? _AttendanceRate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the NumberOfDaysTardy property
        private System.Decimal? _NumberOfDaysTardy;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.Decimal? NumberOfDaysInAttendance { get => _NumberOfDaysInAttendance; set => SetProperty(ref _NumberOfDaysInAttendance, value); }

        public System.Decimal? NumberOfDaysAbsent { get => _NumberOfDaysAbsent; set => SetProperty(ref _NumberOfDaysAbsent, value); }

        public System.Decimal? AttendanceRate { get => _AttendanceRate; set => SetProperty(ref _AttendanceRate, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        public System.Decimal? NumberOfDaysTardy { get => _NumberOfDaysTardy; set => SetProperty(ref _NumberOfDaysTardy, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IRoleAttendance model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            NumberOfDaysInAttendance = model.NumberOfDaysInAttendance;
            NumberOfDaysAbsent = model.NumberOfDaysAbsent;
            AttendanceRate = model.AttendanceRate;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            NumberOfDaysTardy = model.NumberOfDaysTardy;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
