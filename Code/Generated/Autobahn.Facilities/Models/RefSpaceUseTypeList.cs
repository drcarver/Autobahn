//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefSpaceUseTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefSpaceUseType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSpaceUseTypeModel"> List
         /// </summary>
        public static List<RefSpaceUseTypeModel> RefSpaceUseTypeList = new List<RefSpaceUseTypeModel>
        {
            new RefSpaceUseType { Id=Guid.Parse("b764d465-c407-438c-ac73-7982d39ed0fa"), Code="02633", Description="Administration", Definition="Administration is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("2.00") },
            new RefSpaceUseType { Id=Guid.Parse("776587b6-a632-4162-8a32-b0610824f7f6"), Code="02634", Description="Assembly", Definition="Assembly is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("4.00") },
            new RefSpaceUseType { Id=Guid.Parse("9910ae2d-1203-4ec1-a41f-975e932a1fab"), Code="02631", Description="Athletic", Definition="Athletic is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("6.00") },
            new RefSpaceUseType { Id=Guid.Parse("d59fa53c-a2cd-4d61-a66a-97a9aa881c5e"), Code="02628", Description="Basic classroom", Definition="Basic classroom is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("8.00") },
            new RefSpaceUseType { Id=Guid.Parse("30f5eb13-bf1c-44be-8fa9-6f3cd332ea97"), Code="02635", Description="Corridors", Definition="Corridors is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("10.00") },
            new RefSpaceUseType { Id=Guid.Parse("52a2fc99-fa7f-4643-8065-049229c18e45"), Code="02639", Description="Dormitory room", Definition="Dormitory room is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("12.00") },
            new RefSpaceUseType { Id=Guid.Parse("cde06d1a-edfb-43a7-b634-9e211549c325"), Code="02638", Description="Food service", Definition="Food service is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("14.00") },
            new RefSpaceUseType { Id=Guid.Parse("013eed53-655d-4e55-8666-a00b1f3ce293"), Code="02630", Description="Library/media", Definition="Library/media is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("16.00") },
            new RefSpaceUseType { Id=Guid.Parse("98571f25-cc67-496f-af2e-1594381b59ba"), Code="02773", Description="Multi-purpose room", Definition="Multi-purpose room is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("18.00") },
            new RefSpaceUseType { Id=Guid.Parse("cb19b725-7981-4464-bec5-e147508eb8b4"), Code="02636", Description="Operational support", Definition="Operational support is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("20.00") },
            new RefSpaceUseType { Id=Guid.Parse("27b32100-965f-415d-8411-d0d381231757"), Code="03017", Description="Restroom", Definition="Restroom is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("22.00") },
            new RefSpaceUseType { Id=Guid.Parse("75ef34bc-c067-49bb-8dd2-f366ccd3babf"), Code="02629", Description="Specialty classroom", Definition="Specialty classroom is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("24.00") },
            new RefSpaceUseType { Id=Guid.Parse("8544b60a-852d-45d2-ac16-a750da36b319"), Code="02637", Description="Storage", Definition="Storage is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("26.00") },
            new RefSpaceUseType { Id=Guid.Parse("adf24d3f-9a1f-412c-991b-36836876d397"), Code="02788", Description="Storage - hazardous materials", Definition="Storage - hazardous materials is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("28.00") },
            new RefSpaceUseType { Id=Guid.Parse("83274eb6-839f-4248-8728-12793c77613a"), Code="02632", Description="Student support", Definition="Student support is the primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.", SortOrder=Convert.ToDecimal("30.00") },
            new RefSpaceUseType { Id=Guid.Parse("a4693d6d-a27a-4c1f-b65d-915fcf84d4f4"), Code="09999", Description="Other", Definition="The primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("32.00") },
        };

        /// <summary>
        /// The Reference RefSpaceUseType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefSpaceUseTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefSpaceUseType { Id=Guid.Parse("b764d465-c407-438c-ac73-7982d39ed0fa"), Description="Administration", SortOrder=Convert.ToDecimal("2.00") },
            new RefSpaceUseType { Id=Guid.Parse("776587b6-a632-4162-8a32-b0610824f7f6"), Description="Assembly", SortOrder=Convert.ToDecimal("4.00") },
            new RefSpaceUseType { Id=Guid.Parse("9910ae2d-1203-4ec1-a41f-975e932a1fab"), Description="Athletic", SortOrder=Convert.ToDecimal("6.00") },
            new RefSpaceUseType { Id=Guid.Parse("d59fa53c-a2cd-4d61-a66a-97a9aa881c5e"), Description="Basic classroom", SortOrder=Convert.ToDecimal("8.00") },
            new RefSpaceUseType { Id=Guid.Parse("30f5eb13-bf1c-44be-8fa9-6f3cd332ea97"), Description="Corridors", SortOrder=Convert.ToDecimal("10.00") },
            new RefSpaceUseType { Id=Guid.Parse("52a2fc99-fa7f-4643-8065-049229c18e45"), Description="Dormitory room", SortOrder=Convert.ToDecimal("12.00") },
            new RefSpaceUseType { Id=Guid.Parse("cde06d1a-edfb-43a7-b634-9e211549c325"), Description="Food service", SortOrder=Convert.ToDecimal("14.00") },
            new RefSpaceUseType { Id=Guid.Parse("013eed53-655d-4e55-8666-a00b1f3ce293"), Description="Library/media", SortOrder=Convert.ToDecimal("16.00") },
            new RefSpaceUseType { Id=Guid.Parse("98571f25-cc67-496f-af2e-1594381b59ba"), Description="Multi-purpose room", SortOrder=Convert.ToDecimal("18.00") },
            new RefSpaceUseType { Id=Guid.Parse("cb19b725-7981-4464-bec5-e147508eb8b4"), Description="Operational support", SortOrder=Convert.ToDecimal("20.00") },
            new RefSpaceUseType { Id=Guid.Parse("27b32100-965f-415d-8411-d0d381231757"), Description="Restroom", SortOrder=Convert.ToDecimal("22.00") },
            new RefSpaceUseType { Id=Guid.Parse("75ef34bc-c067-49bb-8dd2-f366ccd3babf"), Description="Specialty classroom", SortOrder=Convert.ToDecimal("24.00") },
            new RefSpaceUseType { Id=Guid.Parse("8544b60a-852d-45d2-ac16-a750da36b319"), Description="Storage", SortOrder=Convert.ToDecimal("26.00") },
            new RefSpaceUseType { Id=Guid.Parse("adf24d3f-9a1f-412c-991b-36836876d397"), Description="Storage - hazardous materials", SortOrder=Convert.ToDecimal("28.00") },
            new RefSpaceUseType { Id=Guid.Parse("83274eb6-839f-4248-8728-12793c77613a"), Description="Student support", SortOrder=Convert.ToDecimal("30.00") },
            new RefSpaceUseType { Id=Guid.Parse("a4693d6d-a27a-4c1f-b65d-915fcf84d4f4"), Description="Other", SortOrder=Convert.ToDecimal("32.00") },
       };
   }
}
