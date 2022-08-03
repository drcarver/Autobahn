//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefPrimaryLearningDeviceProvider.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefPrimaryLearningDeviceProvider
     /// </summary>
    public partial interface IRefPrimaryLearningDeviceProvider
    {
        /// <summary>
        /// Defines the RefPrimaryLearningDeviceProvider.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceProvider.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceProvider.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceProvider.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceProvider.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceProvider.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
