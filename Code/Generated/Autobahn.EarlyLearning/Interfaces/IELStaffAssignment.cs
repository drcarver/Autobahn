//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELStaffAssignment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELStaffAssignment Interface
     /// </summary>
    public partial interface IELStaffAssignment : IAutobahnBase
    {
        /// <summary>
        /// An indication of whether a person provides services at more than one site.
        /// </summary>
        System.Boolean ItinerantProvider { get; set; }

    }
}
