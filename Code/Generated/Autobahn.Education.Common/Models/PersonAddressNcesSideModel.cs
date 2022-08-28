//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressNcesSideModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The PersonAddressNcesSide Model
     /// </summary>
    public partial class PersonAddressNcesSideModel : IPersonAddressNcesSide
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IPersonAddressNcesSide
        /// <summary>
        /// NCES SIDE Date Processed
        /// <para>
        /// The year, month, and day on which the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE) was processed through the BlindSIDE resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20943">NCES SIDE Date Processed</a>
        /// </para>
        /// </summary>
        public DateTime? NcesSideDateProcessed { get; set; }

        /// <summary>
        /// NCES SIDE Estimate
        /// <para>
        /// The National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE) based on the person's latitude and longitude location.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20944">NCES SIDE Estimate</a>
        /// </para>
        /// </summary>
        public Decimal? NcesSideEstimate { get; set; }

        /// <summary>
        /// NCES SIDE Standard Error
        /// <para>
        /// The standard error applied to the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20945">NCES SIDE Standard Error</a>
        /// </para>
        /// </summary>
        public Decimal? NcesSideStandardError { get; set; }

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
        /// Reference to an optional instance of the <see cref="IPersonAddress"/> model
        /// </summary>
        public Guid PersonAddressId { get; set; }

        #endregion
    }
}
