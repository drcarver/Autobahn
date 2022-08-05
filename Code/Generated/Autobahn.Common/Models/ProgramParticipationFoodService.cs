//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationFoodService.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationFoodService
     /// </summary>
    public partial class ProgramParticipationFoodService : AutobahnBase, Interfaces.IProgramParticipationFoodService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefSchoolFoodServiceProgram"/> model
        /// </summary>
        public Guid RefSchoolFoodServiceProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
