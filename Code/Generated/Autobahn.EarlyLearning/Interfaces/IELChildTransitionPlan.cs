//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildTransitionPlan.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildTransitionPlan Interface
     /// </summary>
    public partial interface IELChildTransitionPlan : IAutobahnBase
    {
        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        System.Boolean? PartB619PotentialEligibilityInd { get; set; }

    }
}
