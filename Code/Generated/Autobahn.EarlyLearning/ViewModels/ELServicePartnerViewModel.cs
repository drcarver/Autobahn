//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELServicePartnerViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELServicePartnerViewModel
     /// </summary>
    public partial class ELServicePartnerViewModel : ViewModelBase, Interfaces.IELServicePartner
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELServicePartner";

        // member variable for the MemorandumOfUnderstandingEndDate property
        private System.DateTime? _MemorandumOfUnderstandingEndDate;

        // member variable for the MemorandumOfUnderstandingStartDate property
        private System.DateTime? _MemorandumOfUnderstandingStartDate;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the ServicePartnerDescription property
        private System.String _ServicePartnerDescription;

        // member variable for the ServicePartnerName property
        private System.String _ServicePartnerName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELServicePartnerViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </summary>
        public System.DateTime? MemorandumOfUnderstandingEndDate { get => _MemorandumOfUnderstandingEndDate; set => SetProperty(ref _MemorandumOfUnderstandingEndDate, value); }

        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </summary>
        public System.DateTime? MemorandumOfUnderstandingStartDate { get => _MemorandumOfUnderstandingStartDate; set => SetProperty(ref _MemorandumOfUnderstandingStartDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </summary>
        public System.String ServicePartnerDescription { get => _ServicePartnerDescription; set => SetProperty(ref _ServicePartnerDescription, value); }

        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
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
            MemorandumOfUnderstandingEndDate = model.MemorandumOfUnderstandingEndDate;
            MemorandumOfUnderstandingStartDate = model.MemorandumOfUnderstandingStartDate;
            OrganizationId = model.OrganizationId;
            ServicePartnerDescription = model.ServicePartnerDescription;
            ServicePartnerName = model.ServicePartnerName;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
