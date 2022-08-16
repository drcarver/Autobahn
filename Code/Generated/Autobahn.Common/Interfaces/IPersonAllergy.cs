//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonAllergy.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonAllergy Interface
     /// </summary>
    public partial interface IPersonAllergy : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? ReactionDescription { get; set; }

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
         RefAllergySeverityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAllergyTypeId { get; set; }

    }
}
