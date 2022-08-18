//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationTitleIModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationTitleI Model
     /// </summary>
    public partial class ProgramParticipationTitleIModel : AutobahnBase, Interfaces.IProgramParticipationTitleI
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIndicator"/> model
        /// </summary>
        public Guid? RefTitleIIndicatorId { get; set; }

    }
}
