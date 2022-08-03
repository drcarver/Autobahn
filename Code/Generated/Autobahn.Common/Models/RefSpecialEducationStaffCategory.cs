//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSpecialEducationStaffCategory.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefSpecialEducationStaffCategory
     /// </summary>
    public partial class RefSpecialEducationStaffCategory : IRefSpecialEducationStaffCategory
    {
        /// <summary>
        /// Defines the RefSpecialEducationStaffCategory.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationStaffCategory.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationStaffCategory.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationStaffCategory.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationStaffCategory.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationStaffCategory.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
