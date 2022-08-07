//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationWIOABarrierModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationWIOABarrierModel Interface
     /// </summary>
    public partial interface IProgramParticipationWIOABarrierModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProgramParticipationWIOABarriers"/> model
        /// </summary>
        Guid ProgramParticipationWIOABarriersId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProgramParticipationWIOA"/> model
        /// </summary>
        Guid ProgramParticipationWIOAId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWIOABarrierstoEmployment"/> model
        /// </summary>
        Guid? RefWIOABarrierstoEmploymentId { get; set; }

    }
}
