//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPPresentLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IEPPresentLevel Model
     /// </summary>
    public partial class IEPPresentLevelModel : AutobahnBase, Interfaces.IIEPPresentLevel
    {
        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String AcademicDescription { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String FunctionalDescription { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String GeneralEducationDescription { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String ParentConcernDescription { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String PreschoolDescription { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String StudentConcernDescription { get; set; }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String StudentStrengthsDescription { get; set; }

    }
}
