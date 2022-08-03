//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefEmployedPriorToEnrollment.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefEmployedPriorToEnrollment
     /// </summary>
    public partial interface IRefEmployedPriorToEnrollment
    {
        /// <summary>
        /// Defines the RefEmployedPriorToEnrollment.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefEmployedPriorToEnrollment.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefEmployedPriorToEnrollment.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefEmployedPriorToEnrollment.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefEmployedPriorToEnrollment.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefEmployedPriorToEnrollment.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
