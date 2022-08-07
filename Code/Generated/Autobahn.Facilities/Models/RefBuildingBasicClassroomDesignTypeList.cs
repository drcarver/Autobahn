//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingBasicClassroomDesignTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingBasicClassroomDesignType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingBasicClassroomDesignTypeModel"> List
         /// </summary>
        public static List<RefBuildingBasicClassroomDesignTypeModel> RefBuildingBasicClassroomDesignTypeList = new List<RefBuildingBasicClassroomDesignTypeModel>
        {
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("e0603025-1467-4b77-b9d9-5d132ae79640"), Code="01304", Description="Elementary", Definition="Elementary is specified as the particular age group for which a classroom is designed for instruction.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("6d114706-845d-4648-9071-7a79e92c0000"), Code="01981", Description="Preschool/early childhood", Definition="Preschool/early childhood is specified as the particular age group for which a classroom is designed for instruction.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("71c57ab2-31c2-4fcf-ae38-6951cf84d30f"), Code="03495", Description="Resource", Definition="Resource is specified as the particular age group for which a classroom is designed for instruction.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("74a19129-5002-4be5-9e9c-7025cdb9eb78"), Code="02403", Description="Secondary", Definition="Secondary is specified as the particular age group for which a classroom is designed for instruction.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("19596236-43d3-4133-abef-1a6d172bccd3"), Code="14906", Description="Skills center", Definition="Skills center is specified as the particular age group for which a classroom is designed for instruction.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("440a658a-dca3-43a1-bded-98f7519aa9c7"), Code="09999", Description="Other", Definition="Other is specified as the particular age group for which a classroom is designed for instruction.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingBasicClassroomDesignType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingBasicClassroomDesignTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("e0603025-1467-4b77-b9d9-5d132ae79640"), Description="Elementary", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("6d114706-845d-4648-9071-7a79e92c0000"), Description="Preschool/early childhood", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("71c57ab2-31c2-4fcf-ae38-6951cf84d30f"), Description="Resource", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("74a19129-5002-4be5-9e9c-7025cdb9eb78"), Description="Secondary", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("19596236-43d3-4133-abef-1a6d172bccd3"), Description="Skills center", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("440a658a-dca3-43a1-bded-98f7519aa9c7"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
