//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildOutcomeSummary.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildOutcomeSummary Interface
     /// </summary>
    public partial interface IELChildOutcomeSummary : IAutobahnBase
    {
        /// <summary>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// </summary>
        System.Boolean? COSProgressAIndicator { get; set; }

    }
}
