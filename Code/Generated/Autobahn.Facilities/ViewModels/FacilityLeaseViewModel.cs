//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityLeaseViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityLease View Model
     /// </summary>
    public partial class FacilityLeaseViewModel : ViewModelBase, Interfaces.IFacilityLease
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityLease";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // FacilityLeaseAmount -- (backing property for Facility Lease Amount)
        private System.Decimal? _FacilityLeaseAmount;

        // RefFacilityLeaseAmountCategoryId -- (backing property for Facility Lease Amount Category)
        private Guid? _RefFacilityLeaseAmountCategoryId;

        // RefFacilityLeaseTypeId -- (backing property for Facility Lease Type)
        private Guid? _RefFacilityLeaseTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Facility Lease Amount
        /// <para>
        /// The amount of money the school must pay to rent the facility that it is in.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20868">Facility Lease Amount</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FacilityLeaseAmount { get => _FacilityLeaseAmount; set => SetProperty(ref _FacilityLeaseAmount, value); }

        /// <summary>
        /// Facility Lease Amount Category
        /// <para>
        /// The category of payment that a school must pay to rent the facility that it is in.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20869">Facility Lease Amount Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityLeaseAmountCategoryId { get => _RefFacilityLeaseAmountCategoryId; set => SetProperty(ref _RefFacilityLeaseAmountCategoryId, value); }

        /// <summary>
        /// Facility Lease Type
        /// <para>
        /// The type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20870">Facility Lease Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityLeaseTypeId { get => _RefFacilityLeaseTypeId; set => SetProperty(ref _RefFacilityLeaseTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityLease model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId; // 
            FacilityLeaseAmount = model.FacilityLeaseAmount; // Facility Lease Amount
            RefFacilityLeaseAmountCategoryId = model.RefFacilityLeaseAmountCategoryId; // Facility Lease Amount Category
            RefFacilityLeaseTypeId = model.RefFacilityLeaseTypeId; // Facility Lease Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
