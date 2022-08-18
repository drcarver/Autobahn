//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildDemographicModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildDemographic Model
     /// </summary>
    public partial class ELChildDemographicModel : AutobahnBase, Interfaces.IELChildDemographic
    {
        public System.DateTime? FosterCareEndDate { get; set; }

        public System.DateTime? FosterCareStartDate { get; set; }

        /// <summary>
        /// Other Race Indicator
        /// <para>
        /// Race other than American Indian, Black, Asian, White, Native Pacific Islander
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20390">Other Race Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? OtherRaceIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

    }
}
