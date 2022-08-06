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
        /// The complete <see cref="RefInstructionCreditType"> List
         /// </summary>
        public static List<RefInstructionCreditType> RefInstructionCreditTypeList = new List<RefInstructionCreditType>
        {
            new RefInstructionCreditType { Id=Guid.Parse("a34bb544-46ec-44f4-b54f-cc0dd3bc34a4"), Code="ExclusivelyCredit", Description="Exclusively credit", Definition="The instruction being delivered by staff whose primary responsibility is instruction is exclusively for credit.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionCreditType { Id=Guid.Parse("5a94f439-6952-4b3b-9d5b-a022260f492b"), Code="ExclusivelyNotForCredit", Description="Exclusively not-for-credit", Definition="The instruction being delivered by staff whose primary responsibility is instruction is exclusively not-for-credit.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionCreditType { Id=Guid.Parse("646c17d7-cc6b-4c88-a264-7a455501b663"), Code="Combined", Description="Combined credit/not-for-credit", Definition="The instruction being delivered by staff whose primary responsibility is instruction is combined credit/not-for-credit.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefInstructionCreditType Pick List
         /// </summary>
        public static List<RefInstructionCreditType> RefInstructionCreditTypePickList = new List<RefInstructionCreditType>
        {
            new RefInstructionCreditType { Id=Guid.Parse("a34bb544-46ec-44f4-b54f-cc0dd3bc34a4"), Code="ExclusivelyCredit", Description="Exclusively credit", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionCreditType { Id=Guid.Parse("5a94f439-6952-4b3b-9d5b-a022260f492b"), Code="ExclusivelyNotForCredit", Description="Exclusively not-for-credit", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionCreditType { Id=Guid.Parse("646c17d7-cc6b-4c88-a264-7a455501b663"), Code="Combined", Description="Combined credit/not-for-credit", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
