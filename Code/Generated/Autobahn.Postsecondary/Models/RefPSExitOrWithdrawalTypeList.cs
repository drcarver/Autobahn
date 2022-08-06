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
        public static List<RefPSExitOrWithdrawalType> RefPSExitOrWithdrawalTypeList = new List<RefPSExitOrWithdrawalType> =
        {
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("1e390a0a-2589-4575-8bb8-121f1b8752b6"), Code="A student enrolled in a postsecondary institution who has withdrawn, dropped out, failed to re-enroll or been terminated, expelled or dismissed by the institution is considered withdrawn.", Description="Withdrawn", Definition="", SortOrder=0 },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("a558ca92-cce7-47b5-8462-ea71f13335f0"), Code="A student who was enrolled in an eligible postsecondary institution and completed the requirements for graduation or the program of study in which he/she was enrolled is considered graduated.", Description="Graduated", Definition="", SortOrder=0 },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("10c543e3-884d-4868-b6e6-d2f19943b957"), Code="A student who is enrolled in an eligible postsecondary institution and has met the requirements for an approved student loan leave of absence and, therefore, is not required to attend classes for a specified period of time. For purposes of Title IV, HEA program loan borrower, an institution does not have to treat a leave of absence as a withdrawal if it is an approved leave of absence. An approved student loan leave of absence must not exceed 180 days in any 12-month-period. The number of days in a leave of absence is counted beginning with the first day of the student's initial leave of absence in a 12-month period. If a student does not resume attendance at the institution at or before the end of a leave of absence, the institution must treat the student as a withdrawal in accordance with CFR 668.22(d).", Description="ApprovedLeaveOfAbsence", Definition="", SortOrder=0 },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("479788eb-b8d6-448b-a631-fb814aea37ac"), Code="Student is deceased.", Description="Deceased", Definition="", SortOrder=0 },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("79b84a50-cb8d-48c1-b7fa-71dbce4c5928"), Code="Student's exit circumstances are unknown.", Description="Unknown", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPSExitOrWithdrawalType Pick List
         /// </summary>
        public static List<RefPSExitOrWithdrawalType> RefPSExitOrWithdrawalTypePickList = new List<RefPSExitOrWithdrawalType> =
        {
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("1e390a0a-2589-4575-8bb8-121f1b8752b6"), Code="A student enrolled in a postsecondary institution who has withdrawn, dropped out, failed to re-enroll or been terminated, expelled or dismissed by the institution is considered withdrawn.", SortOrder=0 },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("a558ca92-cce7-47b5-8462-ea71f13335f0"), Code="A student who was enrolled in an eligible postsecondary institution and completed the requirements for graduation or the program of study in which he/she was enrolled is considered graduated.", SortOrder=0 },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("10c543e3-884d-4868-b6e6-d2f19943b957"), Code="A student who is enrolled in an eligible postsecondary institution and has met the requirements for an approved student loan leave of absence and, therefore, is not required to attend classes for a specified period of time. For purposes of Title IV, HEA program loan borrower, an institution does not have to treat a leave of absence as a withdrawal if it is an approved leave of absence. An approved student loan leave of absence must not exceed 180 days in any 12-month-period. The number of days in a leave of absence is counted beginning with the first day of the student's initial leave of absence in a 12-month period. If a student does not resume attendance at the institution at or before the end of a leave of absence, the institution must treat the student as a withdrawal in accordance with CFR 668.22(d).", SortOrder=0 },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("479788eb-b8d6-448b-a631-fb814aea37ac"), Code="Student is deceased.", SortOrder=0 },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("79b84a50-cb8d-48c1-b7fa-71dbce4c5928"), Code="Student's exit circumstances are unknown.", SortOrder=0 },
       };
   }
}
