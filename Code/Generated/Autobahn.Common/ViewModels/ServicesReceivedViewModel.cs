//**********************************************************
//* DomainName: Common Models
//* FileName:   ServicesReceivedViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServicesReceived View Model
     /// </summary>
    public partial class ServicesReceivedViewModel : ViewModelBase, Interfaces.IServicesReceived
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServicesReceived";

        // FullTimeEquivalency -- (backing property for Special Education Full Time Equivalency)
        private System.Decimal? _FullTimeEquivalency;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the ServicePlanId property
        private Guid _ServicePlanId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Special Education Full Time Equivalency
        /// <para>
        /// Calculated ratio of time the student is in a special education setting. Values range from 0.00 to 1.00. If the student is in a special education setting 25% of the time, the value is .25; if 100% of the time, the value is 1.00.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20208">Special Education Full Time Equivalency</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IServicePlan"/> model
        /// </summary>
        public Guid ServicePlanId { get => _ServicePlanId; set => SetProperty(ref _ServicePlanId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServicesReceived model)
        {
            IsBusy = true;
            Id = model.Id;
            FullTimeEquivalency = model.FullTimeEquivalency; // Special Education Full Time Equivalency
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            ServicePlanId = model.ServicePlanId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
