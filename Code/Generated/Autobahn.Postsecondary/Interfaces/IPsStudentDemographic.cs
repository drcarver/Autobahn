//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentDemographic.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentDemographic Interface
     /// </summary>
    public partial interface IPsStudentDemographic : IAutobahnBase
    {
        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        Guid? RefCampusResidencyTypeId { get; set; }

    }
}
