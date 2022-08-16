//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCriteriaModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefCriteria Model
     /// </summary>
    public partial class CredentialDefCriteriaModel : AutobahnBase, Interfaces.ICredentialDefCriteria
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Criteria { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CriteriaUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EstimatedDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MaximumDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MinimumAge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MinimumDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCredentialDefAssessMethodTypeId { get; set; }

    }
}
