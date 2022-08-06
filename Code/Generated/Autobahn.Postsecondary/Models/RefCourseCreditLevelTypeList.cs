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
        public static List<RefCourseCreditLevelType> RefCourseCreditLevelTypeList = new List<RefCourseCreditLevelType> =
        {
            new RefCourseCreditLevelType { Id=Guid.Parse("70b4de94-dcad-4601-9d0b-6710d496c567"), Code="Undergraduate is specified as the level of credit associated with the credit hours earned for the course.", Description="Undergraduate", Definition="", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("4addfde6-d672-4b7e-b17e-141890828943"), Code="Ungraded is specified as the level of credit associated with the credit hours earned for the course.", Description="Ungraded", Definition="", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("79e4669f-cab4-4b68-bfbe-5d54f297a1d6"), Code="Lower division credit (associated with first/second year) is specified as the level of credit associated with the credit hours earned for the course.", Description="LowerDivision", Definition="", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("39e0a4b0-54a5-4b17-9113-8a34d1d585e2"), Code="Higher or upper division credit (associated with third or fourth year) is specified as the level of credit associated with the credit hours earned for the course.", Description="UpperDivision", Definition="", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("a873d4a3-e3a8-4057-9f5c-095bf13c204b"), Code="Vocational/technical credit is specified as the level of credit associated with the credit hours earned for the course.", Description="Vocational", Definition="", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("2143feae-6d0b-4b09-b1f1-1509b1defc30"), Code="Technical preparatory credit is specified as the level of credit associated with the credit hours earned for the course.", Description="TechnicalPreparatory", Definition="", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("0637a2e2-827e-4406-b29a-5cf71cfecc45"), Code="Graduate level credit is specified as the level of credit associated with the credit hours earned for the course.", Description="Graduate", Definition="", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("0cdfc786-92a6-443e-b40f-dc651d129bbc"), Code="Professional is specified as the level of credit associated with the credit hours earned for the course.", Description="Professional", Definition="", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("db6581f7-255f-46a9-ae9c-aa165173886c"), Code="Dual level (upper division and graduate- may be applicable to a bachelor's degree or graduate degree or both) is specified as the level of credit associated with the credit hours earned for the course.", Description="Dual", Definition="", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("664b8655-6b41-4ca5-be98-dd2b5a5a199d"), Code="Dual level (graduate and professional- may be applicable to both) is specified as the level of credit associated with the credit hours earned for the course.", Description="GraduateProfessional", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCourseCreditLevelType Pick List
         /// </summary>
        public static List<RefCourseCreditLevelType> RefCourseCreditLevelTypePickList = new List<RefCourseCreditLevelType> =
        {
            new RefCourseCreditLevelType { Id=Guid.Parse("70b4de94-dcad-4601-9d0b-6710d496c567"), Code="Undergraduate is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("4addfde6-d672-4b7e-b17e-141890828943"), Code="Ungraded is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("79e4669f-cab4-4b68-bfbe-5d54f297a1d6"), Code="Lower division credit (associated with first/second year) is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("39e0a4b0-54a5-4b17-9113-8a34d1d585e2"), Code="Higher or upper division credit (associated with third or fourth year) is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("a873d4a3-e3a8-4057-9f5c-095bf13c204b"), Code="Vocational/technical credit is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("2143feae-6d0b-4b09-b1f1-1509b1defc30"), Code="Technical preparatory credit is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("0637a2e2-827e-4406-b29a-5cf71cfecc45"), Code="Graduate level credit is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("0cdfc786-92a6-443e-b40f-dc651d129bbc"), Code="Professional is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("db6581f7-255f-46a9-ae9c-aa165173886c"), Code="Dual level (upper division and graduate- may be applicable to a bachelor's degree or graduate degree or both) is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditLevelType { Id=Guid.Parse("664b8655-6b41-4ca5-be98-dd2b5a5a199d"), Code="Dual level (graduate and professional- may be applicable to both) is specified as the level of credit associated with the credit hours earned for the course.", SortOrder=0 },
       };
   }
}
