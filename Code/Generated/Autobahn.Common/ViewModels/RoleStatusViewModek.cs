//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleStatusViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleStatusViewModel
     /// </summary>
    public partial class RoleStatusViewModel : BindableBase, IRoleStatus
    {
#region "Backing Fields"
        // member variable for the StatusStartDate property
        private System.DateTime _StatusStartDate;

        // member variable for the StatusEndDate property
        private System.DateTime? _StatusEndDate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.DateTime StatusStartDate  { get => _StatusStartDate; set => SetProperty(ref _StatusStartDate, value); }

        public System.DateTime? StatusEndDate { get => _StatusEndDate; set => SetProperty(ref _StatusEndDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRoleStatusId"/> model
        /// </summary>
        public Guid? RefRoleStatusId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

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
        public void Load(IRoleStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            StatusStartDate = model.StatusStartDate;
            StatusEndDate = model.StatusEndDate;
            RefRoleStatusId = model.RefRoleStatusId;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
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
