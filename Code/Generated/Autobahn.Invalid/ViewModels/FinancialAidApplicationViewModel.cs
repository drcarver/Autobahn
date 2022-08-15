//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAidApplicationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the RefFinancialAidApplicationTypeId property
        private Guid _RefFinancialAidApplicationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FinancialAidApplicationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidApplicationType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20186">Financial Aid Application Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Financial Aid Application Type")]
        public Guid RefFinancialAidApplicationTypeId { get => _RefFinancialAidApplicationTypeId; set => SetProperty(ref _RefFinancialAidApplicationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAidApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            RefFinancialAidApplicationTypeId = model.RefFinancialAidApplicationTypeId; // Financial Aid Application Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
