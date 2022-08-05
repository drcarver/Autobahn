//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentAcademicAward.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentAcademicAward
     /// </summary>
    public partial interface IPsStudentAcademicAward : IAutobahnBase
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

    }
}
