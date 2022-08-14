//**********************************************************
//* DomainName: Common Models
//* FileName:   Common.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Common.Interfaces;
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
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganization, OrganizationViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationAccreditation, OrganizationAccreditationViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationCalendar, OrganizationCalendarViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationCalendarCrisis, OrganizationCalendarCrisisViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationCalendarDay, OrganizationCalendarDayViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationCalendarEvent, OrganizationCalendarEventViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationCalendarSession, OrganizationCalendarSessionViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationDetail, OrganizationDetailViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationEmail, OrganizationEmailViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationEmployeeBenefit, OrganizationEmployeeBenefitViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationFederalAccountability, OrganizationFederalAccountabilityViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationFinancial, OrganizationFinancialViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationIdentifier, OrganizationIdentifierViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationImage, OrganizationImageViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationIndicator, OrganizationIndicatorViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationLocation, OrganizationLocationViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationOperationalStatus, OrganizationOperationalStatusViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationPersonRole, OrganizationPersonRoleViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationPersonRoleApplication, OrganizationPersonRoleApplicationViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationPersonRoleFTE, OrganizationPersonRoleFTEViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationPersonRoleRelationship, OrganizationPersonRoleRelationshipViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationPolicy, OrganizationPolicyViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationPopulationServed, OrganizationPopulationServedViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationProgramType, OrganizationProgramTypeViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationRelationship, OrganizationRelationshipViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationService, OrganizationServiceViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationTechnicalAssistance, OrganizationTechnicalAssistanceViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationTelephone, OrganizationTelephoneViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IOrganizationWebsite, OrganizationWebsiteViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPerson, PersonViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonAddress, PersonAddressViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonAddressNcesSide, PersonAddressNcesSideViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonAllergy, PersonAllergyViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonAssessmentPersonalNeedsProfile, PersonAssessmentPersonalNeedsProfileViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonBirthplace, PersonBirthplaceViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonCareerEducationPlan, PersonCareerEducationPlanViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonCredential, PersonCredentialViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonDegreeOrCertificate, PersonDegreeOrCertificateViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonDemographicRace, PersonDemographicRaceViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonDetail, PersonDetailViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonDigitalAccess, PersonDigitalAccessViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonDigitalAccessSpeed, PersonDigitalAccessSpeedViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonDisability, PersonDisabilityViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonEmailAddress, PersonEmailAddressViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonFamily, PersonFamilyViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonHealth, PersonHealthViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonHealthBirth, PersonHealthBirthViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonHomelessness, PersonHomelessnessViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonIdentifier, PersonIdentifierViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonImmunization, PersonImmunizationViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonLanguage, PersonLanguageViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonLearningDevice, PersonLearningDeviceViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonMaster, PersonMasterViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonMilitary, PersonMilitaryViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonOtherName, PersonOtherNameViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonPersonalInformationVerification, PersonPersonalInformationVerificationViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonProgramParticipation, PersonProgramParticipationViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonReferral, PersonReferralViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonRelationship, PersonRelationshipViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonStatus, PersonStatusViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IPersonTelephone, PersonTelephoneViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IRole, RoleViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IRoleAttendance, RoleAttendanceViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IRoleAttendanceEvent, RoleAttendanceEventViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IRoleStatus, RoleStatusViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IStaffCompensation, StaffCompensationViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IStaffCredential, StaffCredentialViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IStaffEmployment, StaffEmploymentViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IStaffEvaluation, StaffEvaluationViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IStaffEvaluationPart, StaffEvaluationPartViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IStaffExperience, StaffExperienceViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IStaffProfessionalDevelopmentActivity, StaffProfessionalDevelopmentActivityViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.IStaffTechnicalAssistance, StaffTechnicalAssistanceViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.ITeacherEducationCredentialExam, TeacherEducationCredentialExamViewModel>();
        serviceCollection.AddTransient<Autobahn.Common.Interfaces.ITeacherStudentDataLinkExclusion, TeacherStudentDataLinkExclusionViewModel>();

        // Now the known views
        serviceCollection.AddTransient<OrganizationView>();
        serviceCollection.AddTransient<OrganizationAccreditationView>();
        serviceCollection.AddTransient<OrganizationCalendarView>();
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
        serviceCollection.AddTransient<PersonAddressView>();
        serviceCollection.AddTransient<PersonAddressNcesSideView>();
        serviceCollection.AddTransient<PersonAllergyView>();
        serviceCollection.AddTransient<PersonAssessmentPersonalNeedsProfileView>();
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
