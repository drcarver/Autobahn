//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefIDEAEducationalEnvironmentSchoolAge.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefIDEAEducationalEnvironmentSchoolAge
     /// </summary>
    public partial interface IRefIDEAEducationalEnvironmentSchoolAge
    {
        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentSchoolAge.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentSchoolAge.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentSchoolAge.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentSchoolAge.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentSchoolAge.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentSchoolAge.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
