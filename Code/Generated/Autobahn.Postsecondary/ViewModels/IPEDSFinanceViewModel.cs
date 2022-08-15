//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPEDSFinanceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The IPEDSFinanceViewModel
     /// </summary>
    public partial class IPEDSFinanceViewModel : ViewModelBase, Interfaces.IIPEDSFinance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IPEDSFinance";

        // member variable for the RefIPEDSFASBFunctionalExpenseId property
        private Guid? _RefIPEDSFASBFunctionalExpenseId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IPEDSFinanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBFunctionalExpense"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20640">IPEDS Finance FASB Functional Expense Category</a>
        /// </para>
        /// </summary>
        [DisplayName("IPEDS Finance FASB Functional Expense Category")]
        public Guid? RefIPEDSFASBFunctionalExpenseId { get => _RefIPEDSFASBFunctionalExpenseId; set => SetProperty(ref _RefIPEDSFASBFunctionalExpenseId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIPEDSFinance model)
        {
            IsBusy = true;
            Id = model.Id;
            RefIPEDSFASBFunctionalExpenseId = model.RefIPEDSFASBFunctionalExpenseId; // IPEDS Finance FASB Functional Expense Category
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
