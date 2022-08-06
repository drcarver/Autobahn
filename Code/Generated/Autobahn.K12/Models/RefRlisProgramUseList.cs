//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefRlisProgramUseList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefRlisProgramUse Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRlisProgramUse"> List
         /// </summary>
        public static List<RefRlisProgramUse> RefRlisProgramUseList = new List<RefRlisProgramUse>
        {
            new RefRlisProgramUse { Id=Guid.Parse("96b41924-6795-4025-868b-b88c71b18b0f"), Code="01", Description="Teacher recruitment and retention", Definition="Teacher recruitment and retention, including the use of signing bonuses and other financial incentives", SortOrder=Convert.ToDecimal("1.00") },
            new RefRlisProgramUse { Id=Guid.Parse("aba99f7d-3a2d-4479-b803-65a50430c0a5"), Code="02", Description="Teacher professional development", Definition="Teacher professional development, including programs that train teachers to utilize technology to improve teaching and to train special needs teachers", SortOrder=Convert.ToDecimal("2.00") },
            new RefRlisProgramUse { Id=Guid.Parse("611178a1-fb70-4e38-a5c1-8c3ad06da086"), Code="03", Description="Educational technology", Definition="Educational technology, including software and hardware as described in Title II, Part D", SortOrder=Convert.ToDecimal("3.00") },
            new RefRlisProgramUse { Id=Guid.Parse("4d9dd452-49f0-4fd7-8e30-2b643fe98027"), Code="04", Description="Parental involvement activities", Definition="Parental involvement activities uses of the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=Convert.ToDecimal("4.00") },
            new RefRlisProgramUse { Id=Guid.Parse("e3f32866-33f2-43dc-8cef-e150559152a5"), Code="05", Description="Activities authorized under the Safe and Drug-Free Schools Program (Title IV, Part A)", Definition="Activities authorized under the Safe and Drug-Free Schools Program (Title IV, Part A) using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=Convert.ToDecimal("5.00") },
            new RefRlisProgramUse { Id=Guid.Parse("9f921cf9-2201-4000-a47f-ddab5dafbcb3"), Code="06", Description="Activities authorized under Title I, Part A", Definition="Activities authorized under Title I, Part A using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=Convert.ToDecimal("6.00") },
            new RefRlisProgramUse { Id=Guid.Parse("55d1cfd4-a2ed-4274-a8a9-39ac8f5454d7"), Code="07", Description="Activities authorized under Title III (Language instruction for English Learner and immigrant students)", Definition="Activities authorized under Title III (Language instruction for English Learner and immigrant students) using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefRlisProgramUse Pick List
         /// </summary>
        public static List<RefRlisProgramUse> RefRlisProgramUsePickList = new List<RefRlisProgramUse>
        {
            new RefRlisProgramUse { Id=Guid.Parse("96b41924-6795-4025-868b-b88c71b18b0f"), Code="01", Description="Teacher recruitment and retention", SortOrder=Convert.ToDecimal("1.00") },
            new RefRlisProgramUse { Id=Guid.Parse("aba99f7d-3a2d-4479-b803-65a50430c0a5"), Code="02", Description="Teacher professional development", SortOrder=Convert.ToDecimal("2.00") },
            new RefRlisProgramUse { Id=Guid.Parse("611178a1-fb70-4e38-a5c1-8c3ad06da086"), Code="03", Description="Educational technology", SortOrder=Convert.ToDecimal("3.00") },
            new RefRlisProgramUse { Id=Guid.Parse("4d9dd452-49f0-4fd7-8e30-2b643fe98027"), Code="04", Description="Parental involvement activities", SortOrder=Convert.ToDecimal("4.00") },
            new RefRlisProgramUse { Id=Guid.Parse("e3f32866-33f2-43dc-8cef-e150559152a5"), Code="05", Description="Activities authorized under the Safe and Drug-Free Schools Program (Title IV, Part A)", SortOrder=Convert.ToDecimal("5.00") },
            new RefRlisProgramUse { Id=Guid.Parse("9f921cf9-2201-4000-a47f-ddab5dafbcb3"), Code="06", Description="Activities authorized under Title I, Part A", SortOrder=Convert.ToDecimal("6.00") },
            new RefRlisProgramUse { Id=Guid.Parse("55d1cfd4-a2ed-4274-a8a9-39ac8f5454d7"), Code="07", Description="Activities authorized under Title III (Language instruction for English Learner and immigrant students)", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
