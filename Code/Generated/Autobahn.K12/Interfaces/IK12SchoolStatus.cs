//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SchoolStatus.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolStatus Interface
     /// </summary>
    public partial interface IK12SchoolStatus : IAutobahnBase
    {
        /// <summary>
        /// An indication of the specific group of students whose needs the alternative school is designed to meet.
        /// </summary>
        Guid? RefAlternativeSchoolFocusId { get; set; }

    }
}
