//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentAcademicHonorModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentAcademicHonor Model
     /// </summary>
    public partial class K12StudentAcademicHonorModel : AutobahnBase, Interfaces.IK12StudentAcademicHonor
    {
        /// <summary>
        /// A designation of the type of academic distinctions earned by or awarded to the student.
        /// </summary>
        public Guid? RefAcademicHonorTypeId { get; set; }

    }
}
