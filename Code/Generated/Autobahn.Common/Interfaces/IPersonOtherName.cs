//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonOtherName.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonOtherName Interface
     /// </summary>
    public partial interface IPersonOtherName : IAutobahnBase
    {
        /// <summary>
        /// Other First Name
        /// <para>
        /// A first name given to a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20486">Other First Name</a>
        /// </para>
        /// </summary>
        System.String FirstName { get; set; }

        /// <summary>
        /// Other Last Name
        /// <para>
        /// A last name given to a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20485">Other Last Name</a>
        /// </para>
        /// </summary>
        System.String LastName { get; set; }

        /// <summary>
        /// Other Middle Name
        /// <para>
        /// A middle name given to a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20487">Other Middle Name</a>
        /// </para>
        /// </summary>
        System.String MiddleName { get; set; }

        /// <summary>
        /// Other Name
        /// <para>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19206">Other Name</a>
        /// </para>
        /// </summary>
        System.String OtherName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefOtherNameType"/> model
        /// </summary>
        Guid? RefOtherNameTypeId { get; set; }

    }
}
