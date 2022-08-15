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
        System.String OtherName { get; set; }

    }
}
