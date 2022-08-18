//**********************************************************
//* DomainName: Common Models
//* FileName:   ProfessionalDevelopmentSessionInstructorModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProfessionalDevelopmentSessionInstructor Model
     /// </summary>
    public partial class ProfessionalDevelopmentSessionInstructorModel : AutobahnBase, Interfaces.IProfessionalDevelopmentSessionInstructor
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Professional Development Session Capacity
        /// <para>
        /// The total number of participants that can be accommodated by a professional development session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20416">Professional Development Session Capacity</a>
        /// </para>
        /// </summary>
        public Guid ProfessionalDevelopmentSessionId { get; set; }

    }
}
