//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefGraduateOrDoctoralExamResultsStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The RefGraduateOrDoctoralExamResultsStatu Interface
     /// </summary>
    public partial interface IRefGraduateOrDoctoralExamResultsStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefGraduateOrDoctoralExamResultsStatus"/> model
        /// </summary>
        Guid RefGraduateOrDoctoralExamResultsStatusId { get; set; }

    }
}
