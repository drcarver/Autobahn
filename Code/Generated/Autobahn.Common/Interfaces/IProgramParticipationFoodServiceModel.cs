//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationFoodServiceModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationFoodServiceModel Interface
     /// </summary>
    public partial interface IProgramParticipationFoodServiceModel : IAutobahnBase
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
