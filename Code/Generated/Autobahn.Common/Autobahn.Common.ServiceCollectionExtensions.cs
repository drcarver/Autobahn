//**********************************************************
//* DomainName: Common Models
//* FileName:   Common.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Common.ViewModels;
using Autobahn.Common.Views;

/// <summary>
/// The Service Collection Extensions for the Common Models domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Common Models Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddCommonServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<Interfaces.IOrganization, OrganizationViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationAccreditation, OrganizationAccreditationViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationCalendar, OrganizationCalendarViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationCalendarCrisi, OrganizationCalendarCrisiViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationCalendarCrisis, OrganizationCalendarCrisisViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationCalendarDay, OrganizationCalendarDayViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationCalendarEvent, OrganizationCalendarEventViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationCalendarSession, OrganizationCalendarSessionViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationDetail, OrganizationDetailViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationEmail, OrganizationEmailViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationEmployeeBenefit, OrganizationEmployeeBenefitViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationFederalAccountability, OrganizationFederalAccountabilityViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationFinancial, OrganizationFinancialViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationIdentifier, OrganizationIdentifierViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationImage, OrganizationImageViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationIndicator, OrganizationIndicatorViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationLocation, OrganizationLocationViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationOperationalStatus, OrganizationOperationalStatusViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationPersonRole, OrganizationPersonRoleViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationPersonRoleApplication, OrganizationPersonRoleApplicationViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationPersonRoleFTE, OrganizationPersonRoleFTEViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationPersonRoleRelationship, OrganizationPersonRoleRelationshipViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationPolicy, OrganizationPolicyViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationPopulationServed, OrganizationPopulationServedViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationProgramType, OrganizationProgramTypeViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationRelationship, OrganizationRelationshipViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationService, OrganizationServiceViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationTechnicalAssistance, OrganizationTechnicalAssistanceViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationTelephone, OrganizationTelephoneViewModel>();
        serviceCollection.AddTransient<Interfaces.IOrganizationWebsite, OrganizationWebsiteViewModel>();
        serviceCollection.AddTransient<Interfaces.IPerson, PersonViewModel>();
        serviceCollection.AddTransient<Interfaces.IPerson_AssessmentPersonalNeedsProfile, Person_AssessmentPersonalNeedsProfileViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonAddress, PersonAddressViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonAddressNcesSide, PersonAddressNcesSideViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonAllergy, PersonAllergyViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonBirthplace, PersonBirthplaceViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonCareerEducationPlan, PersonCareerEducationPlanViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonCredential, PersonCredentialViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonDegreeOrCertificate, PersonDegreeOrCertificateViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonDemographicRace, PersonDemographicRaceViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonDetail, PersonDetailViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonDigitalAccess, PersonDigitalAccessViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonDigitalAccessSpeed, PersonDigitalAccessSpeedViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonDisability, PersonDisabilityViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonEmailAddress, PersonEmailAddressViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonFamily, PersonFamilyViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonHealth, PersonHealthViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonHealthBirth, PersonHealthBirthViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonHomelessness, PersonHomelessnessViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonIdentifier, PersonIdentifierViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonImmunization, PersonImmunizationViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonLanguage, PersonLanguageViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonLearningDevice, PersonLearningDeviceViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonMaster, PersonMasterViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonMilitary, PersonMilitaryViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonOtherName, PersonOtherNameViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonPersonalInformationVerification, PersonPersonalInformationVerificationViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonProgramParticipation, PersonProgramParticipationViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonReferral, PersonReferralViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonRelationship, PersonRelationshipViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonStatus, PersonStatusViewModel>();
        serviceCollection.AddTransient<Interfaces.IPersonTelephone, PersonTelephoneViewModel>();
        serviceCollection.AddTransient<Interfaces.IRole, RoleViewModel>();
        serviceCollection.AddTransient<Interfaces.IRoleAttendance, RoleAttendanceViewModel>();
        serviceCollection.AddTransient<Interfaces.IRoleAttendanceEvent, RoleAttendanceEventViewModel>();
        serviceCollection.AddTransient<Interfaces.IRoleStatus, RoleStatusViewModel>();
        serviceCollection.AddTransient<Interfaces.IStaffCompensation, StaffCompensationViewModel>();
        serviceCollection.AddTransient<Interfaces.IStaffCredential, StaffCredentialViewModel>();
        serviceCollection.AddTransient<Interfaces.IStaffEmployment, StaffEmploymentViewModel>();
        serviceCollection.AddTransient<Interfaces.IStaffEvaluation, StaffEvaluationViewModel>();
        serviceCollection.AddTransient<Interfaces.IStaffEvaluationPart, StaffEvaluationPartViewModel>();
        serviceCollection.AddTransient<Interfaces.IStaffExperience, StaffExperienceViewModel>();
        serviceCollection.AddTransient<Interfaces.IStaffProfessionalDevelopmentActivity, StaffProfessionalDevelopmentActivityViewModel>();
        serviceCollection.AddTransient<Interfaces.IStaffTechnicalAssistance, StaffTechnicalAssistanceViewModel>();
        serviceCollection.AddTransient<Interfaces.ITeacherEducationCredentialExam, TeacherEducationCredentialExamViewModel>();
        serviceCollection.AddTransient<Interfaces.ITeacherStudentDataLinkExclusion, TeacherStudentDataLinkExclusionViewModel>();

        // Now the known views
        serviceCollection.AddTransient<OrganizationView>();
        serviceCollection.AddTransient<OrganizationAccreditationView>();
        serviceCollection.AddTransient<OrganizationCalendarView>();
        serviceCollection.AddTransient<OrganizationCalendarCrisiView>();
        serviceCollection.AddTransient<OrganizationCalendarCrisisView>();
        serviceCollection.AddTransient<OrganizationCalendarDayView>();
        serviceCollection.AddTransient<OrganizationCalendarEventView>();
        serviceCollection.AddTransient<OrganizationCalendarSessionView>();
        serviceCollection.AddTransient<OrganizationDetailView>();
        serviceCollection.AddTransient<OrganizationEmailView>();
        serviceCollection.AddTransient<OrganizationEmployeeBenefitView>();
        serviceCollection.AddTransient<OrganizationFederalAccountabilityView>();
        serviceCollection.AddTransient<OrganizationFinancialView>();
        serviceCollection.AddTransient<OrganizationIdentifierView>();
        serviceCollection.AddTransient<OrganizationImageView>();
        serviceCollection.AddTransient<OrganizationIndicatorView>();
        serviceCollection.AddTransient<OrganizationLocationView>();
        serviceCollection.AddTransient<OrganizationOperationalStatusView>();
        serviceCollection.AddTransient<OrganizationPersonRoleView>();
        serviceCollection.AddTransient<OrganizationPersonRoleApplicationView>();
        serviceCollection.AddTransient<OrganizationPersonRoleFTEView>();
        serviceCollection.AddTransient<OrganizationPersonRoleRelationshipView>();
        serviceCollection.AddTransient<OrganizationPolicyView>();
        serviceCollection.AddTransient<OrganizationPopulationServedView>();
        serviceCollection.AddTransient<OrganizationProgramTypeView>();
        serviceCollection.AddTransient<OrganizationRelationshipView>();
        serviceCollection.AddTransient<OrganizationServiceView>();
        serviceCollection.AddTransient<OrganizationTechnicalAssistanceView>();
        serviceCollection.AddTransient<OrganizationTelephoneView>();
        serviceCollection.AddTransient<OrganizationWebsiteView>();
        serviceCollection.AddTransient<PersonView>();
        serviceCollection.AddTransient<Person_AssessmentPersonalNeedsProfileView>();
        serviceCollection.AddTransient<PersonAddressView>();
        serviceCollection.AddTransient<PersonAddressNcesSideView>();
        serviceCollection.AddTransient<PersonAllergyView>();
        serviceCollection.AddTransient<PersonBirthplaceView>();
        serviceCollection.AddTransient<PersonCareerEducationPlanView>();
        serviceCollection.AddTransient<PersonCredentialView>();
        serviceCollection.AddTransient<PersonDegreeOrCertificateView>();
        serviceCollection.AddTransient<PersonDemographicRaceView>();
        serviceCollection.AddTransient<PersonDetailView>();
        serviceCollection.AddTransient<PersonDigitalAccessView>();
        serviceCollection.AddTransient<PersonDigitalAccessSpeedView>();
        serviceCollection.AddTransient<PersonDisabilityView>();
        serviceCollection.AddTransient<PersonEmailAddressView>();
        serviceCollection.AddTransient<PersonFamilyView>();
        serviceCollection.AddTransient<PersonHealthView>();
        serviceCollection.AddTransient<PersonHealthBirthView>();
        serviceCollection.AddTransient<PersonHomelessnessView>();
        serviceCollection.AddTransient<PersonIdentifierView>();
        serviceCollection.AddTransient<PersonImmunizationView>();
        serviceCollection.AddTransient<PersonLanguageView>();
        serviceCollection.AddTransient<PersonLearningDeviceView>();
        serviceCollection.AddTransient<PersonMasterView>();
        serviceCollection.AddTransient<PersonMilitaryView>();
        serviceCollection.AddTransient<PersonOtherNameView>();
        serviceCollection.AddTransient<PersonPersonalInformationVerificationView>();
        serviceCollection.AddTransient<PersonProgramParticipationView>();
        serviceCollection.AddTransient<PersonReferralView>();
        serviceCollection.AddTransient<PersonRelationshipView>();
        serviceCollection.AddTransient<PersonStatusView>();
        serviceCollection.AddTransient<PersonTelephoneView>();
        serviceCollection.AddTransient<RoleView>();
        serviceCollection.AddTransient<RoleAttendanceView>();
        serviceCollection.AddTransient<RoleAttendanceEventView>();
        serviceCollection.AddTransient<RoleStatusView>();
        serviceCollection.AddTransient<StaffCompensationView>();
        serviceCollection.AddTransient<StaffCredentialView>();
        serviceCollection.AddTransient<StaffEmploymentView>();
        serviceCollection.AddTransient<StaffEvaluationView>();
        serviceCollection.AddTransient<StaffEvaluationPartView>();
        serviceCollection.AddTransient<StaffExperienceView>();
        serviceCollection.AddTransient<StaffProfessionalDevelopmentActivityView>();
        serviceCollection.AddTransient<StaffTechnicalAssistanceView>();
        serviceCollection.AddTransient<TeacherEducationCredentialExamView>();
        serviceCollection.AddTransient<TeacherStudentDataLinkExclusionView>();

        return serviceCollection;
    }
}
