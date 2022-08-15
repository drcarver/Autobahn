//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IServicePlan.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IServicePlan Interface
     /// </summary>
    public partial interface IServicePlan : IAutobahnBase
    {
        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        System.String ReasonForDeclinedServices { get; set; }

    }
}
