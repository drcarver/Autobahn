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
        public static List<RefInstructionCreditType> RefInstructionCreditTypeList = new List<RefInstructionCreditType> =
        {
            new RefInstructionCreditType { Id=Guid.Parse("8a9acfb3-e8a8-49e3-a880-59c993220b99"), Code="The instruction being delivered by staff whose primary responsibility is instruction is exclusively for credit.", Description="ExclusivelyCredit", Definition="", SortOrder=0 },
            new RefInstructionCreditType { Id=Guid.Parse("38653e85-3966-4e2e-a962-dc83d7d71ed1"), Code="The instruction being delivered by staff whose primary responsibility is instruction is exclusively not-for-credit.", Description="ExclusivelyNotForCredit", Definition="", SortOrder=0 },
            new RefInstructionCreditType { Id=Guid.Parse("2d5187d5-a38c-4e4b-82c8-c184e26ca642"), Code="The instruction being delivered by staff whose primary responsibility is instruction is combined credit/not-for-credit.", Description="Combined", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefInstructionCreditType Pick List
         /// </summary>
        public static List<RefInstructionCreditType> RefInstructionCreditTypePickList = new List<RefInstructionCreditType> =
        {
            new RefInstructionCreditType { Id=Guid.Parse("8a9acfb3-e8a8-49e3-a880-59c993220b99"), Code="The instruction being delivered by staff whose primary responsibility is instruction is exclusively for credit.", SortOrder=0 },
            new RefInstructionCreditType { Id=Guid.Parse("38653e85-3966-4e2e-a962-dc83d7d71ed1"), Code="The instruction being delivered by staff whose primary responsibility is instruction is exclusively not-for-credit.", SortOrder=0 },
            new RefInstructionCreditType { Id=Guid.Parse("2d5187d5-a38c-4e4b-82c8-c184e26ca642"), Code="The instruction being delivered by staff whose primary responsibility is instruction is combined credit/not-for-credit.", SortOrder=0 },
       };
   }
}
