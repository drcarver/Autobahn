//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefDevelopmentalEducationType.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefDevelopmentalEducationType
     /// </summary>
    public partial class RefDevelopmentalEducationType : IRefDevelopmentalEducationType
    {
        /// <summary>
        /// Defines the RefDevelopmentalEducationType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefDevelopmentalEducationType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefDevelopmentalEducationType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefDevelopmentalEducationType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefDevelopmentalEducationType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefDevelopmentalEducationType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
