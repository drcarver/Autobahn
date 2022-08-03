//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   WorkforceEmploymentQuarterlyDataViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Workforce.Interfaces;

namespace Autobahn.Workforce.ViewModels
{
     /// <summary>
     /// The WorkforceEmploymentQuarterlyDataViewModel
     /// </summary>
    public partial class WorkforceEmploymentQuarterlyDataViewModel : BindableBase, IWorkforceEmploymentQuarterlyData
    {
#region "Backing Fields"
        // member variable for the EmployedInMultipleJobsCount property
        private System.Decimal? _EmployedInMultipleJobsCount;

        // member variable for the MilitaryEnlistmentAfterExit property
        private System.Boolean? _MilitaryEnlistmentAfterExit;

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

        public System.Decimal? EmployedInMultipleJobsCount { get => _EmployedInMultipleJobsCount; set => SetProperty(ref _EmployedInMultipleJobsCount, value); }

        public System.Boolean? MilitaryEnlistmentAfterExit { get => _MilitaryEnlistmentAfterExit; set => SetProperty(ref _MilitaryEnlistmentAfterExit, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolledId"/> model
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExitId"/> model
        /// </summary>
        public Guid? RefEmployedAfterExitId { get; set; }

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
        public void Load(IWorkforceEmploymentQuarterlyData model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            EmployedInMultipleJobsCount = model.EmployedInMultipleJobsCount;
            MilitaryEnlistmentAfterExit = model.MilitaryEnlistmentAfterExit;
            RefEmployedWhileEnrolledId = model.RefEmployedWhileEnrolledId;
            RefEmployedAfterExitId = model.RefEmployedAfterExitId;
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
