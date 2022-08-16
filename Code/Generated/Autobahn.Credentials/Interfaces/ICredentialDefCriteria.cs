//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefCriteria.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefCriteria Interface
     /// </summary>
    public partial interface ICredentialDefCriteria : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Criteria { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CriteriaUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EstimatedDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MaximumDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MinimumAge { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MinimumDuration { get; set; }

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
         RefCredentialDefAssessMethodTypeId { get; set; }

    }
}
