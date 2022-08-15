//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELFacilityLicensingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELFacilityLicensingViewModel
     /// </summary>
    public partial class ELFacilityLicensingViewModel : ViewModelBase, Interfaces.IELFacilityLicensing
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELFacilityLicensing";

        // member variable for the InitialLicensingDate property
        private System.DateTime? _InitialLicensingDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELFacilityLicensingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19347">Initial License Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Initial License Date")]
        public System.DateTime? InitialLicensingDate { get => _InitialLicensingDate; set => SetProperty(ref _InitialLicensingDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELFacilityLicensing model)
        {
            IsBusy = true;
            Id = model.Id;
            InitialLicensingDate = model.InitialLicensingDate; // Initial License Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
