//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingJointUseRationaleType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingJointUseRationaleType
     /// </summary>
    public partial class RefBuildingJointUseRationaleType : IRefBuildingJointUseRationaleType
    {
        /// <summary>
        /// Defines the RefBuildingJointUseRationaleType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBuildingJointUseRationaleType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBuildingJointUseRationaleType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBuildingJointUseRationaleType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBuildingJointUseRationaleType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBuildingJointUseRationaleType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
