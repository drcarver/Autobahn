//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefTimeForCompletionUnitModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The RefTimeForCompletionUnit Interface Model
     /// </summary>
    public partial interface IRefTimeForCompletionUnitModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTimeForCompletionUnits"/> model
        /// </summary>
        Guid RefTimeForCompletionUnitsId { get; set; }

    }
}
