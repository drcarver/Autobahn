//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProfessionalDevelopmentRequirement.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProfessionalDevelopmentRequirement
     /// </summary>
    public partial interface IProfessionalDevelopmentRequirement : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentRequirement.RequiredTrainingClockHours nullable property
        /// </summary>
        System.Decimal? RequiredTrainingClockHours { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySet"/> model
        /// </summary>
        Guid? CompetencySetId { get; set; }

    }
}
