//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefCharterSchoolAuthorizerType.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefCharterSchoolAuthorizerType
     /// </summary>
    public partial class RefCharterSchoolAuthorizerType : IRefCharterSchoolAuthorizerType
    {
        /// <summary>
        /// Defines the RefCharterSchoolAuthorizerType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolAuthorizerType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolAuthorizerType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolAuthorizerType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolAuthorizerType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolAuthorizerType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
