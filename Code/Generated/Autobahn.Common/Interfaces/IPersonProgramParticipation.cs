//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonProgramParticipation.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonProgramParticipation Interface
     /// </summary>
    public partial interface IPersonProgramParticipation : IAutobahnBase
    {
        /// <summary>
        /// An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
        /// </summary>
        Guid? RefParticipationTypeId { get; set; }

    }
}
