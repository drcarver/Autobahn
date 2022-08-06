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
        /// The complete <see cref="RefLeaType"> List
         /// </summary>
        public static List<RefLeaType> RefLeaTypeList = new List<RefLeaType>
        {
            new RefLeaType { Id=Guid.Parse("dfcce77b-09b1-453e-bcb6-3b72f7d73cb6"), Code="RegularNotInSupervisoryUnion", Description="Regular public school district that is NOT a component of a supervisory union", Definition="A local government administrative authority which governs the education system at a specified local level on behalf of the public and the state and is NOT a component of a supervisory union.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLeaType { Id=Guid.Parse("56081d88-8334-4f86-aa47-13a555687877"), Code="RegularInSupervisoryUnion", Description="Regular public school district that is a component of a supervisory union", Definition="A local government administrative authority which governs the education system at a specified local level on behalf of the public and the state and is a component of a supervisory union.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLeaType { Id=Guid.Parse("df5f5dbd-8406-4717-b2a4-2bec40dbe75c"), Code="SupervisoryUnion", Description=" Supervisory Union", Definition="An administrative center or county superintendent's office serving as the administrative center.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLeaType { Id=Guid.Parse("6afcce5e-5bee-406d-9c6e-6c8e4fab748d"), Code="SpecializedPublicSchoolDistrict", Description="Specialized Public School District", Definition="A school district that operates one or more schools that are designed for a specific educational need or purpose.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLeaType { Id=Guid.Parse("fc2437c9-6ef0-4d18-941b-6bd3d9ca3e60"), Code="ServiceAgency", Description="Service Agency", Definition="An agency that does not operate schools, instead it provides specialized educational services (such as career and technical education) or related services (such as services in IEPs) to other education agencies that the agencies cannot readily provide for themselves.", SortOrder=Convert.ToDecimal("5.00") },
            new RefLeaType { Id=Guid.Parse("175aaa07-a426-4474-8ed9-7d45730d6a3c"), Code="StateOperatedAgency", Description="State Operated Agency", Definition="An organization overseen by a state agency that operates schools or programs that provide public elementary and/or secondary level instruction.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLeaType { Id=Guid.Parse("b4029877-d0ac-43f3-ac15-621a7c7c10d9"), Code="FederalOperatedAgency", Description="Federal Operated Agency", Definition="An organization overseen by a federal agency that operates schools or programs that provide public elementary and/or secondary level instruction.", SortOrder=Convert.ToDecimal("7.00") },
            new RefLeaType { Id=Guid.Parse("37bf0419-996b-4f18-8b7d-9547882f9c73"), Code="IndependentCharterDistrict", Description="Independent Charter District", Definition="An independent charter district is an education unit created under the state charter legislation that is not under the administrative control of another local education agency and that operates one or more charter schools - and only charter schools.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLeaType { Id=Guid.Parse("43656195-c83c-44db-be49-41bef5984655"), Code="Other", Description="Other Local Education Agencies", Definition="Category for an agency providing elementary or secondary instruction or support services to use when one of the other types defined in CEDS is not appropriate.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefLeaType Pick List
         /// </summary>
        public static List<RefLeaType> RefLeaTypePickList = new List<RefLeaType>
        {
            new RefLeaType { Id=Guid.Parse("dfcce77b-09b1-453e-bcb6-3b72f7d73cb6"), Code="RegularNotInSupervisoryUnion", Description="Regular public school district that is NOT a component of a supervisory union", SortOrder=Convert.ToDecimal("1.00") },
            new RefLeaType { Id=Guid.Parse("56081d88-8334-4f86-aa47-13a555687877"), Code="RegularInSupervisoryUnion", Description="Regular public school district that is a component of a supervisory union", SortOrder=Convert.ToDecimal("2.00") },
            new RefLeaType { Id=Guid.Parse("df5f5dbd-8406-4717-b2a4-2bec40dbe75c"), Code="SupervisoryUnion", Description=" Supervisory Union", SortOrder=Convert.ToDecimal("3.00") },
            new RefLeaType { Id=Guid.Parse("6afcce5e-5bee-406d-9c6e-6c8e4fab748d"), Code="SpecializedPublicSchoolDistrict", Description="Specialized Public School District", SortOrder=Convert.ToDecimal("4.00") },
            new RefLeaType { Id=Guid.Parse("fc2437c9-6ef0-4d18-941b-6bd3d9ca3e60"), Code="ServiceAgency", Description="Service Agency", SortOrder=Convert.ToDecimal("5.00") },
            new RefLeaType { Id=Guid.Parse("175aaa07-a426-4474-8ed9-7d45730d6a3c"), Code="StateOperatedAgency", Description="State Operated Agency", SortOrder=Convert.ToDecimal("6.00") },
            new RefLeaType { Id=Guid.Parse("b4029877-d0ac-43f3-ac15-621a7c7c10d9"), Code="FederalOperatedAgency", Description="Federal Operated Agency", SortOrder=Convert.ToDecimal("7.00") },
            new RefLeaType { Id=Guid.Parse("37bf0419-996b-4f18-8b7d-9547882f9c73"), Code="IndependentCharterDistrict", Description="Independent Charter District", SortOrder=Convert.ToDecimal("8.00") },
            new RefLeaType { Id=Guid.Parse("43656195-c83c-44db-be49-41bef5984655"), Code="Other", Description="Other Local Education Agencies", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
