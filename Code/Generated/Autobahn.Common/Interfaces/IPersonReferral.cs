//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonReferral.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonReferral Interface
     /// </summary>
    public partial interface IPersonReferral : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         Reason { get; set; }

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
        Guid? ReferralDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ReferralTypeReceived { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ReferredTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefReferralOutcomeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Source { get; set; }

    }
}
