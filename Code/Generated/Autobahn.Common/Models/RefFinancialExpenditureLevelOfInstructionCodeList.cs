//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialExpenditureLevelOfInstructionCodeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFinancialExpenditureLevelOfInstructionCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFinancialExpenditureLevelOfInstructionCodeModel"> List
         /// </summary>
        public static List<RefFinancialExpenditureLevelOfInstructionCodeModel> RefFinancialExpenditureLevelOfInstructionCodeList = new List<RefFinancialExpenditureLevelOfInstructionCodeModel>
        {
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("33c5bb37-fe18-49aa-8f71-43f8cc99c72f"), Code="10", Description="Elementary", Definition="A school organization classified as elementary by state and local practice and composed of any span of grades from prekindergarten, kindergarten, or grade 1 through grade 8.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("795d62cc-c342-4413-be74-cf0c9ecb5cf1"), Code="11", Description="Prekindergarten", Definition="A school organization composed entirely of any span of ages below kindergarten. This category is normally used for students identified as needing special services, although regular education prekindergarten would also be appropriate.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("0961f245-7346-4671-8909-b30854cdefa0"), Code="12", Description="Kindergarten", Definition="A school organization for children in the year immediately preceding first grade.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("4d10e310-ab22-4451-9cae-7bc93f20dd76"), Code="19", Description="Other Elementary", Definition="A school organization composed of any span of grades not above grade 8, except prekindergarten and kindergarten.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("900fd13a-fb96-46f2-8e0e-86f530c06e53"), Code="20", Description="Middle", Definition="A school organization composed of at least three grades, usually beginning with grade 4 through grade 6 or the equivalent and usually ending with grade 8 or grade 9. Most middle school organizations presume that students finishing middle school will go on to secondary school.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("40e793ea-0aeb-40c1-9145-13600e7a801b"), Code="30", Description="Secondary", Definition="A school organization comprising any span of grades beginning with the next grade following an elementary or middle school, usually beginning with grade 7 through grade 10, and ending with or below grade 12.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("757538fc-c905-4186-a049-181c35fa6eae"), Code="37", Description="Elementary and Secondary Combined", Definition="A school organization comprising elementary and secondary levels of instruction, which may also include kindergarten and prekindergarten programs.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("f92009da-89b6-4df0-9aee-2a2b4f1ed5ac"), Code="40", Description="Postsecondary", Definition="A school organization providing formal instructional programs with a curriculum designed primarily for students who have completed the requirements for a high school diploma or the equivalent. This includes programs of an academic, vocational, and continuing professional education purpose and excludes avocational and adult education programs.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("0d0b78c3-cce3-4787-99b3-30b4b6f35924"), Code="41", Description="Programs for Adult/Continuing", Definition="A program for adults and out-of-school youth (typically 16 years of age and older who are not regularly enrolled in school) who have completed, interrupted, or not begun their formal education and are pursuing skills or knowledge in other than regularly prescribed courses. These include adult basic education programs and other programs for the pursuit of special interests or enrichment.", SortOrder=Convert.ToDecimal("9.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("a3a55512-aa7f-46af-9bbe-ec0c241c0433"), Code="42", Description="Community/Junior College", Definition="An institution of higher education that usually offers the first 2 years of college instruction and frequently grants an associate's degree, but does not grant a bachelor's degree. It is an independently organized institution (public or nonpublic), an institution that is part of a school district, or an independently organized system of junior colleges. Junior colleges offer college transfer courses and programs; vocational, technical, and semiprofessional occupational programs; or general education programs.", SortOrder=Convert.ToDecimal("10.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("d7742f70-2352-4775-92d1-e96fcbd9f2d3"), Code="50", Description="School Wide", Definition="For coding expenditures that cannot be clearly assigned to a specific instructional level.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The Reference RefFinancialExpenditureLevelOfInstructionCode Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFinancialExpenditureLevelOfInstructionCodeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("33c5bb37-fe18-49aa-8f71-43f8cc99c72f"), Description="Elementary", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("795d62cc-c342-4413-be74-cf0c9ecb5cf1"), Description="Prekindergarten", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("0961f245-7346-4671-8909-b30854cdefa0"), Description="Kindergarten", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("4d10e310-ab22-4451-9cae-7bc93f20dd76"), Description="Other Elementary", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("900fd13a-fb96-46f2-8e0e-86f530c06e53"), Description="Middle", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("40e793ea-0aeb-40c1-9145-13600e7a801b"), Description="Secondary", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("757538fc-c905-4186-a049-181c35fa6eae"), Description="Elementary and Secondary Combined", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("f92009da-89b6-4df0-9aee-2a2b4f1ed5ac"), Description="Postsecondary", SortOrder=Convert.ToDecimal("8.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("0d0b78c3-cce3-4787-99b3-30b4b6f35924"), Description="Programs for Adult/Continuing", SortOrder=Convert.ToDecimal("9.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("a3a55512-aa7f-46af-9bbe-ec0c241c0433"), Description="Community/Junior College", SortOrder=Convert.ToDecimal("10.00") },
            new RefFinancialExpenditureLevelOfInstructionCode { Id=Guid.Parse("d7742f70-2352-4775-92d1-e96fcbd9f2d3"), Description="School Wide", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
