//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIEPPresentLevel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIEPPresentLevel Interface
     /// </summary>
    public partial interface IIEPPresentLevel : IAutobahnBase
    {
        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        System.String AcademicDescription { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        System.String FunctionalDescription { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        System.String GeneralEducationDescription { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        System.String ParentConcernDescription { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        System.String PreschoolDescription { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        System.String StudentConcernDescription { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        System.String StudentStrengthsDescription { get; set; }

    }
}
