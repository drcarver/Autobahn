//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceStaffViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServiceStaffViewModel
     /// </summary>
    public partial class ServiceStaffViewModel : ViewModelBase, Interfaces.IServiceStaffViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServiceStaff";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefSpecialEducationStaffCategoryId property
        private Guid _RefSpecialEducationStaffCategoryId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the ServiceStaffViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefSpecialEducationStaffCategoryId"/> model
        /// </summary>
        public Guid RefSpecialEducationStaffCategoryId { get => _RefSpecialEducationStaffCategoryId; set => SetProperty(ref _RefSpecialEducationStaffCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServiceStaff model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefSpecialEducationStaffCategoryId = model.RefSpecialEducationStaffCategoryId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
