//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffTechnicalAssistanceViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffTechnicalAssistanceViewModel
     /// </summary>
    public partial class StaffTechnicalAssistanceViewModel : ViewModelBase, Interfaces.IStaffTechnicalAssistance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffTechnicalAssistance";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefTechnicalAssistanceDeliveryTypeId property
        private Guid? _RefTechnicalAssistanceDeliveryTypeId;

        // member variable for the RefTechnicalAssistanceTypeId property
        private Guid? _RefTechnicalAssistanceTypeId;

        // member variable for the TechnicalAssistanceApprovedInd property
        private System.Boolean? _TechnicalAssistanceApprovedInd;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the StaffTechnicalAssistanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceDeliveryType"/> model
        /// </summary>
        public Guid? RefTechnicalAssistanceDeliveryTypeId { get => _RefTechnicalAssistanceDeliveryTypeId; set => SetProperty(ref _RefTechnicalAssistanceDeliveryTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceType"/> model
        /// </summary>
        public Guid? RefTechnicalAssistanceTypeId { get => _RefTechnicalAssistanceTypeId; set => SetProperty(ref _RefTechnicalAssistanceTypeId, value); }

        /// <summary>
        /// Indicates whether or not the technical assistance was approved.
        /// </summary>
        public System.Boolean? TechnicalAssistanceApprovedInd { get => _TechnicalAssistanceApprovedInd; set => SetProperty(ref _TechnicalAssistanceApprovedInd, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffTechnicalAssistance model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefTechnicalAssistanceDeliveryTypeId = model.RefTechnicalAssistanceDeliveryTypeId;
            RefTechnicalAssistanceTypeId = model.RefTechnicalAssistanceTypeId;
            TechnicalAssistanceApprovedInd = model.TechnicalAssistanceApprovedInd;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
