//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefInstructionalStaffContractLength.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefInstructionalStaffContractLength
     /// </summary>
    public partial class RefInstructionalStaffContractLength : IRefInstructionalStaffContractLength
    {
        /// <summary>
        /// Defines the RefInstructionalStaffContractLength.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffContractLength.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffContractLength.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffContractLength.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffContractLength.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefInstructionalStaffContractLength.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
