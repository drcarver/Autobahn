//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationTitleI.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationTitleI
     /// </summary>
    public partial interface IProgramParticipationTitleI : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIndicator"/> model
        /// </summary>
        Guid? RefTitleIIndicatorId { get; set; }

    }
}
