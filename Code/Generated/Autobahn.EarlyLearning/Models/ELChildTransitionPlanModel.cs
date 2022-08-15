//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildTransitionPlanModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildTransitionPlan Model
     /// </summary>
    public partial class ELChildTransitionPlanModel : AutobahnBase, Interfaces.IELChildTransitionPlan
    {
        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// </summary>
        public System.Boolean? PartB619PotentialEligibilityInd { get; set; }

    }
}
