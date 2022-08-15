//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   QuarterlyEmploymentRecordViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The QuarterlyEmploymentRecordViewModel
     /// </summary>
    public partial class QuarterlyEmploymentRecordViewModel : ViewModelBase, Interfaces.IQuarterlyEmploymentRecord
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from QuarterlyEmploymentRecord";

        // member variable for the Earnings property
        private System.Decimal? _Earnings;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the QuarterlyEmploymentRecordViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19991">Quarterly Earnings</a>
        /// </para>
        /// </summary>
        [DisplayName("Quarterly Earnings")]
        public System.Decimal? Earnings { get => _Earnings; set => SetProperty(ref _Earnings, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IQuarterlyEmploymentRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            Earnings = model.Earnings; // Quarterly Earnings
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
