//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingDesignTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingDesignType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingDesignType"> List
         /// </summary>
        public static List<RefBuildingDesignType> RefBuildingDesignTypeList = new List<RefBuildingDesignType>
        {
            new RefBuildingDesignType { Id=Guid.Parse("e3597c4e-c920-4e91-9a7f-7374d6011c97"), Code="02621", Description="Assembly building", Definition="A free-standing building used for large gatherings for school or agency-related activities of students, staff, and public.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingDesignType { Id=Guid.Parse("150a6e5f-500c-4cf3-969f-ddca04d91ef3"), Code="02614", Description="Central kitchen building", Definition="A building designed to accommodate storage and preparation of food.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingDesignType { Id=Guid.Parse("a8dd5bfd-46b4-46a0-a4e9-1dbc3b1ca74f"), Code="02619", Description="Dormitory building", Definition="A building that houses student residences.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingDesignType { Id=Guid.Parse("31b92fd5-16e2-4696-a4c3-0c4369793455"), Code="02616", Description="Field house building", Definition="A free-standing building designed to service athletic facilities, athletes, and athletic events.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingDesignType { Id=Guid.Parse("d673ad53-836b-4f3f-941f-1faf4ce12f3a"), Code="02613", Description="Garage building", Definition="A building that houses the storage and repair of vehicles.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingDesignType { Id=Guid.Parse("c764d21d-affc-4935-a96e-2c6c56dccec0"), Code="02620", Description="Gymnasium building", Definition="A free-standing building for athletic practices and events.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingDesignType { Id=Guid.Parse("a37296ea-bd80-40df-a4d2-ff2e30c381c3"), Code="02617", Description="Media production center building", Definition="A building that houses support communications activities, including newspaper, radio, or television productions.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingDesignType { Id=Guid.Parse("c31834c8-de53-4cd8-a6f9-1e86fcb677c9"), Code="02618", Description="Natatorium", Definition="A building that houses swimming and diving activities, including supporting requirements such as lockers and changing areas.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingDesignType { Id=Guid.Parse("e4ea92a3-e54f-4d8a-8ce2-1d9a502bef01"), Code="02611", Description="Office building", Definition="A building that houses administrative functions.", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingDesignType { Id=Guid.Parse("3561a4a6-b75f-4a58-ac29-3734a78373f8"), Code="03106", Description="School building", Definition="A building that houses instructional and related activities associated with the education of students.", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingDesignType { Id=Guid.Parse("f65351a8-4ca7-419d-87f1-c61e22d8dc2d"), Code="02610", Description="Service center building", Definition="A building that houses support services to students and their families, not direct instruction.", SortOrder=Convert.ToDecimal("11.00") },
            new RefBuildingDesignType { Id=Guid.Parse("ada0bebc-1b61-4750-bfb0-2833c2155313"), Code="02615", Description="Stadium building", Definition="An outdoor building designed for athletic events with large audiences.", SortOrder=Convert.ToDecimal("12.00") },
            new RefBuildingDesignType { Id=Guid.Parse("c14fd06e-eeca-44ef-adbb-418a3582ce56"), Code="02612", Description="Warehouse building", Definition="A building that houses the storage of materials and supplies.", SortOrder=Convert.ToDecimal("13.00") },
            new RefBuildingDesignType { Id=Guid.Parse("fe876411-189d-458a-85ac-bc0bf907f70b"), Code="09999", Description="Other", Definition="Other is specified as the primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingDesignType Pick List
         /// </summary>
        public static List<RefBuildingDesignType> RefBuildingDesignTypePickList = new List<RefBuildingDesignType>
        {
            new RefBuildingDesignType { Id=Guid.Parse("e3597c4e-c920-4e91-9a7f-7374d6011c97"), Code="02621", Description="Assembly building", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingDesignType { Id=Guid.Parse("150a6e5f-500c-4cf3-969f-ddca04d91ef3"), Code="02614", Description="Central kitchen building", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingDesignType { Id=Guid.Parse("a8dd5bfd-46b4-46a0-a4e9-1dbc3b1ca74f"), Code="02619", Description="Dormitory building", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingDesignType { Id=Guid.Parse("31b92fd5-16e2-4696-a4c3-0c4369793455"), Code="02616", Description="Field house building", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingDesignType { Id=Guid.Parse("d673ad53-836b-4f3f-941f-1faf4ce12f3a"), Code="02613", Description="Garage building", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingDesignType { Id=Guid.Parse("c764d21d-affc-4935-a96e-2c6c56dccec0"), Code="02620", Description="Gymnasium building", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingDesignType { Id=Guid.Parse("a37296ea-bd80-40df-a4d2-ff2e30c381c3"), Code="02617", Description="Media production center building", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingDesignType { Id=Guid.Parse("c31834c8-de53-4cd8-a6f9-1e86fcb677c9"), Code="02618", Description="Natatorium", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingDesignType { Id=Guid.Parse("e4ea92a3-e54f-4d8a-8ce2-1d9a502bef01"), Code="02611", Description="Office building", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingDesignType { Id=Guid.Parse("3561a4a6-b75f-4a58-ac29-3734a78373f8"), Code="03106", Description="School building", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingDesignType { Id=Guid.Parse("f65351a8-4ca7-419d-87f1-c61e22d8dc2d"), Code="02610", Description="Service center building", SortOrder=Convert.ToDecimal("11.00") },
            new RefBuildingDesignType { Id=Guid.Parse("ada0bebc-1b61-4750-bfb0-2833c2155313"), Code="02615", Description="Stadium building", SortOrder=Convert.ToDecimal("12.00") },
            new RefBuildingDesignType { Id=Guid.Parse("c14fd06e-eeca-44ef-adbb-418a3582ce56"), Code="02612", Description="Warehouse building", SortOrder=Convert.ToDecimal("13.00") },
            new RefBuildingDesignType { Id=Guid.Parse("fe876411-189d-458a-85ac-bc0bf907f70b"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
