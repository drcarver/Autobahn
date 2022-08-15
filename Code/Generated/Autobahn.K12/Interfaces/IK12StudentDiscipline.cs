//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentDiscipline.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentDiscipline Interface
     /// </summary>
    public partial interface IK12StudentDiscipline : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        System.DateTime? DisciplinaryActionEndDate { get; set; }

    }
}
