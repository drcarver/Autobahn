//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilitySchoolDesign.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilitySchoolDesign
     /// </summary>
    public partial class FacilitySchoolDesign : IFacilitySchoolDesign
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityDesign"/> model
        /// </summary>
        public Guid FacilityDesignId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefBuildingSchoolDesignType"/> model
        /// </summary>
        public Guid RefBuildingSchoolDesignTypeId { get; set; }

        /// <summary>
        /// Defines the FacilitySchoolDesign.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilitySchoolDesign.RecordEndDateTime nullable property
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
