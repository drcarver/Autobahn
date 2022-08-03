//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefTitleIProgramStaffCategory.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefTitleIProgramStaffCategory
     /// </summary>
    public partial interface IRefTitleIProgramStaffCategory
    {
        /// <summary>
        /// Defines the RefTitleIProgramStaffCategory.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefTitleIProgramStaffCategory.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefTitleIProgramStaffCategory.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefTitleIProgramStaffCategory.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefTitleIProgramStaffCategory.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefTitleIProgramStaffCategory.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
