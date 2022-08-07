//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationFoodServiceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationFoodService Model
     /// </summary>
    public partial class ProgramParticipationFoodServiceModel : AutobahnBase, Interfaces.IProgramParticipationFoodServiceModel
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
