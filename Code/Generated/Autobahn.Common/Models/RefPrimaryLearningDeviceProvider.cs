//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPrimaryLearningDeviceProvider.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefPrimaryLearningDeviceProvider
     /// </summary>
    public partial class RefPrimaryLearningDeviceProvider : IRefPrimaryLearningDeviceProvider
    {
        /// <summary>
        /// Defines the RefPrimaryLearningDeviceProvider.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceProvider.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceProvider.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceProvider.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceProvider.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceProvider.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
