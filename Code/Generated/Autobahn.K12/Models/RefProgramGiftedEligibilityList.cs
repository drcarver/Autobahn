//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefProgramGiftedEligibilityList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefProgramGiftedEligibility Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProgramGiftedEligibilityModel"> List
         /// </summary>
        public static List<RefProgramGiftedEligibilityModel> RefProgramGiftedEligibilityList = new List<RefProgramGiftedEligibilityModel>
        {
            new RefProgramGiftedEligibility { Id=Guid.Parse("e56119e5-869d-4309-b33c-df1d980bb95f"), Code="13452", Description="General Intellectual Aptitude only", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude only.", SortOrder=Convert.ToDecimal("0.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("b82a653b-2e29-4bbd-b249-622b94505790"), Code="13453", Description="Specific Academic Aptitude only", Definition="The student's eligibility for Gifted/Talented program is in the category: Specific Academic Aptitude only.", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("ac4e6ddb-eab2-4be2-8921-3f24b21d25bd"), Code="13454", Description="Visual/Performing Arts only", Definition="The student's eligibility for Gifted/Talented program is in the category: Visual/Performing Arts only.", SortOrder=Convert.ToDecimal("4.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("1c3d4bee-2b13-47b6-8b8f-2a29013e8c68"), Code="13456", Description="General Intellectual Aptitude & Specific Academic Aptitude", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude & Specific Academic Aptitude.", SortOrder=Convert.ToDecimal("6.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("8e283007-b239-4a5c-a34f-9bdccc9b35df"), Code="13457", Description="General Intellectual Aptitude & Visual/Performing Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude & Visual/Performing Arts.", SortOrder=Convert.ToDecimal("8.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("c682a4ed-c0bc-4d60-960d-4dfafbee1752"), Code="13458", Description="General Intellectual Aptitude & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("10.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("fa384f38-5423-480b-a5e3-33f6a2f711fb"), Code="13459", Description="Specific Academic Aptitude & Visual/Performing Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: Specific Academic Aptitude & Visual/Performing Arts.", SortOrder=Convert.ToDecimal("12.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("4d72d834-df42-49e7-a84e-8c2ca5d79406"), Code="13460", Description="Specific Academic Aptitude & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: Specific Academic Aptitude & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("14.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("04f001fc-2496-49b2-83b2-d9cf141183e0"), Code="13461", Description="Visual/Performing Arts & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: Visual/Performing Arts & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("16.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("9cb4a803-e410-4f59-b33f-921801b40f34"), Code="13462", Description="General Intellectual Aptitude, Specific Academic Aptitude, and Visual Performing Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude, Specific Academic Aptitude, and Visual Performing Arts.", SortOrder=Convert.ToDecimal("18.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("152bfd05-70ff-482f-82df-b846e335af8a"), Code="13463", Description="General Intellectual Aptitude, Specific Academic Aptitude, & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual Aptitude, Specific Academic Aptitude, & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("20.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("a2afb785-02f5-4e22-ac2d-b93a2f70e6e7"), Code="13464", Description="Specific Academic Aptitude, Visual/Performing Arts, & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: Specific Academic Aptitude, Visual/Performing Arts, & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("22.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("a7ca72be-ea4e-4d41-b319-b28172314e9a"), Code="13465", Description="General Intellectual & Specific Academic Aptitude, Visual/Performing Arts & Technical/Practical Arts", Definition="The student's eligibility for Gifted/Talented program is in the category: General Intellectual & Specific Academic Aptitude, Visual/Performing Arts & Technical/Practical Arts.", SortOrder=Convert.ToDecimal("24.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("7946b211-9f61-4b41-b855-28c5e3805c3d"), Code="06002", Description="Not specified", Definition="The student's eligibility for Gifted/Talented program is in the category is not specified.", SortOrder=Convert.ToDecimal("26.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("05bedb6c-bea1-48d9-b162-ec788401459a"), Code="09999", Description="Other", Definition="The student's eligibility for Gifted/Talented program is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("28.00") },
        };

        /// <summary>
        /// The Reference RefProgramGiftedEligibility Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefProgramGiftedEligibilityViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefProgramGiftedEligibility { Id=Guid.Parse("e56119e5-869d-4309-b33c-df1d980bb95f"), Description="General Intellectual Aptitude only", SortOrder=Convert.ToDecimal("0.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("b82a653b-2e29-4bbd-b249-622b94505790"), Description="Specific Academic Aptitude only", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("ac4e6ddb-eab2-4be2-8921-3f24b21d25bd"), Description="Visual/Performing Arts only", SortOrder=Convert.ToDecimal("4.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("1c3d4bee-2b13-47b6-8b8f-2a29013e8c68"), Description="General Intellectual Aptitude & Specific Academic Aptitude", SortOrder=Convert.ToDecimal("6.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("8e283007-b239-4a5c-a34f-9bdccc9b35df"), Description="General Intellectual Aptitude & Visual/Performing Arts", SortOrder=Convert.ToDecimal("8.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("c682a4ed-c0bc-4d60-960d-4dfafbee1752"), Description="General Intellectual Aptitude & Technical/Practical Arts", SortOrder=Convert.ToDecimal("10.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("fa384f38-5423-480b-a5e3-33f6a2f711fb"), Description="Specific Academic Aptitude & Visual/Performing Arts", SortOrder=Convert.ToDecimal("12.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("4d72d834-df42-49e7-a84e-8c2ca5d79406"), Description="Specific Academic Aptitude & Technical/Practical Arts", SortOrder=Convert.ToDecimal("14.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("04f001fc-2496-49b2-83b2-d9cf141183e0"), Description="Visual/Performing Arts & Technical/Practical Arts", SortOrder=Convert.ToDecimal("16.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("9cb4a803-e410-4f59-b33f-921801b40f34"), Description="General Intellectual Aptitude, Specific Academic Aptitude, and Visual Performing Arts", SortOrder=Convert.ToDecimal("18.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("152bfd05-70ff-482f-82df-b846e335af8a"), Description="General Intellectual Aptitude, Specific Academic Aptitude, & Technical/Practical Arts", SortOrder=Convert.ToDecimal("20.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("a2afb785-02f5-4e22-ac2d-b93a2f70e6e7"), Description="Specific Academic Aptitude, Visual/Performing Arts, & Technical/Practical Arts", SortOrder=Convert.ToDecimal("22.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("a7ca72be-ea4e-4d41-b319-b28172314e9a"), Description="General Intellectual & Specific Academic Aptitude, Visual/Performing Arts & Technical/Practical Arts", SortOrder=Convert.ToDecimal("24.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("7946b211-9f61-4b41-b855-28c5e3805c3d"), Description="Not specified", SortOrder=Convert.ToDecimal("26.00") },
            new RefProgramGiftedEligibility { Id=Guid.Parse("05bedb6c-bea1-48d9-b162-ec788401459a"), Description="Other", SortOrder=Convert.ToDecimal("28.00") },
       };
   }
}
