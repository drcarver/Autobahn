//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IApipInteraction.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IApipInteraction Interface
     /// </summary>
    public partial interface IApipInteraction : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         APIPInteractionSequenceNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefApipInteractionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? Xml { get; set; }

        /// <summary>
        /// 
        /// </summary>
         XML { get; set; }

    }
}
