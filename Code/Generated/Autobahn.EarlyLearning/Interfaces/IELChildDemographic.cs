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
        System.DateTime? FosterCareEndDate { get; set; }

        System.DateTime? FosterCareStartDate { get; set; }

        /// <summary>
        /// Other Race Indicator
        /// <para>
        /// Race other than American Indian, Black, Asian, White, Native Pacific Islander
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20390">Other Race Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? OtherRaceIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

    }
}
