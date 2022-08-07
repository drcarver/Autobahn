//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncreasedLearningTimeTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncreasedLearningTimeType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncreasedLearningTimeTypeModel"> List
         /// </summary>
        public static List<RefIncreasedLearningTimeTypeModel> RefIncreasedLearningTimeTypeList = new List<RefIncreasedLearningTimeTypeModel>
        {
            new RefIncreasedLearningTimeType { Id=Guid.Parse("9336e08c-f8a4-418e-942c-a4500348e7da"), Code="LongerSchoolYear", Description="Longer School Year", Definition="Longer School Year is a type of increased learning time provided.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("769e0acb-817c-4c42-8a8a-d371933eb65d"), Code="LongerSchoolDay", Description="Longer School Day", Definition="Longer School Day is a type of increased learning time provided.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("0abe4ea9-4e84-4c1e-ba0d-7c8c90926d99"), Code="BeforeOrAfterSchool", Description="Before or After School", Definition="Before or After School is a type of increased learning time provided.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("7915faa9-121f-4489-9ad6-da082a30a262"), Code="SummerSchool", Description="Summer School", Definition="Summer School is a type of increased learning time provided.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("2b541309-50ea-43a4-b334-72bb719f0b18"), Code="WeekendSchool", Description="Weekend School", Definition="Weekend School is a type of increased learning time provided.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("ce817e8b-c191-4395-a180-694517f8dba4"), Code="AfterSchool", Description="After School", Definition="After school is a type of increased learning time provided.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("04d23684-ecfe-4247-b4b6-cf96c88cc7d2"), Code="Other", Description="Other", Definition="Other is a type of increased learning time provided.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("f1f4892e-98f5-4cef-852a-6878d496c0f0"), Code="BeforeSchool", Description="Before School", Definition="Before school is a type of increased learning time provided.", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("fd3de8f6-cba2-49d4-808e-4c5e142876ff"), Code="NightSchool", Description="Night School", Definition="Night School is a type of increased learning time provided.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefIncreasedLearningTimeType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIncreasedLearningTimeTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIncreasedLearningTimeType { Id=Guid.Parse("9336e08c-f8a4-418e-942c-a4500348e7da"), Description="Longer School Year", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("769e0acb-817c-4c42-8a8a-d371933eb65d"), Description="Longer School Day", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("0abe4ea9-4e84-4c1e-ba0d-7c8c90926d99"), Description="Before or After School", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("7915faa9-121f-4489-9ad6-da082a30a262"), Description="Summer School", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("2b541309-50ea-43a4-b334-72bb719f0b18"), Description="Weekend School", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("ce817e8b-c191-4395-a180-694517f8dba4"), Description="After School", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("04d23684-ecfe-4247-b4b6-cf96c88cc7d2"), Description="Other", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("f1f4892e-98f5-4cef-852a-6878d496c0f0"), Description="Before School", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncreasedLearningTimeType { Id=Guid.Parse("fd3de8f6-cba2-49d4-808e-4c5e142876ff"), Description="Night School", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
