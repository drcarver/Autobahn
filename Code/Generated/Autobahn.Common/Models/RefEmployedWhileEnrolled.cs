//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmployedWhileEnrolled.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefEmployedWhileEnrolled
     /// </summary>
    public partial class RefEmployedWhileEnrolled : IRefEmployedWhileEnrolled
    {
        /// <summary>
        /// Defines the RefEmployedWhileEnrolled.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefEmployedWhileEnrolled.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefEmployedWhileEnrolled.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefEmployedWhileEnrolled.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefEmployedWhileEnrolled.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefEmployedWhileEnrolled.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
