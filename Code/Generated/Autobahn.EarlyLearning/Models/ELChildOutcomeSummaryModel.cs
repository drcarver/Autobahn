//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildOutcomeSummaryModel.cs
//* Name:       Child Outcomes Summary Progress A Indicator
//* Definition: Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
     /// </summary>
    public partial class ELChildOutcomeSummaryModel : AutobahnBase, Interfaces.IELChildOutcomeSummary
    {
        /// <summary>
        /// Child Outcomes Summary Progress A Indicator
        /// <para>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20476">Child Outcomes Summary Progress A Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? COSProgressAIndicator { get; set; }

        /// <summary>
        /// Child Outcomes Summary Progress B Indicator
        /// <para>
        /// Indicates that the child demonstrates progress in acquisition and use of knowledge and skills, including early language/communication.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20477">Child Outcomes Summary Progress B Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? COSProgressBIndicator { get; set; }

        /// <summary>
        /// Child Outcomes Summary Progress C Indicator
        /// <para>
        /// Indicates that the child demonstrates progress in use of appropriate behaviors to meet their needs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20478">Child Outcomes Summary Progress C Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? COSProgressCIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICOSRatingA"/> model
        /// </summary>
        public Guid? COSRatingAId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICOSRatingB"/> model
        /// </summary>
        public Guid? COSRatingBId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICOSRatingC"/> model
        /// </summary>
        public Guid? COSRatingCId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

    }
}
