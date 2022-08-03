//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProfessionalDevelopmentSessionInstructor.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProfessionalDevelopmentSessionInstructor
     /// </summary>
    public partial interface IProfessionalDevelopmentSessionInstructor
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentSession"/> model
        /// </summary>
        Guid ProfessionalDevelopmentSessionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSessionInstructor.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentSessionInstructor.RecordEndDateTime nullable property
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
