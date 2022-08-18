//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonIdentifier.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonIdentifier Interface
     /// </summary>
    public partial interface IPersonIdentifier : IAutobahnBase
    {
        /// <summary>
        /// Staff Member Identifier
        /// <para>
        /// A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, registry, or other agency or entity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19156">Staff Member Identifier</a>
        /// </para>
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        Guid? RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonentificationSystem"/> model
        /// </summary>
        Guid RefPersonIdentificationSystemId { get; set; }

    }
}
