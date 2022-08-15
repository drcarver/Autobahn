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
        public System.String OtherName { get; set; }

    }
}
