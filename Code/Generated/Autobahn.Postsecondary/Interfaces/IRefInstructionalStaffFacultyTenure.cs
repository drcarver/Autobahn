//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefInstructionalStaffFacultyTenure.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IRefInstructionalStaffFacultyTenure
     /// </summary>
    public partial interface IRefInstructionalStaffFacultyTenure
    {
        /// <summary>
        /// Defines the RefInstructionalStaffFacultyTenure.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffFacultyTenure.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffFacultyTenure.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffFacultyTenure.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffFacultyTenure.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffFacultyTenure.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}