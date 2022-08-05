//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationWIOABarrier.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationWIOABarrier
     /// </summary>
    public partial class ProgramParticipationWIOABarrier : AutobahnBase, Interfaces.IProgramParticipationWIOABarrier
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProgramParticipationWIOABarriers"/> model
        /// </summary>
        public Guid ProgramParticipationWIOABarriersId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProgramParticipationWIOA"/> model
        /// </summary>
        public Guid ProgramParticipationWIOAId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWIOABarrierstoEmployment"/> model
        /// </summary>
        public Guid? RefWIOABarrierstoEmploymentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
