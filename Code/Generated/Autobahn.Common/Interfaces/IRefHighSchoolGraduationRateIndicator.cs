//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefHighSchoolGraduationRateIndicator.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefHighSchoolGraduationRateIndicator
     /// </summary>
    public partial interface IRefHighSchoolGraduationRateIndicator
    {
        /// <summary>
        /// Defines the RefHighSchoolGraduationRateIndicator.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolGraduationRateIndicator.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolGraduationRateIndicator.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolGraduationRateIndicator.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolGraduationRateIndicator.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefHighSchoolGraduationRateIndicator.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
