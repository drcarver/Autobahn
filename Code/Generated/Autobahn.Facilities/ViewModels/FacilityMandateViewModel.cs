//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMandateViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityMandate View Model
     /// </summary>
    public partial class FacilityMandateViewModel : ViewModelBase, Interfaces.IFacilityMandate
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityMandate";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // FacilityStateOrLocalMandateName -- (backing property for Facility State or Local Mandate Name)
        private System.String _FacilityStateOrLocalMandateName;

        // RefFacilitiesMandateAuthorityTypeId -- (backing property for Facilities Mandate Authority Type)
        private Guid? _RefFacilitiesMandateAuthorityTypeId;

        // RefFacilityApplicableFederalMandateTypeId -- (backing property for Facility Applicable Federal Mandate Type)
        private Guid? _RefFacilityApplicableFederalMandateTypeId;

        // RefFacilityFederalMandateInterestTypeId -- (backing property for Facility Federal Mandate Interest Type)
        private Guid? _RefFacilityFederalMandateInterestTypeId;

        // RefFacilityStateOrLocalMandateInterestTypeId -- (backing property for Facility State or Local Mandate Interest Type)
        private Guid? _RefFacilityStateOrLocalMandateInterestTypeId;

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
        /// Facility State or Local Mandate Name
        /// <para>
        /// The specific law, rule, regulation, or standard of a state or local government that pertains to public school facilities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20787">Facility State or Local Mandate Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilityStateOrLocalMandateName { get => _FacilityStateOrLocalMandateName; set => SetProperty(ref _FacilityStateOrLocalMandateName, value); }

        /// <summary>
        /// Facilities Mandate Authority Type
        /// <para>
        /// The authority that mandates through law, regulation, or standard that pertains to a specific mandate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20866">Facilities Mandate Authority Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilitiesMandateAuthorityTypeId { get => _RefFacilitiesMandateAuthorityTypeId; set => SetProperty(ref _RefFacilitiesMandateAuthorityTypeId, value); }

        /// <summary>
        /// Facility Applicable Federal Mandate Type
        /// <para>
        /// The particular federal law, regulation, or standard that pertains to a school facility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20777">Facility Applicable Federal Mandate Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityApplicableFederalMandateTypeId { get => _RefFacilityApplicableFederalMandateTypeId; set => SetProperty(ref _RefFacilityApplicableFederalMandateTypeId, value); }

        /// <summary>
        /// Facility Federal Mandate Interest Type
        /// <para>
        /// The area of interest controlled by a federal law, regulation, or standard that pertains to a school facility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20778">Facility Federal Mandate Interest Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityFederalMandateInterestTypeId { get => _RefFacilityFederalMandateInterestTypeId; set => SetProperty(ref _RefFacilityFederalMandateInterestTypeId, value); }

        /// <summary>
        /// Facility State or Local Mandate Interest Type
        /// <para>
        /// The area of interest controlled by a law, rule, regulation, or standard of state and local governments that pertains to public school facilities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20786">Facility State or Local Mandate Interest Type</a>
        /// </para>
        /// </summary>
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
            FacilityId = model.FacilityId; // 
            FacilityStateOrLocalMandateName = model.FacilityStateOrLocalMandateName; // Facility State or Local Mandate Name
            RefFacilitiesMandateAuthorityTypeId = model.RefFacilitiesMandateAuthorityTypeId; // Facilities Mandate Authority Type
            RefFacilityApplicableFederalMandateTypeId = model.RefFacilityApplicableFederalMandateTypeId; // Facility Applicable Federal Mandate Type
            RefFacilityFederalMandateInterestTypeId = model.RefFacilityFederalMandateInterestTypeId; // Facility Federal Mandate Interest Type
            RefFacilityStateOrLocalMandateInterestTypeId = model.RefFacilityStateOrLocalMandateInterestTypeId; // Facility State or Local Mandate Interest Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
