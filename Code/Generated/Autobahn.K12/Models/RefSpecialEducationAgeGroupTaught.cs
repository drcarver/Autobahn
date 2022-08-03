//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefSpecialEducationAgeGroupTaught.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefSpecialEducationAgeGroupTaught
     /// </summary>
    public partial class RefSpecialEducationAgeGroupTaught : IRefSpecialEducationAgeGroupTaught
    {
        /// <summary>
        /// Defines the RefSpecialEducationAgeGroupTaught.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationAgeGroupTaught.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationAgeGroupTaught.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationAgeGroupTaught.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationAgeGroupTaught.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationAgeGroupTaught.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
