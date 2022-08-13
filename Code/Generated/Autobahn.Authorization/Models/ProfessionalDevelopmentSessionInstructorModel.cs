//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProfessionalDevelopmentSessionInstructorModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The ProfessionalDevelopmentSessionInstructor Model
     /// </summary>
    public partial class ProfessionalDevelopmentSessionInstructorModel : AutobahnBase, Interfaces.IProfessionalDevelopmentSessionInstructor
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid ProfessionalDevelopmentSessionId { get; set; }

    }
}
