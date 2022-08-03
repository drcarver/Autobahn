//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIDEAEducationalEnvironmentEC.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefIDEAEducationalEnvironmentEC
     /// </summary>
    public partial class RefIDEAEducationalEnvironmentEC : IRefIDEAEducationalEnvironmentEC
    {
        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentEC.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentEC.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentEC.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentEC.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentEC.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentEC.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
