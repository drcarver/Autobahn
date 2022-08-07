//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityManagementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityManagement Model
     /// </summary>
    public partial class FacilityManagementModel : AutobahnBase, Interfaces.IFacilityManagementModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCharterSchoolRealtyAccessType"/> model
        /// </summary>
        public Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCleaningStandardType"/> model
        /// </summary>
        public Guid? RefBuildingCleaningStandardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityCapitalProgramMgmtType"/> model
        /// </summary>
        public Guid? RefFacilityCapitalProgramMgmtTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityComplianceAgencyType"/> model
        /// </summary>
        public Guid? RefFacilityComplianceAgencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityOperationsMgmtType"/> model
        /// </summary>
        public Guid? RefFacilityOperationsMgmtTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
