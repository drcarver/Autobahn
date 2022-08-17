//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12LeaSafeDrugFree.cs
//* Name:       Safe and Drug Free Baseline
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IK12LeaSafeDrugFree : IAutobahnBase
    {
        /// <summary>
        /// Safe and Drug Free Baseline
        /// <para>
        /// The baseline of the performance indicator of student behavior under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19468">Safe and Drug Free Baseline</a>
        /// </para>
        /// </summary>
        System.String Baseline { get; set; }

        /// <summary>
        /// Safe and Drug Free Baseline Year
        /// <para>
        /// The academic year the baseline was established.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19469">Safe and Drug Free Baseline Year</a>
        /// </para>
        /// </summary>
        System.String BaselineYear { get; set; }

        /// <summary>
        /// Safe and Drug Free Collection Frequency
        /// <para>
        ///  The frequency of data collection for performance indicator under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19463">Safe and Drug Free Collection Frequency</a>
        /// </para>
        /// </summary>
        System.String CollectionFrequency { get; set; }

        /// <summary>
        /// Safe and Drug Free Indicator Name
        /// <para>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19461">Safe and Drug Free Indicator Name</a>
        /// </para>
        /// </summary>
        System.String IndicatorName { get; set; }

        /// <summary>
        /// Safe and Drug Free Instrument
        /// <para>
        /// The instrument or data source for reported performance indicator of student behavior under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19462">Safe and Drug Free Instrument</a>
        /// </para>
        /// </summary>
        System.String Instrument { get; set; }

        /// <summary>
        /// Charter School Indicator
        /// <para>
        /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19039">Charter School Indicator</a>
        /// </para>
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// Safe and Drug Free Year Most Recent Collection
        /// <para>
        /// The academic year of the most recent collection of the performance indicator under the Sage and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19464">Safe and Drug Free Year Most Recent Collection</a>
        /// </para>
        /// </summary>
        System.String MostRecentCollection { get; set; }

        /// <summary>
        /// Safe and Drug Free Performance
        /// <para>
        /// Actual performance for the given  indicator of student behavior under the Safe and Drug-Free Schools and Communities Act
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19466">Safe and Drug Free Performance</a>
        /// </para>
        /// </summary>
        System.String Performance { get; set; }

        /// <summary>
        /// Safe and Drug Free Target
        /// <para>
        /// The targeted performance for the given  indicator of student behavior under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19465">Safe and Drug Free Target</a>
        /// </para>
        /// </summary>
        System.String Target { get; set; }

    }
}
