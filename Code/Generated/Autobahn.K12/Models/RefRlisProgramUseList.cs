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
        public static List<RefRlisProgramUse> RefRlisProgramUseList = new List<RefRlisProgramUse> =
        {
            new RefRlisProgramUse { Id=Guid.Parse("1d29983c-4577-4aef-b2a0-03a549458b57"), Code="Teacher recruitment and retention, including the use of signing bonuses and other financial incentives", Description="01", Definition="", SortOrder=0 },
            new RefRlisProgramUse { Id=Guid.Parse("5e50c95d-4571-42fe-a98b-dd2d983c693b"), Code="Teacher professional development, including programs that train teachers to utilize technology to improve teaching and to train special needs teachers", Description="02", Definition="", SortOrder=0 },
            new RefRlisProgramUse { Id=Guid.Parse("949db813-d53d-458a-9daf-557f277c431e"), Code="Educational technology, including software and hardware as described in Title II, Part D", Description="03", Definition="", SortOrder=0 },
            new RefRlisProgramUse { Id=Guid.Parse("a201bd8e-f4e2-41b3-88c9-77932eb17e17"), Code="Parental involvement activities uses of the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", Description="04", Definition="", SortOrder=0 },
            new RefRlisProgramUse { Id=Guid.Parse("20b33275-d31b-4c11-ba6a-5d52a1a30827"), Code="Activities authorized under the Safe and Drug-Free Schools Program (Title IV, Part A) using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", Description="05", Definition="", SortOrder=0 },
            new RefRlisProgramUse { Id=Guid.Parse("5f66cab1-314b-498f-ab96-ec4b89604ae5"), Code="Activities authorized under Title I, Part A using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", Description="06", Definition="", SortOrder=0 },
            new RefRlisProgramUse { Id=Guid.Parse("2870d7e7-0fdf-4579-96c1-8ce630fd50c6"), Code="Activities authorized under Title III (Language instruction for English Learner and immigrant students) using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", Description="07", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefRlisProgramUse Pick List
         /// </summary>
        public static List<RefRlisProgramUse> RefRlisProgramUsePickList = new List<RefRlisProgramUse> =
        {
            new RefRlisProgramUse { Id=Guid.Parse("1d29983c-4577-4aef-b2a0-03a549458b57"), Code="Teacher recruitment and retention, including the use of signing bonuses and other financial incentives", SortOrder=0 },
            new RefRlisProgramUse { Id=Guid.Parse("5e50c95d-4571-42fe-a98b-dd2d983c693b"), Code="Teacher professional development, including programs that train teachers to utilize technology to improve teaching and to train special needs teachers", SortOrder=0 },
            new RefRlisProgramUse { Id=Guid.Parse("949db813-d53d-458a-9daf-557f277c431e"), Code="Educational technology, including software and hardware as described in Title II, Part D", SortOrder=0 },
            new RefRlisProgramUse { Id=Guid.Parse("a201bd8e-f4e2-41b3-88c9-77932eb17e17"), Code="Parental involvement activities uses of the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=0 },
            new RefRlisProgramUse { Id=Guid.Parse("20b33275-d31b-4c11-ba6a-5d52a1a30827"), Code="Activities authorized under the Safe and Drug-Free Schools Program (Title IV, Part A) using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=0 },
            new RefRlisProgramUse { Id=Guid.Parse("5f66cab1-314b-498f-ab96-ec4b89604ae5"), Code="Activities authorized under Title I, Part A using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=0 },
            new RefRlisProgramUse { Id=Guid.Parse("2870d7e7-0fdf-4579-96c1-8ce630fd50c6"), Code="Activities authorized under Title III (Language instruction for English Learner and immigrant students) using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=0 },
       };
   }
}
