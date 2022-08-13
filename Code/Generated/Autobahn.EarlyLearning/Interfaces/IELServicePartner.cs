//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELServicePartner.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELServicePartner Interface
     /// </summary>
    public partial interface IELServicePartner : IAutobahnBase
    {
        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </summary>
        System.DateTime? MemorandumOfUnderstandingEndDate { get; set; }

        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </summary>
        System.DateTime? MemorandumOfUnderstandingStartDate { get; set; }

        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </summary>
        System.String ServicePartnerDescription { get; set; }

        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </summary>
        System.String ServicePartnerName { get; set; }

    }
}
