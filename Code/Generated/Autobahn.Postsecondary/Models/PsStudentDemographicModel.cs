//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentDemographicModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentDemographic Model
     /// </summary>
    public partial class PsStudentDemographicModel : AutobahnBase, Interfaces.IPsStudentDemographic
    {
        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public Guid? RefCampusResidencyTypeId { get; set; }

    }
}
