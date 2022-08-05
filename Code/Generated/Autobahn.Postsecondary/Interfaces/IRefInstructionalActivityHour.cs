//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefInstructionalActivityHour.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The RefInstructionalActivityHour Interface
     /// </summary>
    public partial interface IRefInstructionalActivityHour : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefInstructionalActivityHours"/> model
        /// </summary>
        Guid RefInstructionalActivityHoursId { get; set; }

    }
}
