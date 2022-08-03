//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIDEAEducationalEnvironmentSchoolAge.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefIDEAEducationalEnvironmentSchoolAge
     /// </summary>
    public partial class RefIDEAEducationalEnvironmentSchoolAge : IRefIDEAEducationalEnvironmentSchoolAge
    {
        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentSchoolAge.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentSchoolAge.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentSchoolAge.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentSchoolAge.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentSchoolAge.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentSchoolAge.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
