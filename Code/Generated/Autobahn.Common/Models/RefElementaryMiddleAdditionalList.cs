//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefElementaryMiddleAdditionalList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefElementaryMiddleAdditional Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefElementaryMiddleAdditionalModel"> List
         /// </summary>
        public static List<RefElementaryMiddleAdditionalModel> RefElementaryMiddleAdditionalList = new List<RefElementaryMiddleAdditionalModel>
        {
            new RefElementaryMiddleAdditional { Id=Guid.Parse("e988ca87-c571-471a-ab82-e1341dbfd979"), Code="MetAdditionalIndicator", Description="Met Additional Indicator", Definition="The school or district met the additional indicator for all students.", SortOrder=Convert.ToDecimal("1.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("3e07c24f-3442-475c-b226-0ff19e13b256"), Code="DidNotMeet", Description="Did Not Meet", Definition="The school or district did not meet the additional indicator for all students.", SortOrder=Convert.ToDecimal("2.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("c5d2edbb-7779-4ce6-94da-fa54a7930d82"), Code="TooFewStudents", Description="Too Few Students", Definition="The number of students in the school or district was less than the minimum group size outlined in a state's consolidated accountability workbook necessary required to reliably calculate the additional indicator status.", SortOrder=Convert.ToDecimal("3.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("188a42ad-a7c3-4226-89f7-3f450b757ff8"), Code="NoStudents", Description="No Students", Definition="There were no students.", SortOrder=Convert.ToDecimal("4.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("84b6ac95-c88c-47a0-81a4-b248ffe7598a"), Code="NA", Description="Not applicable", Definition="Elementary/Middle Additional Indicator status is not applicable.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefElementaryMiddleAdditional Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefElementaryMiddleAdditionalViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefElementaryMiddleAdditional { Id=Guid.Parse("e988ca87-c571-471a-ab82-e1341dbfd979"), Description="Met Additional Indicator", SortOrder=Convert.ToDecimal("1.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("3e07c24f-3442-475c-b226-0ff19e13b256"), Description="Did Not Meet", SortOrder=Convert.ToDecimal("2.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("c5d2edbb-7779-4ce6-94da-fa54a7930d82"), Description="Too Few Students", SortOrder=Convert.ToDecimal("3.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("188a42ad-a7c3-4226-89f7-3f450b757ff8"), Description="No Students", SortOrder=Convert.ToDecimal("4.00") },
            new RefElementaryMiddleAdditional { Id=Guid.Parse("84b6ac95-c88c-47a0-81a4-b248ffe7598a"), Description="Not applicable", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
