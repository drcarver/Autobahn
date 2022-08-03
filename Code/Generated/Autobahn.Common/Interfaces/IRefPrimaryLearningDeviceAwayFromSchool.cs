//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefPrimaryLearningDeviceAwayFromSchool.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefPrimaryLearningDeviceAwayFromSchool
     /// </summary>
    public partial interface IRefPrimaryLearningDeviceAwayFromSchool
    {
        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAwayFromSchool.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAwayFromSchool.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAwayFromSchool.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAwayFromSchool.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAwayFromSchool.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPrimaryLearningDeviceAwayFromSchool.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
