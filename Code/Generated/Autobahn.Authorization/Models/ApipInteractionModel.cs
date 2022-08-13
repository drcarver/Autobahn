//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ApipInteractionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The ApipInteraction Model
     /// </summary>
    public partial class ApipInteractionModel : AutobahnBase, Interfaces.IApipInteraction
    {
        /// <summary>
        /// The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.
        /// </summary>
        public System.Decimal? APIPInteractionSequenceNumber { get; set; }

        /// <summary>
        /// The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.
        /// </summary>
        public Guid AssessmentItemApipId { get; set; }

        /// <summary>
        /// The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.
        /// </summary>
        public Guid? RefApipInteractionTypeId { get; set; }

        /// <summary>
        /// The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.
        /// </summary>
        public System.Int32? SequenceNumber { get; set; }

        /// <summary>
        /// The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.
        /// </summary>
        public System.String Xml { get; set; }

    }
}
