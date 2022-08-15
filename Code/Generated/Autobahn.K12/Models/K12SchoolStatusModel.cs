//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolStatusModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolStatus Model
     /// </summary>
    public partial class K12SchoolStatusModel : AutobahnBase, Interfaces.IK12SchoolStatus
    {
        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        public Guid? RefAlternativeSchoolFocusId { get; set; }

    }
}
