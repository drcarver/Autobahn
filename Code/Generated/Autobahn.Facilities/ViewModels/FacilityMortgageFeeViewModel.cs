//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageFeeViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityMortgageFeeViewModel
     /// </summary>
    public partial class FacilityMortgageFeeViewModel : ViewModelBase, Interfaces.IFacilityMortgageFee
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityMortgageFee";

        // member variable for the RefFacilityFinancingFeeTypeId property
        private Guid _RefFacilityFinancingFeeTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityMortgageFeeViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityFinancingFeeType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20867">Facility Financing Fee Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Facility Financing Fee Type")]
        public Guid RefFacilityFinancingFeeTypeId { get => _RefFacilityFinancingFeeTypeId; set => SetProperty(ref _RefFacilityFinancingFeeTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityMortgageFee model)
        {
            IsBusy = true;
            Id = model.Id;
            RefFacilityFinancingFeeTypeId = model.RefFacilityFinancingFeeTypeId; // Facility Financing Fee Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
