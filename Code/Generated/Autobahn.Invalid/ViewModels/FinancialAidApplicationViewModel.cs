//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAidApplicationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The FinancialAidApplicationViewModel
     /// </summary>
    public partial class FinancialAidApplicationViewModel : ViewModelBase, Interfaces.IFinancialAidApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAidApplication";

        // member variable for the FinancialAidYearDesignator property
        private System.String _FinancialAidYearDesignator;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefFinancialAidApplicationTypeId property
        private Guid _RefFinancialAidApplicationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FinancialAidApplicationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The type of financial application completed by an individual.
        /// </summary>
        public System.String FinancialAidYearDesignator { get => _FinancialAidYearDesignator; set => SetProperty(ref _FinancialAidYearDesignator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidApplicationType"/> model
        /// </summary>
        public Guid RefFinancialAidApplicationTypeId { get => _RefFinancialAidApplicationTypeId; set => SetProperty(ref _RefFinancialAidApplicationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAidApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            FinancialAidYearDesignator = model.FinancialAidYearDesignator;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefFinancialAidApplicationTypeId = model.RefFinancialAidApplicationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
