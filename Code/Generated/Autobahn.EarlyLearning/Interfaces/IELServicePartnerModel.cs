//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELServicePartnerModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELServicePartnerModel Interface
     /// </summary>
    public partial interface IELServicePartnerModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the ELServicePartner.ServicePartnerName non nullable property
        /// </summary>
        System.String ServicePartnerName { get; set; }

        /// <summary>
        /// Defines the ELServicePartner.ServicePartnerDescription non nullable property
        /// </summary>
        System.String ServicePartnerDescription { get; set; }

        /// <summary>
        /// Defines the ELServicePartner.MemorandumOfUnderstandingEndDate nullable property
        /// </summary>
        System.DateTime? MemorandumOfUnderstandingEndDate { get; set; }

        /// <summary>
        /// Defines the ELServicePartner.MemorandumOfUnderstandingStartDate nullable property
        /// </summary>
        System.DateTime? MemorandumOfUnderstandingStartDate { get; set; }

    }
}
