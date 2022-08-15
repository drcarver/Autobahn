//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityComplianceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityComplianceViewModel
     /// </summary>
    public partial class FacilityComplianceViewModel : ViewModelBase, Interfaces.IFacilityCompliance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityCompliance";

        // member variable for the RefFacilityComplianceStatusId property
        private Guid? _RefFacilityComplianceStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityComplianceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityComplianceStatus"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20773">Facility Compliance Status</a>
        /// </para>
        /// </summary>
        [DisplayName("Facility Compliance Status")]
        public Guid? RefFacilityComplianceStatusId { get => _RefFacilityComplianceStatusId; set => SetProperty(ref _RefFacilityComplianceStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityCompliance model)
        {
            IsBusy = true;
            Id = model.Id;
            RefFacilityComplianceStatusId = model.RefFacilityComplianceStatusId; // Facility Compliance Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
