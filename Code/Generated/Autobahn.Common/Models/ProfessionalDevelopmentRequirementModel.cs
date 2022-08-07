//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProfessionalDevelopmentRequirementModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProfessionalDevelopmentRequirement Model
     /// </summary>
    public partial class ProfessionalDevelopmentRequirementModel : AutobahnBase, Interfaces.IProfessionalDevelopmentRequirementModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ProfessionalDevelopmentRequirement.RequiredTrainingClockHours nullable property
        /// </summary>
        public System.Decimal? RequiredTrainingClockHours { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySet"/> model
        /// </summary>
        public Guid? CompetencySetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
