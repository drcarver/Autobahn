//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefTitleISchoolStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefTitleISchoolStatu Interface
     /// </summary>
    public partial interface IRefTitleISchoolStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTitleISchoolStatus"/> model
        /// </summary>
        Guid RefTitleISchoolStatusId { get; set; }

    }
}
