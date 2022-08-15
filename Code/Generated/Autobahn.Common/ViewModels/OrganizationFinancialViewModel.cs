//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFinancialViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationFinancialViewModel
     /// </summary>
    public partial class OrganizationFinancialViewModel : ViewModelBase, Interfaces.IOrganizationFinancial
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationFinancial";

        // member variable for the ActualValue property
        private System.Decimal? _ActualValue;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationFinancialViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20317">Financial Accounting Period Actual Value</a>
        /// </para>
        /// </summary>
        [DisplayName("Financial Accounting Period Actual Value")]
        public System.Decimal? ActualValue { get => _ActualValue; set => SetProperty(ref _ActualValue, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationFinancial model)
        {
            IsBusy = true;
            Id = model.Id;
            ActualValue = model.ActualValue; // Financial Accounting Period Actual Value
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
