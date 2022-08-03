//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefGraduateAssistantIpedsCategory.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IRefGraduateAssistantIpedsCategory
     /// </summary>
    public partial interface IRefGraduateAssistantIpedsCategory
    {
        /// <summary>
        /// Defines the RefGraduateAssistantIpedsCategory.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefGraduateAssistantIpedsCategory.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefGraduateAssistantIpedsCategory.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefGraduateAssistantIpedsCategory.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefGraduateAssistantIpedsCategory.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefGraduateAssistantIpedsCategory.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
