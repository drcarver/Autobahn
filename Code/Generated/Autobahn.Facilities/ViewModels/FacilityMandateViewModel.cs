//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMandateViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the FacilityStateOrLocalMandateName property
        private System.String _FacilityStateOrLocalMandateName;

        // member variable for the RefFacilitiesMandateAuthorityTypeId property
        private Guid? _RefFacilitiesMandateAuthorityTypeId;

        // member variable for the RefFacilityApplicableFederalMandateTypeId property
        private Guid? _RefFacilityApplicableFederalMandateTypeId;

        // member variable for the RefFacilityFederalMandateInterestTypeId property
        private Guid? _RefFacilityFederalMandateInterestTypeId;

        // member variable for the RefFacilityStateOrLocalMandateInterestTypeId property
        private Guid? _RefFacilityStateOrLocalMandateInterestTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityMandateViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </summary>
        public System.String FacilityStateOrLocalMandateName { get => _FacilityStateOrLocalMandateName; set => SetProperty(ref _FacilityStateOrLocalMandateName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitiesMandateAuthorityType"/> model
        /// </summary>
        public Guid? RefFacilitiesMandateAuthorityTypeId { get => _RefFacilitiesMandateAuthorityTypeId; set => SetProperty(ref _RefFacilitiesMandateAuthorityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityApplicableFederalMandateType"/> model
        /// </summary>
        public Guid? RefFacilityApplicableFederalMandateTypeId { get => _RefFacilityApplicableFederalMandateTypeId; set => SetProperty(ref _RefFacilityApplicableFederalMandateTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityFederalMandateInterestType"/> model
        /// </summary>
        public Guid? RefFacilityFederalMandateInterestTypeId { get => _RefFacilityFederalMandateInterestTypeId; set => SetProperty(ref _RefFacilityFederalMandateInterestTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityStateOrLocalMandateInterestType"/> model
        /// </summary>
        public Guid? RefFacilityStateOrLocalMandateInterestTypeId { get => _RefFacilityStateOrLocalMandateInterestTypeId; set => SetProperty(ref _RefFacilityStateOrLocalMandateInterestTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityMandate model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            FacilityStateOrLocalMandateName = model.FacilityStateOrLocalMandateName;
            RefFacilitiesMandateAuthorityTypeId = model.RefFacilitiesMandateAuthorityTypeId;
            RefFacilityApplicableFederalMandateTypeId = model.RefFacilityApplicableFederalMandateTypeId;
            RefFacilityFederalMandateInterestTypeId = model.RefFacilityFederalMandateInterestTypeId;
            RefFacilityStateOrLocalMandateInterestTypeId = model.RefFacilityStateOrLocalMandateInterestTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
