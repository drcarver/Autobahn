//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefERSRuralUrbanContinuumCode.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefERSRuralUrbanContinuumCode
     /// </summary>
    public partial interface IRefERSRuralUrbanContinuumCode
    {
        /// <summary>
        /// Defines the RefERSRuralUrbanContinuumCode.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefERSRuralUrbanContinuumCode.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefERSRuralUrbanContinuumCode.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefERSRuralUrbanContinuumCode.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefERSRuralUrbanContinuumCode.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefERSRuralUrbanContinuumCode.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
