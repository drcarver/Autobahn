//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefLiteracyAssessmentList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefLiteracyAssessment Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLiteracyAssessment"> List
         /// </summary>
        public static List<RefLiteracyAssessment> RefLiteracyAssessmentList = new List<RefLiteracyAssessment>
        {
            new RefLiteracyAssessment { Id=Guid.Parse("0b5feda9-95eb-448d-96df-5eef47f07087"), Code="TABE", Description="TABE", Definition="TABE is the type of literacy test administered.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("ae977864-9af3-4805-a8b7-20535ea41fb0"), Code="CASAS", Description="CASAS", Definition="CASAS is the type of literacy test administered.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("d01534ec-09d9-4472-a8a7-4efb099a0b83"), Code="BEST", Description="BEST", Definition="BEST is the type of literacy test administered.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("147b4b33-a07f-46cf-8f86-edffaa0a17d5"), Code="BESTPlus", Description="BESTPlus", Definition="BESTPlus is the type of literacy test administered.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("bbda3073-43aa-4ee4-8f51-e9eb51141de3"), Code="BESTLiteracy", Description="BEST Literacy", Definition="BEST Literacy is the type of literacy test administered.", SortOrder=Convert.ToDecimal("5.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("9d95da82-92ed-4c97-affc-9056099257f8"), Code="PPVT-III", Description="PPVT-III", Definition="PPVT-III is the type of literacy test administered.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("a9a4932e-63bd-4980-83c3-b6f8315a781c"), Code="PPVT-IV", Description="PPVT-IV", Definition="PPVT-IV is the type of literacy test administered.", SortOrder=Convert.ToDecimal("7.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("726e2813-1464-426f-92ab-484ccde19a03"), Code="TVIP", Description="TVIP", Definition="TVIP is the type of literacy test administered.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("ce759ded-c9b6-48c1-bfef-8e925843a002"), Code="PALSPreKUpperCase", Description="PALS PreK Upper Case", Definition="PALS PreK Upper Case is the type of literacy test administered.", SortOrder=Convert.ToDecimal("9.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("1c0eafbc-9d0b-46d3-b885-5cc56f8ccf16"), Code="PEPScaleI", Description="PEP Scale I", Definition="PEP Scale I is the type of literacy test administered.", SortOrder=Convert.ToDecimal("10.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("9f6e45bd-ec4e-4d31-81a6-11b27effe424"), Code="PEPScaleII", Description="PEP Scale II", Definition="PEP Scale II is the type of literacy test administered.", SortOrder=Convert.ToDecimal("11.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("07530166-2f45-4b9b-a318-2de597d5d879"), Code="PEPScaleIII", Description="PEP Scale III", Definition="PEP Scale III is the type of literacy test administered.", SortOrder=Convert.ToDecimal("12.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("af9f67eb-8d4c-42fa-a41b-530166f4d919"), Code="PEPScaleIV", Description="PEP Scale IV", Definition="PEP Scale IV is the type of literacy test administered.", SortOrder=Convert.ToDecimal("13.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("3ccab7f9-eb15-433d-95c3-b85fb9e6f161"), Code="Other", Description="Other", Definition="The type of literacy test administered is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("14.00") },
        };

        /// <summary>
        /// The RefLiteracyAssessment Pick List
         /// </summary>
        public static List<RefLiteracyAssessment> RefLiteracyAssessmentPickList = new List<RefLiteracyAssessment>
        {
            new RefLiteracyAssessment { Id=Guid.Parse("0b5feda9-95eb-448d-96df-5eef47f07087"), Code="TABE", Description="TABE", SortOrder=Convert.ToDecimal("1.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("ae977864-9af3-4805-a8b7-20535ea41fb0"), Code="CASAS", Description="CASAS", SortOrder=Convert.ToDecimal("2.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("d01534ec-09d9-4472-a8a7-4efb099a0b83"), Code="BEST", Description="BEST", SortOrder=Convert.ToDecimal("3.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("147b4b33-a07f-46cf-8f86-edffaa0a17d5"), Code="BESTPlus", Description="BESTPlus", SortOrder=Convert.ToDecimal("4.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("bbda3073-43aa-4ee4-8f51-e9eb51141de3"), Code="BESTLiteracy", Description="BEST Literacy", SortOrder=Convert.ToDecimal("5.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("9d95da82-92ed-4c97-affc-9056099257f8"), Code="PPVT-III", Description="PPVT-III", SortOrder=Convert.ToDecimal("6.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("a9a4932e-63bd-4980-83c3-b6f8315a781c"), Code="PPVT-IV", Description="PPVT-IV", SortOrder=Convert.ToDecimal("7.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("726e2813-1464-426f-92ab-484ccde19a03"), Code="TVIP", Description="TVIP", SortOrder=Convert.ToDecimal("8.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("ce759ded-c9b6-48c1-bfef-8e925843a002"), Code="PALSPreKUpperCase", Description="PALS PreK Upper Case", SortOrder=Convert.ToDecimal("9.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("1c0eafbc-9d0b-46d3-b885-5cc56f8ccf16"), Code="PEPScaleI", Description="PEP Scale I", SortOrder=Convert.ToDecimal("10.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("9f6e45bd-ec4e-4d31-81a6-11b27effe424"), Code="PEPScaleII", Description="PEP Scale II", SortOrder=Convert.ToDecimal("11.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("07530166-2f45-4b9b-a318-2de597d5d879"), Code="PEPScaleIII", Description="PEP Scale III", SortOrder=Convert.ToDecimal("12.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("af9f67eb-8d4c-42fa-a41b-530166f4d919"), Code="PEPScaleIV", Description="PEP Scale IV", SortOrder=Convert.ToDecimal("13.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("3ccab7f9-eb15-433d-95c3-b85fb9e6f161"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("14.00") },
       };
   }
}
