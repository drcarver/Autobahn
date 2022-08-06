//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCurriculumFrameworkTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCurriculumFrameworkType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCurriculumFrameworkType"> List
         /// </summary>
        public static List<RefCurriculumFrameworkType> RefCurriculumFrameworkTypeList = new List<RefCurriculumFrameworkType>
        {
            new RefCurriculumFrameworkType { Id=Guid.Parse("5b637200-6f88-4828-b66f-1454705bafc8"), Code="LEA", Description="Local Education Agency (LEA) curriculum framework", Definition="A Local Education Agency (LEA) curriculum framework is the standard curriculum used for this course.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("15a24e91-0903-4ff3-ae74-21351d1ff81b"), Code="NationalStandard", Description="National curriculum standard", Definition="A national curriculum standard is the standard curriculum used for this course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("852598d5-a728-4f07-bda7-f5f89a42b442"), Code="PrivateOrReligious", Description="Private, religious curriculum", Definition="A private, religious curriculum is the standard curriculum used for this course.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("7f517543-35ac-4500-959d-f56db7ed8034"), Code="School", Description="School curriculum framework", Definition="A school curriculum framework is the standard curriculum used for this course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("9309325f-aa2c-4c07-95bc-0653444f0020"), Code="State", Description="State curriculum framework", Definition="A state curriculum framework is the standard curriculum used for this course.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("5e0d2d7c-6c11-4680-b04f-90301e4db222"), Code="Other", Description="Other", Definition="The standard curriculum used for this course is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefCurriculumFrameworkType Pick List
         /// </summary>
        public static List<RefCurriculumFrameworkType> RefCurriculumFrameworkTypePickList = new List<RefCurriculumFrameworkType>
        {
            new RefCurriculumFrameworkType { Id=Guid.Parse("5b637200-6f88-4828-b66f-1454705bafc8"), Code="LEA", Description="Local Education Agency (LEA) curriculum framework", SortOrder=Convert.ToDecimal("1.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("15a24e91-0903-4ff3-ae74-21351d1ff81b"), Code="NationalStandard", Description="National curriculum standard", SortOrder=Convert.ToDecimal("2.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("852598d5-a728-4f07-bda7-f5f89a42b442"), Code="PrivateOrReligious", Description="Private, religious curriculum", SortOrder=Convert.ToDecimal("3.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("7f517543-35ac-4500-959d-f56db7ed8034"), Code="School", Description="School curriculum framework", SortOrder=Convert.ToDecimal("4.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("9309325f-aa2c-4c07-95bc-0653444f0020"), Code="State", Description="State curriculum framework", SortOrder=Convert.ToDecimal("5.00") },
            new RefCurriculumFrameworkType { Id=Guid.Parse("5e0d2d7c-6c11-4680-b04f-90301e4db222"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
