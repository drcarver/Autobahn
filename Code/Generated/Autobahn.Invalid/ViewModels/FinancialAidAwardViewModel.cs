//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAidAwardViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The FinancialAidAwardViewModel
     /// </summary>
    public partial class FinancialAidAwardViewModel : ViewModelBase, Interfaces.IFinancialAidAward
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAidAward";

        // member variable for the FinancialAidAwardAmount property
        private System.Decimal? _FinancialAidAwardAmount;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FinancialAidAwardViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The amount of financial aid awarded to a person for the term/year.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19112">Financial Aid Award Amount</a>
        /// </para>
        /// </summary>
        [DisplayName("Financial Aid Award Amount")]
        public System.Decimal? FinancialAidAwardAmount { get => _FinancialAidAwardAmount; set => SetProperty(ref _FinancialAidAwardAmount, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAidAward model)
        {
            IsBusy = true;
            Id = model.Id;
            FinancialAidAwardAmount = model.FinancialAidAwardAmount; // Financial Aid Award Amount
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
