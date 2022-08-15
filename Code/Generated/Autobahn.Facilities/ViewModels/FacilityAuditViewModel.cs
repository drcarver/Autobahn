//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityAuditViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityAuditViewModel
     /// </summary>
    public partial class FacilityAuditViewModel : ViewModelBase, Interfaces.IFacilityAudit
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityAudit";

        // member variable for the RefFacilityAuditTypeId property
        private Guid? _RefFacilityAuditTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityAuditViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityAuditType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20845">Facility Audit Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Facility Audit Type")]
        public Guid? RefFacilityAuditTypeId { get => _RefFacilityAuditTypeId; set => SetProperty(ref _RefFacilityAuditTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityAudit model)
        {
            IsBusy = true;
            Id = model.Id;
            RefFacilityAuditTypeId = model.RefFacilityAuditTypeId; // Facility Audit Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
