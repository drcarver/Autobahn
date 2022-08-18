//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityAuditViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityAudit View Model
     /// </summary>
    public partial class FacilityAuditViewModel : ViewModelBase, Interfaces.IFacilityAudit
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityAudit";

        // FacilityAuditDate -- (backing property for Facility Audit Date)
        private System.DateTime? _FacilityAuditDate;

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // RefFacilityAuditTypeId -- (backing property for Facility Audit Type)
        private Guid? _RefFacilityAuditTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Facility Audit Date
        /// <para>
        /// The month, day, and year of the systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20862">Facility Audit Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? FacilityAuditDate { get => _FacilityAuditDate; set => SetProperty(ref _FacilityAuditDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Facility Audit Type
        /// <para>
        /// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20845">Facility Audit Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityAuditTypeId { get => _RefFacilityAuditTypeId; set => SetProperty(ref _RefFacilityAuditTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityAudit model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityAuditDate = model.FacilityAuditDate; // Facility Audit Date
            FacilityId = model.FacilityId; // 
            RefFacilityAuditTypeId = model.RefFacilityAuditTypeId; // Facility Audit Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
