//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentAcademicAward.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentAcademicAward
     /// </summary>
    public partial class PsStudentAcademicAward : IPsStudentAcademicAward
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
        /// Defines the PsStudentAcademicAward.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicAward.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
