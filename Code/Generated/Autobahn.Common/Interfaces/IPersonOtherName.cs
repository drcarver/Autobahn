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
        /// Previous, alternate or other names or aliases associated with the person.
        /// </summary>
        System.String FirstName { get; set; }

        /// <summary>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </summary>
        System.String LastName { get; set; }

        /// <summary>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </summary>
        System.String MiddleName { get; set; }

        /// <summary>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </summary>
        System.String OtherName { get; set; }

        /// <summary>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Previous, alternate or other names or aliases associated with the person.
        /// </summary>
        Guid? RefOtherNameTypeId { get; set; }

    }
}
