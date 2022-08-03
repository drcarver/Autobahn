//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefProfessionalEducationJobClassification.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefProfessionalEducationJobClassification
     /// </summary>
    public partial class RefProfessionalEducationJobClassification : IRefProfessionalEducationJobClassification
    {
        /// <summary>
        /// Defines the RefProfessionalEducationJobClassification.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefProfessionalEducationJobClassification.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefProfessionalEducationJobClassification.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefProfessionalEducationJobClassification.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefProfessionalEducationJobClassification.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefProfessionalEducationJobClassification.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
