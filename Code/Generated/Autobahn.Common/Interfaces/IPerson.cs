//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPerson.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPerson
     /// </summary>
    public partial interface IPerson : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonMaster"/> model
        /// </summary>
        Guid? PersonMasterId { get; set; }

    }
}
