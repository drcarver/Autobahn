//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELServicePartner.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELServicePartner
     /// </summary>
    public partial class ELServicePartner : AutobahnBase, Interfaces.IELServicePartner
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the ELServicePartner.ServicePartnerName non nullable property
        /// </summary>
        public System.String ServicePartnerName { get; set; }

        /// <summary>
        /// Defines the ELServicePartner.ServicePartnerDescription non nullable property
        /// </summary>
        public System.String ServicePartnerDescription { get; set; }

        /// <summary>
        /// Defines the ELServicePartner.MemorandumOfUnderstandingEndDate nullable property
        /// </summary>
        public System.DateTime? MemorandumOfUnderstandingEndDate { get; set; }

        /// <summary>
        /// Defines the ELServicePartner.MemorandumOfUnderstandingStartDate nullable property
        /// </summary>
        public System.DateTime? MemorandumOfUnderstandingStartDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
