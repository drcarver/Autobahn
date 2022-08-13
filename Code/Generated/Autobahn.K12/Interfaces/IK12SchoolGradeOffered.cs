//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SchoolGradeOffered.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolGradeOffered Interface
     /// </summary>
    public partial interface IK12SchoolGradeOffered : IAutobahnBase
    {
        /// <summary>
        /// The specific grade or combination of grades offered by an education institution.
        /// </summary>
        Guid K12SchoolId { get; set; }

        /// <summary>
        /// The specific grade or combination of grades offered by an education institution.
        /// </summary>
        Guid RefGradeLevelId { get; set; }

    }
}