//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationFundViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELOrganizationFundViewModel
     /// </summary>
    public partial class ELOrganizationFundViewModel : ViewModelBase, Interfaces.IELOrganizationFund
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELOrganizationFund";

        // member variable for the ELOrganizationFundsId property
        private Guid _ELOrganizationFundsId;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefBillableBasisTypeId property
        private Guid? _RefBillableBasisTypeId;

        // member variable for the RefELFederalFundingTypeId property
        private Guid? _RefELFederalFundingTypeId;

        // member variable for the RefELLocalRevenueSourceId property
        private Guid? _RefELLocalRevenueSourceId;

        // member variable for the RefELOtherFederalFundingSourcesId property
        private Guid? _RefELOtherFederalFundingSourcesId;

        // member variable for the RefELStateRevenueSourceId property
        private Guid? _RefELStateRevenueSourceId;

        // member variable for the RefReimbursementTypeId property
        private Guid? _RefReimbursementTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELOrganizationFundViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ELOrganizationFunds"/> model
        /// </summary>
        public Guid ELOrganizationFundsId { get => _ELOrganizationFundsId; set => SetProperty(ref _ELOrganizationFundsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBillableBasisType"/> model
        /// </summary>
        public Guid? RefBillableBasisTypeId { get => _RefBillableBasisTypeId; set => SetProperty(ref _RefBillableBasisTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFederalFundingType"/> model
        /// </summary>
        public Guid? RefELFederalFundingTypeId { get => _RefELFederalFundingTypeId; set => SetProperty(ref _RefELFederalFundingTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELLocalRevenueSource"/> model
        /// </summary>
        public Guid? RefELLocalRevenueSourceId { get => _RefELLocalRevenueSourceId; set => SetProperty(ref _RefELLocalRevenueSourceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELOtherFederalFundingSources"/> model
        /// </summary>
        public Guid? RefELOtherFederalFundingSourcesId { get => _RefELOtherFederalFundingSourcesId; set => SetProperty(ref _RefELOtherFederalFundingSourcesId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELStateRevenueSource"/> model
        /// </summary>
        public Guid? RefELStateRevenueSourceId { get => _RefELStateRevenueSourceId; set => SetProperty(ref _RefELStateRevenueSourceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReimbursementType"/> model
        /// </summary>
        public Guid? RefReimbursementTypeId { get => _RefReimbursementTypeId; set => SetProperty(ref _RefReimbursementTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELOrganizationFund model)
        {
            IsBusy = true;
            Id = model.Id;
            ELOrganizationFundsId = model.ELOrganizationFundsId;
            OrganizationId = model.OrganizationId;
            RefBillableBasisTypeId = model.RefBillableBasisTypeId;
            RefELFederalFundingTypeId = model.RefELFederalFundingTypeId;
            RefELLocalRevenueSourceId = model.RefELLocalRevenueSourceId;
            RefELOtherFederalFundingSourcesId = model.RefELOtherFederalFundingSourcesId;
            RefELStateRevenueSourceId = model.RefELStateRevenueSourceId;
            RefReimbursementTypeId = model.RefReimbursementTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
