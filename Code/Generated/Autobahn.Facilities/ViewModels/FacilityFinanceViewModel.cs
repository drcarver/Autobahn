//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinanceViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityFinance View Model
     /// </summary>
    public partial class FacilityFinanceViewModel : ViewModelBase, Interfaces.IFacilityFinance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityFinance";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // FacilityReplacementValue -- (backing property for Facility Replacement Value)
        private System.Decimal? _FacilityReplacementValue;

        // IndebtednessAmountAllowed -- (backing property for Indebtedness Amount Allowed)
        private System.Decimal? _IndebtednessAmountAllowed;

        // InsuranceDeductible -- (backing property for Insurance Deductible)
        private System.Decimal? _InsuranceDeductible;

        // PublicEducationMillRate -- (backing property for Public Education Mill Rate)
        private System.Decimal? _PublicEducationMillRate;

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
        /// Facility Replacement Value
        /// <para>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20765">Facility Replacement Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FacilityReplacementValue { get => _FacilityReplacementValue; set => SetProperty(ref _FacilityReplacementValue, value); }

        /// <summary>
        /// Indebtedness Amount Allowed
        /// <para>
        /// The amount of indebtedness allowed by law to be carried by the school district.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20874">Indebtedness Amount Allowed</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? IndebtednessAmountAllowed { get => _IndebtednessAmountAllowed; set => SetProperty(ref _IndebtednessAmountAllowed, value); }

        /// <summary>
        /// Insurance Deductible
        /// <para>
        /// The dollar amount a school district must pay before its insurance will compensate it for loss.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20875">Insurance Deductible</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? InsuranceDeductible { get => _InsuranceDeductible; set => SetProperty(ref _InsuranceDeductible, value); }

        /// <summary>
        /// Public Education Mill Rate
        /// <para>
        /// The millage rate used to calculate property tax revenue for K-12 public education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20876">Public Education Mill Rate</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? PublicEducationMillRate { get => _PublicEducationMillRate; set => SetProperty(ref _PublicEducationMillRate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityFinance model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId; // 
            FacilityReplacementValue = model.FacilityReplacementValue; // Facility Replacement Value
            IndebtednessAmountAllowed = model.IndebtednessAmountAllowed; // Indebtedness Amount Allowed
            InsuranceDeductible = model.InsuranceDeductible; // Insurance Deductible
            PublicEducationMillRate = model.PublicEducationMillRate; // Public Education Mill Rate
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
