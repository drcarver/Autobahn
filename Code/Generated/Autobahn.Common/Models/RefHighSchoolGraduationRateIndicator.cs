//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefHighSchoolGraduationRateIndicator.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefHighSchoolGraduationRateIndicator
     /// </summary>
    public partial class RefHighSchoolGraduationRateIndicator : IRefHighSchoolGraduationRateIndicator
    {
        /// <summary>
        /// Defines the RefHighSchoolGraduationRateIndicator.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolGraduationRateIndicator.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolGraduationRateIndicator.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolGraduationRateIndicator.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolGraduationRateIndicator.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolGraduationRateIndicator.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
