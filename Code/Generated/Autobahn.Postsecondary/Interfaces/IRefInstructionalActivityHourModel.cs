//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefInstructionalActivityHourModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The RefInstructionalActivityHour Interface Model
     /// </summary>
    public partial interface IRefInstructionalActivityHourModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefInstructionalActivityHours"/> model
        /// </summary>
        Guid RefInstructionalActivityHoursId { get; set; }

    }
}
