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
        /// The complete <see cref="RefBuildingDesignTypeModel"> List
         /// </summary>
        public static List<RefBuildingDesignTypeModel> RefBuildingDesignTypeList = new List<RefBuildingDesignTypeModel>
        {
            new RefBuildingDesignType { Id=Guid.Parse("84b8ef30-fc8e-4ee6-add3-60d2a549cb16"), Code="02621", Description="Assembly building", Definition="A free-standing building used for large gatherings for school or agency-related activities of students, staff, and public.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingDesignType { Id=Guid.Parse("7954a0fc-6476-4fb9-9dd7-ebc15155271a"), Code="02614", Description="Central kitchen building", Definition="A building designed to accommodate storage and preparation of food.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingDesignType { Id=Guid.Parse("d007a6f6-9256-49aa-ad0c-5306c6be3c01"), Code="02619", Description="Dormitory building", Definition="A building that houses student residences.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingDesignType { Id=Guid.Parse("5dc20194-1974-4f9a-9344-51e25fc986e0"), Code="02616", Description="Field house building", Definition="A free-standing building designed to service athletic facilities, athletes, and athletic events.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingDesignType { Id=Guid.Parse("30d38b79-b545-4fbd-9407-af81915d16d3"), Code="02613", Description="Garage building", Definition="A building that houses the storage and repair of vehicles.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingDesignType { Id=Guid.Parse("a1686028-1f42-40a1-bf82-140f80974b3e"), Code="02620", Description="Gymnasium building", Definition="A free-standing building for athletic practices and events.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingDesignType { Id=Guid.Parse("4fd52301-675a-4f1b-be6d-16f7243c7fd5"), Code="02617", Description="Media production center building", Definition="A building that houses support communications activities, including newspaper, radio, or television productions.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingDesignType { Id=Guid.Parse("95d2336e-8200-427f-a01e-f33ff8a5a3a4"), Code="02618", Description="Natatorium", Definition="A building that houses swimming and diving activities, including supporting requirements such as lockers and changing areas.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingDesignType { Id=Guid.Parse("1f732da9-236e-45c4-be5c-60c87522a5dd"), Code="02611", Description="Office building", Definition="A building that houses administrative functions.", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingDesignType { Id=Guid.Parse("12dde03a-c430-4af5-a975-5ce33d2ef7be"), Code="03106", Description="School building", Definition="A building that houses instructional and related activities associated with the education of students.", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingDesignType { Id=Guid.Parse("4a23de99-a622-43f6-952b-1f99f5d82aa2"), Code="02610", Description="Service center building", Definition="A building that houses support services to students and their families, not direct instruction.", SortOrder=Convert.ToDecimal("11.00") },
            new RefBuildingDesignType { Id=Guid.Parse("80d0c234-c41c-406a-bc85-7e666c36c2d6"), Code="02615", Description="Stadium building", Definition="An outdoor building designed for athletic events with large audiences.", SortOrder=Convert.ToDecimal("12.00") },
            new RefBuildingDesignType { Id=Guid.Parse("9d85a805-9a44-439b-92e5-a3559c5b3b3f"), Code="02612", Description="Warehouse building", Definition="A building that houses the storage of materials and supplies.", SortOrder=Convert.ToDecimal("13.00") },
            new RefBuildingDesignType { Id=Guid.Parse("aabbce3a-94e9-454e-bf10-1e0351dbc7f7"), Code="09999", Description="Other", Definition="Other is specified as the primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingDesignType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingDesignTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingDesignType { Id=Guid.Parse("84b8ef30-fc8e-4ee6-add3-60d2a549cb16"), Description="Assembly building", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingDesignType { Id=Guid.Parse("7954a0fc-6476-4fb9-9dd7-ebc15155271a"), Description="Central kitchen building", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingDesignType { Id=Guid.Parse("d007a6f6-9256-49aa-ad0c-5306c6be3c01"), Description="Dormitory building", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingDesignType { Id=Guid.Parse("5dc20194-1974-4f9a-9344-51e25fc986e0"), Description="Field house building", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingDesignType { Id=Guid.Parse("30d38b79-b545-4fbd-9407-af81915d16d3"), Description="Garage building", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingDesignType { Id=Guid.Parse("a1686028-1f42-40a1-bf82-140f80974b3e"), Description="Gymnasium building", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingDesignType { Id=Guid.Parse("4fd52301-675a-4f1b-be6d-16f7243c7fd5"), Description="Media production center building", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingDesignType { Id=Guid.Parse("95d2336e-8200-427f-a01e-f33ff8a5a3a4"), Description="Natatorium", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingDesignType { Id=Guid.Parse("1f732da9-236e-45c4-be5c-60c87522a5dd"), Description="Office building", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingDesignType { Id=Guid.Parse("12dde03a-c430-4af5-a975-5ce33d2ef7be"), Description="School building", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingDesignType { Id=Guid.Parse("4a23de99-a622-43f6-952b-1f99f5d82aa2"), Description="Service center building", SortOrder=Convert.ToDecimal("11.00") },
            new RefBuildingDesignType { Id=Guid.Parse("80d0c234-c41c-406a-bc85-7e666c36c2d6"), Description="Stadium building", SortOrder=Convert.ToDecimal("12.00") },
            new RefBuildingDesignType { Id=Guid.Parse("9d85a805-9a44-439b-92e5-a3559c5b3b3f"), Description="Warehouse building", SortOrder=Convert.ToDecimal("13.00") },
            new RefBuildingDesignType { Id=Guid.Parse("aabbce3a-94e9-454e-bf10-1e0351dbc7f7"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
