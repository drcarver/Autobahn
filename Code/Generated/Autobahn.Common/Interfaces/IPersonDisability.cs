//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonDisability.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDisability Interface
     /// </summary>
    public partial interface IPersonDisability : IAutobahnBase
    {
        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        Guid? PrimaryDisabilityTypeId { get; set; }

    }
}
