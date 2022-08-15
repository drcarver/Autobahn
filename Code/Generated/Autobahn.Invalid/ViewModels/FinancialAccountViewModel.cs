//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAccountViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The FinancialAccountViewModel
     /// </summary>
    public partial class FinancialAccountViewModel : ViewModelBase, Interfaces.IFinancialAccount
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAccount";

        // member variable for the RefFinancialAccountCategoryId property
        private Guid? _RefFinancialAccountCategoryId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FinancialAccountViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountCategory"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20312">Financial Account Category</a>
        /// </para>
        /// </summary>
        [DisplayName("Financial Account Category")]
        public Guid? RefFinancialAccountCategoryId { get => _RefFinancialAccountCategoryId; set => SetProperty(ref _RefFinancialAccountCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAccount model)
        {
            IsBusy = true;
            Id = model.Id;
            RefFinancialAccountCategoryId = model.RefFinancialAccountCategoryId; // Financial Account Category
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
