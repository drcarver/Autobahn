//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefPSExitOrWithdrawalTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefPSExitOrWithdrawalType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPSExitOrWithdrawalType"> List
         /// </summary>
        public static List<RefPSExitOrWithdrawalType> RefPSExitOrWithdrawalTypeList = new List<RefPSExitOrWithdrawalType>
        {
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("cb6e4d01-4565-4da6-a0a1-4e28984ce142"), Code="Withdrawn", Description="Withdrawn", Definition="A student enrolled in a postsecondary institution who has withdrawn, dropped out, failed to re-enroll or been terminated, expelled or dismissed by the institution is considered withdrawn.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("51348af3-3b32-41e4-903b-4e22d7700d85"), Code="Graduated", Description="Graduated", Definition="A student who was enrolled in an eligible postsecondary institution and completed the requirements for graduation or the program of study in which he/she was enrolled is considered graduated.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("217e1d2a-45ef-444c-a513-dcc2be0a368e"), Code="ApprovedLeaveOfAbsence", Description="Approved Leave of Absence", Definition="A student who is enrolled in an eligible postsecondary institution and has met the requirements for an approved student loan leave of absence and, therefore, is not required to attend classes for a specified period of time. For purposes of Title IV, HEA program loan borrower, an institution does not have to treat a leave of absence as a withdrawal if it is an approved leave of absence. An approved student loan leave of absence must not exceed 180 days in any 12-month-period. The number of days in a leave of absence is counted beginning with the first day of the student's initial leave of absence in a 12-month period. If a student does not resume attendance at the institution at or before the end of a leave of absence, the institution must treat the student as a withdrawal in accordance with CFR 668.22(d).", SortOrder=Convert.ToDecimal("5.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("f3a51660-5d11-47a4-b17e-74e7a7931721"), Code="Deceased", Description="Deceased", Definition="Student is deceased.", SortOrder=Convert.ToDecimal("7.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("b5061f0e-9ecc-452f-9040-c4006bdf33ca"), Code="Unknown", Description="Unknown", Definition="Student's exit circumstances are unknown.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefPSExitOrWithdrawalType Pick List
         /// </summary>
        public static List<RefPSExitOrWithdrawalType> RefPSExitOrWithdrawalTypePickList = new List<RefPSExitOrWithdrawalType>
        {
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("cb6e4d01-4565-4da6-a0a1-4e28984ce142"), Code="Withdrawn", Description="Withdrawn", SortOrder=Convert.ToDecimal("1.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("51348af3-3b32-41e4-903b-4e22d7700d85"), Code="Graduated", Description="Graduated", SortOrder=Convert.ToDecimal("3.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("217e1d2a-45ef-444c-a513-dcc2be0a368e"), Code="ApprovedLeaveOfAbsence", Description="Approved Leave of Absence", SortOrder=Convert.ToDecimal("5.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("f3a51660-5d11-47a4-b17e-74e7a7931721"), Code="Deceased", Description="Deceased", SortOrder=Convert.ToDecimal("7.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("b5061f0e-9ecc-452f-9040-c4006bdf33ca"), Code="Unknown", Description="Unknown", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
