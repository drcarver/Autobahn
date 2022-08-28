//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonOtherNameModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The PersonOtherName Model
     /// </summary>
    public partial class PersonOtherNameModel : IPersonOtherName
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

        #region IPersonOtherName
        /// <summary>
        /// Other First Name
        /// <para>
        /// A first name given to a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20486">Other First Name</a>
        /// </para>
        /// </summary>
        public System.String FirstName { get; set; }

        /// <summary>
        /// Other Last Name
        /// <para>
        /// A last name given to a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20485">Other Last Name</a>
        /// </para>
        /// </summary>
        public System.String LastName { get; set; }

        /// <summary>
        /// Other Middle Name
        /// <para>
        /// A middle name given to a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20487">Other Middle Name</a>
        /// </para>
        /// </summary>
        public System.String MiddleName { get; set; }

        /// <summary>
        /// Other Name
        /// <para>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19206">Other Name</a>
        /// </para>
        /// </summary>
        public System.String OtherName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Other Name Type
        /// <para>
        /// The types of previous, alternate or other names for a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19627">Other Name Type</a>
        /// </para>
        /// </summary>
        public Guid? RefOtherNameTypeId { get; set; }

        #endregion
    }
}
