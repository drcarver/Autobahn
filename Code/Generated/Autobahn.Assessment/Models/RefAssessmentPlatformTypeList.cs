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
        public static List<RefAssessmentPlatformType> RefAssessmentPlatformTypeList = new List<RefAssessmentPlatformType> =
        {
            new RefAssessmentPlatformType { Id=Guid.Parse("8c1e2241-2083-48f7-ae8e-678e35da839f"), Code="Paper is specified as the platform with which the assessment was delivered to the student during the assessment session.", Description="Paper", Definition="", SortOrder=0 },
            new RefAssessmentPlatformType { Id=Guid.Parse("10277817-e5af-4aa6-ad02-d9dda512848a"), Code="Computer is specified as the platform with which the assessment was delivered to the student during the assessment session.", Description="Computer", Definition="", SortOrder=0 },
            new RefAssessmentPlatformType { Id=Guid.Parse("6e67483b-b461-478f-a33d-11623e54fa02"), Code="Mobile is specified as the platform with which the assessment was delivered to the student during the assessment session.", Description="Mobile", Definition="", SortOrder=0 },
            new RefAssessmentPlatformType { Id=Guid.Parse("0fd46a15-b7ec-43b1-8b04-530978085ede"), Code="Clicker is specified as the platform with which the assessment was delivered to the student during the assessment session.", Description="Clicker", Definition="", SortOrder=0 },
            new RefAssessmentPlatformType { Id=Guid.Parse("38e8d9b6-36d9-47b1-8af3-67d461b56518"), Code="Other is specified as the platform with which the assessment was delivered to the student during the assessment session.", Description="Other", Definition="", SortOrder=0 },
            new RefAssessmentPlatformType { Id=Guid.Parse("c670ce72-2941-4446-a1d5-56656bb49336"), Code="Handheld is specified as the platform with which the assessment was delivered to the student during the assessment session.", Description="Handheld", Definition="", SortOrder=0 },
            new RefAssessmentPlatformType { Id=Guid.Parse("d9a9a26f-1f05-44f9-a631-979d899a22cd"), Code="Tablet is specified as the platform with which the assessment was delivered to the student during the assessment session.", Description="Tablet", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentPlatformType Pick List
         /// </summary>
        public static List<RefAssessmentPlatformType> RefAssessmentPlatformTypePickList = new List<RefAssessmentPlatformType> =
        {
            new RefAssessmentPlatformType { Id=Guid.Parse("8c1e2241-2083-48f7-ae8e-678e35da839f"), Code="Paper is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=0 },
            new RefAssessmentPlatformType { Id=Guid.Parse("10277817-e5af-4aa6-ad02-d9dda512848a"), Code="Computer is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=0 },
            new RefAssessmentPlatformType { Id=Guid.Parse("6e67483b-b461-478f-a33d-11623e54fa02"), Code="Mobile is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=0 },
            new RefAssessmentPlatformType { Id=Guid.Parse("0fd46a15-b7ec-43b1-8b04-530978085ede"), Code="Clicker is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=0 },
            new RefAssessmentPlatformType { Id=Guid.Parse("38e8d9b6-36d9-47b1-8af3-67d461b56518"), Code="Other is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=0 },
            new RefAssessmentPlatformType { Id=Guid.Parse("c670ce72-2941-4446-a1d5-56656bb49336"), Code="Handheld is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=0 },
            new RefAssessmentPlatformType { Id=Guid.Parse("d9a9a26f-1f05-44f9-a631-979d899a22cd"), Code="Tablet is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=0 },
       };
   }
}
