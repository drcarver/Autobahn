//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAssessmentTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAssessmentType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentType"> List
         /// </summary>
        public static List<RefAssessmentType> RefAssessmentTypeList = new List<RefAssessmentType>
        {
            new RefAssessmentType { Id=Guid.Parse("14f872cc-613b-4cb5-88af-d15f45b65a2f"), Code="AchievementTest", Description="Achievement test", Definition="Achievement test is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentType { Id=Guid.Parse("2a5374c2-176d-4f9b-bdc3-a7d04fc0aa4d"), Code="AdvancedPlacementTest", Description="Advanced placement test", Definition="Advanced placement test is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentType { Id=Guid.Parse("0307c66f-d67b-4c85-9974-f7ada8711aef"), Code="AlternateAssessmentELL", Description="Alternate assessment/ELL", Definition="Alternate assessment/ELL is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentType { Id=Guid.Parse("1ad66743-0258-4cd3-8d17-34facb95bf32"), Code="AlternateAssessmentGradeLevelStandards", Description="Alternate assessment/grade-level standards", Definition="Alternate assessment/grade-level standards is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentType { Id=Guid.Parse("1d85ab4c-d906-4670-8fdb-6d6ab15be472"), Code="AlternativeAssessmentModifiedStandards", Description="Alternative assessment/modified standards", Definition="Alternative assessment/modified standards is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentType { Id=Guid.Parse("31561e3a-1413-48e6-aa27-5580431c1eb9"), Code="AptitudeTest", Description="Aptitude Test", Definition="Aptitude Test is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentType { Id=Guid.Parse("c70c891f-5094-4ecf-98dd-98323d3b89f7"), Code="Benchmark", Description="Benchmark", Definition="Benchmark is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentType { Id=Guid.Parse("3561280f-e407-4dcd-ac47-59fad02a3085"), Code="CognitiveAndPerceptualSkills", Description="Cognitive and perceptual skills test", Definition="Cognitive and perceptual skills test is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentType { Id=Guid.Parse("d218c8b7-5b5d-476d-b4ed-598be16692e9"), Code="ComputerAdaptiveTest", Description="Computer Adaptive Test", Definition="Computer Adaptive Test is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("15.00") },
            new RefAssessmentType { Id=Guid.Parse("42d018b0-cdfa-4bdd-8751-b053f6924874"), Code="DevelopmentalObservation", Description="Developmental observation", Definition="Developmental observation is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("16.00") },
            new RefAssessmentType { Id=Guid.Parse("08e0745e-f0ce-4255-ae96-c3d415efe5bd"), Code="Diagnostic", Description="Diagnostic", Definition="Diagnostic is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("18.00") },
            new RefAssessmentType { Id=Guid.Parse("73e3e5de-0275-4dd2-be9c-7711f2887a53"), Code="DirectAssessment", Description="Direct Assessment", Definition="Direct Assessment is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("20.00") },
            new RefAssessmentType { Id=Guid.Parse("1c736a0c-ac66-43be-8687-f175b16e2ca5"), Code="Formative", Description="Formative", Definition="Formative is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("22.00") },
            new RefAssessmentType { Id=Guid.Parse("96c1eee6-52ba-44e1-bc01-1558023ae5be"), Code="GrowthMeasure", Description="Growth Measure", Definition="Growth Measure is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("23.00") },
            new RefAssessmentType { Id=Guid.Parse("e90cf4eb-e33d-4897-9b21-1058028224c9"), Code="Interim", Description="Interim", Definition="Interim is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("24.00") },
            new RefAssessmentType { Id=Guid.Parse("28195ed5-61e6-4bf5-9f98-21ba659587ba"), Code="KindergartenReadiness", Description="Kindergarten Readiness", Definition="Kindergarten Readiness is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("26.00") },
            new RefAssessmentType { Id=Guid.Parse("88dc06fb-bfcd-4f17-a983-4563fc2342d3"), Code="LanguageProficiency", Description="Language proficiency test", Definition="Language proficiency test is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("28.00") },
            new RefAssessmentType { Id=Guid.Parse("5476362e-23ce-4698-ae81-745160eb5077"), Code="MentalAbility", Description="Mental ability (intelligence) test", Definition="Mental ability (intelligence) test is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("30.00") },
            new RefAssessmentType { Id=Guid.Parse("da2a59d0-d13c-4708-b40e-0cdf17e54363"), Code="Observation", Description="Observation", Definition="Observation is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("32.00") },
            new RefAssessmentType { Id=Guid.Parse("a19c7c1c-6d9a-40f8-8fbc-ce2b2f92d0de"), Code="ParentReport", Description="Parent Report", Definition="Parent Report is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("34.00") },
            new RefAssessmentType { Id=Guid.Parse("b1ff6423-0e9b-4336-94c4-43c7b8622fe8"), Code="PerformanceAssessment", Description="Performance assessment", Definition="Performance assessment is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("36.00") },
            new RefAssessmentType { Id=Guid.Parse("99906ed2-c195-461e-8892-aed19814a47a"), Code="PortfolioAssessment", Description="Portfolio assessment", Definition="Portfolio assessment is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("38.00") },
            new RefAssessmentType { Id=Guid.Parse("27a9df1c-db51-4f9c-a96c-adeab36b1c7d"), Code="PrekindergartenReadiness", Description="Prekindergarten Readiness", Definition="Prekindergarten Readiness is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("40.00") },
            new RefAssessmentType { Id=Guid.Parse("adcb8143-9b85-43e1-90a4-b78fe4344ffc"), Code="ReadingReadiness", Description="Reading readiness test", Definition="Reading readiness test is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("42.00") },
            new RefAssessmentType { Id=Guid.Parse("b2cd8cc7-ceba-4adb-9281-3d1ede02294a"), Code="Screening", Description="Screening", Definition="Screening is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("44.00") },
            new RefAssessmentType { Id=Guid.Parse("d02de5c4-4f21-4836-971e-b374ded472ef"), Code="TeacherReport", Description="Teacher Report", Definition="Teacher Report is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("46.00") },
            new RefAssessmentType { Id=Guid.Parse("5a5097af-dace-48aa-a427-78e5e7610dc7"), Code="Other", Description="Other", Definition="Other is specified as the category of an assessment based on format and content.", SortOrder=Convert.ToDecimal("48.00") },
        };

        /// <summary>
        /// The RefAssessmentType Pick List
         /// </summary>
        public static List<RefAssessmentType> RefAssessmentTypePickList = new List<RefAssessmentType>
        {
            new RefAssessmentType { Id=Guid.Parse("14f872cc-613b-4cb5-88af-d15f45b65a2f"), Code="AchievementTest", Description="Achievement test", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentType { Id=Guid.Parse("2a5374c2-176d-4f9b-bdc3-a7d04fc0aa4d"), Code="AdvancedPlacementTest", Description="Advanced placement test", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentType { Id=Guid.Parse("0307c66f-d67b-4c85-9974-f7ada8711aef"), Code="AlternateAssessmentELL", Description="Alternate assessment/ELL", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentType { Id=Guid.Parse("1ad66743-0258-4cd3-8d17-34facb95bf32"), Code="AlternateAssessmentGradeLevelStandards", Description="Alternate assessment/grade-level standards", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentType { Id=Guid.Parse("1d85ab4c-d906-4670-8fdb-6d6ab15be472"), Code="AlternativeAssessmentModifiedStandards", Description="Alternative assessment/modified standards", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentType { Id=Guid.Parse("31561e3a-1413-48e6-aa27-5580431c1eb9"), Code="AptitudeTest", Description="Aptitude Test", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentType { Id=Guid.Parse("c70c891f-5094-4ecf-98dd-98323d3b89f7"), Code="Benchmark", Description="Benchmark", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentType { Id=Guid.Parse("3561280f-e407-4dcd-ac47-59fad02a3085"), Code="CognitiveAndPerceptualSkills", Description="Cognitive and perceptual skills test", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentType { Id=Guid.Parse("d218c8b7-5b5d-476d-b4ed-598be16692e9"), Code="ComputerAdaptiveTest", Description="Computer Adaptive Test", SortOrder=Convert.ToDecimal("15.00") },
            new RefAssessmentType { Id=Guid.Parse("42d018b0-cdfa-4bdd-8751-b053f6924874"), Code="DevelopmentalObservation", Description="Developmental observation", SortOrder=Convert.ToDecimal("16.00") },
            new RefAssessmentType { Id=Guid.Parse("08e0745e-f0ce-4255-ae96-c3d415efe5bd"), Code="Diagnostic", Description="Diagnostic", SortOrder=Convert.ToDecimal("18.00") },
            new RefAssessmentType { Id=Guid.Parse("73e3e5de-0275-4dd2-be9c-7711f2887a53"), Code="DirectAssessment", Description="Direct Assessment", SortOrder=Convert.ToDecimal("20.00") },
            new RefAssessmentType { Id=Guid.Parse("1c736a0c-ac66-43be-8687-f175b16e2ca5"), Code="Formative", Description="Formative", SortOrder=Convert.ToDecimal("22.00") },
            new RefAssessmentType { Id=Guid.Parse("96c1eee6-52ba-44e1-bc01-1558023ae5be"), Code="GrowthMeasure", Description="Growth Measure", SortOrder=Convert.ToDecimal("23.00") },
            new RefAssessmentType { Id=Guid.Parse("e90cf4eb-e33d-4897-9b21-1058028224c9"), Code="Interim", Description="Interim", SortOrder=Convert.ToDecimal("24.00") },
            new RefAssessmentType { Id=Guid.Parse("28195ed5-61e6-4bf5-9f98-21ba659587ba"), Code="KindergartenReadiness", Description="Kindergarten Readiness", SortOrder=Convert.ToDecimal("26.00") },
            new RefAssessmentType { Id=Guid.Parse("88dc06fb-bfcd-4f17-a983-4563fc2342d3"), Code="LanguageProficiency", Description="Language proficiency test", SortOrder=Convert.ToDecimal("28.00") },
            new RefAssessmentType { Id=Guid.Parse("5476362e-23ce-4698-ae81-745160eb5077"), Code="MentalAbility", Description="Mental ability (intelligence) test", SortOrder=Convert.ToDecimal("30.00") },
            new RefAssessmentType { Id=Guid.Parse("da2a59d0-d13c-4708-b40e-0cdf17e54363"), Code="Observation", Description="Observation", SortOrder=Convert.ToDecimal("32.00") },
            new RefAssessmentType { Id=Guid.Parse("a19c7c1c-6d9a-40f8-8fbc-ce2b2f92d0de"), Code="ParentReport", Description="Parent Report", SortOrder=Convert.ToDecimal("34.00") },
            new RefAssessmentType { Id=Guid.Parse("b1ff6423-0e9b-4336-94c4-43c7b8622fe8"), Code="PerformanceAssessment", Description="Performance assessment", SortOrder=Convert.ToDecimal("36.00") },
            new RefAssessmentType { Id=Guid.Parse("99906ed2-c195-461e-8892-aed19814a47a"), Code="PortfolioAssessment", Description="Portfolio assessment", SortOrder=Convert.ToDecimal("38.00") },
            new RefAssessmentType { Id=Guid.Parse("27a9df1c-db51-4f9c-a96c-adeab36b1c7d"), Code="PrekindergartenReadiness", Description="Prekindergarten Readiness", SortOrder=Convert.ToDecimal("40.00") },
            new RefAssessmentType { Id=Guid.Parse("adcb8143-9b85-43e1-90a4-b78fe4344ffc"), Code="ReadingReadiness", Description="Reading readiness test", SortOrder=Convert.ToDecimal("42.00") },
            new RefAssessmentType { Id=Guid.Parse("b2cd8cc7-ceba-4adb-9281-3d1ede02294a"), Code="Screening", Description="Screening", SortOrder=Convert.ToDecimal("44.00") },
            new RefAssessmentType { Id=Guid.Parse("d02de5c4-4f21-4836-971e-b374ded472ef"), Code="TeacherReport", Description="Teacher Report", SortOrder=Convert.ToDecimal("46.00") },
            new RefAssessmentType { Id=Guid.Parse("5a5097af-dace-48aa-a427-78e5e7610dc7"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("48.00") },
       };
   }
}
