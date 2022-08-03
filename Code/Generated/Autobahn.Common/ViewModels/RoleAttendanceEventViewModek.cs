//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleAttendanceEventViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleAttendanceEventViewModel
     /// </summary>
    public partial class RoleAttendanceEventViewModel : BindableBase, IRoleAttendanceEvent
    {
#region "Backing Fields"
        // member variable for the Date property
        private System.DateTime _Date;

        // member variable for the StartTime property
        private System.TimeSpan? _StartTime;

        // member variable for the EndTime property
        private System.TimeSpan? _EndTime;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.DateTime Date  { get => _Date; set => SetProperty(ref _Date, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAttendanceEventTypeId"/> model
        /// </summary>
        public Guid? RefAttendanceEventTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAttendanceStatusId"/> model
        /// </summary>
        public Guid? RefAttendanceStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAbsentAttendanceCategoryId"/> model
        /// </summary>
        public Guid? RefAbsentAttendanceCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPresentAttendanceCategoryId"/> model
        /// </summary>
        public Guid? RefPresentAttendanceCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaveEventTypeId"/> model
        /// </summary>
        public Guid? RefLeaveEventTypeId { get; set; }

        public System.TimeSpan? StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        public System.TimeSpan? EndTime { get => _EndTime; set => SetProperty(ref _EndTime, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

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
        public void Load(IRoleAttendanceEvent model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            Date = model.Date;
            RefAttendanceEventTypeId = model.RefAttendanceEventTypeId;
            RefAttendanceStatusId = model.RefAttendanceStatusId;
            RefAbsentAttendanceCategoryId = model.RefAbsentAttendanceCategoryId;
            RefPresentAttendanceCategoryId = model.RefPresentAttendanceCategoryId;
            RefLeaveEventTypeId = model.RefLeaveEventTypeId;
            StartTime = model.StartTime;
            EndTime = model.EndTime;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
