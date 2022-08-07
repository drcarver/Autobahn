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
        /// The complete <see cref="RefAeSpecialProgramTypeModel"> List
         /// </summary>
        public static List<RefAeSpecialProgramTypeModel> RefAeSpecialProgramTypeList = new List<RefAeSpecialProgramTypeModel>
        {
            new RefAeSpecialProgramType { Id=Guid.Parse("bb598a14-5ac0-4714-a256-341d19bc06ad"), Code="CorrectionalEducation", Description="Correctional education program", Definition="A program of Adult Basic Education (ABE), Adult Secondary Education (ASE), or English Language Learner (ELL) instruction for adult criminal offenders in correctional institutions.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("ce9af178-3564-49c6-ad46-167872110b3d"), Code="FamilyLiteracy", Description="Family Literacy Program", Definition="A program with a literacy component for parents and children or other intergenerational literacy components.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("c09bc0a8-302c-46fd-bbb7-8a366724a703"), Code="WorkplaceLiteracy", Description="Workplace Adult Education and Literacy Activities", Definition="Adult education and literacy activities offered by an eligible provider in collaboration with an employer or employee organization at a workplace or an off-site location that is designed to improve the productivity of the workforce.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("5f13107b-58c5-4f91-af24-a3793a497769"), Code="Homeless", Description="Program for the Homeless", Definition="Program for the Homeless is specified as the type, by location or delivery mode, of adult education instruction program in which an adult participates.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("188f7ac4-f1ff-4b91-a015-d7231ad694ec"), Code="Co-enrollment", Description="Co-enrollment in adult education and postsecondary education", Definition="Co-enrollment in adult education and postsecondary education is specified as the type, by location or delivery mode, of adult education instruction program in which an adult participates.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("626dc43a-cab3-4692-99b2-a77650ad80cc"), Code="DistanceEducation", Description="Distance Education", Definition="Formal learning activity where students and instructors are separated by geography, time, or both for the majority of the instructional period. Distance learning materials are delivered through a variety of media, including but not limited to, print, audio recording, videotape, broadcasts, computer software, web-based programs, and other online technology. Teachers support distance learners through communication by mail, telephone, e-mail, or online technologies and software.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("d5786d27-4ec8-46d8-9a38-794cdec462ff"), Code="CommunityCorrections", Description="Community Corrections Programs", Definition="A community-based rehabilitation facility or halfway house.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("fcb66080-3910-4d7e-a173-4c7be2f2b3a9"), Code="IntegratedEducationTraining", Description="Integrated Education and Training (IET)", Definition="A service approach that provides adult education and literacy activities concurrently and contextually with workforce preparation activities and workforce training for a specific occupation or occupational cluster for the purpose of educational and career advancement.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("6b48a163-a87a-4106-b7e2-68c86057e377"), Code="OtherInstitutional", Description="Other Institutional Programs", Definition="Any other medical or special institution.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The Reference RefAeSpecialProgramType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAeSpecialProgramTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAeSpecialProgramType { Id=Guid.Parse("bb598a14-5ac0-4714-a256-341d19bc06ad"), Description="Correctional education program", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("ce9af178-3564-49c6-ad46-167872110b3d"), Description="Family Literacy Program", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("c09bc0a8-302c-46fd-bbb7-8a366724a703"), Description="Workplace Adult Education and Literacy Activities", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("5f13107b-58c5-4f91-af24-a3793a497769"), Description="Program for the Homeless", SortOrder=Convert.ToDecimal("4.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("188f7ac4-f1ff-4b91-a015-d7231ad694ec"), Description="Co-enrollment in adult education and postsecondary education", SortOrder=Convert.ToDecimal("5.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("626dc43a-cab3-4692-99b2-a77650ad80cc"), Description="Distance Education", SortOrder=Convert.ToDecimal("8.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("d5786d27-4ec8-46d8-9a38-794cdec462ff"), Description="Community Corrections Programs", SortOrder=Convert.ToDecimal("9.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("fcb66080-3910-4d7e-a173-4c7be2f2b3a9"), Description="Integrated Education and Training (IET)", SortOrder=Convert.ToDecimal("10.00") },
            new RefAeSpecialProgramType { Id=Guid.Parse("6b48a163-a87a-4106-b7e2-68c86057e377"), Description="Other Institutional Programs", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
