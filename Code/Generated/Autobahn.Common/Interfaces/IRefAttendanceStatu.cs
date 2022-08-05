//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefAttendanceStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefAttendanceStatu Interface
     /// </summary>
    public partial interface IRefAttendanceStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAttendanceStatus"/> model
        /// </summary>
        Guid RefAttendanceStatusId { get; set; }

    }
}
