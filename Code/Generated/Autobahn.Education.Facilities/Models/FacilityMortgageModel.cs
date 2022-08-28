//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Facilities;

namespace Autobahn.Education.Facilities.Models
{
     /// <summary>
     /// The FacilityMortgage Model
     /// </summary>
    public partial class FacilityMortgageModel : IFacilityMortgage
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

        #region IFacilityMortgage
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Facility Mortgage Interest Amount
        /// <para>
        /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20871">Facility Mortgage Interest Amount</a>
        /// </para>
        /// </summary>
        public Decimal? FacilityMortgageInterestAmount { get; set; }

        /// <summary>
        /// Facility Total Assessed Value
        /// <para>
        /// The total assessed value of property that constitutes the basis for public borrowing.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20877">Facility Total Assessed Value</a>
        /// </para>
        /// </summary>
        public Decimal? FacilityTotalAssessedValue { get; set; }

        /// <summary>
        /// Facility Mortgage Interest Type
        /// <para>
        /// The type of interest paid on a mortgage to the lender to compensate the lender for the use of money to purchase a building or facility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20872">Facility Mortgage Interest Type</a>
        /// </para>
        /// </summary>
        public Guid? RefFacilityMortgageInterestTypeId { get; set; }

        /// <summary>
        /// Facility Mortgage Type
        /// <para>
        /// The status of a mortgage as it relates to priority of payment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20873">Facility Mortgage Type</a>
        /// </para>
        /// </summary>
        public Guid? RefFacilityMortgageTypeId { get; set; }

        #endregion
    }
}
