//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonHealth.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonHealth Interface
     /// </summary>
    public partial interface IPersonHealth : IAutobahnBase
    {
        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        Guid? RefVisionScreeningStatusId { get; set; }

    }
}
