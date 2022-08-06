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
        public static List<RefLeaType> RefLeaTypeList = new List<RefLeaType> =
        {
            new RefLeaType { Id=Guid.Parse("4bb53d59-5c2c-48c0-b2fc-110efe051f84"), Code="A local government administrative authority which governs the education system at a specified local level on behalf of the public and the state and is NOT a component of a supervisory union.", Description="RegularNotInSupervisoryUnion", Definition="", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("67cd9fbb-1620-4522-854d-fb6516472548"), Code="A local government administrative authority which governs the education system at a specified local level on behalf of the public and the state and is a component of a supervisory union.", Description="RegularInSupervisoryUnion", Definition="", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("94dc8ac5-d628-45f8-a88a-40fe5c0fc4e8"), Code="An administrative center or county superintendent's office serving as the administrative center.", Description="SupervisoryUnion", Definition="", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("52eab240-2917-4803-9692-8093a16920f6"), Code="A school district that operates one or more schools that are designed for a specific educational need or purpose.", Description="SpecializedPublicSchoolDistrict", Definition="", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("ae02a7af-a0ca-427a-872e-e2336da655d4"), Code="An agency that does not operate schools, instead it provides specialized educational services (such as career and technical education) or related services (such as services in IEPs) to other education agencies that the agencies cannot readily provide for themselves.", Description="ServiceAgency", Definition="", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("693efe03-37b7-48e0-b610-98d45feb0fbd"), Code="An organization overseen by a state agency that operates schools or programs that provide public elementary and/or secondary level instruction.", Description="StateOperatedAgency", Definition="", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("28e2f5fc-dbcb-47c3-bc80-8020a56bf122"), Code="An organization overseen by a federal agency that operates schools or programs that provide public elementary and/or secondary level instruction.", Description="FederalOperatedAgency", Definition="", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("50a6a045-5112-4b75-8472-3a022459fae5"), Code="An independent charter district is an education unit created under the state charter legislation that is not under the administrative control of another local education agency and that operates one or more charter schools - and only charter schools.", Description="IndependentCharterDistrict", Definition="", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("15f3e28f-a9f0-481f-976b-57c08afcefa8"), Code="Category for an agency providing elementary or secondary instruction or support services to use when one of the other types defined in CEDS is not appropriate.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLeaType Pick List
         /// </summary>
        public static List<RefLeaType> RefLeaTypePickList = new List<RefLeaType> =
        {
            new RefLeaType { Id=Guid.Parse("4bb53d59-5c2c-48c0-b2fc-110efe051f84"), Code="A local government administrative authority which governs the education system at a specified local level on behalf of the public and the state and is NOT a component of a supervisory union.", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("67cd9fbb-1620-4522-854d-fb6516472548"), Code="A local government administrative authority which governs the education system at a specified local level on behalf of the public and the state and is a component of a supervisory union.", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("94dc8ac5-d628-45f8-a88a-40fe5c0fc4e8"), Code="An administrative center or county superintendent's office serving as the administrative center.", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("52eab240-2917-4803-9692-8093a16920f6"), Code="A school district that operates one or more schools that are designed for a specific educational need or purpose.", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("ae02a7af-a0ca-427a-872e-e2336da655d4"), Code="An agency that does not operate schools, instead it provides specialized educational services (such as career and technical education) or related services (such as services in IEPs) to other education agencies that the agencies cannot readily provide for themselves.", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("693efe03-37b7-48e0-b610-98d45feb0fbd"), Code="An organization overseen by a state agency that operates schools or programs that provide public elementary and/or secondary level instruction.", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("28e2f5fc-dbcb-47c3-bc80-8020a56bf122"), Code="An organization overseen by a federal agency that operates schools or programs that provide public elementary and/or secondary level instruction.", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("50a6a045-5112-4b75-8472-3a022459fae5"), Code="An independent charter district is an education unit created under the state charter legislation that is not under the administrative control of another local education agency and that operates one or more charter schools - and only charter schools.", SortOrder=0 },
            new RefLeaType { Id=Guid.Parse("15f3e28f-a9f0-481f-976b-57c08afcefa8"), Code="Category for an agency providing elementary or secondary instruction or support services to use when one of the other types defined in CEDS is not appropriate.", SortOrder=0 },
       };
   }
}
