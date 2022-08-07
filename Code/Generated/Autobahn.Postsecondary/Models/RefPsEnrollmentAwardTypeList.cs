//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefPsEnrollmentAwardTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefPsEnrollmentAwardType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPsEnrollmentAwardTypeModel"> List
         /// </summary>
        public static List<RefPsEnrollmentAwardTypeModel> RefPsEnrollmentAwardTypeList = new List<RefPsEnrollmentAwardTypeModel>
        {
            new RefPsEnrollmentAwardType { Id=Guid.Parse("96b3dbec-e9c1-4f72-b51d-546b2b55ee55"), Code="01", Description="Postsecondary award, certificate, or diploma of less than 1 academic year", Definition="Postsecondary award, certificate, or diploma of less than 1 academic year is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("620a97f6-a079-4a1a-a442-c59dc3151b5d"), Code="02", Description="Postsecondary award, certificate, or diploma of at least 1 but less than 2 academic years", Definition="Postsecondary award, certificate, or diploma of at least 1 but less than 2 academic years is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("fa8390e2-1704-4441-b2a0-6370b11055e1"), Code="03", Description="Associate's Degree", Definition="Associate's Degree is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("db0c82d3-d293-4613-8cfc-e68f80e856be"), Code="04", Description="Postsecondary award, certificate, or diploma of at least 2 but less than 4 academic  years", Definition="Postsecondary award, certificate, or diploma of at least 2 but less than 4 academic  years is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("9d077a55-b043-4377-84d8-084d4f8d12cb"), Code="05", Description="Bachelor's Degree", Definition="Bachelor's Degree is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("9005c465-b642-45ee-a803-a167907d934c"), Code="06", Description="Postbaccalaureate Certificate", Definition="Postbaccalaureate Certificate is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("274e39b1-308d-45fd-930b-169d52715aa7"), Code="07", Description="Master's Degree", Definition="Master's Degree is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("7.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("a64b48a1-9e34-462a-b0b3-637f37d89db9"), Code="08", Description="Post-Master's Certificate", Definition="Post-Master's Certificate is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("8.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("66c98624-bf57-45bc-883a-d40543a3a951"), Code="17", Description="Doctor's Degree-Research/Scholarship", Definition="Doctor's Degree-Research/Scholarship is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("9.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("ebf302b5-cf7f-40fa-b04f-006ca5d1f8ba"), Code="18", Description="Doctor's Degree-Professional Practice", Definition="Doctor's Degree-Professional Practice is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("10.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("cfbebb73-9b29-40df-b9d3-fef7da808272"), Code="19", Description="Doctor's Degree-Other", Definition="Doctor's Degree-Other is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The Reference RefPsEnrollmentAwardType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPsEnrollmentAwardTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPsEnrollmentAwardType { Id=Guid.Parse("96b3dbec-e9c1-4f72-b51d-546b2b55ee55"), Description="Postsecondary award, certificate, or diploma of less than 1 academic year", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("620a97f6-a079-4a1a-a442-c59dc3151b5d"), Description="Postsecondary award, certificate, or diploma of at least 1 but less than 2 academic years", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("fa8390e2-1704-4441-b2a0-6370b11055e1"), Description="Associate's Degree", SortOrder=Convert.ToDecimal("3.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("db0c82d3-d293-4613-8cfc-e68f80e856be"), Description="Postsecondary award, certificate, or diploma of at least 2 but less than 4 academic  years", SortOrder=Convert.ToDecimal("4.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("9d077a55-b043-4377-84d8-084d4f8d12cb"), Description="Bachelor's Degree", SortOrder=Convert.ToDecimal("5.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("9005c465-b642-45ee-a803-a167907d934c"), Description="Postbaccalaureate Certificate", SortOrder=Convert.ToDecimal("6.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("274e39b1-308d-45fd-930b-169d52715aa7"), Description="Master's Degree", SortOrder=Convert.ToDecimal("7.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("a64b48a1-9e34-462a-b0b3-637f37d89db9"), Description="Post-Master's Certificate", SortOrder=Convert.ToDecimal("8.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("66c98624-bf57-45bc-883a-d40543a3a951"), Description="Doctor's Degree-Research/Scholarship", SortOrder=Convert.ToDecimal("9.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("ebf302b5-cf7f-40fa-b04f-006ca5d1f8ba"), Description="Doctor's Degree-Professional Practice", SortOrder=Convert.ToDecimal("10.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("cfbebb73-9b29-40df-b9d3-fef7da808272"), Description="Doctor's Degree-Other", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
