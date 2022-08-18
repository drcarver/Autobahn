//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonDemographicRace.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDemographicRace Interface
     /// </summary>
    public partial interface IPersonDemographicRace : IAutobahnBase
    {
        /// <summary>
        /// Federal Race and Ethnicity Declined
        /// <para>
        /// A parent, guardian, or student declined to report sufficient information for identifying a student's federal race and/or ethnicity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20932">Federal Race and Ethnicity Declined</a>
        /// </para>
        /// </summary>
        System.Boolean? FederalRaceAndEthnicityDeclined { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRace"/> model
        /// </summary>
        Guid RefRaceId { get; set; }

    }
}
