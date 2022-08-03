//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityManagement.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityManagement
     /// </summary>
    public partial interface IFacilityManagement
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCharterSchoolRealtyAccessType"/> model
        /// </summary>
        Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCleaningStandardType"/> model
        /// </summary>
        Guid? RefBuildingCleaningStandardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityCapitalProgramMgmtType"/> model
        /// </summary>
        Guid? RefFacilityCapitalProgramMgmtTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityComplianceAgencyType"/> model
        /// </summary>
        Guid? RefFacilityComplianceAgencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityOperationsMgmtType"/> model
        /// </summary>
        Guid? RefFacilityOperationsMgmtTypeId { get; set; }

        /// <summary>
        /// Defines the FacilityManagement.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityManagement.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
