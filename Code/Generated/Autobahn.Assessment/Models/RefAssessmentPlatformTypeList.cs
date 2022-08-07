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
        /// The complete <see cref="RefAssessmentPlatformTypeModel"> List
         /// </summary>
        public static List<RefAssessmentPlatformTypeModel> RefAssessmentPlatformTypeList = new List<RefAssessmentPlatformTypeModel>
        {
            new RefAssessmentPlatformType { Id=Guid.Parse("b557b101-347a-43a2-a139-cf33d9d3591d"), Code="Paper", Description="Paper", Definition="Paper is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("c1958dd7-774a-4efc-b61b-567b726b581c"), Code="Computer", Description="Computer", Definition="Computer is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("dd6135c2-6d4c-40ee-a9c9-7ee91c41e982"), Code="Mobile", Description="Mobile", Definition="Mobile is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("7dd6de0c-4748-4e26-9866-5c1800441f76"), Code="Clicker", Description="Clicker", Definition="Clicker is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("0e8e765d-6217-42b7-b2f8-fb2668ab70ae"), Code="Other", Description="Other", Definition="Other is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("ef6defbb-4bb7-4082-b0fa-cf8c956d7166"), Code="Handheld", Description="Handheld", Definition="Handheld is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("d9dc9de5-0449-44ae-b2b9-14b3e963685c"), Code="Tablet", Description="Tablet", Definition="Tablet is specified as the platform with which the assessment was delivered to the student during the assessment session.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentPlatformType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentPlatformTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentPlatformType { Id=Guid.Parse("b557b101-347a-43a2-a139-cf33d9d3591d"), Description="Paper", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("c1958dd7-774a-4efc-b61b-567b726b581c"), Description="Computer", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("dd6135c2-6d4c-40ee-a9c9-7ee91c41e982"), Description="Mobile", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("7dd6de0c-4748-4e26-9866-5c1800441f76"), Description="Clicker", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("0e8e765d-6217-42b7-b2f8-fb2668ab70ae"), Description="Other", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("ef6defbb-4bb7-4082-b0fa-cf8c956d7166"), Description="Handheld", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentPlatformType { Id=Guid.Parse("d9dc9de5-0449-44ae-b2b9-14b3e963685c"), Description="Tablet", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
