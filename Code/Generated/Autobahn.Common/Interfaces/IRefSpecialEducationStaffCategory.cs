//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefSpecialEducationStaffCategory.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefSpecialEducationStaffCategory
     /// </summary>
    public partial interface IRefSpecialEducationStaffCategory
    {
        /// <summary>
        /// Defines the RefSpecialEducationStaffCategory.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationStaffCategory.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationStaffCategory.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationStaffCategory.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationStaffCategory.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationStaffCategory.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
