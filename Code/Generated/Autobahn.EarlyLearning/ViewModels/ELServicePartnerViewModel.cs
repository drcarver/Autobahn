//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELServicePartnerViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELServicePartner View Model
     /// </summary>
    public partial class ELServicePartnerViewModel : ViewModelBase, Interfaces.IELServicePartner
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELServicePartner";

        // MemorandumOfUnderstandingEndDate -- (backing property for Memorandum of Understanding End Date)
        private System.DateTime? _MemorandumOfUnderstandingEndDate;

        // MemorandumOfUnderstandingStartDate -- (backing property for Memorandum of Understanding Start Date)
        private System.DateTime? _MemorandumOfUnderstandingStartDate;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // ServicePartnerDescription -- (backing property for Service Partner Description)
        private System.String _ServicePartnerDescription;

        // ServicePartnerName -- (backing property for Service Partner Name)
        private System.String _ServicePartnerName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Memorandum of Understanding End Date
        /// <para>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20593">Memorandum of Understanding End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? MemorandumOfUnderstandingEndDate { get => _MemorandumOfUnderstandingEndDate; set => SetProperty(ref _MemorandumOfUnderstandingEndDate, value); }

        /// <summary>
        /// Memorandum of Understanding Start Date
        /// <para>
        /// The effective date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner Organization is effective.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20594">Memorandum of Understanding Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? MemorandumOfUnderstandingStartDate { get => _MemorandumOfUnderstandingStartDate; set => SetProperty(ref _MemorandumOfUnderstandingStartDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Service Partner Description
        /// <para>
        /// A description of the type of services that the partner organization provides.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20603">Service Partner Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ServicePartnerDescription { get => _ServicePartnerDescription; set => SetProperty(ref _ServicePartnerDescription, value); }

        /// <summary>
        /// Service Partner Name
        /// <para>
        /// The name of a non-person entity such as an organization, institution, agency or business, that partners with the Early Learning Organization to provide services to enrolled children/families.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20606">Service Partner Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ServicePartnerName { get => _ServicePartnerName; set => SetProperty(ref _ServicePartnerName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELServicePartner model)
        {
            IsBusy = true;
            Id = model.Id;
            MemorandumOfUnderstandingEndDate = model.MemorandumOfUnderstandingEndDate; // Memorandum of Understanding End Date
            MemorandumOfUnderstandingStartDate = model.MemorandumOfUnderstandingStartDate; // Memorandum of Understanding Start Date
            OrganizationId = model.OrganizationId; // 
            ServicePartnerDescription = model.ServicePartnerDescription; // Service Partner Description
            ServicePartnerName = model.ServicePartnerName; // Service Partner Name
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
