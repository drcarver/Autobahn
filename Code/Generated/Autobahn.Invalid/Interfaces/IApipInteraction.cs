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
        /// The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.
        /// </summary>
        System.String Xml { get; set; }

    }
}
