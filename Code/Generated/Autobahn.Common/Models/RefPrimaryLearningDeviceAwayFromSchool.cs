//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPrimaryLearningDeviceAwayFromSchool.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefPrimaryLearningDeviceAwayFromSchool
     /// </summary>
    public partial class RefPrimaryLearningDeviceAwayFromSchool : IRefPrimaryLearningDeviceAwayFromSchool
    {
        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAwayFromSchool.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAwayFromSchool.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAwayFromSchool.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAwayFromSchool.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAwayFromSchool.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAwayFromSchool.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
