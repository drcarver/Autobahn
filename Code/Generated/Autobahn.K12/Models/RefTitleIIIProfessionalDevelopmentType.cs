//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefTitleIIIProfessionalDevelopmentType.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefTitleIIIProfessionalDevelopmentType
     /// </summary>
    public partial class RefTitleIIIProfessionalDevelopmentType : IRefTitleIIIProfessionalDevelopmentType
    {
        /// <summary>
        /// Defines the RefTitleIIIProfessionalDevelopmentType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefTitleIIIProfessionalDevelopmentType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefTitleIIIProfessionalDevelopmentType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefTitleIIIProfessionalDevelopmentType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefTitleIIIProfessionalDevelopmentType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefTitleIIIProfessionalDevelopmentType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
