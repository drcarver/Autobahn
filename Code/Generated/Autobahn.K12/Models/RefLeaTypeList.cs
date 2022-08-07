//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefLeaTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefLeaType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLeaTypeModel"> List
         /// </summary>
        public static List<RefLeaTypeModel> RefLeaTypeList = new List<RefLeaTypeModel>
        {
            new RefLeaType { Id=Guid.Parse("38ef3956-83e5-4096-a882-a76d9b8b1b86"), Code="RegularNotInSupervisoryUnion", Description="Regular public school district that is NOT a component of a supervisory union", Definition="A local government administrative authority which governs the education system at a specified local level on behalf of the public and the state and is NOT a component of a supervisory union.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLeaType { Id=Guid.Parse("ba85a312-ddf2-48ba-adb2-588497405f91"), Code="RegularInSupervisoryUnion", Description="Regular public school district that is a component of a supervisory union", Definition="A local government administrative authority which governs the education system at a specified local level on behalf of the public and the state and is a component of a supervisory union.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLeaType { Id=Guid.Parse("37c585f7-35ea-4787-bea3-8e35f6bcff47"), Code="SupervisoryUnion", Description=" Supervisory Union", Definition="An administrative center or county superintendent's office serving as the administrative center.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLeaType { Id=Guid.Parse("12fcc943-4643-430a-b4fd-1caac2bca8c3"), Code="SpecializedPublicSchoolDistrict", Description="Specialized Public School District", Definition="A school district that operates one or more schools that are designed for a specific educational need or purpose.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLeaType { Id=Guid.Parse("6d35615b-2f09-45ce-94c6-dc46cf9a76c5"), Code="ServiceAgency", Description="Service Agency", Definition="An agency that does not operate schools, instead it provides specialized educational services (such as career and technical education) or related services (such as services in IEPs) to other education agencies that the agencies cannot readily provide for themselves.", SortOrder=Convert.ToDecimal("5.00") },
            new RefLeaType { Id=Guid.Parse("8af5e072-05a9-425b-951f-4ad9cefd32f7"), Code="StateOperatedAgency", Description="State Operated Agency", Definition="An organization overseen by a state agency that operates schools or programs that provide public elementary and/or secondary level instruction.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLeaType { Id=Guid.Parse("a82987e8-3af2-4a26-9436-4c1c827125d0"), Code="FederalOperatedAgency", Description="Federal Operated Agency", Definition="An organization overseen by a federal agency that operates schools or programs that provide public elementary and/or secondary level instruction.", SortOrder=Convert.ToDecimal("7.00") },
            new RefLeaType { Id=Guid.Parse("9afa143e-e5a9-476a-8afc-16d6dad15cf2"), Code="IndependentCharterDistrict", Description="Independent Charter District", Definition="An independent charter district is an education unit created under the state charter legislation that is not under the administrative control of another local education agency and that operates one or more charter schools - and only charter schools.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLeaType { Id=Guid.Parse("2493c369-c2da-4bdc-9972-cfc2a85f942a"), Code="Other", Description="Other Local Education Agencies", Definition="Category for an agency providing elementary or secondary instruction or support services to use when one of the other types defined in CEDS is not appropriate.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefLeaType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLeaTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLeaType { Id=Guid.Parse("38ef3956-83e5-4096-a882-a76d9b8b1b86"), Description="Regular public school district that is NOT a component of a supervisory union", SortOrder=Convert.ToDecimal("1.00") },
            new RefLeaType { Id=Guid.Parse("ba85a312-ddf2-48ba-adb2-588497405f91"), Description="Regular public school district that is a component of a supervisory union", SortOrder=Convert.ToDecimal("2.00") },
            new RefLeaType { Id=Guid.Parse("37c585f7-35ea-4787-bea3-8e35f6bcff47"), Description=" Supervisory Union", SortOrder=Convert.ToDecimal("3.00") },
            new RefLeaType { Id=Guid.Parse("12fcc943-4643-430a-b4fd-1caac2bca8c3"), Description="Specialized Public School District", SortOrder=Convert.ToDecimal("4.00") },
            new RefLeaType { Id=Guid.Parse("6d35615b-2f09-45ce-94c6-dc46cf9a76c5"), Description="Service Agency", SortOrder=Convert.ToDecimal("5.00") },
            new RefLeaType { Id=Guid.Parse("8af5e072-05a9-425b-951f-4ad9cefd32f7"), Description="State Operated Agency", SortOrder=Convert.ToDecimal("6.00") },
            new RefLeaType { Id=Guid.Parse("a82987e8-3af2-4a26-9436-4c1c827125d0"), Description="Federal Operated Agency", SortOrder=Convert.ToDecimal("7.00") },
            new RefLeaType { Id=Guid.Parse("9afa143e-e5a9-476a-8afc-16d6dad15cf2"), Description="Independent Charter District", SortOrder=Convert.ToDecimal("8.00") },
            new RefLeaType { Id=Guid.Parse("2493c369-c2da-4bdc-9972-cfc2a85f942a"), Description="Other Local Education Agencies", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
