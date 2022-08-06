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
        /// The complete <see cref="RefPsEnrollmentAwardType"> List
         /// </summary>
        public static List<RefPsEnrollmentAwardType> RefPsEnrollmentAwardTypeList = new List<RefPsEnrollmentAwardType>
        {
            new RefPsEnrollmentAwardType { Id=Guid.Parse("7fe75728-142d-41b3-acbf-64c98dd236cd"), Code="01", Description="Postsecondary award, certificate, or diploma of less than 1 academic year", Definition="Postsecondary award, certificate, or diploma of less than 1 academic year is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("950ba7c2-cfb1-4c9f-b0b3-ed826e3238fd"), Code="02", Description="Postsecondary award, certificate, or diploma of at least 1 but less than 2 academic years", Definition="Postsecondary award, certificate, or diploma of at least 1 but less than 2 academic years is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("54bedaaa-e616-4c0c-a282-967d41b33a2d"), Code="03", Description="Associate's Degree", Definition="Associate's Degree is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("231adb0c-99b5-4876-beb9-70784e830290"), Code="04", Description="Postsecondary award, certificate, or diploma of at least 2 but less than 4 academic  years", Definition="Postsecondary award, certificate, or diploma of at least 2 but less than 4 academic  years is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("411a8ad1-ec5f-4d83-a732-5ec96c96c3ac"), Code="05", Description="Bachelor's Degree", Definition="Bachelor's Degree is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("50470fd8-285f-4e3f-93e1-98aad186a524"), Code="06", Description="Postbaccalaureate Certificate", Definition="Postbaccalaureate Certificate is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("5789f19c-b56b-46bf-8df0-1d5d2f039ac4"), Code="07", Description="Master's Degree", Definition="Master's Degree is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("7.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("7fc2431a-b055-4a79-aceb-b4c078dfeb36"), Code="08", Description="Post-Master's Certificate", Definition="Post-Master's Certificate is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("8.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("d6f34ff6-32ee-428b-8d69-02ae1db2ea59"), Code="17", Description="Doctor's Degree-Research/Scholarship", Definition="Doctor's Degree-Research/Scholarship is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("9.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("0c5190bc-0fe0-48fd-a148-6ccc421514f5"), Code="18", Description="Doctor's Degree-Professional Practice", Definition="Doctor's Degree-Professional Practice is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("10.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("4819ae92-0e19-40d7-a62d-ebb9b2faa988"), Code="19", Description="Doctor's Degree-Other", Definition="Doctor's Degree-Other is the award level in which the person is currently enrolled.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The RefPsEnrollmentAwardType Pick List
         /// </summary>
        public static List<RefPsEnrollmentAwardType> RefPsEnrollmentAwardTypePickList = new List<RefPsEnrollmentAwardType>
        {
            new RefPsEnrollmentAwardType { Id=Guid.Parse("7fe75728-142d-41b3-acbf-64c98dd236cd"), Code="01", Description="Postsecondary award, certificate, or diploma of less than 1 academic year", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("950ba7c2-cfb1-4c9f-b0b3-ed826e3238fd"), Code="02", Description="Postsecondary award, certificate, or diploma of at least 1 but less than 2 academic years", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("54bedaaa-e616-4c0c-a282-967d41b33a2d"), Code="03", Description="Associate's Degree", SortOrder=Convert.ToDecimal("3.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("231adb0c-99b5-4876-beb9-70784e830290"), Code="04", Description="Postsecondary award, certificate, or diploma of at least 2 but less than 4 academic  years", SortOrder=Convert.ToDecimal("4.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("411a8ad1-ec5f-4d83-a732-5ec96c96c3ac"), Code="05", Description="Bachelor's Degree", SortOrder=Convert.ToDecimal("5.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("50470fd8-285f-4e3f-93e1-98aad186a524"), Code="06", Description="Postbaccalaureate Certificate", SortOrder=Convert.ToDecimal("6.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("5789f19c-b56b-46bf-8df0-1d5d2f039ac4"), Code="07", Description="Master's Degree", SortOrder=Convert.ToDecimal("7.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("7fc2431a-b055-4a79-aceb-b4c078dfeb36"), Code="08", Description="Post-Master's Certificate", SortOrder=Convert.ToDecimal("8.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("d6f34ff6-32ee-428b-8d69-02ae1db2ea59"), Code="17", Description="Doctor's Degree-Research/Scholarship", SortOrder=Convert.ToDecimal("9.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("0c5190bc-0fe0-48fd-a148-6ccc421514f5"), Code="18", Description="Doctor's Degree-Professional Practice", SortOrder=Convert.ToDecimal("10.00") },
            new RefPsEnrollmentAwardType { Id=Guid.Parse("4819ae92-0e19-40d7-a62d-ebb9b2faa988"), Code="19", Description="Doctor's Degree-Other", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
