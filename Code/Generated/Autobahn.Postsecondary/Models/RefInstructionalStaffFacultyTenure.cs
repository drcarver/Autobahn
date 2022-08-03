//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefInstructionalStaffFacultyTenure.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefInstructionalStaffFacultyTenure
     /// </summary>
    public partial class RefInstructionalStaffFacultyTenure : IRefInstructionalStaffFacultyTenure
    {
        /// <summary>
        /// Defines the RefInstructionalStaffFacultyTenure.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffFacultyTenure.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffFacultyTenure.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffFacultyTenure.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffFacultyTenure.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffFacultyTenure.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
