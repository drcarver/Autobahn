using Autobahn.Codegen.Models;
using SchemaOrg;
using System;
using System.Reflection;

namespace Autobahn.Codegen;

internal class Program
{
    /// <summary>
    /// In AUtobahn.Core or just extra stuff
    /// </summary>
    private static List<string> EntitiesToIgnore = new List<string>
        {
            "Application",
            "Authentication",
            "Authorization",
            "Autobahn",
            "Cedselement",
            "CedselementDetail",
            "CedsMapping",
            "CedstoNdsmapping",
            "Location",
            "LocationAddress",
            "Organization",
            "OrganizationPersonRole",
            "Person",
            "Role",
            "RefAuthorizerType",
            "RefCountry",
            "RefCounty",
            "RefErsruralUrbanContinuumCode",
            "RefLanguage",
            "RefRole",
            "RefSex",
            "RefState",
        };

    /// <summary>
    /// The adult education domain
    /// </summary>
    private static List<string> AdditionalAdultEducationTypes = new()
    {
        "RefCourseLevelType",
        "RefCareerCluster",
        "RefLevelOfInstitution",
        "RefHighSchoolDiplomaType",
        "RefProfessionalTechnicalCredentialType",
        "RefEmployedWhileEnrolled",
        "RefEmployedAfterExit",
        "RefGoalsForAttendingAdultEducation",
        "RefCorrectionalEducationFacilityType",
        "RefWorkbasedLearningOpportunityType",
        "RefAdultEducationProgramExitReason",
        "RefWorkbasedLearningOpportunityType",
};

    private static List<string> AdditionalAssessmentTypes = new()
    {
        "ApipInteraction",
        "AssessmentPersonalNeedsProfile",
        "AssessmentResult",
        "PersonAssessmentPersonalNeedsProfile",
        "RefAcademicSubject",
        "RefAccommodationType",
        "RefApipInteractionType",
        "RefAssessmentAccommodationCategory",
        "RefAssessmentAssetType",
        "RefAssessmentEldevelopmentalDomain",
        "RefAssessmentEldevelopmentalDomain",
        "RefAssessmentItemCharacteristicType",
        "RefAssessmentItemResponseScoreStatus",
        "RefAssessmentItemResponseStatus",
        "RefAssessmentItemType",
        "RefAssessmentNeedAlternativeRepresentationType",
        "RefAssessmentNeedBrailleGradeType",
        "RefAssessmentNeedBrailleMarkType",
        "RefAssessmentNeedBrailleStatusCellType",
        "RefAssessmentNeedHazardType",
        "RefAssessmentNeedIncreasedWhitespacingType",
        "RefAssessmentNeedLanguageLearnerType",
        "RefAssessmentNeedLinkIndicationType",
        "RefAssessmentNeedMaskingType",
        "RefAssessmentNeedSigningType",
        "RefAssessmentNeedSpokenSourcePreferenceType",
        "RefAssessmentNeedSupportTool",
        "RefAssessmentNeedUsageType",
        "RefAssessmentNeedUserSpokenPreferenceType",
        "RefAssessmentParticipationIndicator",
        "RefAssessmentPlatformType",
        "RefAssessmentPretestOutcome",
        "RefAssessmentPurpose",
        "RefAssessmentPurpose",
        "RefAssessmentPurpose",
        "RefAssessmentReasonNotCompleting",
        "RefAssessmentReasonNotTested",
        "RefAssessmentRegistrationCompletionStatus",
        "RefAssessmentReportingMethod",
        "RefAssessmentReportingMethod",
        "RefAssessmentResultDataType",
        "RefAssessmentResultScoreType",
        "RefAssessmentSessionSpecialCircumstanceType",
        "RefAssessmentSessionSpecialCircumstanceType",
        "RefAssessmentSessionStaffRoleType",
        "RefAssessmentSessionType",
        "RefAssessmentType",
        "RefContentStandardType",
        "RefEloutcomeMeasurementLevel",
        "RefGoalMeasurementType",
        "RefGoalStatusType",
        "RefItemResponseTheoryDifficultyCategory",
        "RefItemResponseTheoryKappaAlgorithm",
        "RefLearnerActionType",
        "RefLearnerActivityAddToGradeBookFlag",
        "RefLearnerActivityMaximumTimeAllowedUnit",
        "RefLearnerActivityType",
        "RefNaepAspectsOfReading",
        "RefNaepMathComplexityLevel",
        "RefOutcomeTimePoint",
        "RefProficiencyStatus",
        "RefScoreMetricType",
        "RefTextComplexitySystem",
    };

    private static List<string> AdditionalCompetenciesTypes = new()
    {
        "RefType",
        "RefLearningResourceCompetencyAlignmentType",
        "RefEducationLevel",
        "RubricCriterion",
        "Rubric",
    };

    private static List<string> AdditionalCredentialsTypes = new()
    {
        "RefCareerCluster",
        "RefCipCode",
        "RefOnetsococcupationType",
        "RefCtdlaudienceLevelType",
    };

    private static List<string> AdditionalCommonEducationTypes = new()
    {
        "Classroom",
        "CompetencyDefinition",
        "CompetencyFramework",
        "CompetencySet",
        "Course",
        "CourseSection",
        "FinancialAccount",
        "FinancialAccountProgram",
        "LearningResource",
        "OrganizationAccreditation",
        "OrganizationCalendarSession",
        "OrganizationFederalAccountability",
        "OrganizationFinancial",
        "OrganizationPopulationServed",
        "OrganizationProgramType",
        "OrganizationService",
        "OrganizationTechnicalAssistance",
        "RefAcademicSubject",
        "RefAcademicTermDesignator",
        "RefAccreditationAgency",
        "RefAdditionalCreditType",
        "RefAdditionalTargetedSupportAndImprovementStatus",
        "RefAdvancedPlacementCourseCode",
        "RefAypStatus",
        "RefBloomsTaxonomyDomain",
        "RefCompetencyDefNodeAccessibilityProfile",
        "RefCompetencyDefTestabilityType",
        "RefCompetencyFrameworkPublicationStatus",
        "RefComprehensiveSupportAndImprovementStatus",
        "RefCourseApplicableEducationLevel",
        "RefCourseCreditUnit",
        "RefCourseSectionDeliveryMode",
        "RefCreditTypeEarned",
        "RefCteGraduationRateInclusion",
        "RefElementaryMiddleAdditional",
        "RefFinancialAccountBalanceSheetCode",
        "RefFinancialAccountCategory",
        "RefFinancialAccountFundClassification",
        "RefFinancialAccountProgramCode",
        "RefFinancialAccountRevenueCode",
        "RefFinancialExpenditureFunctionCode",
        "RefFinancialExpenditureLevelOfInstructionCode",
        "RefFinancialExpenditureObjectCode",
        "RefGradeLevel",
        "RefGunFreeSchoolsActReportingStatus",
        "RefHighSchoolGraduationRateIndicator",
        "RefLearningResourceAccessApitype",
        "RefLearningResourceAccessHazardType",
        "RefLearningResourceAccessModeType",
        "RefLearningResourceAccessRightsUrl",
        "RefLearningResourceAuthorType",
        "RefLearningResourceBookFormatType",
        "RefLearningResourceControlFlexibilityType",
        "RefLearningResourceDigitalMediaSubType",
        "RefLearningResourceDigitalMediaType",
        "RefLearningResourceEducationalUse",
        "RefLearningResourceIntendedEndUserRole",
        "RefLearningResourceInteractionMode",
        "RefLearningResourceInteractivityType",
        "RefLearningResourceType",
        "RefMultipleIntelligenceType",
        "RefPopulationServed",
        "RefProgramType",
        "RefReconstitutedStatus",
        "RefSessionType",
        "RefSingleSexClassStatus",
        "RefStudentSupportServiceType",
        "RefTargetedSupportAndImprovementStatus",
        "RefTechnicalAssistanceDeliveryType",
        "RefTechnicalAssistanceType",
};

    private static List<string> AdditionalEarlyChildhoodTypes = new()
    {
    };

    private static List<string> AdditionalK12Types = new()
    {
    };

    private static List<string> AdditionalLearningResourcesTypes = new()
    {
    };
    
    private static List<string> AdditionalOrganizationTypes = new()
    {
        "RefOrganizationEmailType",
        "RefOrganizationTelephoneNumberListedStatus",
        "OrganizationEmployeeBenefit",
        "RefEmployeeBenefit",
        "RefInstitutionTelephoneType",
        "RefTelephoneNumberListedStatus",
        "RefOperationalStatus",
        "Activity",
        "ActivityRecognition",
        "RefActivityRecognitionType",
    };

    private static List<string> AdditionalPersonTypes = new()
    {
        "AssessmentPersonalNeedsProfile",
        "Incident",
        "IncidentPerson",
        "PersonLearningDevice",
        "RefAccommodationsNeededType",
        "RefAllergySeverity",
        "RefAllergyType",
        "RefBarrierToInternetAccessInResidence",
        "RefCareerEducationPlanType",
        "RefCommunicationMethod",
        "RefCredentialType",
        "RefDegreeOrCertificateType",
        "RefDentalInsuranceCoverageType",
        "RefDentalScreeningStatus",
        "RefDisabilityConditionStatusCode",
        "RefDisabilityConditionType",
        "RefDisabilityDeterminationSourceType",
        "RefEducationVerificationMethod",
        "RefElprogramEligibility",
        "RefEmailType",
        "RefFamilyIncomeSource",
        "RefFirearmType",
        "RefHealthInsuranceCoverage",
        "RefHearingScreeningStatus",
        "RefHigherEducationInstitutionAccreditationStatus",
        "RefHomelessNighttimeResidence",
        "RefImmunizationType",
        "RefIncidentBehavior",
        "RefIncidentBehaviorSecondary",
        "RefIncidentInjuryType",
        "RefIncidentLocation",
        "RefIncidentMultipleOffenseType",
        "RefIncidentPerpetratorInjuryType",
        "RefIncidentReporterType",
        "RefIncidentTimeDescriptionCode",
        "RefIncomeCalculationMethod",
        "RefInternetAccessTypeInResidence",
        "RefInternetPerformanceInResidence",
        "RefLanguageUseType",
        "RefMedicalAlertIndicator",
        "RefMilitaryActiveStudentIndicator",
        "RefMilitaryBranch",
        "RefMilitaryConnectedStudentIndicator",
        "RefMilitaryVeteranStudentIndicator",
        "RefOtherNameType",
        "RefParticipationType",
        "RefPrimaryLearningDeviceAccess",
        "RefPrimaryLearningDeviceAwayFromSchool",
        "RefPrimaryLearningDeviceProvider",
        "RefProgramEntryReason",
        "RefProgramExitReason",
        "RefProofOfResidencyType",
        "RefRace",
        "RefReferralOutcome",
        "RefTelephoneNumberListedStatus",
        "RefTribalAffiliation",
        "RefTrimesterWhenPrenatalCareBegan",
        "RefUscitizenshipStatus",
        "RefVisaType",
        "RefVisionScreeningStatus",
        "RefWeaponType",
};

    private static List<string> AdditionalRoleTypes = new()
    {
        "RefAttendanceEventType",
        "RefAttendanceStatus",
        "RefAbsentAttendanceCategory",
        "RefPresentAttendanceCategory",
        "RefLeaveEventType",
    };

    /// <summary>
    /// Set the domain of the table based on it name
    /// </summary>
    /// <param name="autobahnDomains"></param>
    /// <param name="table"></param>
    static void SetTableDomain(List<AutobahnDomain> autobahnDomains, AutobahnEntity table)
    {
        // Set the domains in the tablesMetadata
        var comdom = autobahnDomains.First(d => d.Module == "Common");
        var assesdom = autobahnDomains.First(d => d.Module == "Assessments");
        var aedom = autobahnDomains.First(d => d.Module == "AdultEducation");
        var eldom = autobahnDomains.First(d => d.Module == "EarlyLearning");
        var lrdom = autobahnDomains.First(d => d.Module == "LearningResources");
        var k12dom = autobahnDomains.First(d => d.Module == "K12");
        var facdom = autobahnDomains.First(d => d.Module == "Facilities");
        var psdom = autobahnDomains.First(d => d.Module == "Postsecondary");
        var compdom = autobahnDomains.First(d => d.Module == "Competencies");
        var creddom = autobahnDomains.First(d => d.Module == "Credentials");
        var ctedom = autobahnDomains.First(d => d.Module == "CTE");
        var wfdom = autobahnDomains.First(d => d.Module == "Workforce");

        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("AE")
            || table.Name.ToUpper().EndsWith("AE")
            || table.Name.ToUpper().StartsWith("REFAE")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name)                )
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = aedom.Module;
                return;
            }
        }
        if (AdditionalAdultEducationTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = aedom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("EL")
            || table.Name.ToUpper().StartsWith("EARLYCHILDHOOD")
            || table.Name.ToUpper().EndsWith("EL")
            || table.Name.ToUpper().StartsWith("REFEL")
            || table.Name.ToUpper().IndexOf("EARLYCHILDHOOD") > 0))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = eldom.Module;
                return;
            }
        }
        if (AdditionalEarlyChildhoodTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = aedom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("ASSESSMENT")
            || table.Name.ToUpper().StartsWith("RUBRIC")
            || table.Name.ToUpper().StartsWith("GOAL")
            || table.Name.ToUpper().StartsWith("LEARNER")
            || table.Name.IndexOf("ASSESSMENT") > 0
            || table.Name.IndexOf("RUBRIC") > 0
            || table.Name.IndexOf("GOAL") > 0
            || table.Name.IndexOf("LEARNER") > 0))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = assesdom.Module;
                return;
            }
        }
        if (AdditionalAssessmentTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = assesdom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("Learning".ToUpper())
            || table.Name.ToUpper().StartsWith("Peer".ToUpper())
            || table.Name.ToUpper().IndexOf("Learning".ToUpper()) > 0
            || table.Name.ToUpper().IndexOf("Peer".ToUpper()) > 0))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = lrdom.Module;
                return;
            }
        }
        if (AdditionalLearningResourcesTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = assesdom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("K12")
            || table.Name.ToUpper().IndexOf("K12") > 0))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = k12dom.Module;
                return;
            }
        }
        if (AdditionalK12Types.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = assesdom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("Build")
            || table.Name.StartsWith("Facility")
            || table.Name.StartsWith("RefBuild")
            || table.Name.StartsWith("RefFacility")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = facdom.Module;
                return;
            }
        }

        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("Ps")
            || table.Name.StartsWith("PS")
            || table.Name.IndexOf("IPEDS", StringComparison.InvariantCulture) > -1
            || table.Name.StartsWith("RefPs")
            || table.Name.StartsWith("RefPS")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = psdom.Module;
                return;
            }
        }

        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("Competency")
            || table.Name.StartsWith("RefCompet")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = compdom.Module;
                return;
            }
        }
        if (AdditionalCompetenciesTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = compdom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("Credential")
            || table.Name.StartsWith("RefCred")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = creddom.Module;
                return;
            }
        }
        if (AdditionalCredentialsTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = compdom.Module;
            return;
        }
        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("Cte")
            || table.Name.EndsWith("Cte")
            || table.Name.StartsWith("RefCte")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = ctedom.Module;
                return;
            }
        }

        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("App")
            || table.Name.StartsWith("Auth")
            || table.Name.StartsWith("RefApp")
            || table.Name.StartsWith("RefAuth")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = "Autorization";
                return;
            }
        }

        if (table.Attributes.TableAttribute?.Schema == null
            && (table.Name.StartsWith("Workforce")
            || table.Name.StartsWith("RefWorkforce")))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = wfdom.Module;
            }
        }

        if (AdditionalCommonEducationTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = comdom.Module;
            return;
        }

        if (table.Attributes?.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("Organization".ToUpper())
            || table.Name.ToUpper().IndexOf("Organization".ToUpper()) > 0))
       {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = "Organization";
                return;
            }
        }
        if (AdditionalOrganizationTypes.Contains(table.Name)
            && !AdditionalCommonEducationTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = "Organization";
            return;
        }

        if (table.Attributes?.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("Person".ToUpper())
            || table.Name.ToUpper().IndexOf("Person".ToUpper()) > 0))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = "Person";
                return;
            }
        }
        if (AdditionalPersonTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = "Person";
            return;
        }

        if (table.Attributes?.TableAttribute?.Schema == null
            && (table.Name.ToUpper().StartsWith("Role".ToUpper())
            || table.Name.ToUpper().IndexOf("Role".ToUpper()) > 0))
        {
            if (!AdditionalCommonEducationTypes.Contains(table.Name))
            {
                table.Attributes.TableAttribute = new(table.Name);
                table.Attributes.TableAttribute.Schema = "Role";
                return;
            }
        }
        if (AdditionalRoleTypes.Contains(table.Name))
        {
            table.Attributes.TableAttribute = new(table.Name);
            table.Attributes.TableAttribute.Schema = "Role";
            return;
        }
    }

    /// <summary>
    /// Return the list of autobahn entities from a list of types
    /// </summary>
    /// <returns>Return the list of Autobahn Entities</returns>
    private static List<AutobahnEntity> GetAutobahnEntities(
        List<Type> types, 
        List<AutobahnDomain> domains, 
        List<AutobahnTable> tables, 
        List<AutobahnElement> elements)
    {
        // iterate the known types and create a list of
        // autobahn types
        List<AutobahnEntity> autobahnEntities = new();

        foreach (var type in types)
        {
            if (!type.IsClass  
                || EntitiesToIgnore.Contains(type.Name))
            {
                continue;
            }

            var entity  = new AutobahnEntity(type);
            var globalId = tables.FirstOrDefault(t => t.TableName == entity.Name && string.IsNullOrEmpty(t.ColumnName.Trim()))?.GlobalId;
            entity.AutobahnElement = elements.FirstOrDefault(e => e.GlobalID == globalId);
            if (entity.Attributes.CommentAttribute == null)
            {
                if (!string.IsNullOrEmpty(entity.AutobahnElement?.Definition))
                {
                    entity.Attributes.CommentAttribute = new($"{entity.AutobahnElement?.Definition}");
                }
                else
                {
                    entity.Attributes.CommentAttribute = new($"The {entity.Name} ");
                }
            }
            SetTableDomain(domains, entity);
            foreach (var prop in entity.AutobahnProperties)
            {
                globalId = tables.FirstOrDefault(t => t.TableName == entity.Name && t.ColumnName == prop.Name)?.GlobalId;
                prop.AutobahnElement = elements.FirstOrDefault(e => e.GlobalID == globalId);
                if (!string.IsNullOrEmpty(prop.AutobahnElement?.Definition))
                {
                    prop.Attributes.CommentAttribute = new(prop.AutobahnElement.Definition);
                }
            }
            autobahnEntities.Add(entity);
        }

        foreach (var entity in autobahnEntities.Where(e => e.Attributes.TableAttribute.Schema == null))
        {
            entity.Attributes.TableAttribute.Schema = "Invalid";
        }

        var notcommon = autobahnEntities.Count(e => e.Attributes.TableAttribute.Schema != "Common");
        var common = autobahnEntities.Count(e => e.Attributes.TableAttribute.Schema == "Common");

        return autobahnEntities;
    }

    private static void SetDomain(List<AutobahnEntity> entities, AutobahnEntity entity, string module)
    {
        // If module != common the schema name is not the module name we
        // want to shift to then reset it and all of its foreign keys to 
        // common.  Basically if the  is in multiple domains move it
        // to common
        if (entity.Attributes?.TableAttribute.Schema != module)
        {
            entity.Attributes.TableAttribute.Schema = "Common";
        }

        // Put the domain and all of it's foreign keys into the same domain
        foreach (var prop in entity.AutobahnProperties.Where(p => p.Name.EndsWith("Id")))
        {
            var fkey = entities.FirstOrDefault(e => e.Name == prop.VirtualType);
            if (fkey != null)
            {
                if (fkey.Attributes.TableAttribute.Schema != module
                    && fkey.Attributes.TableAttribute.Schema != "Common")
                {
                    fkey.Attributes.TableAttribute.Schema = module;
                    SetDomain(entities, fkey, module);
                }
                prop.MapFKeyVirtualType();
            }
            else
            {
                if (!EntitiesToIgnore.Contains(prop.VirtualType))
                {
                    prop.Attributes.ObsoleteAttribute = new($"The {prop.VirtualType} property is obsolete and will be removed in a later version");
                }
            }
            prop.MapFKeyVirtualType();
        }
        entity.ResetEntityDomain();
    }

    static async Task Main(string[] args)
    {
        var csv = new CSVServices();
        var autobahnDomains = csv.ReadDomainsFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\AutobahnDomains.csv");
        var autobahnElements = csv.ReadAutobahnElementFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDSElements.csv");
        var autobahnTables = csv.ReadTablesFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\_CEDStoNDSMapping.csv");

        // Autobahn Domains
        var autobahnEntites = GetAutobahnEntities(
            Assembly.GetExecutingAssembly().GetExportedTypes().OrderBy(o => o.Name).ToList(), 
            autobahnDomains, autobahnTables, autobahnElements);

        var schemaEntites = GetSchemaEntities(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\schemaorg-all-http.jsonld");

        var tickerlist = JsonConvert.DeserializeObject<List<Ticker>>(File.ReadAllText(@"C:\Users\drcarver\Desktop\codegen\FMP\Data\list.json"));
        int symbolLength = 0;
        int nameLength = 0;
        int exchangenameLength = 0;
        int exchangeshortnameLength = 0;
        List<string> tickertype = new();
        List<string> exchangeabbr = new();
        foreach (var ticker in tickerlist)
        {
            if (ticker.Symbol.Length > symbolLength) symbolLength = ticker.Symbol.Length;
            if (ticker.Name.Length > nameLength) nameLength = ticker.Name.Length;
            if (ticker.Exchange.Length > exchangenameLength) exchangenameLength = ticker.Exchange.Length;
            if (ticker.ExchangeShortName.Length > exchangeshortnameLength) exchangeshortnameLength = ticker.ExchangeShortName.Length;
            if (!tickertype.Contains(ticker.TickerType))
            {
                tickertype.Add(ticker.TickerType);
            }
            if (!exchangeabbr.Contains(ticker.Exchange))
            {
                exchangeabbr.Add(ticker.Exchange);
            }
        }

        Console.WriteLine($"TickerCount={tickerlist.Count()}");
        Console.WriteLine($"MaxSymbolLength={symbolLength}");
        Console.WriteLine($"MaxNameLength={nameLength}");
        Console.WriteLine($"MaxExchangeNameLength={exchangenameLength}");
        Console.WriteLine($"MaxExchangeShortNameLength={exchangeshortnameLength}");
        foreach (var item in tickertype)
        {
            Console.WriteLine($"{item}");
        }
        foreach (var item in exchangeabbr)
        {
            Console.WriteLine($"{item}");
        }

        //SeedOrganization();
        //SeedRefRecordStatusType();
        //SeedRefRecordStatusCreator();

        //var autobahnMarc = csv.ReadMarcReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\MarcRelator.csv");
        //            csv.WriteReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefMarcRelator.csv", autobahnMarc, false, "|");
        //var marc = autobahnTables.Where(t => t.TableName == "RefMarcRelator");
        //var RefAutobahnMarc = csv.ReadMarcReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefMarcRelator.csv").ToList();
        //var domainReferenceList = BuildTableListByProperty(autobahnTables);

        var location = $@"C:\Users\drcarver\Desktop\codegen\Autobahn\src\";
        MauiModule.GenerateModule(location, autobahnEntites, autobahnDomains);
    }

    private static List<AutobahnEntity> GetSchemaEntities(string location)
    {
        var domains = new Dictionary<string, List<string>>();
        Root SchemaOrg = JsonConvert.DeserializeObject<Root>(File.ReadAllText(location));

        // First build the list of entites and the domain
        // list that goes with them
        var graphlist = new List<AutobahnEntity>();
        foreach (var schema in SchemaOrg.Graph)
        {
            if (schema.SchemaType.Contains("rdfs:Class") && !schema.SchemaType.Contains("schema:DataType"))
            {
                var Name = FirstCharToUpper(schema.Id.Replace("schema:", string.Empty));
                var entity = graphlist.FirstOrDefault(e => e.Name == Name);
                if (entity == null)
                {
                    entity = new AutobahnEntity
                    {
                        Name = Name,
                    };
                    if (!string.IsNullOrEmpty(schema.RdfsComment))
                    {
                        entity.Attributes.CommentAttribute ??= new CommentAttribute(schema.RdfsComment);
                    }
                    if (schema.RdfsSubClassOf != null)
                    {
                        foreach (var subclass in schema.RdfsSubClassOf)
                        {
                            var subClassName = FirstCharToUpper(subclass.Id.Replace("schema:", string.Empty));
                            if (!entity.SubClass.Contains(subClassName) && subClassName != Name)
                            {
                                entity.SubClass.Add(subClassName);
                            }

                            // Update the domain map (entities that inherit from many others)
                            if (domains.ContainsKey(subClassName))
                            {
                                if (!domains[subClassName].Contains(Name))
                                {
                                    domains[subClassName].Add(Name);
                                }
                            }
                            else
                            {
                                domains.Add(subClassName, new List<string> { Name });
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(schema.RdfsLabel))
                    {
                        entity.Label = FirstCharToUpper(schema.RdfsLabel);
                    }
                    if (!entity.SubClass.Any())
                    {
                        entity.SubClass.Add("Base");
                    }
                    entity.Attributes.TableAttribute = new TableAttribute(entity.Name);
                    entity.SubClass.Add($"I{entity.Name}");
                    graphlist.Add(entity);
                }
            }
        }

        // Add the properties to the 
        foreach (var schema in SchemaOrg.Graph)
        {
            if (schema.SchemaType.Contains("rdf:Property"))
            {
                if (schema.SchemaDomainIncludes != null)
                {
                    foreach (var schemaName in schema.SchemaDomainIncludes)
                    {
                        var Name = FirstCharToUpper(schemaName.Id.Replace("schema:", string.Empty));
                        var entity = graphlist.FirstOrDefault(e => e.Name == Name);
                        if (entity != null)
                        {
                            var propName = FirstCharToUpper(schema.Id.Replace("schema:", string.Empty));
                            var prop = entity.AutobahnProperties.FirstOrDefault(p => p.Name == propName);
                            if (prop == null)
                            {
                                prop = new AutobahnProperty
                                {
                                    Name = propName,
                                    PropertyType = SchemaPropertyType(schema.SchemaRangeIncludes)

                                };
                                if (!string.IsNullOrEmpty(schema.RdfsComment))
                                {
                                    prop.Attributes.CommentAttribute ??= new CommentAttribute(schema.RdfsComment);
                                }
                                if (!string.IsNullOrEmpty(schema.RdfsLabel))
                                {
                                    entity.Label = FirstCharToUpper(schema.RdfsLabel);
                                }
                                var fk = graphlist.FirstOrDefault(e => e.Name == prop.PropertyType);
                                if (fk != null)
                                {
                                    var virtualProperty = new AutobahnProperty
                                    {
                                        Name = propName,
                                        PropertyType = propName,
                                        IsVirtual = true,
                                    };
                                    virtualProperty.Attributes.CommentAttribute = prop.Attributes.CommentAttribute;
                                    entity.AutobahnProperties.Add(virtualProperty);
                                    prop.Attributes.ForeignKeyAttribute = new ForeignKeyAttribute(prop.PropertyType);
                                    prop.Name = $"{prop.Name}Id";
                                    prop.PropertyType = "Guid";
                                }
                                entity.AutobahnProperties.Add(prop);
                            }
                        }
                    }
                }
            }
        }

        return graphlist;
    }

    private static AutobahnElement? GetMeta(string Name, 
        string propertyName, List<AutobahnTable> tables,
        List<AutobahnElement> elements)
    {
        AutobahnTable? tableMeta;
        if (string.IsNullOrEmpty(propertyName))
        {
            tableMeta = tables.FirstOrDefault(t => t.TableName == Name);
        }
        else
        {
            tableMeta = tables.FirstOrDefault(e => e.TableName == Name && e.ColumnName == propertyName);
        }
        AutobahnElement? element = null;
        if (!string.IsNullOrEmpty(tableMeta?.GlobalId))
        {
            foreach (var item in elements)
            {
                int intOut;
                Int32.TryParse(item.GlobalID, out intOut);
                if (intOut.ToString() == tableMeta?.GlobalId)
                {
                    return item;
                }
            }
        }
        return element;
    }

    private static string SchemaPropertyType(List<SchemaRangeIncludes> schemaRangeIncludes)
    {
        var nettype = string.Empty;
        foreach (var propType in schemaRangeIncludes)
        {
            switch (propType.Id)
            {
                case "schema:Text":
                    nettype = "string";
                    break;
                case "schema:Boolean":
                    nettype = "bool";
                    break;
                case "schema:Date":
                    nettype = "Date";
                    break;
                case "schema:DateTime":
                    nettype = "DateTime";
                    break;
                case "schema:Number":
                    nettype = "int";
                    break;
                case "schema:Time":
                    nettype = "Time";
                    break;
                default:
                    nettype = FirstCharToUpper(propType.Id.Replace("schema:", string.Empty));
                    break;
            }
        }
        return nettype;
    }

    //private static void SeedRefRecordStatusType()
    //{
    //    var csv = new CSVServices();
    //    using (var ctx = new AutobahnCommonContext())
    //    {
    //        var reftype = csv.ReadReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefRecordStatusType.csv");
    //        foreach (var item in reftype)
    //        {
    //            ctx.RefRecordStatusType.Add(new RefRecordStatusType
    //            {
    //                Id = item.Id, // ?? Guid.NewGuid(),
    //                Code = item.Code,
    //                Description = item.Description,
    //                Definition = item.Definition,
    //                SortOrder = item.SortOrder
    //            });
    //        }

    //        ctx.SaveChanges();
    //    }
    //}

    //private static void SeedRefRecordStatusCreator()
    //{
    //    var csv = new CSVServices();
    //    using (var ctx = new AutobahnCommonContext())
    //    {
    //        var reftype = csv.ReadReferenceFile(@"C:\Users\drcarver\Desktop\codegen\Autobahn\Data\RefRecordStatusCreator.csv");
    //        foreach (var item in reftype)
    //        {
    //            ctx.RefRecordStatusCreator.Add(new RefRecordStatusCreator
    //            {
    //                Id = item.Id, // ?? Guid.NewGuid(),
    //                Code = item.Code,
    //                Description = item.Description,
    //                Definition = item.Definition,
    //                SortOrder = item.SortOrder
    //            });
    //        }

    //        ctx.SaveChanges();
    //    }
    //}

    //private static void SeedOrganization()
    //{
    //    using (var ctx = new AutobahnCommonContext())
    //    {
    //        // Autobahn
    //        var Organization = new Organization { Id = Guid.Parse("22B1FD25-AE5C-4B03-B463-284D0C1B49F5") };
    //        ctx.Organization.Add(Organization);

    //        // Project GutenBurg
    //        Organization = new Organization { Id = Guid.Parse("BC734F30-EADD-4456-9B34-8583ABC17CD0") };
    //        ctx.Organization.Add(Organization);

    //        ctx.SaveChanges();
    //    }
    //}

    //private static Dictionary<string, List<AutobahnTable>> BuildTableListByProperty(List<AutobahnTable> tables)
    //{
    //    var domainFiles = new Dictionary<string, List<AutobahnTable>>();
    //    foreach (var table in tables.Where(t => t.ColumnName.StartsWith("Ref") && t.ColumnName.EndsWith("Id")))
    //    {
    //        var columnKey = table.ColumnName.Replace("Id", string.Empty);
    //        if (columnKey.StartsWith("RefMarc"))
    //        {

    //        }
    //        if (domainFiles.ContainsKey(columnKey))
    //        {
    //            var exists = domainFiles.Values.Any(v => v.Any(t => t.TableName == table.TableName));
    //            if (!exists)
    //            {
    //                domainFiles[columnKey].Add(table);
    //            }
    //        }
    //        else
    //        {
    //            domainFiles.Add(columnKey, new List<AutobahnTable>());
    //            domainFiles[columnKey].Add(table);
    //        }
    //    }

    //    return  domainFiles;
    //}

    /// <summary>
    /// Convert a string to start with a upper case character
    /// </summary>
    /// <param name="value">The original string</param>
    /// <returns>The string with the first character converted to upper case</returns>
    public static string FirstCharToUpper(string value)
    {
        char[] array = value.ToCharArray();

        // Handle the first letter in the string.  
        if (array.Length >= 1)
        {
            if (char.IsLower(array[0]))
            {
                array[0] = char.ToUpper(array[0]);
            }
        }
        return new string(array);
    }

    /// <summary>
    /// Convert a string to start with a upper lower character
    /// </summary>
    /// <param name="value">The original string</param>
    /// <returns>The string with the first character converted to lower case</returns>
    public static string FirstCharToLower(string value)
    {
        char[] array = value.ToCharArray();

        // Handle the first letter in the string.  
        if (array.Length >= 1)
        {
            if (char.IsUpper(array[0]))
            {
                array[0] = char.ToLower(array[0]);
            }
        }
        return new string(array);
    }
}
