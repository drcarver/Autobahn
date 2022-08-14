//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   Invalid.ServiceCollectionExtensions.cs
//**********************************************************

using Autobahn.Invalid.Interfaces;
using Autobahn.Invalid.ViewModels;
using Autobahn.Invalid.Views;

/// <summary>
/// The Service Collection Extensions for the Invalid or Unreferenced Models domain
/// </summary>
public static partial  class ServiceCollectionExtensions
{
    /// <summary>
    /// Known Invalid or Unreferenced Models Services to add to the services Collection
    /// </summary>
    public static IServiceCollection AddInvalidServices(this IServiceCollection serviceCollection)
    {
        // First the known view models
        serviceCollection.AddTransient<IActivity, ActivityViewModel>();
        serviceCollection.AddTransient<IActivityRecognition, ActivityRecognitionViewModel>();
        serviceCollection.AddTransient<IApipInteraction, ApipInteractionViewModel>();
        serviceCollection.AddTransient<IAutobahnDomain, AutobahnDomainViewModel>();
        serviceCollection.AddTransient<IAutobahnElement, AutobahnElementViewModel>();
        serviceCollection.AddTransient<IAutobahnTable, AutobahnTableViewModel>();
        serviceCollection.AddTransient<IC_CEDSElements, C_CEDSElementsViewModel>();
        serviceCollection.AddTransient<IC_CEDStoNDSMapping, C_CEDStoNDSMappingViewModel>();
        serviceCollection.AddTransient<IClassroom, ClassroomViewModel>();
        serviceCollection.AddTransient<ICoreKnowledgeArea, CoreKnowledgeAreaViewModel>();
        serviceCollection.AddTransient<ICourse, CourseViewModel>();
        serviceCollection.AddTransient<ICourseSection, CourseSectionViewModel>();
        serviceCollection.AddTransient<ICourseSectionAssessmentReporting, CourseSectionAssessmentReportingViewModel>();
        serviceCollection.AddTransient<ICourseSectionLevel, CourseSectionLevelViewModel>();
        serviceCollection.AddTransient<ICourseSectionLocation, CourseSectionLocationViewModel>();
        serviceCollection.AddTransient<ICourseSectionSchedule, CourseSectionScheduleViewModel>();
        serviceCollection.AddTransient<IDataCollection, DataCollectionViewModel>();
        serviceCollection.AddTransient<IEligibilityEvaluation, EligibilityEvaluationViewModel>();
        serviceCollection.AddTransient<IFinancialAccount, FinancialAccountViewModel>();
        serviceCollection.AddTransient<IFinancialAccountProgram, FinancialAccountProgramViewModel>();
        serviceCollection.AddTransient<IFinancialAidApplication, FinancialAidApplicationViewModel>();
        serviceCollection.AddTransient<IFinancialAidAward, FinancialAidAwardViewModel>();
        serviceCollection.AddTransient<IIDEAEligibilityEvaluationCategory, IDEAEligibilityEvaluationCategoryViewModel>();
        serviceCollection.AddTransient<IIDSVersion, IDSVersionViewModel>();
        serviceCollection.AddTransient<IIEPAuthorization, IEPAuthorizationViewModel>();
        serviceCollection.AddTransient<IIEPAuthorizationRejected, IEPAuthorizationRejectedViewModel>();
        serviceCollection.AddTransient<IIEPPresentLevel, IEPPresentLevelViewModel>();
        serviceCollection.AddTransient<IIncident, IncidentViewModel>();
        serviceCollection.AddTransient<IIncidentPerson, IncidentPersonViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgram, IndividualizedProgramViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramAccommodation, IndividualizedProgramAccommodationViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramAccommodationSubject, IndividualizedProgramAccommodationSubjectViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramAmendment, IndividualizedProgramAmendmentViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramAssessment, IndividualizedProgramAssessmentViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramAssessmentAccommodation, IndividualizedProgramAssessmentAccommodationViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramEligibility, IndividualizedProgramEligibilityViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramEligibilityEvaluation, IndividualizedProgramEligibilityEvaluationViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramGoal, IndividualizedProgramGoalViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramMeeting, IndividualizedProgramMeetingViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramMeetingAttendee, IndividualizedProgramMeetingAttendeeViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramProgressGoal, IndividualizedProgramProgressGoalViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramProgressReport, IndividualizedProgramProgressReportViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramProgressReportPlan, IndividualizedProgramProgressReportPlanViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramService, IndividualizedProgramServiceViewModel>();
        serviceCollection.AddTransient<IIndividualizedProgramServicesReceived, IndividualizedProgramServicesReceivedViewModel>();
        serviceCollection.AddTransient<ILocation, LocationViewModel>();
        serviceCollection.AddTransient<ILocationAddress, LocationAddressViewModel>();
        serviceCollection.AddTransient<IPDActivityEducationLevel, PDActivityEducationLevelViewModel>();
        serviceCollection.AddTransient<IProfessionalDevelopmentActivity, ProfessionalDevelopmentActivityViewModel>();
        serviceCollection.AddTransient<IProfessionalDevelopmentRequirement, ProfessionalDevelopmentRequirementViewModel>();
        serviceCollection.AddTransient<IProfessionalDevelopmentSession, ProfessionalDevelopmentSessionViewModel>();
        serviceCollection.AddTransient<IProfessionalDevelopmentSessionInstructor, ProfessionalDevelopmentSessionInstructorViewModel>();
        serviceCollection.AddTransient<IProgram, ProgramViewModel>();
        serviceCollection.AddTransient<IProgramParticipationAttainment, ProgramParticipationAttainmentViewModel>();
        serviceCollection.AddTransient<IProgramParticipationFoodService, ProgramParticipationFoodServiceViewModel>();
        serviceCollection.AddTransient<IProgramParticipationMigrant, ProgramParticipationMigrantViewModel>();
        serviceCollection.AddTransient<IProgramParticipationNeglected, ProgramParticipationNeglectedViewModel>();
        serviceCollection.AddTransient<IProgramParticipationSpecialEducation, ProgramParticipationSpecialEducationViewModel>();
        serviceCollection.AddTransient<IProgramParticipationTeacherPrep, ProgramParticipationTeacherPrepViewModel>();
        serviceCollection.AddTransient<IProgramParticipationTitleI, ProgramParticipationTitleIViewModel>();
        serviceCollection.AddTransient<IProgramParticipationTitleIIILep, ProgramParticipationTitleIIILepViewModel>();
        serviceCollection.AddTransient<IProgramParticipationWIOA, ProgramParticipationWIOAViewModel>();
        serviceCollection.AddTransient<IProgramParticipationWIOABarriers, ProgramParticipationWIOABarriersViewModel>();
        serviceCollection.AddTransient<IQuarterlyEmploymentRecord, QuarterlyEmploymentRecordViewModel>();
        serviceCollection.AddTransient<IRecordStatus, RecordStatusViewModel>();
        serviceCollection.AddTransient<IRecordStatusHistory, RecordStatusHistoryViewModel>();
        serviceCollection.AddTransient<IRequiredImmunization, RequiredImmunizationViewModel>();
        serviceCollection.AddTransient<IServiceFrequency, ServiceFrequencyViewModel>();
        serviceCollection.AddTransient<IServicePlan, ServicePlanViewModel>();
        serviceCollection.AddTransient<IServiceProvided, ServiceProvidedViewModel>();
        serviceCollection.AddTransient<IServiceProvider, ServiceProviderViewModel>();
        serviceCollection.AddTransient<IServicesReceived, ServicesReceivedViewModel>();
        serviceCollection.AddTransient<IServiceStaff, ServiceStaffViewModel>();

        // Now the known views
        serviceCollection.AddTransient<ActivityView>();
        serviceCollection.AddTransient<ActivityRecognitionView>();
        serviceCollection.AddTransient<ApipInteractionView>();
        serviceCollection.AddTransient<AutobahnDomainView>();
        serviceCollection.AddTransient<AutobahnElementView>();
        serviceCollection.AddTransient<AutobahnTableView>();
        serviceCollection.AddTransient<C_CEDSElementsView>();
        serviceCollection.AddTransient<C_CEDStoNDSMappingView>();
        serviceCollection.AddTransient<ClassroomView>();
        serviceCollection.AddTransient<CoreKnowledgeAreaView>();
        serviceCollection.AddTransient<CourseView>();
        serviceCollection.AddTransient<CourseSectionView>();
        serviceCollection.AddTransient<CourseSectionAssessmentReportingView>();
        serviceCollection.AddTransient<CourseSectionLevelView>();
        serviceCollection.AddTransient<CourseSectionLocationView>();
        serviceCollection.AddTransient<CourseSectionScheduleView>();
        serviceCollection.AddTransient<DataCollectionView>();
        serviceCollection.AddTransient<EligibilityEvaluationView>();
        serviceCollection.AddTransient<FinancialAccountView>();
        serviceCollection.AddTransient<FinancialAccountProgramView>();
        serviceCollection.AddTransient<FinancialAidApplicationView>();
        serviceCollection.AddTransient<FinancialAidAwardView>();
        serviceCollection.AddTransient<IDEAEligibilityEvaluationCategoryView>();
        serviceCollection.AddTransient<IDSVersionView>();
        serviceCollection.AddTransient<IEPAuthorizationView>();
        serviceCollection.AddTransient<IEPAuthorizationRejectedView>();
        serviceCollection.AddTransient<IEPPresentLevelView>();
        serviceCollection.AddTransient<IncidentView>();
        serviceCollection.AddTransient<IncidentPersonView>();
        serviceCollection.AddTransient<IndividualizedProgramView>();
        serviceCollection.AddTransient<IndividualizedProgramAccommodationView>();
        serviceCollection.AddTransient<IndividualizedProgramAccommodationSubjectView>();
        serviceCollection.AddTransient<IndividualizedProgramAmendmentView>();
        serviceCollection.AddTransient<IndividualizedProgramAssessmentView>();
        serviceCollection.AddTransient<IndividualizedProgramAssessmentAccommodationView>();
        serviceCollection.AddTransient<IndividualizedProgramEligibilityView>();
        serviceCollection.AddTransient<IndividualizedProgramEligibilityEvaluationView>();
        serviceCollection.AddTransient<IndividualizedProgramGoalView>();
        serviceCollection.AddTransient<IndividualizedProgramMeetingView>();
        serviceCollection.AddTransient<IndividualizedProgramMeetingAttendeeView>();
        serviceCollection.AddTransient<IndividualizedProgramProgressGoalView>();
        serviceCollection.AddTransient<IndividualizedProgramProgressReportView>();
        serviceCollection.AddTransient<IndividualizedProgramProgressReportPlanView>();
        serviceCollection.AddTransient<IndividualizedProgramServiceView>();
        serviceCollection.AddTransient<IndividualizedProgramServicesReceivedView>();
        serviceCollection.AddTransient<LocationView>();
        serviceCollection.AddTransient<LocationAddressView>();
        serviceCollection.AddTransient<PDActivityEducationLevelView>();
        serviceCollection.AddTransient<ProfessionalDevelopmentActivityView>();
        serviceCollection.AddTransient<ProfessionalDevelopmentRequirementView>();
        serviceCollection.AddTransient<ProfessionalDevelopmentSessionView>();
        serviceCollection.AddTransient<ProfessionalDevelopmentSessionInstructorView>();
        serviceCollection.AddTransient<ProgramView>();
        serviceCollection.AddTransient<ProgramParticipationAttainmentView>();
        serviceCollection.AddTransient<ProgramParticipationFoodServiceView>();
        serviceCollection.AddTransient<ProgramParticipationMigrantView>();
        serviceCollection.AddTransient<ProgramParticipationNeglectedView>();
        serviceCollection.AddTransient<ProgramParticipationSpecialEducationView>();
        serviceCollection.AddTransient<ProgramParticipationTeacherPrepView>();
        serviceCollection.AddTransient<ProgramParticipationTitleIView>();
        serviceCollection.AddTransient<ProgramParticipationTitleIIILepView>();
        serviceCollection.AddTransient<ProgramParticipationWIOAView>();
        serviceCollection.AddTransient<ProgramParticipationWIOABarriersView>();
        serviceCollection.AddTransient<QuarterlyEmploymentRecordView>();
        serviceCollection.AddTransient<RecordStatusView>();
        serviceCollection.AddTransient<RecordStatusHistoryView>();
        serviceCollection.AddTransient<RequiredImmunizationView>();
        serviceCollection.AddTransient<ServiceFrequencyView>();
        serviceCollection.AddTransient<ServicePlanView>();
        serviceCollection.AddTransient<ServiceProvidedView>();
        serviceCollection.AddTransient<ServiceProviderView>();
        serviceCollection.AddTransient<ServicesReceivedView>();
        serviceCollection.AddTransient<ServiceStaffView>();

        return serviceCollection;
    }
}
