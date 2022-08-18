//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationFoodService.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationFoodService Interface
     /// </summary>
    public partial interface IProgramParticipationFoodService : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolFoodServiceProgram"/> model
        /// </summary>
        Guid RefSchoolFoodServiceProgramId { get; set; }

    }
}
