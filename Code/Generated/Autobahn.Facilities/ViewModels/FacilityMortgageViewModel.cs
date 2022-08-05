//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityMortgageViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityMortgageViewModel
     /// </summary>
    public partial class FacilityMortgageViewModel : ViewModelBase, Interfaces.IFacilityMortgage
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityMortgage";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the FacilityMortgageInterestAmount property
        private System.Decimal? _FacilityMortgageInterestAmount;

        // member variable for the FacilityTotalAssessedValue property
        private System.Decimal? _FacilityTotalAssessedValue;

        // member variable for the RefFacilityMortgageInterestTypeId property
        private Guid? _RefFacilityMortgageInterestTypeId;

        // member variable for the RefFacilityMortgageTypeId property
        private Guid? _RefFacilityMortgageTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityMortgageViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        public System.Decimal? FacilityMortgageInterestAmount { get => _FacilityMortgageInterestAmount; set => SetProperty(ref _FacilityMortgageInterestAmount, value); }

        public System.Decimal? FacilityTotalAssessedValue { get => _FacilityTotalAssessedValue; set => SetProperty(ref _FacilityTotalAssessedValue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageInterestTypeId"/> model
        /// </summary>
        public Guid? RefFacilityMortgageInterestTypeId { get => _RefFacilityMortgageInterestTypeId; set => SetProperty(ref _RefFacilityMortgageInterestTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMortgageTypeId"/> model
        /// </summary>
        public Guid? RefFacilityMortgageTypeId { get => _RefFacilityMortgageTypeId; set => SetProperty(ref _RefFacilityMortgageTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityMortgage model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            FacilityMortgageInterestAmount = model.FacilityMortgageInterestAmount;
            FacilityTotalAssessedValue = model.FacilityTotalAssessedValue;
            RefFacilityMortgageInterestTypeId = model.RefFacilityMortgageInterestTypeId;
            RefFacilityMortgageTypeId = model.RefFacilityMortgageTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
