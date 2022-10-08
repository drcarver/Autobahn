using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("Person", Schema = "Core")]
    public partial class Person
    {
        public Person()
        {
            AssessmentRegistrationAssignedByPeople = new HashSet<AssessmentRegistration>();
            AssessmentRegistrationPeople = new HashSet<AssessmentRegistration>();
            AssessmentSessionStaffRoles = new HashSet<AssessmentSessionStaffRole>();
            CredentialAwards = new HashSet<CredentialAward>();
            CredentialDefAgents = new HashSet<CredentialDefAgent>();
            ElchildDemographics = new HashSet<ELChildDemographic>();
            ElchildDevelopmentalAssessments = new HashSet<ELChildDevelopmentalAssessment>();
            ElchildHealths = new HashSet<ELChildHealth>();
            ElchildIndividualizedPrograms = new HashSet<ELChildIndividualizedProgram>();
            ElchildOutcomeSummaries = new HashSet<ELChildOutcomeSummary>();
            ElchildTransitionPlans = new HashSet<ELChildTransitionPlan>();
            ElenrollmentOtherFundings = new HashSet<ELEnrollmentOtherFunding>();
            IncidentPeople = new HashSet<IncidentPerson>();
            Incidents = new HashSet<Incident>();
            IndividualizedProgramServices = new HashSet<IndividualizedProgramService>();
            LearnerActivityAssignedByPeople = new HashSet<LearnerActivity>();
            LearnerActivityPeople = new HashSet<LearnerActivity>();
            LearningResourcePeerRatings = new HashSet<LearningResourcePeerRating>();
            OrganizationPersonRoles = new HashSet<OrganizationPersonRole>();
            PersonAddresses = new HashSet<PersonAddress>();
            PersonAllergies = new HashSet<PersonAllergy>();
            PersonAssessmentPersonalNeedsProfiles = new HashSet<PersonAssessmentPersonalNeedsProfile>();
            PersonBirthplaces = new HashSet<PersonBirthplace>();
            PersonCareerEducationPlans = new HashSet<PersonCareerEducationPlan>();
            PersonCredentials = new HashSet<PersonCredential>();
            PersonDegreeOrCertificates = new HashSet<PersonDegreeOrCertificate>();
            PersonDemographicRaces = new HashSet<PersonDemographicRace>();
            PersonDetails = new HashSet<PersonDetail>();
            PersonDigitalAccesses = new HashSet<PersonDigitalAccess>();
            PersonDisabilities = new HashSet<PersonDisability>();
            PersonEmailAddresses = new HashSet<PersonEmailAddress>();
            PersonFamilies = new HashSet<PersonFamily>();
            PersonHealthBirths = new HashSet<PersonHealthBirth>();
            PersonHealths = new HashSet<PersonHealth>();
            PersonHomelessnesses = new HashSet<PersonHomelessness>();
            PersonIdentifiers = new HashSet<PersonIdentifier>();
            PersonImmunizations = new HashSet<PersonImmunization>();
            PersonLanguages = new HashSet<PersonLanguage>();
            PersonMilitaries = new HashSet<PersonMilitary>();
            PersonOtherNames = new HashSet<PersonOtherName>();
            PersonPersonalInformationVerifications = new HashSet<PersonPersonalInformationVerification>();
            PersonReferrals = new HashSet<PersonReferral>();
            PersonRelationshipPeople = new HashSet<PersonRelationship>();
            PersonRelationshipRelatedPeople = new HashSet<PersonRelationship>();
            PersonStatuses = new HashSet<PersonStatus>();
            PersonTelephones = new HashSet<PersonTelephone>();
            QuarterlyEmploymentRecords = new HashSet<QuarterlyEmploymentRecord>();
            RecordStatusHistories = new HashSet<RecordStatusHistory>();
            RecordStatuses = new HashSet<RecordStatus>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int PersonId { get; set; }
        public int? PersonMasterId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("People")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("People")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("AssignedByPerson")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrationAssignedByPeople { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrationPeople { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<AssessmentSessionStaffRole> AssessmentSessionStaffRoles { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<CredentialAward> CredentialAwards { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<CredentialDefAgent> CredentialDefAgents { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<ELChildDemographic> ElchildDemographics { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<ELChildDevelopmentalAssessment> ElchildDevelopmentalAssessments { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<ELChildHealth> ElchildHealths { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<ELChildIndividualizedProgram> ElchildIndividualizedPrograms { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<ELChildOutcomeSummary> ElchildOutcomeSummaries { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<ELChildTransitionPlan> ElchildTransitionPlans { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<ELEnrollmentOtherFunding> ElenrollmentOtherFundings { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<IncidentPerson> IncidentPeople { get; set; }
        [InverseProperty("IncidentReporter")]
        public virtual ICollection<Incident> Incidents { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<IndividualizedProgramService> IndividualizedProgramServices { get; set; }
        [InverseProperty("AssignedByPerson")]
        public virtual ICollection<LearnerActivity> LearnerActivityAssignedByPeople { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<LearnerActivity> LearnerActivityPeople { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<LearningResourcePeerRating> LearningResourcePeerRatings { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<OrganizationPersonRole> OrganizationPersonRoles { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonAllergy> PersonAllergies { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonAssessmentPersonalNeedsProfile> PersonAssessmentPersonalNeedsProfiles { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonBirthplace> PersonBirthplaces { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonCareerEducationPlan> PersonCareerEducationPlans { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonCredential> PersonCredentials { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonDegreeOrCertificate> PersonDegreeOrCertificates { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonDemographicRace> PersonDemographicRaces { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonDetail> PersonDetails { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonDigitalAccess> PersonDigitalAccesses { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonDisability> PersonDisabilities { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonEmailAddress> PersonEmailAddresses { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonFamily> PersonFamilies { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonHealthBirth> PersonHealthBirths { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonHealth> PersonHealths { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonHomelessness> PersonHomelessnesses { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonIdentifier> PersonIdentifiers { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonImmunization> PersonImmunizations { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonLanguage> PersonLanguages { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonMilitary> PersonMilitaries { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonOtherName> PersonOtherNames { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonPersonalInformationVerification> PersonPersonalInformationVerifications { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonReferral> PersonReferrals { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonRelationship> PersonRelationshipPeople { get; set; }
        [InverseProperty("RelatedPerson")]
        public virtual ICollection<PersonRelationship> PersonRelationshipRelatedPeople { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonStatus> PersonStatuses { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<PersonTelephone> PersonTelephones { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<QuarterlyEmploymentRecord> QuarterlyEmploymentRecords { get; set; }
        [InverseProperty("RecordStatusCreatorPerson")]
        public virtual ICollection<RecordStatusHistory> RecordStatusHistories { get; set; }
        [InverseProperty("RecordStatusCreatorPerson")]
        public virtual ICollection<RecordStatus> RecordStatuses { get; set; }
    }
}
