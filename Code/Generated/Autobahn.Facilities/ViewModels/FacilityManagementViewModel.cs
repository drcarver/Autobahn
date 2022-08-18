//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityManagement View Model
     /// </summary>
    public partial class FacilityManagementViewModel : ViewModelBase, Interfaces.IFacilityManagement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityManagement";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // RefBuildingCharterSchoolRealtyAccessTypeId -- (backing property for Building Charter School Realty Access Type)
        private Guid? _RefBuildingCharterSchoolRealtyAccessTypeId;

        // RefBuildingCleaningStandardTypeId -- (backing property for Building Cleaning Standard Type)
        private Guid? _RefBuildingCleaningStandardTypeId;

        // RefFacilityCapitalProgramMgmtTypeId -- (backing property for Facility Capital Program Management Type)
        private Guid? _RefFacilityCapitalProgramMgmtTypeId;

        // RefFacilityComplianceAgencyTypeId -- (backing property for Facility Compliance Agency Type)
        private Guid? _RefFacilityComplianceAgencyTypeId;

        // RefFacilityOperationsMgmtTypeId -- (backing property for Facility Operations Management Type)
        private Guid? _RefFacilityOperationsMgmtTypeId;

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
        /// Building Charter School Realty Access Type
        /// <para>
        /// The type of real estate vehicle through which a public charter school has access and control of its building space.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20846">Building Charter School Realty Access Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get => _RefBuildingCharterSchoolRealtyAccessTypeId; set => SetProperty(ref _RefBuildingCharterSchoolRealtyAccessTypeId, value); }

        /// <summary>
        /// Building Cleaning Standard Type
        /// <para>
        /// The standard for cleanliness, and benchmarks for how much space can be assigned to one properly supplied custodian to meet these standards.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20847">Building Cleaning Standard Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingCleaningStandardTypeId { get => _RefBuildingCleaningStandardTypeId; set => SetProperty(ref _RefBuildingCleaningStandardTypeId, value); }

        /// <summary>
        /// Facility Capital Program Management Type
        /// <para>
        /// The type of management organization for planning, design, and construction of major capital projects.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20853">Facility Capital Program Management Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityCapitalProgramMgmtTypeId { get => _RefFacilityCapitalProgramMgmtTypeId; set => SetProperty(ref _RefFacilityCapitalProgramMgmtTypeId, value); }

        /// <summary>
        /// Facility Compliance Agency Type
        /// <para>
        /// The type of agency that has ultimate responsibility for the compliance determination.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20848">Facility Compliance Agency Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityComplianceAgencyTypeId { get => _RefFacilityComplianceAgencyTypeId; set => SetProperty(ref _RefFacilityComplianceAgencyTypeId, value); }

        /// <summary>
        /// Facility Operations Management Type
        /// <para>
        /// The type of management arrangements whereby a district oversees and manages its facilities operations.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20854">Facility Operations Management Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityOperationsMgmtTypeId { get => _RefFacilityOperationsMgmtTypeId; set => SetProperty(ref _RefFacilityOperationsMgmtTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityManagement model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId; // 
            RefBuildingCharterSchoolRealtyAccessTypeId = model.RefBuildingCharterSchoolRealtyAccessTypeId; // Building Charter School Realty Access Type
            RefBuildingCleaningStandardTypeId = model.RefBuildingCleaningStandardTypeId; // Building Cleaning Standard Type
            RefFacilityCapitalProgramMgmtTypeId = model.RefFacilityCapitalProgramMgmtTypeId; // Facility Capital Program Management Type
            RefFacilityComplianceAgencyTypeId = model.RefFacilityComplianceAgencyTypeId; // Facility Compliance Agency Type
            RefFacilityOperationsMgmtTypeId = model.RefFacilityOperationsMgmtTypeId; // Facility Operations Management Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
