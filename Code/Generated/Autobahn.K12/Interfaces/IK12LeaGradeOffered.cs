//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12LeaGradeOffered.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaGradeOffered Interface
     /// </summary>
    public partial interface IK12LeaGradeOffered : IAutobahnBase
    {
        /// <summary>
        /// The specific grade or combination of grades offered by an education institution.
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// The specific grade or combination of grades offered by an education institution.
        /// </summary>
        Guid RefGradeLevelId { get; set; }

    }
}
