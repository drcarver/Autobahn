//**********************************************************
//* DomainName: Common Models
//* FileName:   ApipInteractionModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ApipInteraction Model
     /// </summary>
    public partial class ApipInteractionModel : AutobahnBase, Interfaces.IApipInteraction
    {
        /// <summary>
        /// APIP Interaction Sequence Number
        /// <para>
        /// The position of this APIP Interaction in a sequence of interactions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20504">APIP Interaction Sequence Number</a>
        /// </para>
        /// </summary>
        public System.Decimal? APIPInteractionSequenceNumber { get; set; }

        /// <summary>
        /// Assessment Item Adaptive Indicator
        /// <para>
        /// This indicator determines whether an assessment item is an adaptive item.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20111">Assessment Item Adaptive Indicator</a>
        /// </para>
        /// </summary>
        public Guid AssessmentItemApipId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefApipInteractionType"/> model
        /// </summary>
        public Guid? RefApipInteractionTypeId { get; set; }

        public System.Int32? SequenceNumber { get; set; }

        /// <summary>
        /// Assessment Item Body Custom Interaction XML
        /// <para>
        /// The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20079">Assessment Item Body Custom Interaction XML</a>
        /// </para>
        /// </summary>
        public System.String Xml { get; set; }

    }
}
