//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefTitleIIIProfessionalDevelopmentType.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefTitleIIIProfessionalDevelopmentType
     /// </summary>
    public partial interface IRefTitleIIIProfessionalDevelopmentType
    {
        /// <summary>
        /// Defines the RefTitleIIIProfessionalDevelopmentType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefTitleIIIProfessionalDevelopmentType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefTitleIIIProfessionalDevelopmentType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefTitleIIIProfessionalDevelopmentType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefTitleIIIProfessionalDevelopmentType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefTitleIIIProfessionalDevelopmentType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
