//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefProfessionalEducationJobClassification.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefProfessionalEducationJobClassification
     /// </summary>
    public partial interface IRefProfessionalEducationJobClassification
    {
        /// <summary>
        /// Defines the RefProfessionalEducationJobClassification.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefProfessionalEducationJobClassification.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefProfessionalEducationJobClassification.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefProfessionalEducationJobClassification.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefProfessionalEducationJobClassification.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefProfessionalEducationJobClassification.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
