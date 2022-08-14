//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServicePlanViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ServicePlanViewModel
     /// </summary>
    public partial class ServicePlanViewModel : ViewModelBase, Interfaces.IServicePlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServicePlan";

        // member variable for the DeclinedServicesDate property
        private System.DateTime? _DeclinedServicesDate;

        // member variable for the ExtendsOutsideSchoolYear property
        private System.Boolean? _ExtendsOutsideSchoolYear;

        // member variable for the InclusiveSettingIndicator property
        private System.Boolean? _InclusiveSettingIndicator;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the ReasonForDeclinedServices property
        private System.String _ReasonForDeclinedServices;

        // member variable for the SettingDescription property
        private System.String _SettingDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ServicePlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        public System.DateTime? DeclinedServicesDate { get => _DeclinedServicesDate; set => SetProperty(ref _DeclinedServicesDate, value); }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        public System.Boolean? ExtendsOutsideSchoolYear { get => _ExtendsOutsideSchoolYear; set => SetProperty(ref _ExtendsOutsideSchoolYear, value); }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        public System.Boolean? InclusiveSettingIndicator { get => _InclusiveSettingIndicator; set => SetProperty(ref _InclusiveSettingIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        public System.String ReasonForDeclinedServices { get => _ReasonForDeclinedServices; set => SetProperty(ref _ReasonForDeclinedServices, value); }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        public System.String SettingDescription { get => _SettingDescription; set => SetProperty(ref _SettingDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServicePlan model)
        {
            IsBusy = true;
            Id = model.Id;
            DeclinedServicesDate = model.DeclinedServicesDate;
            ExtendsOutsideSchoolYear = model.ExtendsOutsideSchoolYear;
            InclusiveSettingIndicator = model.InclusiveSettingIndicator;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            ReasonForDeclinedServices = model.ReasonForDeclinedServices;
            SettingDescription = model.SettingDescription;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
