//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentAcademicAward.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentAcademicAward
     /// </summary>
    public partial interface IPsStudentAcademicAward
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicAward.AcademicAwardDate non nullable property
        /// </summary>
        System.String AcademicAwardDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicAwardLevel"/> model
        /// </summary>
        Guid? RefAcademicAwardLevelId { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicAward.AcademicAwardTitle non nullable property
        /// </summary>
        System.String AcademicAwardTitle { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicAward.RequirementsURL non nullable property
        /// </summary>
        System.String RequirementsURL { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicAwardPrerequisiteType"/> model
        /// </summary>
        Guid? RefAcademicAwardPrerequisiteTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPESCAwardLevelType"/> model
        /// </summary>
        Guid? RefPESCAwardLevelTypeId { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicAward.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentAcademicAward.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
