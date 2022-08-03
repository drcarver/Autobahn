//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefGraduateAssistantIpedsCategory.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefGraduateAssistantIpedsCategory
     /// </summary>
    public partial class RefGraduateAssistantIpedsCategory : IRefGraduateAssistantIpedsCategory
    {
        /// <summary>
        /// Defines the RefGraduateAssistantIpedsCategory.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefGraduateAssistantIpedsCategory.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefGraduateAssistantIpedsCategory.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefGraduateAssistantIpedsCategory.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefGraduateAssistantIpedsCategory.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefGraduateAssistantIpedsCategory.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
