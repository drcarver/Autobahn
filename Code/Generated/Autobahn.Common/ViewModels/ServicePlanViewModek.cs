//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServicePlanViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServicePlanViewModel
     /// </summary>
    public partial class ServicePlanViewModel : BindableBase, IServicePlan
    {
#region "Backing Fields"
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

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.DateTime? DeclinedServicesDate { get => _DeclinedServicesDate; set => SetProperty(ref _DeclinedServicesDate, value); }

        public System.Boolean? ExtendsOutsideSchoolYear { get => _ExtendsOutsideSchoolYear; set => SetProperty(ref _ExtendsOutsideSchoolYear, value); }

        public System.Boolean? InclusiveSettingIndicator { get => _InclusiveSettingIndicator; set => SetProperty(ref _InclusiveSettingIndicator, value); }

        public System.String ReasonForDeclinedServices  { get => _ReasonForDeclinedServices; set => SetProperty(ref _ReasonForDeclinedServices, value); }

        public System.String SettingDescription  { get => _SettingDescription; set => SetProperty(ref _SettingDescription, value); }

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
        public void Load(IServicePlan model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            DeclinedServicesDate = model.DeclinedServicesDate;
            ExtendsOutsideSchoolYear = model.ExtendsOutsideSchoolYear;
            InclusiveSettingIndicator = model.InclusiveSettingIndicator;
            ReasonForDeclinedServices = model.ReasonForDeclinedServices;
            SettingDescription = model.SettingDescription;
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
