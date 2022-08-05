//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProfessionalDevelopmentSessionInstructor.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProfessionalDevelopmentSessionInstructor
     /// </summary>
    public partial interface IProfessionalDevelopmentSessionInstructor : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentSession"/> model
        /// </summary>
        Guid ProfessionalDevelopmentSessionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}
