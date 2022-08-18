//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDigitalAccess Model
     /// </summary>
    public partial class PersonDigitalAccessModel : AutobahnBase, Interfaces.IPersonDigitalAccess
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
        public System.Boolean? InternetAccessInResidence { get; set; }

        /// <summary>
        /// Address County Name
        /// <para>
        /// The name of the county, parish, borough, or comparable unit (within a state) in which an address is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19190">Address County Name</a>
        /// </para>
        /// </summary>
        public Guid? PersonAddressId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBarrierToInternetAccessInResidence"/> model
        /// </summary>
        public Guid? RefBarrierToInternetAccessInResidenceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetAccessTypeInResidence"/> model
        /// </summary>
        public Guid? RefInternetAccessTypeInResidenceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInternetPerformanceInResidence"/> model
        /// </summary>
        public Guid? RefInternetPerformanceInResidenceId { get; set; }

    }
}
