//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefCampusStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The RefCampusStatu Interface
     /// </summary>
    public partial interface IRefCampusStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCampusStatus"/> model
        /// </summary>
        Guid RefCampusStatusId { get; set; }

    }
}
