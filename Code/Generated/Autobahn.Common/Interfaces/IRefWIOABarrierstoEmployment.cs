//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefWIOABarrierstoEmployment.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefWIOABarrierstoEmployment
     /// </summary>
    public partial interface IRefWIOABarrierstoEmployment
    {
        /// <summary>
        /// Defines the RefWIOABarrierstoEmployment.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefWIOABarrierstoEmployment.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefWIOABarrierstoEmployment.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefWIOABarrierstoEmployment.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefWIOABarrierstoEmployment.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefWIOABarrierstoEmployment.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
