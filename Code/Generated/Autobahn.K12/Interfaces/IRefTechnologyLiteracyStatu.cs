//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefTechnologyLiteracyStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefTechnologyLiteracyStatu Interface
     /// </summary>
    public partial interface IRefTechnologyLiteracyStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTechnologyLiteracyStatus"/> model
        /// </summary>
        Guid RefTechnologyLiteracyStatusId { get; set; }

    }
}
