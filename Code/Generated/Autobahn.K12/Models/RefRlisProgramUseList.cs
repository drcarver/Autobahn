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
        /// The complete <see cref="RefRlisProgramUseModel"> List
         /// </summary>
        public static List<RefRlisProgramUseModel> RefRlisProgramUseList = new List<RefRlisProgramUseModel>
        {
            new RefRlisProgramUse { Id=Guid.Parse("86e7f081-a5d8-47d7-bc75-3cc4e2f2dcb7"), Code="01", Description="Teacher recruitment and retention", Definition="Teacher recruitment and retention, including the use of signing bonuses and other financial incentives", SortOrder=Convert.ToDecimal("1.00") },
            new RefRlisProgramUse { Id=Guid.Parse("4d916b25-4cb3-47e4-9ef9-a1d8f1ae0470"), Code="02", Description="Teacher professional development", Definition="Teacher professional development, including programs that train teachers to utilize technology to improve teaching and to train special needs teachers", SortOrder=Convert.ToDecimal("2.00") },
            new RefRlisProgramUse { Id=Guid.Parse("ea5e8dc4-2726-4c77-b4ea-92b47fb71efd"), Code="03", Description="Educational technology", Definition="Educational technology, including software and hardware as described in Title II, Part D", SortOrder=Convert.ToDecimal("3.00") },
            new RefRlisProgramUse { Id=Guid.Parse("03c0f5b2-53fc-445d-af60-dbc27bf3375e"), Code="04", Description="Parental involvement activities", Definition="Parental involvement activities uses of the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=Convert.ToDecimal("4.00") },
            new RefRlisProgramUse { Id=Guid.Parse("bc7878b2-5b24-4a79-a733-ea439bda2900"), Code="05", Description="Activities authorized under the Safe and Drug-Free Schools Program (Title IV, Part A)", Definition="Activities authorized under the Safe and Drug-Free Schools Program (Title IV, Part A) using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=Convert.ToDecimal("5.00") },
            new RefRlisProgramUse { Id=Guid.Parse("3f2f5f1c-eafa-4505-84d4-6163471f4a94"), Code="06", Description="Activities authorized under Title I, Part A", Definition="Activities authorized under Title I, Part A using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=Convert.ToDecimal("6.00") },
            new RefRlisProgramUse { Id=Guid.Parse("22bdc805-138a-482a-82e1-536e3862d8ed"), Code="07", Description="Activities authorized under Title III (Language instruction for English Learner and immigrant students)", Definition="Activities authorized under Title III (Language instruction for English Learner and immigrant students) using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefRlisProgramUse Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefRlisProgramUseViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefRlisProgramUse { Id=Guid.Parse("86e7f081-a5d8-47d7-bc75-3cc4e2f2dcb7"), Description="Teacher recruitment and retention", SortOrder=Convert.ToDecimal("1.00") },
            new RefRlisProgramUse { Id=Guid.Parse("4d916b25-4cb3-47e4-9ef9-a1d8f1ae0470"), Description="Teacher professional development", SortOrder=Convert.ToDecimal("2.00") },
            new RefRlisProgramUse { Id=Guid.Parse("ea5e8dc4-2726-4c77-b4ea-92b47fb71efd"), Description="Educational technology", SortOrder=Convert.ToDecimal("3.00") },
            new RefRlisProgramUse { Id=Guid.Parse("03c0f5b2-53fc-445d-af60-dbc27bf3375e"), Description="Parental involvement activities", SortOrder=Convert.ToDecimal("4.00") },
            new RefRlisProgramUse { Id=Guid.Parse("bc7878b2-5b24-4a79-a733-ea439bda2900"), Description="Activities authorized under the Safe and Drug-Free Schools Program (Title IV, Part A)", SortOrder=Convert.ToDecimal("5.00") },
            new RefRlisProgramUse { Id=Guid.Parse("3f2f5f1c-eafa-4505-84d4-6163471f4a94"), Description="Activities authorized under Title I, Part A", SortOrder=Convert.ToDecimal("6.00") },
            new RefRlisProgramUse { Id=Guid.Parse("22bdc805-138a-482a-82e1-536e3862d8ed"), Description="Activities authorized under Title III (Language instruction for English Learner and immigrant students)", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
