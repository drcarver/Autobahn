//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressNcesSideModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAddressNcesSide Model
     /// </summary>
    public partial class PersonAddressNcesSideModel : AutobahnBase, Interfaces.IPersonAddressNcesSide
    {
        /// <summary>
        /// NCES SIDE Date Processed
        /// <para>
        /// The year, month, and day on which the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE) was processed through the BlindSIDE resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20943">NCES SIDE Date Processed</a>
        /// </para>
        /// </summary>
        public System.DateTime? NcesSideDateProcessed { get; set; }

        /// <summary>
        /// NCES SIDE Estimate
        /// <para>
        /// The National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE) based on the person's latitude and longitude location.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20944">NCES SIDE Estimate</a>
        /// </para>
        /// </summary>
        public System.Decimal? NcesSideEstimate { get; set; }

        /// <summary>
        /// NCES SIDE Standard Error
        /// <para>
        /// The standard error applied to the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20945">NCES SIDE Standard Error</a>
        /// </para>
        /// </summary>
        public System.Decimal? NcesSideStandardError { get; set; }

        /// <summary>
        /// NCES SIDE Vintage Begin Year
        /// <para>
        /// The begin year for the American Community Survey (ACS) period estimates used to construct the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20946">NCES SIDE Vintage Begin Year</a>
        /// </para>
        /// </summary>
        public System.String NcesSideVintageBeginYear { get; set; }

        /// <summary>
        /// NCES SIDE Vintage End Year
        /// <para>
        /// The end year for the American Community Survey (ACS) period estimates used to construct the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20947">NCES SIDE Vintage End Year</a>
        /// </para>
        /// </summary>
        public System.String NcesSideVintageEndYear { get; set; }

        /// <summary>
        /// Address County Name
        /// <para>
        /// The name of the county, parish, borough, or comparable unit (within a state) in which an address is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19190">Address County Name</a>
        /// </para>
        /// </summary>
        public Guid PersonAddressId { get; set; }

    }
}
