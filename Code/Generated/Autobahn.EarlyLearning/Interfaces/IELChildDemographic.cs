//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildDemographic.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildDemographic Interface
     /// </summary>
    public partial interface IELChildDemographic : IAutobahnBase
    {
        /// <summary>
        /// Race other than American Indian, Black, Asian, White, Native Pacific Islander
        /// </summary>
        System.Boolean? OtherRaceIndicator { get; set; }

    }
}
