//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPrimaryLearningDeviceAwayFromSchoolList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPrimaryLearningDeviceAwayFromSchool Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPrimaryLearningDeviceAwayFromSchool"> List
         /// </summary>
        public static List<RefPrimaryLearningDeviceAwayFromSchool> RefPrimaryLearningDeviceAwayFromSchoolList = new List<RefPrimaryLearningDeviceAwayFromSchool>
        {
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("3cd7a47a-61b8-4041-96b9-ad3482cf002b"), Code="Chromebook", Description="Chromebook", Definition="A Chromebook is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("0e1b3b21-6702-4f15-8202-2a851c71952e"), Code="DesktopComputer", Description="Desktop Computer", Definition="A desktop computer is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("eab40019-ac8f-4366-a8b3-f8189acec2b0"), Code="LaptopComputer", Description="Laptop Computer", Definition="A Laptop Computer is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("1e06322f-37d6-495e-ae48-e428f59d3bac"), Code="None", Description="None", Definition="There is not a device the student uses to complete learning activities away from school.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("79854e10-c8b8-4e98-a05f-c64323227d14"), Code="Smartphone", Description="Smartphone", Definition="A Smartphone is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("4b127fe6-0bfb-47ae-8e23-a619203d4cc9"), Code="Tablet", Description="Tablet", Definition="A Tablet is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("329f2219-81c8-473d-8ef6-0ea3ca8b2d86"), Code="Other", Description="Other", Definition="The type of device the student uses most often to complete learning activities away from school is not yet defined.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefPrimaryLearningDeviceAwayFromSchool Pick List
         /// </summary>
        public static List<RefPrimaryLearningDeviceAwayFromSchool> RefPrimaryLearningDeviceAwayFromSchoolPickList = new List<RefPrimaryLearningDeviceAwayFromSchool>
        {
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("3cd7a47a-61b8-4041-96b9-ad3482cf002b"), Code="Chromebook", Description="Chromebook", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("0e1b3b21-6702-4f15-8202-2a851c71952e"), Code="DesktopComputer", Description="Desktop Computer", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("eab40019-ac8f-4366-a8b3-f8189acec2b0"), Code="LaptopComputer", Description="Laptop Computer", SortOrder=Convert.ToDecimal("3.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("1e06322f-37d6-495e-ae48-e428f59d3bac"), Code="None", Description="None", SortOrder=Convert.ToDecimal("4.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("79854e10-c8b8-4e98-a05f-c64323227d14"), Code="Smartphone", Description="Smartphone", SortOrder=Convert.ToDecimal("5.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("4b127fe6-0bfb-47ae-8e23-a619203d4cc9"), Code="Tablet", Description="Tablet", SortOrder=Convert.ToDecimal("6.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("329f2219-81c8-473d-8ef6-0ea3ca8b2d86"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
