//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationFoodServiceModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ProgramParticipationFoodService Model
     /// </summary>
    public partial class ProgramParticipationFoodServiceModel : AutobahnBase, Interfaces.IProgramParticipationFoodService
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefSchoolFoodServiceProgram"/> model
        /// </summary>
        public Guid RefSchoolFoodServiceProgramId { get; set; }

    }
}
