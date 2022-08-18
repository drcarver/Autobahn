//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationWIOABarriers.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationWIOABarriers Interface
     /// </summary>
    public partial interface IProgramParticipationWIOABarriers : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IProgramParticipationWIOA"/> model
        /// </summary>
        Guid ProgramParticipationWIOAId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWIOABarrierstoEmployment"/> model
        /// </summary>
        Guid? RefWIOABarrierstoEmploymentId { get; set; }

    }
}
