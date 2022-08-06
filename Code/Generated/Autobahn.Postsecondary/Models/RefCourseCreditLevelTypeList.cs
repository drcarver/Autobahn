//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCourseCreditLevelTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCourseCreditLevelType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseCreditLevelType"> List
         /// </summary>
        public static List<RefCourseCreditLevelType> RefCourseCreditLevelTypeList = new List<RefCourseCreditLevelType>
        {
            new RefCourseCreditLevelType { Id=Guid.Parse("e14462bd-f15e-4055-b2a7-a0b5338c213e"), Code="Undergraduate", Description="Undergraduate", Definition="Undergraduate is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("be6714a7-d270-4a44-bfaf-f66b64d7b7f8"), Code="Ungraded", Description="Ungraded", Definition="Ungraded is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("4460c0e3-4ba5-4d4c-8f23-15c526f18aaa"), Code="LowerDivision", Description="Lower division credit (associated with first/second year)", Definition="Lower division credit (associated with first/second year) is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("a72ef326-6091-41fe-ba3e-ac6ebf6699e5"), Code="UpperDivision", Description="Higher or upper division credit (associated with third or fourth year)", Definition="Higher or upper division credit (associated with third or fourth year) is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("1882e275-cb9f-4344-beac-ed25ae66b682"), Code="Vocational", Description="Vocational/technical credit", Definition="Vocational/technical credit is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("18819860-e3e0-4926-ae4a-0d09ddc428b6"), Code="TechnicalPreparatory", Description="Technical preparatory credit", Definition="Technical preparatory credit is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("c634e6f4-9a76-4b36-9447-829819489ed2"), Code="Graduate", Description="Graduate level credit", Definition="Graduate level credit is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("b13f0626-4a94-4163-9eb5-116c591fe5c8"), Code="Professional", Description="Professional", Definition="Professional is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("809da02e-c18f-433c-8d55-497df39f6a25"), Code="Dual", Description="Dual Level", Definition="Dual level (upper division and graduate- may be applicable to a bachelor's degree or graduate degree or both) is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("18.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("d160b7ed-c1e6-4c25-839b-aa1a198ace23"), Code="GraduateProfessional", Description="Graduate Professional", Definition="Dual level (graduate and professional- may be applicable to both) is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("20.00") },
        };

        /// <summary>
        /// The RefCourseCreditLevelType Pick List
         /// </summary>
        public static List<RefCourseCreditLevelType> RefCourseCreditLevelTypePickList = new List<RefCourseCreditLevelType>
        {
            new RefCourseCreditLevelType { Id=Guid.Parse("e14462bd-f15e-4055-b2a7-a0b5338c213e"), Code="Undergraduate", Description="Undergraduate", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("be6714a7-d270-4a44-bfaf-f66b64d7b7f8"), Code="Ungraded", Description="Ungraded", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("4460c0e3-4ba5-4d4c-8f23-15c526f18aaa"), Code="LowerDivision", Description="Lower division credit (associated with first/second year)", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("a72ef326-6091-41fe-ba3e-ac6ebf6699e5"), Code="UpperDivision", Description="Higher or upper division credit (associated with third or fourth year)", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("1882e275-cb9f-4344-beac-ed25ae66b682"), Code="Vocational", Description="Vocational/technical credit", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("18819860-e3e0-4926-ae4a-0d09ddc428b6"), Code="TechnicalPreparatory", Description="Technical preparatory credit", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("c634e6f4-9a76-4b36-9447-829819489ed2"), Code="Graduate", Description="Graduate level credit", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("b13f0626-4a94-4163-9eb5-116c591fe5c8"), Code="Professional", Description="Professional", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("809da02e-c18f-433c-8d55-497df39f6a25"), Code="Dual", Description="Dual Level", SortOrder=Convert.ToDecimal("18.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("d160b7ed-c1e6-4c25-839b-aa1a198ace23"), Code="GraduateProfessional", Description="Graduate Professional", SortOrder=Convert.ToDecimal("20.00") },
       };
   }
}
