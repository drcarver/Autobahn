//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildOutcomeSummary.cs
//* Name:       Child Outcomes Summary Progress A Indicator
//* Definition: COS Progress A Indicator
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// COS Progress A Indicator
     /// </summary>
    public partial interface IELChildOutcomeSummary : IAutobahnBase
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
        System.Boolean? COSProgressAIndicator { get; set; }

        /// <summary>
        /// Child Outcomes Summary Progress B Indicator
        /// <para>
        /// Indicates that the child demonstrates progress in acquisition and use of knowledge and skills, including early language/communication.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20477">Child Outcomes Summary Progress B Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? COSProgressBIndicator { get; set; }

        /// <summary>
        /// Child Outcomes Summary Progress C Indicator
        /// <para>
        /// Indicates that the child demonstrates progress in use of appropriate behaviors to meet their needs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20478">Child Outcomes Summary Progress C Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? COSProgressCIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICOSRatingA"/> model
        /// </summary>
        Guid? COSRatingAId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICOSRatingB"/> model
        /// </summary>
        Guid? COSRatingBId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICOSRatingC"/> model
        /// </summary>
        Guid? COSRatingCId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

    }
}
