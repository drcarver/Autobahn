//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentPlatformTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentPlatformType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentPlatformType"> List
         /// </summary>
        public static List<RefAssessmentPlatformType> RefAssessmentPlatformTypeList = new List<RefAssessmentPlatformType>
        {
            new RefAssessmentPlatformType { Id=Guid.Parse("c8dc076d-54f7-45f5-864e-f9d030fb17d3"), Code="Paper", Description="Paper", Definition="Paper is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("be43c805-ed4c-42f1-9d45-98a515d8ca52"), Code="Computer", Description="Computer", Definition="Computer is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("6b1d3257-a7ff-4aad-a4bd-98a9a7228df1"), Code="Mobile", Description="Mobile", Definition="Mobile is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("d593faed-ef17-470c-b6b0-8ba0ecc54843"), Code="Clicker", Description="Clicker", Definition="Clicker is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("4027b81d-1e38-410f-a698-0329ad4f89d0"), Code="Other", Description="Other", Definition="Other is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("da69c016-0310-4261-a89a-88191ed25664"), Code="Handheld", Description="Handheld", Definition="Handheld is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("005165bd-e727-4a9d-975d-580daf5d06a3"), Code="Tablet", Description="Tablet", Definition="Tablet is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefAssessmentPlatformType Pick List
         /// </summary>
        public static List<RefAssessmentPlatformType> RefAssessmentPlatformTypePickList = new List<RefAssessmentPlatformType>
        {
            new RefAssessmentPlatformType { Id=Guid.Parse("c8dc076d-54f7-45f5-864e-f9d030fb17d3"), Code="Paper", Description="Paper", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("be43c805-ed4c-42f1-9d45-98a515d8ca52"), Code="Computer", Description="Computer", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("6b1d3257-a7ff-4aad-a4bd-98a9a7228df1"), Code="Mobile", Description="Mobile", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("d593faed-ef17-470c-b6b0-8ba0ecc54843"), Code="Clicker", Description="Clicker", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("4027b81d-1e38-410f-a698-0329ad4f89d0"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("da69c016-0310-4261-a89a-88191ed25664"), Code="Handheld", Description="Handheld", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("005165bd-e727-4a9d-975d-580daf5d06a3"), Code="Tablet", Description="Tablet", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
