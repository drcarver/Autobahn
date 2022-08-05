//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefEDFactsTeacherInexperiencedStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefEDFactsTeacherInexperiencedStatu Interface
     /// </summary>
    public partial interface IRefEDFactsTeacherInexperiencedStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEDFactsTeacherInexperiencedStatus"/> model
        /// </summary>
        Guid RefEDFactsTeacherInexperiencedStatusId { get; set; }

    }
}
