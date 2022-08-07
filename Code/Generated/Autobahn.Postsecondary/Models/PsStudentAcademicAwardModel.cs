//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentAcademicAwardModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentAcademicAward Model
     /// </summary>
    public partial class PsStudentAcademicAwardModel : AutobahnBase, Interfaces.IPsStudentAcademicAwardModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicAward.AcademicAwardDate non nullable property
        /// </summary>
        public System.String AcademicAwardDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicAwardLevel"/> model
        /// </summary>
        public Guid? RefAcademicAwardLevelId { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicAward.AcademicAwardTitle non nullable property
        /// </summary>
        public System.String AcademicAwardTitle { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicAward.RequirementsURL non nullable property
        /// </summary>
        public System.String RequirementsURL { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicAwardPrerequisiteType"/> model
        /// </summary>
        public Guid? RefAcademicAwardPrerequisiteTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPESCAwardLevelType"/> model
        /// </summary>
        public Guid? RefPESCAwardLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
