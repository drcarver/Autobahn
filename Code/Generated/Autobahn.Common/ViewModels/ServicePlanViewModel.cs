//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServicePlanViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServicePlanViewModel
     /// </summary>
    public partial class ServicePlanViewModel : ViewModelBase, Interfaces.IServicePlan
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServicePlan";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the DeclinedServicesDate property
        private System.DateTime? _DeclinedServicesDate;

        // member variable for the ExtendsOutsideSchoolYear property
        private System.Boolean? _ExtendsOutsideSchoolYear;

        // member variable for the InclusiveSettingIndicator property
        private System.Boolean? _InclusiveSettingIndicator;

        // member variable for the ReasonForDeclinedServices property
        private System.String _ReasonForDeclinedServices;

        // member variable for the SettingDescription property
        private System.String _SettingDescription;

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
        /// The title of the ServicePlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.DateTime? DeclinedServicesDate { get => _DeclinedServicesDate; set => SetProperty(ref _DeclinedServicesDate, value); }

        public System.Boolean? ExtendsOutsideSchoolYear { get => _ExtendsOutsideSchoolYear; set => SetProperty(ref _ExtendsOutsideSchoolYear, value); }

        public System.Boolean? InclusiveSettingIndicator { get => _InclusiveSettingIndicator; set => SetProperty(ref _InclusiveSettingIndicator, value); }

        public System.String ReasonForDeclinedServices  { get => _ReasonForDeclinedServices; set => SetProperty(ref _ReasonForDeclinedServices, value); }

        public System.String SettingDescription  { get => _SettingDescription; set => SetProperty(ref _SettingDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServicePlan model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            DeclinedServicesDate = model.DeclinedServicesDate;
            ExtendsOutsideSchoolYear = model.ExtendsOutsideSchoolYear;
            InclusiveSettingIndicator = model.InclusiveSettingIndicator;
            ReasonForDeclinedServices = model.ReasonForDeclinedServices;
            SettingDescription = model.SettingDescription;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
