//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefWorkbasedLearningOpportunityType.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefWorkbasedLearningOpportunityType
     /// </summary>
    public partial interface IRefWorkbasedLearningOpportunityType
    {
        /// <summary>
        /// Defines the RefWorkbasedLearningOpportunityType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefWorkbasedLearningOpportunityType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefWorkbasedLearningOpportunityType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefWorkbasedLearningOpportunityType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefWorkbasedLearningOpportunityType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefWorkbasedLearningOpportunityType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
