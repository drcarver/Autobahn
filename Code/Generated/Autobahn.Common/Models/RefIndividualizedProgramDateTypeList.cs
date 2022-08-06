//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIndividualizedProgramDateTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIndividualizedProgramDateType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIndividualizedProgramDateType"> List
         /// </summary>
        public static List<RefIndividualizedProgramDateType> RefIndividualizedProgramDateTypeList = new List<RefIndividualizedProgramDateType>
        {
            new RefIndividualizedProgramDateType { Id=Guid.Parse("b3f3c42a-cd78-4edb-ae37-cd61df11db18"), Code="Development", Description="Development date", Definition="The related Individualized Program Date is a development date.", SortOrder=Convert.ToDecimal("0.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("f6652258-9584-4440-8441-b4312b6a3a0f"), Code="Implementation", Description="Implementation date", Definition="The related Individualized Program Date is an implementation date.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("861289bc-0e67-43d8-a1e5-b0b02b9552a6"), Code="TentativeRevision", Description="Tentative revision date", Definition="The related Individualized Program Date is a tentative revision date.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("8a14d963-32b4-41fa-8de5-dda75831a15f"), Code="Revision", Description="Revision date", Definition="The related Individualized Program Date is an revision date.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("2abccf59-6449-4ba1-af9a-bd45b58d69aa"), Code="Other", Description="Other", Definition="The related Individualized Program Date is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefIndividualizedProgramDateType Pick List
         /// </summary>
        public static List<RefIndividualizedProgramDateType> RefIndividualizedProgramDateTypePickList = new List<RefIndividualizedProgramDateType>
        {
            new RefIndividualizedProgramDateType { Id=Guid.Parse("b3f3c42a-cd78-4edb-ae37-cd61df11db18"), Code="Development", Description="Development date", SortOrder=Convert.ToDecimal("0.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("f6652258-9584-4440-8441-b4312b6a3a0f"), Code="Implementation", Description="Implementation date", SortOrder=Convert.ToDecimal("2.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("861289bc-0e67-43d8-a1e5-b0b02b9552a6"), Code="TentativeRevision", Description="Tentative revision date", SortOrder=Convert.ToDecimal("4.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("8a14d963-32b4-41fa-8de5-dda75831a15f"), Code="Revision", Description="Revision date", SortOrder=Convert.ToDecimal("6.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("2abccf59-6449-4ba1-af9a-bd45b58d69aa"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
