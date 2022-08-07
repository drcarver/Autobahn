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
        /// The complete <see cref="RefLiteracyAssessmentModel"> List
         /// </summary>
        public static List<RefLiteracyAssessmentModel> RefLiteracyAssessmentList = new List<RefLiteracyAssessmentModel>
        {
            new RefLiteracyAssessment { Id=Guid.Parse("6a435142-0869-4db9-9b99-aaba90e7ffaa"), Code="TABE", Description="TABE", Definition="TABE is the type of literacy test administered.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("94d616d7-1111-48a3-8d50-577ba3ed1b57"), Code="CASAS", Description="CASAS", Definition="CASAS is the type of literacy test administered.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("6f2487b5-2b18-4c89-a8ad-b97201388649"), Code="BEST", Description="BEST", Definition="BEST is the type of literacy test administered.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("62456fe5-82f1-4c4b-8add-7be4b475b361"), Code="BESTPlus", Description="BESTPlus", Definition="BESTPlus is the type of literacy test administered.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("b8316ee0-976c-439f-aba2-e9e749d65383"), Code="BESTLiteracy", Description="BEST Literacy", Definition="BEST Literacy is the type of literacy test administered.", SortOrder=Convert.ToDecimal("5.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("9277f5da-cfe4-4bb7-80d1-f57b6074615c"), Code="PPVT-III", Description="PPVT-III", Definition="PPVT-III is the type of literacy test administered.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("d58acd41-e5a8-423e-9a93-302578b339e6"), Code="PPVT-IV", Description="PPVT-IV", Definition="PPVT-IV is the type of literacy test administered.", SortOrder=Convert.ToDecimal("7.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("1239ab3c-db2d-4ad9-91bc-d5e25bf5dde3"), Code="TVIP", Description="TVIP", Definition="TVIP is the type of literacy test administered.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("76c41845-a7d1-4c1b-bd13-03267738749c"), Code="PALSPreKUpperCase", Description="PALS PreK Upper Case", Definition="PALS PreK Upper Case is the type of literacy test administered.", SortOrder=Convert.ToDecimal("9.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("eb69a98a-6eb2-46e7-8cd4-509df943d643"), Code="PEPScaleI", Description="PEP Scale I", Definition="PEP Scale I is the type of literacy test administered.", SortOrder=Convert.ToDecimal("10.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("4a7fa100-8170-489a-9e96-e49919f8d8ff"), Code="PEPScaleII", Description="PEP Scale II", Definition="PEP Scale II is the type of literacy test administered.", SortOrder=Convert.ToDecimal("11.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("cd6d2ade-0407-4f69-9b95-eaf46d08e94a"), Code="PEPScaleIII", Description="PEP Scale III", Definition="PEP Scale III is the type of literacy test administered.", SortOrder=Convert.ToDecimal("12.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("309da2ee-8034-49da-b848-a4789af66409"), Code="PEPScaleIV", Description="PEP Scale IV", Definition="PEP Scale IV is the type of literacy test administered.", SortOrder=Convert.ToDecimal("13.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("36c02f16-7ffc-4cde-8976-9653b9951d40"), Code="Other", Description="Other", Definition="The type of literacy test administered is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("14.00") },
        };

        /// <summary>
        /// The Reference RefLiteracyAssessment Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLiteracyAssessmentViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLiteracyAssessment { Id=Guid.Parse("6a435142-0869-4db9-9b99-aaba90e7ffaa"), Description="TABE", SortOrder=Convert.ToDecimal("1.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("94d616d7-1111-48a3-8d50-577ba3ed1b57"), Description="CASAS", SortOrder=Convert.ToDecimal("2.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("6f2487b5-2b18-4c89-a8ad-b97201388649"), Description="BEST", SortOrder=Convert.ToDecimal("3.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("62456fe5-82f1-4c4b-8add-7be4b475b361"), Description="BESTPlus", SortOrder=Convert.ToDecimal("4.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("b8316ee0-976c-439f-aba2-e9e749d65383"), Description="BEST Literacy", SortOrder=Convert.ToDecimal("5.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("9277f5da-cfe4-4bb7-80d1-f57b6074615c"), Description="PPVT-III", SortOrder=Convert.ToDecimal("6.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("d58acd41-e5a8-423e-9a93-302578b339e6"), Description="PPVT-IV", SortOrder=Convert.ToDecimal("7.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("1239ab3c-db2d-4ad9-91bc-d5e25bf5dde3"), Description="TVIP", SortOrder=Convert.ToDecimal("8.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("76c41845-a7d1-4c1b-bd13-03267738749c"), Description="PALS PreK Upper Case", SortOrder=Convert.ToDecimal("9.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("eb69a98a-6eb2-46e7-8cd4-509df943d643"), Description="PEP Scale I", SortOrder=Convert.ToDecimal("10.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("4a7fa100-8170-489a-9e96-e49919f8d8ff"), Description="PEP Scale II", SortOrder=Convert.ToDecimal("11.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("cd6d2ade-0407-4f69-9b95-eaf46d08e94a"), Description="PEP Scale III", SortOrder=Convert.ToDecimal("12.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("309da2ee-8034-49da-b848-a4789af66409"), Description="PEP Scale IV", SortOrder=Convert.ToDecimal("13.00") },
            new RefLiteracyAssessment { Id=Guid.Parse("36c02f16-7ffc-4cde-8976-9653b9951d40"), Description="Other", SortOrder=Convert.ToDecimal("14.00") },
       };
   }
}
