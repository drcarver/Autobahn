//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELProgramLicensingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELProgramLicensingViewModel
     /// </summary>
    public partial class ELProgramLicensingViewModel : ViewModelBase, Interfaces.IELProgramLicensing
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELProgramLicensing";

        // member variable for the InitialLicenseDate property
        private System.DateTime? _InitialLicenseDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELProgramLicensingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19347">Initial License Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Initial License Date")]
        public System.DateTime? InitialLicenseDate { get => _InitialLicenseDate; set => SetProperty(ref _InitialLicenseDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELProgramLicensing model)
        {
            IsBusy = true;
            Id = model.Id;
            InitialLicenseDate = model.InitialLicenseDate; // Initial License Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
