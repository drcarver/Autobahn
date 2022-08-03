//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPrimaryLearningDeviceAccess.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefPrimaryLearningDeviceAccess
     /// </summary>
    public partial class RefPrimaryLearningDeviceAccess : IRefPrimaryLearningDeviceAccess
    {
        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAccess.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAccess.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAccess.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAccess.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAccess.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAccess.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
