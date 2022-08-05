//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefAlternativeSchoolFocu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefAlternativeSchoolFocu Interface
     /// </summary>
    public partial interface IRefAlternativeSchoolFocu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAlternativeSchoolFocus"/> model
        /// </summary>
        Guid RefAlternativeSchoolFocusId { get; set; }

    }
}
