//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonIdentifierModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonIdentifier Model
     /// </summary>
    public partial class PersonIdentifierModel : AutobahnBase, Interfaces.IPersonIdentifier
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
        public System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonentificationSystem"/> model
        /// </summary>
        public Guid RefPersonIdentificationSystemId { get; set; }

    }
}
