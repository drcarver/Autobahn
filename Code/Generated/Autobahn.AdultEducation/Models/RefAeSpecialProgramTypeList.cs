//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   RefAeSpecialProgramTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The list of RefAeSpecialProgramType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAeSpecialProgramType"> List
         /// </summary>
        public static List<RefAeSpecialProgramType> RefAeSpecialProgramTypeList = new List<RefAeSpecialProgramType>
        {
            new RefAeSpecialProgramType { Id=Guid.Parse("088278d9-8f37-4c23-a73d-cd377196844c"), Code="CorrectionalEducation", Description="Correctional education program", Definition="A program of Adult Basic Education (ABE), Adult Secondary Education (ASE), or English Language Learner (ELL) instruction for adult criminal offenders in correctional institutions.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("667365e1-cae4-450a-a708-a305356cc34c"), Code="FamilyLiteracy", Description="Family Literacy Program", Definition="A program with a literacy component for parents and children or other intergenerational literacy components.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("88e3057c-5206-467e-ac4e-fff45ee595bb"), Code="WorkplaceLiteracy", Description="Workplace Adult Education and Literacy Activities", Definition="Adult education and literacy activities offered by an eligible provider in collaboration with an employer or employee organization at a workplace or an off-site location that is designed to improve the productivity of the workforce.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("efbecec8-ad19-4ebd-bb3b-06ac549f27b2"), Code="Homeless", Description="Program for the Homeless", Definition="Program for the Homeless is specified as the type, by location or delivery mode, of adult education instruction program in which an adult participates.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("5f478a73-b902-41a6-87c9-d6bdaef5a178"), Code="Co-enrollment", Description="Co-enrollment in adult education and postsecondary education", Definition="Co-enrollment in adult education and postsecondary education is specified as the type, by location or delivery mode, of adult education instruction program in which an adult participates.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("94d06bdc-452a-43fb-b318-d0ed1460a6e7"), Code="DistanceEducation", Description="Distance Education", Definition="Formal learning activity where students and instructors are separated by geography, time, or both for the majority of the instructional period. Distance learning materials are delivered through a variety of media, including but not limited to, print, audio recording, videotape, broadcasts, computer software, web-based programs, and other online technology. Teachers support distance learners through communication by mail, telephone, e-mail, or online technologies and software.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("6a85231d-d41e-4211-ba35-d6645d62d8d2"), Code="CommunityCorrections", Description="Community Corrections Programs", Definition="A community-based rehabilitation facility or halfway house.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("68be874f-9c00-4d18-afb0-d7e1b5749c55"), Code="IntegratedEducationTraining", Description="Integrated Education and Training (IET)", Definition="A service approach that provides adult education and literacy activities concurrently and contextually with workforce preparation activities and workforce training for a specific occupation or occupational cluster for the purpose of educational and career advancement.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("97e39b5e-1abb-4861-9b5b-1e1bf641275f"), Code="OtherInstitutional", Description="Other Institutional Programs", Definition="Any other medical or special institution.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The RefAeSpecialProgramType Pick List
         /// </summary>
        public static List<RefAeSpecialProgramType> RefAeSpecialProgramTypePickList = new List<RefAeSpecialProgramType>
        {
            new RefAeSpecialProgramType { Id=Guid.Parse("088278d9-8f37-4c23-a73d-cd377196844c"), Code="CorrectionalEducation", Description="Correctional education program", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("667365e1-cae4-450a-a708-a305356cc34c"), Code="FamilyLiteracy", Description="Family Literacy Program", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("88e3057c-5206-467e-ac4e-fff45ee595bb"), Code="WorkplaceLiteracy", Description="Workplace Adult Education and Literacy Activities", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("efbecec8-ad19-4ebd-bb3b-06ac549f27b2"), Code="Homeless", Description="Program for the Homeless", SortOrder=Convert.ToDecimal("4.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("5f478a73-b902-41a6-87c9-d6bdaef5a178"), Code="Co-enrollment", Description="Co-enrollment in adult education and postsecondary education", SortOrder=Convert.ToDecimal("5.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("94d06bdc-452a-43fb-b318-d0ed1460a6e7"), Code="DistanceEducation", Description="Distance Education", SortOrder=Convert.ToDecimal("8.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("6a85231d-d41e-4211-ba35-d6645d62d8d2"), Code="CommunityCorrections", Description="Community Corrections Programs", SortOrder=Convert.ToDecimal("9.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("68be874f-9c00-4d18-afb0-d7e1b5749c55"), Code="IntegratedEducationTraining", Description="Integrated Education and Training (IET)", SortOrder=Convert.ToDecimal("10.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("97e39b5e-1abb-4861-9b5b-1e1bf641275f"), Code="OtherInstitutional", Description="Other Institutional Programs", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
