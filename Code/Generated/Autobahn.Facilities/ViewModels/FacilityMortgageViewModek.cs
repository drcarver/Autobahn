//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityMortgageViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityMortgageViewModel
     /// </summary>
    public partial class FacilityMortgageViewModel : BindableBase, IFacilityMortgage
    {
#region "Backing Fields"
        // member variable for the FacilityMortgageInterestAmount property
        private System.Decimal? _FacilityMortgageInterestAmount;

        // member variable for the FacilityTotalAssessedValue property
        private System.Decimal? _FacilityTotalAssessedValue;

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

        public System.Decimal? FacilityMortgageInterestAmount { get => _FacilityMortgageInterestAmount; set => SetProperty(ref _FacilityMortgageInterestAmount, value); }

        public System.Decimal? FacilityTotalAssessedValue { get => _FacilityTotalAssessedValue; set => SetProperty(ref _FacilityTotalAssessedValue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageInterestTypeId"/> model
        /// </summary>
        public Guid? RefFacilityMortgageInterestTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageTypeId"/> model
        /// </summary>
        public Guid? RefFacilityMortgageTypeId { get; set; }

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
        public void Load(IFacilityMortgage model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            FacilityMortgageInterestAmount = model.FacilityMortgageInterestAmount;
            FacilityTotalAssessedValue = model.FacilityTotalAssessedValue;
            RefFacilityMortgageInterestTypeId = model.RefFacilityMortgageInterestTypeId;
            RefFacilityMortgageTypeId = model.RefFacilityMortgageTypeId;
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
