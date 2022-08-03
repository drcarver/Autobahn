//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefEmploymentStatusWhileEnrolled.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefEmploymentStatusWhileEnrolled
     /// </summary>
    public partial class RefEmploymentStatusWhileEnrolled : IRefEmploymentStatusWhileEnrolled
    {
        /// <summary>
        /// Defines the RefEmploymentStatusWhileEnrolled.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefEmploymentStatusWhileEnrolled.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefEmploymentStatusWhileEnrolled.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefEmploymentStatusWhileEnrolled.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefEmploymentStatusWhileEnrolled.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefEmploymentStatusWhileEnrolled.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
