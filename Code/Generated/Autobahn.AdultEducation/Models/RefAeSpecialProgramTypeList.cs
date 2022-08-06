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
        public static List<RefAeSpecialProgramType> RefAeSpecialProgramTypeList = new List<RefAeSpecialProgramType> =
        {
            new RefAeSpecialProgramType { Id=Guid.Parse("855bd02d-145d-454a-89a4-fac72870bce0"), Code="A program of Adult Basic Education (ABE), Adult Secondary Education (ASE), or English Language Learner (ELL) instruction for adult criminal offenders in correctional institutions.", Description="CorrectionalEducation", Definition="", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("e1d8f6ad-d6f8-4f53-adfc-6bab577759a7"), Code="A program with a literacy component for parents and children or other intergenerational literacy components.", Description="FamilyLiteracy", Definition="", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("d6edeba0-2647-4775-9eac-f17a79976b17"), Code="Adult education and literacy activities offered by an eligible provider in collaboration with an employer or employee organization at a workplace or an off-site location that is designed to improve the productivity of the workforce.", Description="WorkplaceLiteracy", Definition="", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("efc80c3c-a025-43e0-b3cb-5ece532d6d9e"), Code="Program for the Homeless is specified as the type, by location or delivery mode, of adult education instruction program in which an adult participates.", Description="Homeless", Definition="", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("50b1c234-4a96-4e40-a871-6b22e30bf838"), Code="Co-enrollment in adult education and postsecondary education is specified as the type, by location or delivery mode, of adult education instruction program in which an adult participates.", Description="Co-enrollment", Definition="", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("a04889f6-3cc4-462a-b157-ab611dca259b"), Code="Formal learning activity where students and instructors are separated by geography, time, or both for the majority of the instructional period. Distance learning materials are delivered through a variety of media, including but not limited to, print, audio recording, videotape, broadcasts, computer software, web-based programs, and other online technology. Teachers support distance learners through communication by mail, telephone, e-mail, or online technologies and software.", Description="DistanceEducation", Definition="", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("19c8d345-2744-42e3-acbe-9609b9441dcc"), Code="A community-based rehabilitation facility or halfway house.", Description="CommunityCorrections", Definition="", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("229fc051-5c61-4300-b0a7-0cc2191080a4"), Code="A service approach that provides adult education and literacy activities concurrently and contextually with workforce preparation activities and workforce training for a specific occupation or occupational cluster for the purpose of educational and career advancement.", Description="IntegratedEducationTraining", Definition="", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("0c62cc1a-535a-4ad1-8204-762efa272159"), Code="Any other medical or special institution.", Description="OtherInstitutional", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAeSpecialProgramType Pick List
         /// </summary>
        public static List<RefAeSpecialProgramType> RefAeSpecialProgramTypePickList = new List<RefAeSpecialProgramType> =
        {
            new RefAeSpecialProgramType { Id=Guid.Parse("855bd02d-145d-454a-89a4-fac72870bce0"), Code="A program of Adult Basic Education (ABE), Adult Secondary Education (ASE), or English Language Learner (ELL) instruction for adult criminal offenders in correctional institutions.", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("e1d8f6ad-d6f8-4f53-adfc-6bab577759a7"), Code="A program with a literacy component for parents and children or other intergenerational literacy components.", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("d6edeba0-2647-4775-9eac-f17a79976b17"), Code="Adult education and literacy activities offered by an eligible provider in collaboration with an employer or employee organization at a workplace or an off-site location that is designed to improve the productivity of the workforce.", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("efc80c3c-a025-43e0-b3cb-5ece532d6d9e"), Code="Program for the Homeless is specified as the type, by location or delivery mode, of adult education instruction program in which an adult participates.", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("50b1c234-4a96-4e40-a871-6b22e30bf838"), Code="Co-enrollment in adult education and postsecondary education is specified as the type, by location or delivery mode, of adult education instruction program in which an adult participates.", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("a04889f6-3cc4-462a-b157-ab611dca259b"), Code="Formal learning activity where students and instructors are separated by geography, time, or both for the majority of the instructional period. Distance learning materials are delivered through a variety of media, including but not limited to, print, audio recording, videotape, broadcasts, computer software, web-based programs, and other online technology. Teachers support distance learners through communication by mail, telephone, e-mail, or online technologies and software.", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("19c8d345-2744-42e3-acbe-9609b9441dcc"), Code="A community-based rehabilitation facility or halfway house.", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("229fc051-5c61-4300-b0a7-0cc2191080a4"), Code="A service approach that provides adult education and literacy activities concurrently and contextually with workforce preparation activities and workforce training for a specific occupation or occupational cluster for the purpose of educational and career advancement.", SortOrder=0 },
            new RefAeSpecialProgramType { Id=Guid.Parse("0c62cc1a-535a-4ad1-8204-762efa272159"), Code="Any other medical or special institution.", SortOrder=0 },
       };
   }
}
