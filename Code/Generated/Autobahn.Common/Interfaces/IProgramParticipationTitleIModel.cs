//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationTitleIModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationTitleIModel Interface
     /// </summary>
    public partial interface IProgramParticipationTitleIModel : IAutobahnBase
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
