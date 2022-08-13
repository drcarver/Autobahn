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
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public Guid? CompetencySetId { get; set; }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String Criteria { get; set; }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String CriteriaUrl { get; set; }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String EstimatedDuration { get; set; }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String MaximumDuration { get; set; }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.Int32? MinimumAge { get; set; }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String MinimumDuration { get; set; }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public Guid? RefCredentialDefAssessMethodTypeId { get; set; }

    }
}
