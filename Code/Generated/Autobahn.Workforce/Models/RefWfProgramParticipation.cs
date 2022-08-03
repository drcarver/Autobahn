//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   RefWfProgramParticipation.cs
//**********************************************************

using Autobahn.Workforce.Interfaces;

namespace Autobahn.Workforce.Models
{
     /// <summary>
     /// The RefWfProgramParticipation
     /// </summary>
    public partial class RefWfProgramParticipation : IRefWfProgramParticipation
    {
        /// <summary>
        /// Defines the RefWfProgramParticipation.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefWfProgramParticipation.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefWfProgramParticipation.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefWfProgramParticipation.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefWfProgramParticipation.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefWfProgramParticipation.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
