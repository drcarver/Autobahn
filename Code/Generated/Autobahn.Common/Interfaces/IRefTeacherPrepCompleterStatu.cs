//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefTeacherPrepCompleterStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefTeacherPrepCompleterStatu Interface
     /// </summary>
    public partial interface IRefTeacherPrepCompleterStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTeacherPrepCompleterStatus"/> model
        /// </summary>
        Guid RefTeacherPrepCompleterStatusId { get; set; }

    }
}
