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
        /// The complete <see cref="RefPSExitOrWithdrawalTypeModel"> List
         /// </summary>
        public static List<RefPSExitOrWithdrawalTypeModel> RefPSExitOrWithdrawalTypeList = new List<RefPSExitOrWithdrawalTypeModel>
        {
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("3e6861b6-48a4-441e-a9ef-9d21850d3f77"), Code="Withdrawn", Description="Withdrawn", Definition="A student enrolled in a postsecondary institution who has withdrawn, dropped out, failed to re-enroll or been terminated, expelled or dismissed by the institution is considered withdrawn.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("b8e4c536-d8d5-43b1-994f-e1b337fbc101"), Code="Graduated", Description="Graduated", Definition="A student who was enrolled in an eligible postsecondary institution and completed the requirements for graduation or the program of study in which he/she was enrolled is considered graduated.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("90fdc632-3282-4f4e-b2d4-058135a57ab4"), Code="ApprovedLeaveOfAbsence", Description="Approved Leave of Absence", Definition="A student who is enrolled in an eligible postsecondary institution and has met the requirements for an approved student loan leave of absence and, therefore, is not required to attend classes for a specified period of time. For purposes of Title IV, HEA program loan borrower, an institution does not have to treat a leave of absence as a withdrawal if it is an approved leave of absence. An approved student loan leave of absence must not exceed 180 days in any 12-month-period. The number of days in a leave of absence is counted beginning with the first day of the student's initial leave of absence in a 12-month period. If a student does not resume attendance at the institution at or before the end of a leave of absence, the institution must treat the student as a withdrawal in accordance with CFR 668.22(d).", SortOrder=Convert.ToDecimal("5.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("bda7b1b5-5f28-436f-bf6f-eec0f35ee4af"), Code="Deceased", Description="Deceased", Definition="Student is deceased.", SortOrder=Convert.ToDecimal("7.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("c92a3a02-5f1e-41a3-b4e1-11c8cc6ad9f9"), Code="Unknown", Description="Unknown", Definition="Student's exit circumstances are unknown.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefPSExitOrWithdrawalType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPSExitOrWithdrawalTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("3e6861b6-48a4-441e-a9ef-9d21850d3f77"), Description="Withdrawn", SortOrder=Convert.ToDecimal("1.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("b8e4c536-d8d5-43b1-994f-e1b337fbc101"), Description="Graduated", SortOrder=Convert.ToDecimal("3.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("90fdc632-3282-4f4e-b2d4-058135a57ab4"), Description="Approved Leave of Absence", SortOrder=Convert.ToDecimal("5.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("bda7b1b5-5f28-436f-bf6f-eec0f35ee4af"), Description="Deceased", SortOrder=Convert.ToDecimal("7.00") },
            new RefPSExitOrWithdrawalType { Id=Guid.Parse("c92a3a02-5f1e-41a3-b4e1-11c8cc6ad9f9"), Description="Unknown", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
