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
        /// A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, registry, or other agency or entity.
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, registry, or other agency or entity.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, registry, or other agency or entity.
        /// </summary>
        Guid? RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, registry, or other agency or entity.
        /// </summary>
        Guid RefPersonIdentificationSystemId { get; set; }

    }
}
