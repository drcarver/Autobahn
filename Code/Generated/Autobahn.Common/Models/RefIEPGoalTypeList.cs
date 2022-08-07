//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIEPGoalTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIEPGoalType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIEPGoalTypeModel"> List
         /// </summary>
        public static List<RefIEPGoalTypeModel> RefIEPGoalTypeList = new List<RefIEPGoalTypeModel>
        {
            new RefIEPGoalType { Id=Guid.Parse("ae7f5f15-0f52-4d69-9489-e2aaa9eb8c1b"), Code="Academic", Description="Academic", Definition="Academic is the legal category for an IEP annual goal or short-term objectives.", SortOrder=Convert.ToDecimal("") },
            new RefIEPGoalType { Id=Guid.Parse("f29aba1c-5c1e-4fe6-87e7-cf32c44f6dd0"), Code="Functional", Description="Functional", Definition="Functional is the legal category for an IEP annual goal or short-term objectives.", SortOrder=Convert.ToDecimal("") },
            new RefIEPGoalType { Id=Guid.Parse("c8528637-b90f-441d-b86b-ec347016ff95"), Code="Transitional", Description="Transitional", Definition="Transitional is the legal category for an IEP annual goal or short-term objectives.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefIEPGoalType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIEPGoalTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIEPGoalType { Id=Guid.Parse("ae7f5f15-0f52-4d69-9489-e2aaa9eb8c1b"), Description="Academic", SortOrder=Convert.ToDecimal("") },
            new RefIEPGoalType { Id=Guid.Parse("f29aba1c-5c1e-4fe6-87e7-cf32c44f6dd0"), Description="Functional", SortOrder=Convert.ToDecimal("") },
            new RefIEPGoalType { Id=Guid.Parse("c8528637-b90f-441d-b86b-ec347016ff95"), Description="Transitional", SortOrder=Convert.ToDecimal("") },
       };
   }
}
