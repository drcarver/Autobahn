//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityMortgageFeeViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityMortgageFeeViewModel
     /// </summary>
    public partial class FacilityMortgageFeeViewModel : ViewModelBase, Interfaces.IFacilityMortgageFeeViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityMortgageFee";

        // member variable for the FacilityMortgageId property
        private Guid _FacilityMortgageId;

        // member variable for the RefFacilityFinancingFeeTypeId property
        private Guid _RefFacilityFinancingFeeTypeId;

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
        /// The title of the FacilityMortgageFeeViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityMortgageId"/> model
        /// </summary>
        public Guid FacilityMortgageId { get => _FacilityMortgageId; set => SetProperty(ref _FacilityMortgageId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefFacilityFinancingFeeTypeId"/> model
        /// </summary>
        public Guid RefFacilityFinancingFeeTypeId { get => _RefFacilityFinancingFeeTypeId; set => SetProperty(ref _RefFacilityFinancingFeeTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityMortgageFee model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityMortgageId = model.FacilityMortgageId;
            RefFacilityFinancingFeeTypeId = model.RefFacilityFinancingFeeTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
