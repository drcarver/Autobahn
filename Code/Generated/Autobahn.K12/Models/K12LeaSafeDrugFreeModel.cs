//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaSafeDrugFreeModel.cs
//* Name:       Safe and Drug Free Baseline
//* Definition: The baseline of the performance indicator of student behavior under the Safe and Drug-Free Schools and Communities Act.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The baseline of the performance indicator of student behavior under the Safe and Drug-Free Schools and Communities Act.
     /// </summary>
    public partial class K12LeaSafeDrugFreeModel : AutobahnBase, Interfaces.IK12LeaSafeDrugFree
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
        public System.String Baseline { get; set; }

        /// <summary>
        /// Safe and Drug Free Baseline Year
        /// <para>
        /// The academic year the baseline was established.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19469">Safe and Drug Free Baseline Year</a>
        /// </para>
        /// </summary>
        public System.String BaselineYear { get; set; }

        /// <summary>
        /// Safe and Drug Free Collection Frequency
        /// <para>
        ///  The frequency of data collection for performance indicator under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19463">Safe and Drug Free Collection Frequency</a>
        /// </para>
        /// </summary>
        public System.String CollectionFrequency { get; set; }

        /// <summary>
        /// Safe and Drug Free Indicator Name
        /// <para>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19461">Safe and Drug Free Indicator Name</a>
        /// </para>
        /// </summary>
        public System.String IndicatorName { get; set; }

        /// <summary>
        /// Safe and Drug Free Instrument
        /// <para>
        /// The instrument or data source for reported performance indicator of student behavior under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19462">Safe and Drug Free Instrument</a>
        /// </para>
        /// </summary>
        public System.String Instrument { get; set; }

        /// <summary>
        /// Charter School Indicator
        /// <para>
        /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19039">Charter School Indicator</a>
        /// </para>
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// Safe and Drug Free Year Most Recent Collection
        /// <para>
        /// The academic year of the most recent collection of the performance indicator under the Sage and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19464">Safe and Drug Free Year Most Recent Collection</a>
        /// </para>
        /// </summary>
        public System.String MostRecentCollection { get; set; }

        /// <summary>
        /// Safe and Drug Free Performance
        /// <para>
        /// Actual performance for the given  indicator of student behavior under the Safe and Drug-Free Schools and Communities Act
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19466">Safe and Drug Free Performance</a>
        /// </para>
        /// </summary>
        public System.String Performance { get; set; }

        /// <summary>
        /// Safe and Drug Free Target
        /// <para>
        /// The targeted performance for the given  indicator of student behavior under the Safe and Drug-Free Schools and Communities Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19465">Safe and Drug Free Target</a>
        /// </para>
        /// </summary>
        public System.String Target { get; set; }

    }
}
