//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationWIOABarrierModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationWIOABarrier Model
     /// </summary>
    public partial class ProgramParticipationWIOABarrierModel : AutobahnBase, Interfaces.IProgramParticipationWIOABarrierModel
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
