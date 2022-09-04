using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Autobahn.Codegen.Models
{
    internal class AutobahnProperty
    {
        /// <summary>
        /// No equivalent type yet (like in schema.org)
        /// </summary>
        public AutobahnProperty()
        {
            Attributes = new PropertyAttributes();
        }

        /// <summary>
        /// Initialize from a PropertyInfo when going through 
        /// a set of Types
        /// </summary>
        /// <param name="property">The property Info</param>
        public AutobahnProperty(PropertyInfo property)
        {
            Attributes = new(property);
            Name = property.Name;
            Property = property;
            IsVirtual = property.GetAccessors()[0].IsVirtual;
            if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                IsNullable = true;
                if (property.Name.EndsWith("Id"))
                {
                    // If it is NULLABLE, then get the underlying type. eg if "Nullable<int>" then this will return just "int"
                    PropertyType = $"Guid?";
                    VirtualType = $"{property.Name.Replace("Id", string.Empty)}";
                }
                else
                {
                    // If it is NULLABLE, then get the underlying type. eg if "Nullable<int>" then this will return just "int"
                    PropertyType = $"{property.PropertyType.GetGenericArguments()[0].Name}?";
                    VirtualType = $"{property.PropertyType.GetGenericArguments()[0].Name}";
                }
            }
            else
            {
                Attributes.RequiredAttribute = new RequiredAttribute();
                if (property.Name.EndsWith("Id"))
                {
                    PropertyType = "Guid";
                    VirtualType = property.Name.Replace("Id", string.Empty);
                }
                else
                {
                    PropertyType = property.PropertyType.ToString();
                    VirtualType = property.PropertyType.ToString();
                }
            } 
            NeedsValidation = Attributes.MaxLengthAttribute != null
                           || Attributes.RequiredAttribute != null
                           || Attributes.StringLengthAttribute != null;
            MapFKeyVirtualType();
        }
        internal PropertyAttributes Attributes { get; set; }
        internal string Name { get; set; }
        internal PropertyInfo Property { get; set; }
        internal string PropertyType { get; set; }
        internal bool NeedsValidation { get; set; }
        internal AutobahnElement? AutobahnElement { get; set; }
        internal bool IsVirtual { get; set; } = false;
        internal string VirtualType { get; set; }
        internal bool IsNullable { get; set; }

        internal void MapFKeyVirtualType()
        {
            if (!Name.EndsWith("Id"))
            {
                return; 
            }
            switch (Name.Replace("Id", string.Empty))
            {
                case "RefAssessmentLanguage":
                case "RefKeywordTranslationLanguage":
                case "KeywordTranslationLanguageType":
                case "ItemTranslationDisplayLanguageType":
                case "RefAssessmentNeedsProfileContentLanguageLearnerType":
                case "RefKeywordTranslationsLanguage":
                case "RefInstructionLanguage":
                    VirtualType = "RefLanguage";
                    break;
                case "RefMaternalEducationLevel":
                case "RefPaternalEducationLevel":
                    VirtualType = "RefEducationLevel";
                    break;
                case "RefGradeLevelWhenCourseTaken":
                case "RefGradeLevelWhenAssessed":
                case "RefGradeLevelToBeAssessed":
                case "RefEntryGradeLevel":
                case "RefExitGradeLevel":
                case "RefGrade":
                    VirtualType = "RefGradeLevel";
                    break;
                case "RefProfessionalTechnicalCredentialType":
                    VirtualType = "RefProfessionalTechnicalCredentialType";
                    break;
                case "ChildOfFormSection":
                    VirtualType = "AssessmentFormSection";
                    break;
                case "AssignedByPerson":
                case "RelatedPerson":
                case "RecordStatusCreatorPerson":
                    VirtualType = "Person";
                    break;
                case "SchoolOrganization":
                case "LeaOrganization":
                case "ParentOrganization":
                case "RecordStatusCreatorOrganization":
                    VirtualType = "Organization";
                    break;
                case "ChildOfAssessmentSubtest":
                    VirtualType = "AssessmentSubtest";
                    break;
                case "CredentialAward":
                    VirtualType = "CredentialAward";
                    break;
            }
        }

    //[Obsolete("The RefLearnerActivityMaximumTimeAllowedUnits property is obsolete and will be removed in a later version")] C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Assessments\Autobahn.Education.Assessments\Entities\RefLearnerActivityMaximumTimeAllowedUnitEntity.g.cs	17	5
    //[Obsolete("The RefAssessmentTypeChildrenWithDisabilities property is obsolete and will be removed in a later version")] C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\AssessmentEntity.g.cs	147	5
    //[Obsolete("The RefAssessmentSubtestentifierType property is obsolete and will be removed in a later version")] C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\AssessmentSubtestEntity.g.cs	156	5
    //[Obsolete("The CompetencyDefParent property is obsolete and will be removed in a later version")] C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\CompetencyDefinitionEntity.g.cs	44	5
    //[Obsolete("The ChildOfCompetencyDefinition property is obsolete and will be removed in a later version")] C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\CompetencyDefinitionEntity.g.cs	16	5
    //[Obsolete("The RefCompletionCriteria property is obsolete and will be removed in a later version")] C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\CompetencySetEntity.g.cs	36	5
    //[Obsolete("The RefCourseLevelCharacteristics property is obsolete and will be removed in a later version")] C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\CourseEntity.g.cs	93	5
    //[Obsolete("The RefeapartCeligibilityCategory property is obsolete and will be removed in a later version")] C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ElchildIndividualizedProgramEntity.g.cs	36	5
    //[Obsolete("The Refeaiepstatus property is obsolete and will be removed in a later version")] C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ElchildIndividualizedProgramEntity.g.cs	29	5
    //[Obsolete("The RefEarlyChildhoodServicesReceived property is obsolete and will be removed in a later version")] C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ElchildServiceEntity.g.cs	36	5
    //[Obsolete("The RefEarlyChildhoodServicesOffered property is obsolete and will be removed in a later version")] C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ElchildServiceEntity.g.cs	29	5
    //[Obsolete("The RefElotherFederalFundingSources property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ElenrollmentOtherFundingEntity.g.cs	24	5
    //[Obsolete("The RefElotherFederalFundingSources property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ElorganizationFundEntity.g.cs	49	5
    //[Obsolete("The ElorganizationFunds property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ElorganizationFundEntity.g.cs	17	5
    //[Obsolete("The RefOrganizationMonitoringNotifications property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ElorganizationMonitoringEntity.g.cs	23	5
    //[Obsolete("The RefFinancialAidStatus property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\FinancialAidAwardEntity.g.cs	68	5
    //[Obsolete("The RefeaeligibilityEvaluationCategory property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\IdeaeligibilityEvaluationCategoryEntity.g.cs	24	5
    //[Obsolete("The AuthorizationDocument property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\IepauthorizationEntity.g.cs	17	5
    //[Obsolete("The IncidentReporter property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\IncidentEntity.g.cs	75	5
    //[Obsolete("The RefIpedsintercollegiateAthleticsExpenses property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\IpedsfinanceEntity.g.cs	84	5
    //[Obsolete("The RefIpedsfasbpellGrantTransactions property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\IpedsfinanceEntity.g.cs	35	5
    //[Obsolete("The RefCourseGpaapplicability property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\K12studentCourseSectionEntity.g.cs	43	5
    //[Obsolete("The RefProficiencyTargetStatusMath property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\OrganizationFederalAccountabilityEntity.g.cs	258	5
    //[Obsolete("The RefParticipationStatusRla property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\OrganizationFederalAccountabilityEntity.g.cs	244	5
    //[Obsolete("The RefParticipationStatusMath property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\OrganizationFederalAccountabilityEntity.g.cs	230	5
    //[Obsolete("The RefOrganizationentifierType property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\OrganizationIdentifierEntity.g.cs	57	5
    //[Obsolete("The RefOrganizationentificationSystem property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\OrganizationIdentifierEntity.g.cs	43	5
    //[Obsolete("The RefIssuingState property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\PersonCredentialEntity.g.cs	108	5
    //[Obsolete("The RefStateOfResidence property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\PersonDetailEntity.g.cs	177	5
    //[Obsolete("The RefHighestEducationLevelCompleted property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\PersonDetailEntity.g.cs	137	5
    //[Obsolete("The RefeadisabilityType property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\PersonDisabilityEntity.g.cs	101	5
    //[Obsolete("The PrimaryDisabilityType property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\PersonDisabilityEntity.g.cs	41	5
    //[Obsolete("The RefHighestEducationLevelCompleted property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\PersonFamilyEntity.g.cs	135	5
    //[Obsolete("The RefPersonentificationSystem property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\PersonIdentifierEntity.g.cs	57	5
    //[Obsolete("The RefQualifyingMoveFromState property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ProgramParticipationMigrantEntity.g.cs	210	5
    //[Obsolete("The RefQualifyingMoveFromCountry property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ProgramParticipationMigrantEntity.g.cs	196	5
    //[Obsolete("The RefContinuationOfServicesReason property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ProgramParticipationMigrantEntity.g.cs	143	5
    //[Obsolete("The DesignatedGraduationSchool property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ProgramParticipationMigrantEntity.g.cs	48	5
    //[Obsolete("The RefeaeducationalEnvironmentSchoolAge property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ProgramParticipationSpecialEducationEntity.g.cs	30	5
    //[Obsolete("The ProgramParticipationTitleIiiLep property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ProgramParticipationTitleIiilepEntity.g.cs	24	5
    //[Obsolete("The ProgramParticipationWioabarriers property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ProgramParticipationWioabarrierEntity.g.cs	17	5
    //[Obsolete("The Record property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RecordStatusHistoryEntity.g.cs	17	5
    //[Obsolete("The RefApipinteractionType property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefApipInteractionTypeEntity.g.cs	26	5
    //[Obsolete("The RefContinuationOfServicesReason property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefContinuationOfServiceEntity.g.cs	17	5
    //[Obsolete("The RefCorrectiveAction property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefCorrectiveActionTypeEntity.g.cs	26	5
    //[Obsolete("The RefCourseGpaapplicability property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefCourseGpaApplicabilityEntity.g.cs	26	5
    //[Obsolete("The RefDisciplineMethodFirearms property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefDisciplineMethodFirearmEntity.g.cs	17	5
    //[Obsolete("The RefElotherFederalFundingSources property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefElotherFederalFundingSourceEntity.g.cs	17	5
    //[Obsolete("The RefFinancialBalanceSheetAccountCode property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefFinancialAccountBalanceSheetCodeEntity.g.cs	26	5
    //[Obsolete("The RefFinancialAidStatus property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefFinancialAidAwardStatusEntity.g.cs	26	5
    //[Obsolete("The RefInstructionalActivityHours property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefInstructionalActivityHourEntity.g.cs	17	5
    //[Obsolete("The RefIpedsfasbpellGrantTransactions property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefIpedsfasbpellGrantTransactionEntity.g.cs	17	5
    //[Obsolete("The RefIpedsintercollegiateAthleticsExpenses property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefIpedsintercollegiateAthleticsExpenseEntity.g.cs	17	5
    //[Obsolete("The RefOrganizationentifierType property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefOrganizationIdentificationSystemEntity.g.cs	25	5
    //[Obsolete("The RefOrganizationMonitoringNotifications property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefOrganizationMonitoringNotificationEntity.g.cs	17	5
    //[Obsolete("The RefPersonentifierType property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefPersonIdentificationSystemEntity.g.cs	25	5
    //[Obsolete("The RefSchoolImprovementFunds property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefSchoolImprovementFundEntity.g.cs	17	5
    //[Obsolete("The RefServices property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefServiceEntity.g.cs	17	5
    //[Obsolete("The RefTimeForCompletionUnits property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefTimeForCompletionUnitEntity.g.cs	17	5
    //[Obsolete("The RefTitleIinstructionalServices property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\RefTitleIinstructionalServiceEntity.g.cs	17	5
    //[Obsolete("The RefServices property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\ServiceProvidedEntity.g.cs	22	5
    //[Obsolete("The RefChildDevAssociateType property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Common\Autobahn.Education.Common\Entities\StaffCredentialEntity.g.cs	82	5
    //[Obsolete("The AssociatedEntity property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Competencies\Autobahn.Education.Competencies\Entities\CompetencyDefAssociationEntity.g.cs	23	5
    //[Obsolete("The RefCompetencySetCompletionCriteria property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Competencies\Autobahn.Education.Competencies\Entities\RefCompetencySetCompletionCriterionEntity.g.cs	17	5
    //[Obsolete("The CredentialDefCriteria property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Credentials\Autobahn.Education.Credentials\Entities\CredentialCriteriaCourseEntity.g.cs	24	5
    //[Obsolete("The CredentialDefCriteria property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Credentials\Autobahn.Education.Credentials\Entities\CredentialDefCriterionEntity.g.cs	23	5
    //[Obsolete("The RefCredentialentifierSystem property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Credentials\Autobahn.Education.Credentials\Entities\CredentialDefIdentifierEntity.g.cs	43	5
    //[Obsolete("The RefCourseGpaapplicability property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.CTE\Autobahn.Education.CTE\Entities\CteCourseEntity.g.cs	111	5
    //[Obsolete("The RefCtenonTraditionalGenderStatus property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.CTE\Autobahn.Education.CTE\Entities\RefCteNonTraditionalGenderStatusEntity.g.cs	26	5
    //[Obsolete("The RefEarlyChildhoodProgramType property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\RefEarlyChildhoodProgramEnrollmentTypeEntity.g.cs	26	5
    //[Obsolete("The RefEarlyChildhoodServices property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.EarlyLearning\Autobahn.Education.EarlyLearning\Entities\RefEarlyChildhoodServiceEntity.g.cs	17	5
    //[Obsolete("The ParentFacility property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Facilities\Autobahn.Education.Facilities\Entities\FacilityRelationshipEntity.g.cs	24	5
    //[Obsolete("The RefCourseGpaapplicability property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12courseEntity.g.cs	59	5
    //[Obsolete("The K12leaFederalFunds property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12leaFederalFundEntity.g.cs	23	5
    //[Obsolete("The K12leapreKeligibility property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12leaPreKeligibilityEntity.g.cs	24	5
    //[Obsolete("The K12leatitleIiiprofessionalDevelopment property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12leaTitleIiiprofessionalDevelopmentEntity.g.cs	24	5
    //[Obsolete("The RefTitleIinstructionalServices property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12programOrServiceEntity.g.cs	57	5
    //[Obsolete("The RefPrekindergartenDailyLength property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12programOrServiceEntity.g.cs	44	5
    //[Obsolete("The RefKindergartenDailyLength property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12programOrServiceEntity.g.cs	25	5
    //[Obsolete("The RefSchoolImprovementFunds property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12schoolImprovementEntity.g.cs	23	5
    //[Obsolete("The RefAlternateFundUses property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12seaAlternateFundUseEntity.g.cs	25	5
    //[Obsolete("The K12seaFederalFunds property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12seaAlternateFundUseEntity.g.cs	17	5
    //[Obsolete("The K12seaFederalFunds property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12seaFederalFundEntity.g.cs	21	5
    //[Obsolete("The RefeaInterimRemovalReason property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentDisciplineEntity.g.cs	86	5
    //[Obsolete("The RefeaInterimRemoval property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentDisciplineEntity.g.cs	79	5
    //[Obsolete("The RefeadisciplineMethodFirearm property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentDisciplineEntity.g.cs	72	5
    //[Obsolete("The RefDisciplineMethodFirearms property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\K12studentDisciplineEntity.g.cs	53	5
    //[Obsolete("The RefK12leatitleIsupportService property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.K12\Autobahn.Education.K12\Entities\RefK12leaTitleIsupportServiceEntity.g.cs	17	5
    //[Obsolete("The PspriceOfAttendance property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsPriceOfAttendanceEntity.g.cs	88	5
    //[Obsolete("The RefTimeForCompletionUnits property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsProgramEntity.g.cs	106	5
    //[Obsolete("The RefCourseGpaapplicability property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsSectionEntity.g.cs	50	5
    //[Obsolete("The RefProfessionalTechCredentialType property is obsolete and will be removed in a later version")]	C:\Users\drcarver\Desktop\codegen\Autobahn.Education\src\Autobahn.Education.Postsecondary\Autobahn.Education.Postsecondary\Entities\PsStudentAcademicRecordEntity.g.cs	193	5
    }
}