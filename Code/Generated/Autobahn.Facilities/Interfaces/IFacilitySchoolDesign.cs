//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilitySchoolDesign.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilitySchoolDesign
     /// </summary>
    public partial interface IFacilitySchoolDesign
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityDesign"/> model
        /// </summary>
        Guid FacilityDesignId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefBuildingSchoolDesignType"/> model
        /// </summary>
        Guid RefBuildingSchoolDesignTypeId { get; set; }

        /// <summary>
        /// Defines the FacilitySchoolDesign.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilitySchoolDesign.RecordEndDateTime nullable property
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
