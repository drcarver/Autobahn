//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Person.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("Person")]
    public partial class Person : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            //    AssessmentRegistrations = new HashSet<AssessmentRegistration>();
            //    AssessmentRegistrations1 = new HashSet<AssessmentRegistration>();
            //    AssessmentSessionStaffRoles = new HashSet<AssessmentSessionStaffRole>();
            //    CredentialAwards = new HashSet<CredentialAward>();
            //    CredentialDefAgents = new HashSet<CredentialDefAgent>();
            //    ELChildDemographics = new HashSet<ELChildDemographic>();
            //    ELChildDevelopmentalAssessments = new HashSet<ELChildDevelopmentalAssessment>();
            //    ELChildHealths = new HashSet<ELChildHealth>();
            //    ELChildIndividualizedPrograms = new HashSet<ELChildIndividualizedProgram>();
            //    ELChildOutcomeSummaries = new HashSet<ELChildOutcomeSummary>();
            //    ELChildTransitionPlans = new HashSet<ELChildTransitionPlan>();
            //    ELEnrollmentOtherFundings = new HashSet<ELEnrollmentOtherFunding>();
            //    Incidents = new HashSet<Incident>();
            //    IncidentPersons = new HashSet<IncidentPerson>();
            //    IndividualizedProgramServices = new HashSet<IndividualizedProgramService>();
            //    LearnerActivities = new HashSet<LearnerActivity>();
            //    LearnerActivities1 = new HashSet<LearnerActivity>();
            //    LearningResourcePeerRatings = new HashSet<LearningResourcePeerRating>();
            OrganizationPersonRoles = new HashSet<OrganizationPersonRole>();
            //    PersonHomelessnesses = new HashSet<PersonHomelessness>();
            //    Person_AssessmentPersonalNeedsProfile = new HashSet<PersonAssessmentPersonalNeedsProfile>();
            //    PersonEmailAddresses = new HashSet<PersonEmailAddress>();
            //    PersonAddresses = new HashSet<PersonAddress>();
            //    PersonAllergies = new HashSet<PersonAllergy>();
            //    PersonBirthplaces = new HashSet<PersonBirthplace>();
            //    PersonCareerEducationPlans = new HashSet<PersonCareerEducationPlan>();
            //    PersonCredentials = new HashSet<PersonCredential>();
            //    PersonDegreeOrCertificates = new HashSet<PersonDegreeOrCertificate>();
            //    PersonDemographicRaces = new HashSet<PersonDemographicRace>();
            //    PersonDetails = new HashSet<PersonDetail>();
            //    PersonDigitalAccesses = new HashSet<PersonDigitalAccess>();
            //    PersonDisabilities = new HashSet<PersonDisability>();
            //    PersonFamilies = new HashSet<PersonFamily>();
            //    PersonHealths = new HashSet<PersonHealth>();
            //    PersonHealthBirths = new HashSet<PersonHealthBirth>();
            //    PersonIdentifiers = new HashSet<PersonIdentifier>();
            //    PersonImmunizations = new HashSet<PersonImmunization>();
            //    PersonLanguages = new HashSet<PersonLanguage>();
            //    PersonMilitaries = new HashSet<PersonMilitary>();
            //    PersonOtherNames = new HashSet<PersonOtherName>();
            //    PersonPersonalInformationVerifications = new HashSet<PersonPersonalInformationVerification>();
            //    PersonTelephones = new HashSet<PersonTelephone>();
            //    PersonReferrals = new HashSet<PersonReferral>();
            //    PersonRelationships = new HashSet<PersonRelationship>();
            //    PersonRelationships1 = new HashSet<PersonRelationship>();
            //    PersonStatus = new HashSet<PersonStatus>();
            //    QuarterlyEmploymentRecords = new HashSet<QuarterlyEmploymentRecord>();
            //    RecordStatuses = new HashSet<RecordStatus>();
            //    RecordStatusHistories = new HashSet<RecordStatusHistory>();
        }

        public int? PersonMasterId { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AssessmentRegistration> AssessmentRegistrations { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AssessmentRegistration> AssessmentRegistrations1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AssessmentSessionStaffRole> AssessmentSessionStaffRoles { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CredentialAward> CredentialAwards { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CredentialDefAgent> CredentialDefAgents { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ELChildDemographic> ELChildDemographics { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ELChildDevelopmentalAssessment> ELChildDevelopmentalAssessments { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ELChildHealth> ELChildHealths { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ELChildIndividualizedProgram> ELChildIndividualizedPrograms { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ELChildOutcomeSummary> ELChildOutcomeSummaries { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ELChildTransitionPlan> ELChildTransitionPlans { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ELEnrollmentOtherFunding> ELEnrollmentOtherFundings { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Incident> Incidents { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<IncidentPerson> IncidentPersons { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<IndividualizedProgramService> IndividualizedProgramServices { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<LearnerActivity> LearnerActivities { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<LearnerActivity> LearnerActivities1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<LearningResourcePeerRating> LearningResourcePeerRatings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationPersonRole> OrganizationPersonRoles { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonHomelessness> PersonHomelessnesses { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonAssessmentPersonalNeedsProfile> Person_AssessmentPersonalNeedsProfile { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonEmailAddress> PersonEmailAddresses { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonAddress> PersonAddresses { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonAllergy> PersonAllergies { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonBirthplace> PersonBirthplaces { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonCareerEducationPlan> PersonCareerEducationPlans { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonCredential> PersonCredentials { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonDegreeOrCertificate> PersonDegreeOrCertificates { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonDemographicRace> PersonDemographicRaces { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonDetail> PersonDetails { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonDigitalAccess> PersonDigitalAccesses { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonDisability> PersonDisabilities { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonFamily> PersonFamilies { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonHealth> PersonHealths { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonHealthBirth> PersonHealthBirths { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonIdentifier> PersonIdentifiers { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonImmunization> PersonImmunizations { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonLanguage> PersonLanguages { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonMilitary> PersonMilitaries { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonOtherName> PersonOtherNames { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonPersonalInformationVerification> PersonPersonalInformationVerifications { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonTelephone> PersonTelephones { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonReferral> PersonReferrals { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonRelationship> PersonRelationships { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonRelationship> PersonRelationships1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonStatus> PersonStatus { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<QuarterlyEmploymentRecord> QuarterlyEmploymentRecords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecordStatus> RecordStatuses { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<RecordStatusHistory> RecordStatusHistories { get; set; }
    }
}
