//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityJointDevelopmentType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefFacilityJointDevelopmentType
     /// </summary>
    public partial class RefFacilityJointDevelopmentType : IRefFacilityJointDevelopmentType
    {
        /// <summary>
        /// Defines the RefFacilityJointDevelopmentType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilityJointDevelopmentType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilityJointDevelopmentType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilityJointDevelopmentType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilityJointDevelopmentType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilityJointDevelopmentType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
