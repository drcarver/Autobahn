//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefTimeForCompletionUnit.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The RefTimeForCompletionUnit Interface
     /// </summary>
    public partial interface IRefTimeForCompletionUnit : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTimeForCompletionUnits"/> model
        /// </summary>
        Guid RefTimeForCompletionUnitsId { get; set; }

    }
}
