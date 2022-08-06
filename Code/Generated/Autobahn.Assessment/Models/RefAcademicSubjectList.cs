//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAcademicSubjectList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAcademicSubject Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAcademicSubject"> List
         /// </summary>
        public static List<RefAcademicSubject> RefAcademicSubjectList = new List<RefAcademicSubject> =
        {
            new RefAcademicSubject { Id=Guid.Parse("2f411a5c-329d-4caa-8401-17923f762878"), Code="Arts is specified as the academic content or subject area being evaluated.", Description="13371", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("0025b25d-e920-4ec0-af50-e73e16effe84"), Code="Career and Technical Education is specified as the academic content or subject area being evaluated.", Description="73065", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("04df7535-b8c3-49f5-ba5d-f360ab2e744d"), Code="English is specified as the academic content or subject area being evaluated.", Description="13372", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("9a1db7e9-ad51-4b65-8027-786543907beb"), Code="English as a second language (ESL) is specified as the academic content or subject area being evaluated.", Description="00256", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("0bfcd6b1-7ffe-47a9-be2e-95019a3cb877"), Code="Foreign Languages is specified as the academic content or subject area being evaluated.", Description="00546", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("11b4699d-2e7e-468c-b61a-24d745641f98"), Code="History Government - US is specified as the academic content or subject area being evaluated.", Description="73088", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("e75a4247-9a9f-4c2d-a736-ec83d30ed865"), Code="History Government - World is specified as the academic content or subject area being evaluated.", Description="73089", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("10d31f94-b33c-4d93-8169-aedb9cdeddbf"), Code="Language arts is specified as the academic content or subject area being evaluated.", Description="00554", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("5fb14992-5b0c-468d-87fb-cae352236d7e"), Code="Mathematics is specified as the academic content or subject area being evaluated.", Description="01166", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("87bf2ceb-c61b-4bc1-acc1-69a797ebab6d"), Code="Reading is specified as the academic content or subject area being evaluated.", Description="00560", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("5d25b3a8-8cf5-4067-9d0f-25d943a57e6b"), Code="Reading/Language Arts is specified as the academic content or subject area being evaluated.", Description="13373", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("e1fa3ff5-0449-4f6d-8bbd-23dcc664988b"), Code="Science is specified as the academic content or subject area being evaluated.", Description="00562", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("02bf8ab0-3ac2-4e06-8f7c-5ef05cf6ebff"), Code="Science - Life is specified as the academic content or subject area being evaluated.", Description="73086", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("10836ff8-92a7-45f2-bffb-232113bbcfb6"), Code="Science - Physical is specified as the academic content or subject area being evaluated.", Description="73087", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("db0e7853-1752-4044-a61e-184541a03bb9"), Code="Social Sciences (History, Geography, Economics, Civics and Government) is specified as the academic content or subject area being evaluated.", Description="13374", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("a58f47a3-4934-4fe4-9313-486566d142fd"), Code="Special education is specified as the academic content or subject area being evaluated.", Description="02043", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("3eeb5d5d-cfb9-449f-b985-ddf9bbadce12"), Code="Writing is specified as the academic content or subject area being evaluated.", Description="01287", Definition="", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("9e36a153-c2c3-4af4-a9f5-73567b6d3154"), Code="Other is specified as the academic content or subject area being evaluated.", Description="09999", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAcademicSubject Pick List
         /// </summary>
        public static List<RefAcademicSubject> RefAcademicSubjectPickList = new List<RefAcademicSubject> =
        {
            new RefAcademicSubject { Id=Guid.Parse("2f411a5c-329d-4caa-8401-17923f762878"), Code="Arts is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("0025b25d-e920-4ec0-af50-e73e16effe84"), Code="Career and Technical Education is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("04df7535-b8c3-49f5-ba5d-f360ab2e744d"), Code="English is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("9a1db7e9-ad51-4b65-8027-786543907beb"), Code="English as a second language (ESL) is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("0bfcd6b1-7ffe-47a9-be2e-95019a3cb877"), Code="Foreign Languages is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("11b4699d-2e7e-468c-b61a-24d745641f98"), Code="History Government - US is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("e75a4247-9a9f-4c2d-a736-ec83d30ed865"), Code="History Government - World is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("10d31f94-b33c-4d93-8169-aedb9cdeddbf"), Code="Language arts is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("5fb14992-5b0c-468d-87fb-cae352236d7e"), Code="Mathematics is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("87bf2ceb-c61b-4bc1-acc1-69a797ebab6d"), Code="Reading is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("5d25b3a8-8cf5-4067-9d0f-25d943a57e6b"), Code="Reading/Language Arts is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("e1fa3ff5-0449-4f6d-8bbd-23dcc664988b"), Code="Science is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("02bf8ab0-3ac2-4e06-8f7c-5ef05cf6ebff"), Code="Science - Life is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("10836ff8-92a7-45f2-bffb-232113bbcfb6"), Code="Science - Physical is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("db0e7853-1752-4044-a61e-184541a03bb9"), Code="Social Sciences (History, Geography, Economics, Civics and Government) is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("a58f47a3-4934-4fe4-9313-486566d142fd"), Code="Special education is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("3eeb5d5d-cfb9-449f-b985-ddf9bbadce12"), Code="Writing is specified as the academic content or subject area being evaluated.", SortOrder=0 },
            new RefAcademicSubject { Id=Guid.Parse("9e36a153-c2c3-4af4-a9f5-73567b6d3154"), Code="Other is specified as the academic content or subject area being evaluated.", SortOrder=0 },
       };
   }
}
