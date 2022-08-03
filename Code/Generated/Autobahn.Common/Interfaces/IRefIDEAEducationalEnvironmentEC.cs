//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefIDEAEducationalEnvironmentEC.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefIDEAEducationalEnvironmentEC
     /// </summary>
    public partial interface IRefIDEAEducationalEnvironmentEC
    {
        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentEC.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentEC.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentEC.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentEC.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentEC.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIDEAEducationalEnvironmentEC.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
