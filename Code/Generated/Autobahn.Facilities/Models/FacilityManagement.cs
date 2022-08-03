//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityManagement.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityManagement
     /// </summary>
    public partial class FacilityManagement : IFacilityManagement
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
        /// Defines the FacilityManagement.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityManagement.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
