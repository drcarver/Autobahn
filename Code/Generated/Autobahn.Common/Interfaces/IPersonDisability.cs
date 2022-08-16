//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonDisability.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDisability Interface
     /// </summary>
    public partial interface IPersonDisability : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         DisabilityStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? PrimaryDisabilityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAccommodationsNeededTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefDisabilityConditionStatusCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefDisabilityConditionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefDisabilityDeterminationSourceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIDEADisabilityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SignificantCognitiveDisabilityIndicator { get; set; }

    }
}
