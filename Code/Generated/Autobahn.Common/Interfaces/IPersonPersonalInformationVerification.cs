//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonPersonalInformationVerification.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonPersonalInformationVerification Interface
     /// </summary>
    public partial interface IPersonPersonalInformationVerification : IAutobahnBase
    {
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
        /// Birthdate
        /// <para>
        /// The year, month and day on which a person was born.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19033">Birthdate</a>
        /// </para>
        /// </summary>
        Guid? PersonDetailId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonTelephone"/> model
        /// </summary>
        Guid? PersonTelephoneId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationType"/> model
        /// </summary>
        Guid? RefPersonalInformationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        Guid? RefPersonalInformationVerificationId { get; set; }

    }
}
