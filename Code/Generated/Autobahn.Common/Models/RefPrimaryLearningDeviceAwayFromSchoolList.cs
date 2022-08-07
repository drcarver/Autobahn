//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPrimaryLearningDeviceAwayFromSchoolList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPrimaryLearningDeviceAwayFromSchool Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPrimaryLearningDeviceAwayFromSchoolModel"> List
         /// </summary>
        public static List<RefPrimaryLearningDeviceAwayFromSchoolModel> RefPrimaryLearningDeviceAwayFromSchoolList = new List<RefPrimaryLearningDeviceAwayFromSchoolModel>
        {
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("e3e75c3e-ff93-4abc-8993-14428ae4b2d6"), Code="Chromebook", Description="Chromebook", Definition="A Chromebook is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("7dee84d7-ec5d-428d-9066-3afc5c1a8bb9"), Code="DesktopComputer", Description="Desktop Computer", Definition="A desktop computer is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("bb33eab1-9dad-4512-84f4-519a7d321922"), Code="LaptopComputer", Description="Laptop Computer", Definition="A Laptop Computer is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("8e08bfe3-41e1-4e78-a8a8-11ac6b6ac02b"), Code="None", Description="None", Definition="There is not a device the student uses to complete learning activities away from school.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("40d8ee96-c0ae-4e63-b0c8-747a264bafb3"), Code="Smartphone", Description="Smartphone", Definition="A Smartphone is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("f3f707de-8c96-4526-952a-2b854fdd4d97"), Code="Tablet", Description="Tablet", Definition="A Tablet is the type of device the student uses most often to complete learning activities away from school.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("d0d9ff7d-855c-489a-9a28-bca2f54577a2"), Code="Other", Description="Other", Definition="The type of device the student uses most often to complete learning activities away from school is not yet defined.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefPrimaryLearningDeviceAwayFromSchool Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPrimaryLearningDeviceAwayFromSchoolViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("e3e75c3e-ff93-4abc-8993-14428ae4b2d6"), Description="Chromebook", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("7dee84d7-ec5d-428d-9066-3afc5c1a8bb9"), Description="Desktop Computer", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("bb33eab1-9dad-4512-84f4-519a7d321922"), Description="Laptop Computer", SortOrder=Convert.ToDecimal("3.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("8e08bfe3-41e1-4e78-a8a8-11ac6b6ac02b"), Description="None", SortOrder=Convert.ToDecimal("4.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("40d8ee96-c0ae-4e63-b0c8-747a264bafb3"), Description="Smartphone", SortOrder=Convert.ToDecimal("5.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("f3f707de-8c96-4526-952a-2b854fdd4d97"), Description="Tablet", SortOrder=Convert.ToDecimal("6.00") },
            new RefPrimaryLearningDeviceAwayFromSchool { Id=Guid.Parse("d0d9ff7d-855c-489a-9a28-bca2f54577a2"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
