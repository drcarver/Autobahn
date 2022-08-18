//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildServiceViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildService View Model
     /// </summary>
    public partial class ELChildServiceViewModel : ViewModelBase, Interfaces.IELChildService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildService";

        // ECEAPEligibility -- (backing property for Early Childhood Education and Assistance Program Eligibility)
        private System.Boolean? _ECEAPEligibility;

        // EligibilityPriorityPoints -- (backing property for Eligibility Priority Points)
        private System.String _EligibilityPriorityPoints;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefEarlyChildhoodServicesOfferedId -- (backing property for Early Childhood Services Offered)
        private Guid? _RefEarlyChildhoodServicesOfferedId;

        // RefEarlyChildhoodServicesReceivedId -- (backing property for Early Childhood Services Received)
        private Guid? _RefEarlyChildhoodServicesReceivedId;

        // RefELServiceTypeId -- (backing property for Early Learning Service Type)
        private Guid? _RefELServiceTypeId;

        // ServiceDate -- (backing property for Service Date)
        private System.DateTime? _ServiceDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Early Childhood Education and Assistance Program Eligibility
        /// <para>
        /// Denotes whether the family member can receive Early Childhood Education and Assistance Program (ECEAP) information for the child in question.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20570">Early Childhood Education and Assistance Program Eligibility</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ECEAPEligibility { get => _ECEAPEligibility; set => SetProperty(ref _ECEAPEligibility, value); }

        /// <summary>
        /// Eligibility Priority Points
        /// <para>
        /// Priority points used to determine eligibility and placement order
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20597">Eligibility Priority Points</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String EligibilityPriorityPoints { get => _EligibilityPriorityPoints; set => SetProperty(ref _EligibilityPriorityPoints, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Early Childhood Services Offered
        /// <para>
        /// A type of service offered by an organization that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20529">Early Childhood Services Offered</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEarlyChildhoodServicesOfferedId { get => _RefEarlyChildhoodServicesOfferedId; set => SetProperty(ref _RefEarlyChildhoodServicesOfferedId, value); }

        /// <summary>
        /// Early Childhood Services Received
        /// <para>
        /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19321">Early Childhood Services Received</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEarlyChildhoodServicesReceivedId { get => _RefEarlyChildhoodServicesReceivedId; set => SetProperty(ref _RefEarlyChildhoodServicesReceivedId, value); }

        /// <summary>
        /// Early Learning Service Type
        /// <para>
        /// A type of service provided to a child.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20583">Early Learning Service Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefELServiceTypeId { get => _RefELServiceTypeId; set => SetProperty(ref _RefELServiceTypeId, value); }

        /// <summary>
        /// Service Date
        /// <para>
        /// The year, month, and day on which a service was provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20616">Service Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ServiceDate { get => _ServiceDate; set => SetProperty(ref _ServiceDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildService model)
        {
            IsBusy = true;
            Id = model.Id;
            ECEAPEligibility = model.ECEAPEligibility; // Early Childhood Education and Assistance Program Eligibility
            EligibilityPriorityPoints = model.EligibilityPriorityPoints; // Eligibility Priority Points
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefEarlyChildhoodServicesOfferedId = model.RefEarlyChildhoodServicesOfferedId; // Early Childhood Services Offered
            RefEarlyChildhoodServicesReceivedId = model.RefEarlyChildhoodServicesReceivedId; // Early Childhood Services Received
            RefELServiceTypeId = model.RefELServiceTypeId; // Early Learning Service Type
            ServiceDate = model.ServiceDate; // Service Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefEarlyChildhoodServicesOffered List
        /// <summary>
        /// The complete <see cref="RefEarlyChildhoodServicesOffered"> List
        /// </summary>
        private static List<ReferenceModelBase> RefEarlyChildhoodServicesOfferedList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefEarlyChildhoodServicesReceived List
        /// <summary>
        /// The complete <see cref="RefEarlyChildhoodServicesReceived"> List
        /// </summary>
        private static List<ReferenceModelBase> RefEarlyChildhoodServicesReceivedList = new List<ReferenceModelBase>
        {
        };
        #endregion
    }
}
