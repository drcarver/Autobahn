//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELOrganization.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELOrganization Interface
     /// </summary>
    public partial interface IELOrganization : IAutobahnBase
    {
        /// <summary>
        /// An indication of the for-profit status of a facility.
        /// </summary>
        Guid? RefProfitStatusId { get; set; }

    }
}
