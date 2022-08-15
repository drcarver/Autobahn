//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFederalAccountabilityViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationFederalAccountabilityViewModel
     /// </summary>
    public partial class OrganizationFederalAccountabilityViewModel : ViewModelBase, Interfaces.IOrganizationFederalAccountability
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationFederalAccountability";

        // member variable for the AccountabilityReportTitle property
        private System.String _AccountabilityReportTitle;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationFederalAccountabilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The title of the accountability report.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19005">Accountability Report Title</a>
        /// </para>
        /// </summary>
        [DisplayName("Accountability Report Title")]
        public System.String AccountabilityReportTitle { get => _AccountabilityReportTitle; set => SetProperty(ref _AccountabilityReportTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationFederalAccountability model)
        {
            IsBusy = true;
            Id = model.Id;
            AccountabilityReportTitle = model.AccountabilityReportTitle; // Accountability Report Title
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
