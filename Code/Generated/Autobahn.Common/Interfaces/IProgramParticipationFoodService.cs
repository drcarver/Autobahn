//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationFoodService.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationFoodService
     /// </summary>
    public partial interface IProgramParticipationFoodService : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefSchoolFoodServiceProgram"/> model
        /// </summary>
        Guid RefSchoolFoodServiceProgramId { get; set; }

    }
}
