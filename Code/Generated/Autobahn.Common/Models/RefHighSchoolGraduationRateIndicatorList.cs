//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefHighSchoolGraduationRateIndicatorList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefHighSchoolGraduationRateIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefHighSchoolGraduationRateIndicatorModel"> List
         /// </summary>
        public static List<RefHighSchoolGraduationRateIndicatorModel> RefHighSchoolGraduationRateIndicatorList = new List<RefHighSchoolGraduationRateIndicatorModel>
        {
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("3d311af9-d642-4b14-a805-ac0bd416c66b"), Code="MetGoal", Description="Met (Goal)", Definition="The school or district met the High School Graduation Rate goal in accordance with state definition for the purposes of determining AYP.", SortOrder=Convert.ToDecimal("1.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("92657081-1250-4c07-a6c8-35602dd76b30"), Code="MetTarget", Description="Met (Target)", Definition="The school or district met the High School Graduation Rate target in accordance with state definition for the purposes of determining AYP.", SortOrder=Convert.ToDecimal("2.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("b8487cdc-bcf7-4273-858f-325e936a89ec"), Code="DidNotMeet", Description="Did Not Meet", Definition="The school or district did not meet the high school graduation rate indicator for a student subgroup or for all students.", SortOrder=Convert.ToDecimal("3.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("66423083-f568-4ea2-9bad-0fd1ac669030"), Code="TooFewStudents", Description="Too Few Students", Definition="The number of students in the school or district or for a student subgroup was less than the minimum group size outlines in a state's consolidated accountability workbook necessary required to reliably calculate the high school graduation rate indicator.", SortOrder=Convert.ToDecimal("4.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("92a33198-5d9b-4b11-b62f-3e8debb78505"), Code="NoStudents", Description="There are no students in a student subgroup. ", Definition="There are no students in the student subgroup for determining the High School Graduation Rate.", SortOrder=Convert.ToDecimal("5.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("83309aa8-5492-4996-8247-6855474d798c"), Code="NA", Description="Not applicable", Definition="The high school graduation rate indicator status is not applicable.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefHighSchoolGraduationRateIndicator Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefHighSchoolGraduationRateIndicatorViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("3d311af9-d642-4b14-a805-ac0bd416c66b"), Description="Met (Goal)", SortOrder=Convert.ToDecimal("1.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("92657081-1250-4c07-a6c8-35602dd76b30"), Description="Met (Target)", SortOrder=Convert.ToDecimal("2.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("b8487cdc-bcf7-4273-858f-325e936a89ec"), Description="Did Not Meet", SortOrder=Convert.ToDecimal("3.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("66423083-f568-4ea2-9bad-0fd1ac669030"), Description="Too Few Students", SortOrder=Convert.ToDecimal("4.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("92a33198-5d9b-4b11-b62f-3e8debb78505"), Description="There are no students in a student subgroup. ", SortOrder=Convert.ToDecimal("5.00") },
            new RefHighSchoolGraduationRateIndicator { Id=Guid.Parse("83309aa8-5492-4996-8247-6855474d798c"), Description="Not applicable", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
