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
        /// The complete <see cref="RefBuildingBasicClassroomDesignType"> List
         /// </summary>
        public static List<RefBuildingBasicClassroomDesignType> RefBuildingBasicClassroomDesignTypeList = new List<RefBuildingBasicClassroomDesignType>
        {
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("5b960828-fe4a-40d4-bd1f-f1a7036d02d1"), Code="01304", Description="Elementary", Definition="Elementary is specified as the particular age group for which a classroom is designed for instruction.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("fbc43f38-1558-43d9-a5d3-ca09d2dc5417"), Code="01981", Description="Preschool/early childhood", Definition="Preschool/early childhood is specified as the particular age group for which a classroom is designed for instruction.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("c309fa9c-73ba-410e-b0ee-c7a8be98ab49"), Code="03495", Description="Resource", Definition="Resource is specified as the particular age group for which a classroom is designed for instruction.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("72dbbdec-8d27-4140-9496-6cd2c8bf42a5"), Code="02403", Description="Secondary", Definition="Secondary is specified as the particular age group for which a classroom is designed for instruction.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("b4e8c6af-62c1-422a-8c60-9f0f2dcacd7f"), Code="14906", Description="Skills center", Definition="Skills center is specified as the particular age group for which a classroom is designed for instruction.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("34933b84-c8ac-43a4-954e-6cb4f969b754"), Code="09999", Description="Other", Definition="Other is specified as the particular age group for which a classroom is designed for instruction.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingBasicClassroomDesignType Pick List
         /// </summary>
        public static List<RefBuildingBasicClassroomDesignType> RefBuildingBasicClassroomDesignTypePickList = new List<RefBuildingBasicClassroomDesignType>
        {
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("5b960828-fe4a-40d4-bd1f-f1a7036d02d1"), Code="01304", Description="Elementary", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("fbc43f38-1558-43d9-a5d3-ca09d2dc5417"), Code="01981", Description="Preschool/early childhood", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("c309fa9c-73ba-410e-b0ee-c7a8be98ab49"), Code="03495", Description="Resource", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("72dbbdec-8d27-4140-9496-6cd2c8bf42a5"), Code="02403", Description="Secondary", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("b4e8c6af-62c1-422a-8c60-9f0f2dcacd7f"), Code="14906", Description="Skills center", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingBasicClassroomDesignType { Id=Guid.Parse("34933b84-c8ac-43a4-954e-6cb4f969b754"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
