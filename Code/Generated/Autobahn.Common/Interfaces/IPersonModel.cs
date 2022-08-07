//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonModel Interface
     /// </summary>
    public partial interface IPersonModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonMaster"/> model
        /// </summary>
        Guid? PersonMasterId { get; set; }

    }
}
