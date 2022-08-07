//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefAlternativeSchoolFocuModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefAlternativeSchoolFocu Interface Model
     /// </summary>
    public partial interface IRefAlternativeSchoolFocuModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAlternativeSchoolFocus"/> model
        /// </summary>
        Guid RefAlternativeSchoolFocusId { get; set; }

    }
}
