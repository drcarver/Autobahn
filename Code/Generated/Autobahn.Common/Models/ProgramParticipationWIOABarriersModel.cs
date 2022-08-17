//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationWIOABarriersModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ProgramParticipationWIOABarriers Model
     /// </summary>
    public partial class ProgramParticipationWIOABarriersModel : AutobahnBase, Interfaces.IProgramParticipationWIOABarriers
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IProgramParticipationWIOA"/> model
        /// </summary>
        public Guid ProgramParticipationWIOAId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefWIOABarrierstoEmployment"/> model
        /// </summary>
        public Guid? RefWIOABarrierstoEmploymentId { get; set; }

    }
}
