//**********************************************************
//* DomainName: Common Models
//* FileName:   ProfessionalDevelopmentRequirementModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ProfessionalDevelopmentRequirement Model
     /// </summary>
    public partial class ProfessionalDevelopmentRequirementModel : AutobahnBase, Interfaces.IProfessionalDevelopmentRequirement
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        public Guid? CompetencySetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Required Training Clock Hours
        /// <para>
        /// Number of clock hours of training required for providers to meet requirements of the state.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19803">Required Training Clock Hours</a>
        /// </para>
        /// </summary>
        public System.Decimal? RequiredTrainingClockHours { get; set; }

    }
}
