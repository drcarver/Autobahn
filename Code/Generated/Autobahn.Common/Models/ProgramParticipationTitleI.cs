//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationTitleI.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationTitleI
     /// </summary>
    public partial class ProgramParticipationTitleI : AutobahnBase, Interfaces.IProgramParticipationTitleI
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIndicator"/> model
        /// </summary>
        public Guid? RefTitleIIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
