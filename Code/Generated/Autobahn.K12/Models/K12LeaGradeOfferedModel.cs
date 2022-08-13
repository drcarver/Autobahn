//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaGradeOfferedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaGradeOffered Model
     /// </summary>
    public partial class K12LeaGradeOfferedModel : AutobahnBase, Interfaces.IK12LeaGradeOffered
    {
        /// <summary>
        /// The specific grade or combination of grades offered by an education institution.
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// The specific grade or combination of grades offered by an education institution.
        /// </summary>
        public Guid RefGradeLevelId { get; set; }

    }
}
