//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCreditHoursAppliedOtherProgram.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefCreditHoursAppliedOtherProgram
     /// </summary>
    public partial class RefCreditHoursAppliedOtherProgram : IRefCreditHoursAppliedOtherProgram
    {
        /// <summary>
        /// Defines the RefCreditHoursAppliedOtherProgram.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCreditHoursAppliedOtherProgram.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCreditHoursAppliedOtherProgram.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCreditHoursAppliedOtherProgram.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCreditHoursAppliedOtherProgram.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCreditHoursAppliedOtherProgram.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
