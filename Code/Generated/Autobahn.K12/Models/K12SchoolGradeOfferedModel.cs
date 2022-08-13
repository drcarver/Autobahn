//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolGradeOfferedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolGradeOffered Model
     /// </summary>
    public partial class K12SchoolGradeOfferedModel : AutobahnBase, Interfaces.IK12SchoolGradeOffered
    {
        /// <summary>
        /// The specific grade or combination of grades offered by an education institution.
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// The specific grade or combination of grades offered by an education institution.
        /// </summary>
        public Guid RefGradeLevelId { get; set; }

    }
}
