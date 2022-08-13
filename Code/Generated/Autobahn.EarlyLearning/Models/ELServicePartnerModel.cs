//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELServicePartnerModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELServicePartner Model
     /// </summary>
    public partial class ELServicePartnerModel : AutobahnBase, Interfaces.IELServicePartner
    {
        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </summary>
        public System.DateTime? MemorandumOfUnderstandingEndDate { get; set; }

        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </summary>
        public System.DateTime? MemorandumOfUnderstandingStartDate { get; set; }

        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </summary>
        public System.String ServicePartnerDescription { get; set; }

        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </summary>
        public System.String ServicePartnerName { get; set; }

    }
}
