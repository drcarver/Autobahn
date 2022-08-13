//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationFoodService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IProgramParticipationFoodService Interface
     /// </summary>
    public partial interface IProgramParticipationFoodService : IAutobahnBase
    {
        /// <summary>
        /// An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        Guid RefSchoolFoodServiceProgramId { get; set; }

    }
}
