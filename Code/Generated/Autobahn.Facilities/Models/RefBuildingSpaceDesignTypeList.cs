//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingSpaceDesignTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingSpaceDesignType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingSpaceDesignTypeModel"> List
         /// </summary>
        public static List<RefBuildingSpaceDesignTypeModel> RefBuildingSpaceDesignTypeList = new List<RefBuildingSpaceDesignTypeModel>
        {
            new RefBuildingSpaceDesignType { Id=Guid.Parse("3c22fb43-86a7-4267-9733-db1992fd3806"), Code="02633", Description="Administration", Definition="A space primarily for conducting overall administrative and business functions of a school, building, program, or service.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("8e37d730-e79f-49db-b638-22ecbfe46894"), Code="02634", Description="Assembly", Definition="A space primarily for formal and informal gathering, where school and community related activities are conducted by students, staff, and the public.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("c748d1b4-3608-455b-9e5b-95b9cf59452e"), Code="02631", Description="Athletic", Definition="A space primarily or exclusively for physical education and athletic activities, often with specialized floor, walls, size, equipment, lighting, and auxiliary spaces.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("91466f3d-a557-4279-be30-e2a1c09e2330"), Code="02628", Description="Basic classroom", Definition="A space for the activities dealing directly with the interaction between teachers and students that does not require content specialized furniture, fixtures, or equipment.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("d803a155-08a6-4d8b-8315-12da6339a580"), Code="02635", Description="Corridors", Definition="A space for traveling throughout the building.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("0a721b98-3b02-4930-9584-215ce7b6dead"), Code="02639", Description="Dormitory room", Definition="A space specially designed for residence of students.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("483e3154-103e-4074-9cc1-34faf7cfa400"), Code="02638", Description="Food service", Definition="A space to store food.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("494776d7-d1f7-49b1-a7e4-668a056a96b3"), Code="02630", Description="Library/media", Definition="A space for reading, reference, and research in various media, including books, periodicals, and electronic communications.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("45da63e3-704c-4545-9758-2528b250dded"), Code="02773", Description="Multi-purpose Room", Definition="A space with a stage and movable chairs designed for assemblies, but also usable for other purposes.", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("8709f48f-3e2f-40de-bac3-1c62a43869a8"), Code="02636", Description="Operational support", Definition="A space to support building systems and components and to operate the physical plant.", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("db3918d9-757f-4f79-ada5-159598e04c42"), Code="03017", Description="Restroom", Definition="A location on campus designated as a bathroom facility.", SortOrder=Convert.ToDecimal("11.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("57b7b7ae-f8e5-479c-ae66-4042dada8be3"), Code="02629", Description="Specialty classroom", Definition="A space with special elements including furniture, fixtures, equipment, and sometimes size to support instruction in a particular content area.", SortOrder=Convert.ToDecimal("12.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("bf30f093-ea04-4af4-977b-3af0e053f841"), Code="02637", Description="Storage", Definition="A space to provide safekeeping for materials and supplies.", SortOrder=Convert.ToDecimal("13.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("7c7f0520-d4a1-4022-9ab4-9547c82757bb"), Code="02788", Description="Storage - hazardous materials", Definition="Storage for hazardous materials is specified as the primary design or purpose of a space, as determined by its physical layout and built-in systems and equipment, regardless of its current use.", SortOrder=Convert.ToDecimal("14.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("c5a3cd79-649e-4cc4-b8e5-112c643415dd"), Code="02632", Description="Student support", Definition="A space for providing specialized support services to students such as health care or physical therapy.", SortOrder=Convert.ToDecimal("15.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("a2ea6998-0a7e-4e77-a74f-17fe625b7370"), Code="09999", Description="Other", Definition="Other is specified as the primary design or purpose of a space, as determined by its physical layout and built-in systems and equipment, regardless of its current use.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingSpaceDesignType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingSpaceDesignTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingSpaceDesignType { Id=Guid.Parse("3c22fb43-86a7-4267-9733-db1992fd3806"), Description="Administration", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("8e37d730-e79f-49db-b638-22ecbfe46894"), Description="Assembly", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("c748d1b4-3608-455b-9e5b-95b9cf59452e"), Description="Athletic", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("91466f3d-a557-4279-be30-e2a1c09e2330"), Description="Basic classroom", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("d803a155-08a6-4d8b-8315-12da6339a580"), Description="Corridors", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("0a721b98-3b02-4930-9584-215ce7b6dead"), Description="Dormitory room", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("483e3154-103e-4074-9cc1-34faf7cfa400"), Description="Food service", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("494776d7-d1f7-49b1-a7e4-668a056a96b3"), Description="Library/media", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("45da63e3-704c-4545-9758-2528b250dded"), Description="Multi-purpose Room", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("8709f48f-3e2f-40de-bac3-1c62a43869a8"), Description="Operational support", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("db3918d9-757f-4f79-ada5-159598e04c42"), Description="Restroom", SortOrder=Convert.ToDecimal("11.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("57b7b7ae-f8e5-479c-ae66-4042dada8be3"), Description="Specialty classroom", SortOrder=Convert.ToDecimal("12.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("bf30f093-ea04-4af4-977b-3af0e053f841"), Description="Storage", SortOrder=Convert.ToDecimal("13.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("7c7f0520-d4a1-4022-9ab4-9547c82757bb"), Description="Storage - hazardous materials", SortOrder=Convert.ToDecimal("14.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("c5a3cd79-649e-4cc4-b8e5-112c643415dd"), Description="Student support", SortOrder=Convert.ToDecimal("15.00") },
            new RefBuildingSpaceDesignType { Id=Guid.Parse("a2ea6998-0a7e-4e77-a74f-17fe625b7370"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
