//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationFoodService.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationFoodService
     /// </summary>
    public partial class ProgramParticipationFoodService : IProgramParticipationFoodService
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
        /// Defines the ProgramParticipationFoodService.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationFoodService.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
