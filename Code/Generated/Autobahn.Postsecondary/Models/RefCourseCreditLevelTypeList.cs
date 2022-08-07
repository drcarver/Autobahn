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
        /// The complete <see cref="RefCourseCreditLevelTypeModel"> List
         /// </summary>
        public static List<RefCourseCreditLevelTypeModel> RefCourseCreditLevelTypeList = new List<RefCourseCreditLevelTypeModel>
        {
            new RefCourseCreditLevelType { Id=Guid.Parse("561dccbf-fe31-485e-9687-4f3131d706ff"), Code="Undergraduate", Description="Undergraduate", Definition="Undergraduate is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("1fa73a20-cad3-45b3-a229-4f88fdb83c50"), Code="Ungraded", Description="Ungraded", Definition="Ungraded is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("66526ee1-b61e-433f-bfee-e5f1e1f0b476"), Code="LowerDivision", Description="Lower division credit (associated with first/second year)", Definition="Lower division credit (associated with first/second year) is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("ffc1305b-de50-46a1-8671-c1ddcdb1c512"), Code="UpperDivision", Description="Higher or upper division credit (associated with third or fourth year)", Definition="Higher or upper division credit (associated with third or fourth year) is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("580ee656-0949-4d1f-9706-7425eea78ffe"), Code="Vocational", Description="Vocational/technical credit", Definition="Vocational/technical credit is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("af9bc287-889f-4e1c-955a-eff84561eea6"), Code="TechnicalPreparatory", Description="Technical preparatory credit", Definition="Technical preparatory credit is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("d8127292-2dd9-4143-a84b-551ca8c75ed4"), Code="Graduate", Description="Graduate level credit", Definition="Graduate level credit is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("aa88911b-05d3-434a-8343-45f3ee2cc40a"), Code="Professional", Description="Professional", Definition="Professional is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("e777dda1-2fda-4fc8-bc7b-8a42271fa213"), Code="Dual", Description="Dual Level", Definition="Dual level (upper division and graduate- may be applicable to a bachelor's degree or graduate degree or both) is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("18.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("a957e264-eeb1-4e68-8962-ea99fc79f150"), Code="GraduateProfessional", Description="Graduate Professional", Definition="Dual level (graduate and professional- may be applicable to both) is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("20.00") },
        };

        /// <summary>
        /// The Reference RefCourseCreditLevelType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseCreditLevelTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseCreditLevelType { Id=Guid.Parse("561dccbf-fe31-485e-9687-4f3131d706ff"), Description="Undergraduate", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("1fa73a20-cad3-45b3-a229-4f88fdb83c50"), Description="Ungraded", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("66526ee1-b61e-433f-bfee-e5f1e1f0b476"), Description="Lower division credit (associated with first/second year)", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("ffc1305b-de50-46a1-8671-c1ddcdb1c512"), Description="Higher or upper division credit (associated with third or fourth year)", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("580ee656-0949-4d1f-9706-7425eea78ffe"), Description="Vocational/technical credit", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("af9bc287-889f-4e1c-955a-eff84561eea6"), Description="Technical preparatory credit", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("d8127292-2dd9-4143-a84b-551ca8c75ed4"), Description="Graduate level credit", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("aa88911b-05d3-434a-8343-45f3ee2cc40a"), Description="Professional", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("e777dda1-2fda-4fc8-bc7b-8a42271fa213"), Description="Dual Level", SortOrder=Convert.ToDecimal("18.00") },
            new RefCourseCreditLevelType { Id=Guid.Parse("a957e264-eeb1-4e68-8962-ea99fc79f150"), Description="Graduate Professional", SortOrder=Convert.ToDecimal("20.00") },
       };
   }
}
