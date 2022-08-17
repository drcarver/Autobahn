//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonDigitalAccess.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDigitalAccess Interface
     /// </summary>
    public partial interface IPersonDigitalAccess : IAutobahnBase
    {
        /// <summary>
        /// Internet Access In Residence
        /// <para>
        /// An indication of whether the student is able to access the internet in their primary place of residence.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20936">Internet Access In Residence</a>
        /// </para>
        /// </summary>
        System.Boolean? InternetAccessInResidence { get; set; }

        /// <summary>
        /// Address County Name
        /// <para>
        /// The name of the county, parish, borough, or comparable unit (within a state) in which an address is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19190">Address County Name</a>
        /// </para>
        /// </summary>
        Guid? PersonAddressId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBarrierToInternetAccessInResidence"/> model
        /// </summary>
        Guid? RefBarrierToInternetAccessInResidenceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefInternetAccessTypeInResidence"/> model
        /// </summary>
        Guid? RefInternetAccessTypeInResidenceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefInternetPerformanceInResidence"/> model
        /// </summary>
        Guid? RefInternetPerformanceInResidenceId { get; set; }

    }
}
