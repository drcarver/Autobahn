//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMandateViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityMandateViewModel
     /// </summary>
    public partial class FacilityMandateViewModel : ViewModelBase, Interfaces.IFacilityMandate
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityMandate";

        // member variable for the FacilityStateOrLocalMandateName property
        private  _FacilityStateOrLocalMandateName;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFacilitiesMandateAuthorityTypeId property
        private  _RefFacilitiesMandateAuthorityTypeId;

        // member variable for the RefFacilityApplicableFederalMandateTypeId property
        private Guid? _RefFacilityApplicableFederalMandateTypeId;

        // member variable for the RefFacilityFederalMandateInterestTypeId property
        private  _RefFacilityFederalMandateInterestTypeId;

        // member variable for the RefFacilityStateOrLocalMandateInterestTypeId property
        private  _RefFacilityStateOrLocalMandateInterestTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  FacilityStateOrLocalMandateName { get => _FacilityStateOrLocalMandateName; set => SetProperty(ref _FacilityStateOrLocalMandateName, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMandateAuthorityType"/> model
        /// </summary>
        public  RefFacilitiesMandateAuthorityTypeId { get => _RefFacilitiesMandateAuthorityTypeId; set => SetProperty(ref _RefFacilitiesMandateAuthorityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityApplicableFederalMandateType"/> model
        /// </summary>
        public Guid? RefFacilityApplicableFederalMandateTypeId { get => _RefFacilityApplicableFederalMandateTypeId; set => SetProperty(ref _RefFacilityApplicableFederalMandateTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityFederalMandateInterestType"/> model
        /// </summary>
        public  RefFacilityFederalMandateInterestTypeId { get => _RefFacilityFederalMandateInterestTypeId; set => SetProperty(ref _RefFacilityFederalMandateInterestTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityStateOrLocalMandateInterestType"/> model
        /// </summary>
        public  RefFacilityStateOrLocalMandateInterestTypeId { get => _RefFacilityStateOrLocalMandateInterestTypeId; set => SetProperty(ref _RefFacilityStateOrLocalMandateInterestTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityMandate model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityStateOrLocalMandateName = model.FacilityStateOrLocalMandateName; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFacilitiesMandateAuthorityTypeId = model.RefFacilitiesMandateAuthorityTypeId; // 
            RefFacilityApplicableFederalMandateTypeId = model.RefFacilityApplicableFederalMandateTypeId; // 
            RefFacilityFederalMandateInterestTypeId = model.RefFacilityFederalMandateInterestTypeId; // 
            RefFacilityStateOrLocalMandateInterestTypeId = model.RefFacilityStateOrLocalMandateInterestTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
