//**********************************************************
//* DomainName: Common Models
//* FileName:   ServicePlanViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServicePlan View Model
     /// </summary>
    public partial class ServicePlanViewModel : ViewModelBase, Interfaces.IServicePlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServicePlan";

        // DeclinedServicesDate -- (backing property for Declined Services Date)
        private System.DateTime? _DeclinedServicesDate;

        // ExtendsOutsideSchoolYear -- (backing property for Service Extends Outside School Year)
        private System.Boolean? _ExtendsOutsideSchoolYear;

        // InclusiveSettingIndicator -- (backing property for Inclusive Setting Indicator)
        private System.Boolean? _InclusiveSettingIndicator;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // ReasonForDeclinedServices -- (backing property for Reason for Declined Services)
        private System.String _ReasonForDeclinedServices;

        // SettingDescription -- (backing property for Service Setting Description)
        private System.String _SettingDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Declined Services Date
        /// <para>
        /// The date recommended services were declined.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20693">Declined Services Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? DeclinedServicesDate { get => _DeclinedServicesDate; set => SetProperty(ref _DeclinedServicesDate, value); }

        /// <summary>
        /// Service Extends Outside School Year
        /// <para>
        /// Determination if this service continues outside school year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20698">Service Extends Outside School Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ExtendsOutsideSchoolYear { get => _ExtendsOutsideSchoolYear; set => SetProperty(ref _ExtendsOutsideSchoolYear, value); }

        /// <summary>
        /// Inclusive Setting Indicator
        /// <para>
        /// Indicates that services are provided to the child in a place where children of all abilities learn together.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20615">Inclusive Setting Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? InclusiveSettingIndicator { get => _InclusiveSettingIndicator; set => SetProperty(ref _InclusiveSettingIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reason for Declined Services
        /// <para>
        /// The reason given for declining the recommended services.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20460">Reason for Declined Services</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ReasonForDeclinedServices { get => _ReasonForDeclinedServices; set => SetProperty(ref _ReasonForDeclinedServices, value); }

        /// <summary>
        /// Service Setting Description
        /// <para>
        /// Description of the setting in which the services are delivered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20699">Service Setting Description</a>
        /// </para>
        /// </summary>
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
            DeclinedServicesDate = model.DeclinedServicesDate; // Declined Services Date
            ExtendsOutsideSchoolYear = model.ExtendsOutsideSchoolYear; // Service Extends Outside School Year
            InclusiveSettingIndicator = model.InclusiveSettingIndicator; // Inclusive Setting Indicator
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            ReasonForDeclinedServices = model.ReasonForDeclinedServices; // Reason for Declined Services
            SettingDescription = model.SettingDescription; // Service Setting Description
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
