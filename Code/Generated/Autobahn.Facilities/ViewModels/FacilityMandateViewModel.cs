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

        // member variable for the RefFacilityApplicableFederalMandateTypeId property
        private Guid? _RefFacilityApplicableFederalMandateTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityMandateViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityApplicableFederalMandateType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20777">Facility Applicable Federal Mandate Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Facility Applicable Federal Mandate Type")]
        public Guid? RefFacilityApplicableFederalMandateTypeId { get => _RefFacilityApplicableFederalMandateTypeId; set => SetProperty(ref _RefFacilityApplicableFederalMandateTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityMandate model)
        {
            IsBusy = true;
            Id = model.Id;
            RefFacilityApplicableFederalMandateTypeId = model.RefFacilityApplicableFederalMandateTypeId; // Facility Applicable Federal Mandate Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
