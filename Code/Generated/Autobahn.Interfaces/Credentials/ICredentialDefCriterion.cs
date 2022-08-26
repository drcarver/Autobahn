//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefCriterion.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Credentials
{
     /// <summary>
     /// The ICredentialDefCriterion Interface
     /// </summary>
    public partial interface ICredentialDefCriterion : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        Guid? CompetencySetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefCriteria"/> model
        /// </summary>
        Guid CredentialDefCriteriaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        System.String Criteria { get; set; }

        System.String CriteriaUrl { get; set; }

        System.String EstimatedDuration { get; set; }

        System.String MaximumDuration { get; set; }

        Int32? MinimumAge { get; set; }

        System.String MinimumDuration { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAssessMethodType"/> model
        /// </summary>
        Guid? RefCredentialDefAssessMethodTypeId { get; set; }

    }
}
