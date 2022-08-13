//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonIdentifierModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonIdentifier Model
     /// </summary>
    public partial class PersonIdentifierModel : AutobahnBase, Interfaces.IPersonIdentifier
    {
        /// <summary>
        /// A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, registry, or other agency or entity.
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, registry, or other agency or entity.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, registry, or other agency or entity.
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, registry, or other agency or entity.
        /// </summary>
        public Guid RefPersonIdentificationSystemId { get; set; }

    }
}
