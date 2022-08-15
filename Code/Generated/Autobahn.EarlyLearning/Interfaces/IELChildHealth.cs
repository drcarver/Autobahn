//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildHealth.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildHealth Interface
     /// </summary>
    public partial interface IELChildHealth : IAutobahnBase
    {
        /// <summary>
        /// The individual well child visit scheduled according to the AAP recommended periodicity schedule.
        /// </summary>
        Guid? RefScheduledWellChildScreeningId { get; set; }

    }
}
