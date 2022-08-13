//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonOtherNameModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonOtherName Model
     /// </summary>
    public partial class PersonOtherNameModel : AutobahnBase, Interfaces.IPersonOtherName
    {
        /// <summary>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </summary>
        public System.String FirstName { get; set; }

        /// <summary>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </summary>
        public System.String LastName { get; set; }

        /// <summary>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </summary>
        public System.String MiddleName { get; set; }

        /// <summary>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </summary>
        public System.String OtherName { get; set; }

        /// <summary>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </summary>
        public Guid? RefOtherNameTypeId { get; set; }

    }
}
