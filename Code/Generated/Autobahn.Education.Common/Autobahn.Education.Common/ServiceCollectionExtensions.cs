//**********************************************************
//* DomainName: Common Models
//* FileName:   Common.ServiceCollectionExtensions.cs
//**********************************************************

/// <summary>
/// The Service Collection Extensions for the Common Models domain
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Common Models Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddCommonServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IOrganizationAccreditation, OrganizationAccreditationViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendar, OrganizationCalendarViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendarCrisis, OrganizationCalendarCrisisViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendarDay, OrganizationCalendarDayViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendarEvent, OrganizationCalendarEventViewModel>();
        serviceCollection.AddTransient<IOrganizationCalendarSession, OrganizationCalendarSessionViewModel>();
        serviceCollection.AddTransient<IOrganizationDetail, OrganizationDetailViewModel>();
        serviceCollection.AddTransient<IOrganizationEmail, OrganizationEmailViewModel>();
        serviceCollection.AddTransient<IOrganizationEmployeeBenefit, OrganizationEmployeeBenefitViewModel>();
        serviceCollection.AddTransient<IOrganizationFederalAccountability, OrganizationFederalAccountabilityViewModel>();
        serviceCollection.AddTransient<IOrganizationFinancial, OrganizationFinancialViewModel>();
        serviceCollection.AddTransient<IOrganizationIdentifier, OrganizationIdentifierViewModel>();
        serviceCollection.AddTransient<IOrganizationImage, OrganizationImageViewModel>();
        serviceCollection.AddTransient<IOrganizationIndicator, OrganizationIndicatorViewModel>();
        serviceCollection.AddTransient<IOrganizationLocation, OrganizationLocationViewModel>();
        serviceCollection.AddTransient<IOrganizationOperationalStatus, OrganizationOperationalStatusViewModel>();
        serviceCollection.AddTransient<IOrganizationPersonRoleApplication, OrganizationPersonRoleApplicationViewModel>();
        serviceCollection.AddTransient<IOrganizationPersonRoleFte, OrganizationPersonRoleFteViewModel>();
        serviceCollection.AddTransient<IOrganizationPersonRoleRelationship, OrganizationPersonRoleRelationshipViewModel>();
        serviceCollection.AddTransient<IOrganizationPolicy, OrganizationPolicyViewModel>();
        serviceCollection.AddTransient<IOrganizationPopulationServed, OrganizationPopulationServedViewModel>();
        serviceCollection.AddTransient<IOrganizationProgramType, OrganizationProgramTypeViewModel>();
        serviceCollection.AddTransient<IOrganizationRelationship, OrganizationRelationshipViewModel>();
        serviceCollection.AddTransient<IOrganizationService, OrganizationServiceViewModel>();
        serviceCollection.AddTransient<IOrganizationTechnicalAssistance, OrganizationTechnicalAssistanceViewModel>();
        serviceCollection.AddTransient<IOrganizationTelephone, OrganizationTelephoneViewModel>();
        serviceCollection.AddTransient<IOrganizationWebsite, OrganizationWebsiteViewModel>();
        serviceCollection.AddTransient<IPersonAddress, PersonAddressViewModel>();
        serviceCollection.AddTransient<IPersonAddressNcesSide, PersonAddressNcesSideViewModel>();
        serviceCollection.AddTransient<IPersonAllergy, PersonAllergyViewModel>();
        serviceCollection.AddTransient<IPersonAssessmentPersonalNeedsProfile, PersonAssessmentPersonalNeedsProfileViewModel>();
        serviceCollection.AddTransient<IPersonBirthplace, PersonBirthplaceViewModel>();
        serviceCollection.AddTransient<IPersonCareerEducationPlan, PersonCareerEducationPlanViewModel>();
        serviceCollection.AddTransient<IPersonCredential, PersonCredentialViewModel>();
        serviceCollection.AddTransient<IPersonDegreeOrCertificate, PersonDegreeOrCertificateViewModel>();
        serviceCollection.AddTransient<IPersonDemographicRace, PersonDemographicRaceViewModel>();
        serviceCollection.AddTransient<IPersonDetail, PersonDetailViewModel>();
        serviceCollection.AddTransient<IPersonDigitalAccess, PersonDigitalAccessViewModel>();
        serviceCollection.AddTransient<IPersonDigitalAccessSpeed, PersonDigitalAccessSpeedViewModel>();
        serviceCollection.AddTransient<IPersonDisability, PersonDisabilityViewModel>();
        serviceCollection.AddTransient<IPersonEmailAddress, PersonEmailAddressViewModel>();
        serviceCollection.AddTransient<IPersonFamily, PersonFamilyViewModel>();
        serviceCollection.AddTransient<IPersonHealth, PersonHealthViewModel>();
        serviceCollection.AddTransient<IPersonHealthBirth, PersonHealthBirthViewModel>();
        serviceCollection.AddTransient<IPersonHomelessness, PersonHomelessnessViewModel>();
        serviceCollection.AddTransient<IPersonIdentifier, PersonIdentifierViewModel>();
        serviceCollection.AddTransient<IPersonImmunization, PersonImmunizationViewModel>();
        serviceCollection.AddTransient<IPersonLanguage, PersonLanguageViewModel>();
        serviceCollection.AddTransient<IPersonLearningDevice, PersonLearningDeviceViewModel>();
        serviceCollection.AddTransient<IPersonMaster, PersonMasterViewModel>();
        serviceCollection.AddTransient<IPersonMilitary, PersonMilitaryViewModel>();
        serviceCollection.AddTransient<IPersonOtherName, PersonOtherNameViewModel>();
        serviceCollection.AddTransient<IPersonPersonalInformationVerification, PersonPersonalInformationVerificationViewModel>();
        serviceCollection.AddTransient<IPersonProgramParticipation, PersonProgramParticipationViewModel>();
        serviceCollection.AddTransient<IPersonReferral, PersonReferralViewModel>();
        serviceCollection.AddTransient<IPersonRelationship, PersonRelationshipViewModel>();
        serviceCollection.AddTransient<IPersonStatus, PersonStatusViewModel>();
        serviceCollection.AddTransient<IPersonTelephone, PersonTelephoneViewModel>();
        serviceCollection.AddTransient<IRoleAttendance, RoleAttendanceViewModel>();
        serviceCollection.AddTransient<IRoleAttendanceEvent, RoleAttendanceEventViewModel>();
        serviceCollection.AddTransient<IRoleStatus, RoleStatusViewModel>();
        serviceCollection.AddTransient<IStaffCompensation, StaffCompensationViewModel>();
        serviceCollection.AddTransient<IStaffCredential, StaffCredentialViewModel>();
        serviceCollection.AddTransient<IStaffEmployment, StaffEmploymentViewModel>();
        serviceCollection.AddTransient<IStaffEvaluation, StaffEvaluationViewModel>();
        serviceCollection.AddTransient<IStaffEvaluationPart, StaffEvaluationPartViewModel>();
        serviceCollection.AddTransient<IStaffExperience, StaffExperienceViewModel>();
        serviceCollection.AddTransient<IStaffProfessionalDevelopmentActivity, StaffProfessionalDevelopmentActivityViewModel>();
        serviceCollection.AddTransient<IStaffTechnicalAssistance, StaffTechnicalAssistanceViewModel>();
        serviceCollection.AddTransient<ITeacherEducationCredentialExam, TeacherEducationCredentialExamViewModel>();
        serviceCollection.AddTransient<ITeacherStudentDataLinkExclusion, TeacherStudentDataLinkExclusionViewModel>();

        return serviceCollection;
    }
}
