//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefParticipationStatusAyp.cs
//**********************************************************

using Autobahn.Reference.Interfaces;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The RefParticipationStatusAyp
     /// </summary>
    public partial class RefParticipationStatusAyp : IRefParticipationStatusAyp
    {
        /// <summary>
        /// Defines the RefParticipationStatusAyp.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefParticipationStatusAyp.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefParticipationStatusAyp.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefParticipationStatusAyp.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefParticipationStatusAyp.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefParticipationStatusAyp.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
