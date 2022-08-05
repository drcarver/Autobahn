//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   IAeStudentEmployment.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeStudentEmployment
     /// </summary>
    public partial interface IAeStudentEmployment : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the AeStudentEmployment.EmploymentNaicsCode non nullable property
        /// </summary>
        System.String EmploymentNaicsCode { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
        /// </summary>
        Guid? RefEmployedWhileEnrolledId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
        /// </summary>
        Guid? RefEmployedAfterExitId { get; set; }

    }
}
