//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationTitleI.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationTitleI Interface
     /// </summary>
    public partial interface IProgramParticipationTitleI : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTitleIIndicator"/> model
        /// </summary>
        Guid? RefTitleIIndicatorId { get; set; }

    }
}
