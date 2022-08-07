//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRoleList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefRole Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRoleModel"> List
         /// </summary>
        public static List<RefRoleModel> RefRoleList = new List<RefRoleModel>
        {
            new RefRole { Id=Guid.Parse("13ae873d-8623-4e16-a194-85e5164b511f"), Code="AEStaff", Description="AE Staff", Definition="A person for whom instruction and/or services are provided in an Adult Education program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefRole { Id=Guid.Parse("6516e3d7-cb16-473f-9b04-9c6c753a8825"), Code="AEStudent", Description="AE Student", Definition="An individual who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff in a Career and Technical Education program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefRole { Id=Guid.Parse("d16dc009-2eea-40d2-9f54-09f393e60441"), Code="CTEStaff", Description="CTE Staff", Definition="A person for whom instruction, services, and/or care are provided in a Career and Technical Education program and who has met the state-defined threshold of Career and Technical Education participation.", SortOrder=Convert.ToDecimal("3.00") },
            new RefRole { Id=Guid.Parse("ee3034c2-3934-4bda-ab2e-8306d231cbe1"), Code="CTEStudent", Description="CTE Student", Definition="An individual who is an applicant of a postsecondary institution.", SortOrder=Convert.ToDecimal("4.00") },
            new RefRole { Id=Guid.Parse("641e75e2-c063-4849-9fdf-5f9dde030f04"), Code="ELChild", Description="EL Child", Definition="A person for whom instruction, services, and/or care are provided in an early childhood program under the jurisdiction of a school, education agency, or other institution or program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefRole { Id=Guid.Parse("82f17420-2165-4614-a886-a11fe43fbe0d"), Code="ELStaff", Description="EL Staff", Definition="A person who performs specified activities for a public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the early childhood level.", SortOrder=Convert.ToDecimal("6.00") },
            new RefRole { Id=Guid.Parse("f449c2ef-6f82-4c7e-b3e9-5069374137b9"), Code="K12Staff", Description="K12 Staff", Definition="An individual who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the early childhood level through high school completion.", SortOrder=Convert.ToDecimal("7.00") },
            new RefRole { Id=Guid.Parse("8f4e98cb-01c3-4bc7-a9df-f90dda261557"), Code="K12Student", Description="K12 Student", Definition="A person for whom instruction, services, and/or care are provided in an elementary or secondary educational program under the jurisdiction of a school, education agency, or other institution or program.", SortOrder=Convert.ToDecimal("8.00") },
            new RefRole { Id=Guid.Parse("6d5cbfcc-5fe1-4a6f-9a00-17382b493489"), Code="ParentGuardian", Description="Parent/Guardian", Definition="A person having parental or legal guardianship responsibility for a learner.", SortOrder=Convert.ToDecimal("9.00") },
            new RefRole { Id=Guid.Parse("71eaacc7-29fe-4ebc-89c0-d01ae43162cc"), Code="PSApplicant", Description="PS Applicant", Definition="A person who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the postsecondary level.", SortOrder=Convert.ToDecimal("10.00") },
            new RefRole { Id=Guid.Parse("9a27fac0-902d-4f06-a303-7e8c2bcaa32d"), Code="PSStaff", Description="PS Staff", Definition="An individual who is a prospect, applicant, admitted student, enrolled student, or alum of a postsecondary institution.", SortOrder=Convert.ToDecimal("11.00") },
            new RefRole { Id=Guid.Parse("f28a80a6-0fa7-4d57-bf70-f8d8b0a481a6"), Code="PSStudent", Description="PS Student", Definition="", SortOrder=Convert.ToDecimal("12.00") },
            new RefRole { Id=Guid.Parse("e7574ac3-ea2b-4c70-b0e4-12315dd53245"), Code="WorkforceProgramParticipant", Description="Workforce Program Participant", Definition="A person who is employed by an Adult Education program.", SortOrder=Convert.ToDecimal("13.00") },
        };

        /// <summary>
        /// The Reference RefRole Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefRoleViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefRole { Id=Guid.Parse("13ae873d-8623-4e16-a194-85e5164b511f"), Description="AE Staff", SortOrder=Convert.ToDecimal("1.00") },
            new RefRole { Id=Guid.Parse("6516e3d7-cb16-473f-9b04-9c6c753a8825"), Description="AE Student", SortOrder=Convert.ToDecimal("2.00") },
            new RefRole { Id=Guid.Parse("d16dc009-2eea-40d2-9f54-09f393e60441"), Description="CTE Staff", SortOrder=Convert.ToDecimal("3.00") },
            new RefRole { Id=Guid.Parse("ee3034c2-3934-4bda-ab2e-8306d231cbe1"), Description="CTE Student", SortOrder=Convert.ToDecimal("4.00") },
            new RefRole { Id=Guid.Parse("641e75e2-c063-4849-9fdf-5f9dde030f04"), Description="EL Child", SortOrder=Convert.ToDecimal("5.00") },
            new RefRole { Id=Guid.Parse("82f17420-2165-4614-a886-a11fe43fbe0d"), Description="EL Staff", SortOrder=Convert.ToDecimal("6.00") },
            new RefRole { Id=Guid.Parse("f449c2ef-6f82-4c7e-b3e9-5069374137b9"), Description="K12 Staff", SortOrder=Convert.ToDecimal("7.00") },
            new RefRole { Id=Guid.Parse("8f4e98cb-01c3-4bc7-a9df-f90dda261557"), Description="K12 Student", SortOrder=Convert.ToDecimal("8.00") },
            new RefRole { Id=Guid.Parse("6d5cbfcc-5fe1-4a6f-9a00-17382b493489"), Description="Parent/Guardian", SortOrder=Convert.ToDecimal("9.00") },
            new RefRole { Id=Guid.Parse("71eaacc7-29fe-4ebc-89c0-d01ae43162cc"), Description="PS Applicant", SortOrder=Convert.ToDecimal("10.00") },
            new RefRole { Id=Guid.Parse("9a27fac0-902d-4f06-a303-7e8c2bcaa32d"), Description="PS Staff", SortOrder=Convert.ToDecimal("11.00") },
            new RefRole { Id=Guid.Parse("f28a80a6-0fa7-4d57-bf70-f8d8b0a481a6"), Description="PS Student", SortOrder=Convert.ToDecimal("12.00") },
            new RefRole { Id=Guid.Parse("e7574ac3-ea2b-4c70-b0e4-12315dd53245"), Description="Workforce Program Participant", SortOrder=Convert.ToDecimal("13.00") },
       };
   }
}
