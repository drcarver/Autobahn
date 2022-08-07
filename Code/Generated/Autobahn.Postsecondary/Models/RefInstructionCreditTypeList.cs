//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefInstructionCreditTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefInstructionCreditType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInstructionCreditTypeModel"> List
         /// </summary>
        public static List<RefInstructionCreditTypeModel> RefInstructionCreditTypeList = new List<RefInstructionCreditTypeModel>
        {
            new RefInstructionCreditType { Id=Guid.Parse("fa98cc21-2353-4ce4-b679-3f3df1312d76"), Code="ExclusivelyCredit", Description="Exclusively credit", Definition="The instruction being delivered by staff whose primary responsibility is instruction is exclusively for credit.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionCreditType { Id=Guid.Parse("abf8f8b7-d580-44b6-9aae-05bb38bef83b"), Code="ExclusivelyNotForCredit", Description="Exclusively not-for-credit", Definition="The instruction being delivered by staff whose primary responsibility is instruction is exclusively not-for-credit.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionCreditType { Id=Guid.Parse("a43f88b9-a48c-46bc-8d69-a93e26668796"), Code="Combined", Description="Combined credit/not-for-credit", Definition="The instruction being delivered by staff whose primary responsibility is instruction is combined credit/not-for-credit.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefInstructionCreditType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefInstructionCreditTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefInstructionCreditType { Id=Guid.Parse("fa98cc21-2353-4ce4-b679-3f3df1312d76"), Description="Exclusively credit", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionCreditType { Id=Guid.Parse("abf8f8b7-d580-44b6-9aae-05bb38bef83b"), Description="Exclusively not-for-credit", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionCreditType { Id=Guid.Parse("a43f88b9-a48c-46bc-8d69-a93e26668796"), Description="Combined credit/not-for-credit", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
