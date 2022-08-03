//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityFinanceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityFinanceViewModel
     /// </summary>
    public partial class FacilityFinanceViewModel : BindableBase, IFacilityFinance
    {
#region "Backing Fields"
        // member variable for the FacilityReplacementValue property
        private System.Decimal? _FacilityReplacementValue;

        // member variable for the IndebtednessAmountAllowed property
        private System.Decimal? _IndebtednessAmountAllowed;

        // member variable for the InsuranceDeductible property
        private System.Decimal? _InsuranceDeductible;

        // member variable for the PublicEducationMillRate property
        private System.Decimal? _PublicEducationMillRate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        public System.Decimal? FacilityReplacementValue { get => _FacilityReplacementValue; set => SetProperty(ref _FacilityReplacementValue, value); }

        public System.Decimal? IndebtednessAmountAllowed { get => _IndebtednessAmountAllowed; set => SetProperty(ref _IndebtednessAmountAllowed, value); }

        public System.Decimal? InsuranceDeductible { get => _InsuranceDeductible; set => SetProperty(ref _InsuranceDeductible, value); }

        public System.Decimal? PublicEducationMillRate { get => _PublicEducationMillRate; set => SetProperty(ref _PublicEducationMillRate, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IFacilityFinance model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            FacilityReplacementValue = model.FacilityReplacementValue;
            IndebtednessAmountAllowed = model.IndebtednessAmountAllowed;
            InsuranceDeductible = model.InsuranceDeductible;
            PublicEducationMillRate = model.PublicEducationMillRate;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
