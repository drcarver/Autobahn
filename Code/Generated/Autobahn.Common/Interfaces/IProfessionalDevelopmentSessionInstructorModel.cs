//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProfessionalDevelopmentSessionInstructorModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProfessionalDevelopmentSessionInstructorModel Interface
     /// </summary>
    public partial interface IProfessionalDevelopmentSessionInstructorModel : IAutobahnBase
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
