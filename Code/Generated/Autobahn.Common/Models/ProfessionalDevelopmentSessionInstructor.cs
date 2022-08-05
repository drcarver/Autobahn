//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProfessionalDevelopmentSessionInstructor.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProfessionalDevelopmentSessionInstructor
     /// </summary>
    public partial class ProfessionalDevelopmentSessionInstructor : AutobahnBase, Interfaces.IProfessionalDevelopmentSessionInstructor
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentSession"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentSessionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
