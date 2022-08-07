//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefEarlyChildhoodProgramEnrollmentTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefEarlyChildhoodProgramEnrollmentType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEarlyChildhoodProgramEnrollmentTypeModel"> List
         /// </summary>
        public static List<RefEarlyChildhoodProgramEnrollmentTypeModel> RefEarlyChildhoodProgramEnrollmentTypeList = new List<RefEarlyChildhoodProgramEnrollmentTypeModel>
        {
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("e995139a-bcb5-4c2d-b39f-d5e5f6fd0dc0"), Code="HeadStart", Description="Head Start", Definition="Head Start is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("21bccfdb-7997-4537-a7f3-89ca49fa6138"), Code="EarlyHeadStart", Description="Early Head Start", Definition="Early Head Start is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("ee8e3a83-e259-4666-8004-812cd1e3ec6b"), Code="StatePreschool", Description="State Preschool", Definition="State Preschool is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("5.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("06068b25-f931-42a0-96c2-1233db8e978b"), Code="PublicPreschool", Description="Public Preschool", Definition="Public Preschool is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("7.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("b9fd0139-7aa9-4483-b145-71cb89f39df1"), Code="PrivatePreschool", Description="Private Preschool", Definition="Private Preschool is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("9.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("5a7e0472-940e-45ba-a40f-006bebfe48d7"), Code="EarlyChildhoodSpecialEducation", Description="Early Childhood Special Education (619)", Definition="Early Childhood Special Education (619) is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("11.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("cfa9a2d8-1ac6-4ec2-97fe-b39408935d51"), Code="HomeVisiting", Description="Home Visiting", Definition="Home Visiting is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("13.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("5d2e2a51-ff9f-4f40-b72f-7b041b917477"), Code="ChildCare", Description="Child Care", Definition="Child Care is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("15.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("6c3296c1-9c5d-48e1-ad85-bba68c28cc2a"), Code="EarlyInterventionPartC", Description="Early Intervention Services Part C", Definition="Early Intervention Services Part C is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("17.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("9553daa0-339d-424e-8aa3-96974fa514ef"), Code="Other", Description="Other", Definition="The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("19.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("8a5ca8d5-6b5f-49db-8f53-2e68af425d4c"), Code="None", Description="None", Definition="The child is not enrolled in an early childhood program.", SortOrder=Convert.ToDecimal("21.00") },
        };

        /// <summary>
        /// The Reference RefEarlyChildhoodProgramEnrollmentType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEarlyChildhoodProgramEnrollmentTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("e995139a-bcb5-4c2d-b39f-d5e5f6fd0dc0"), Description="Head Start", SortOrder=Convert.ToDecimal("1.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("21bccfdb-7997-4537-a7f3-89ca49fa6138"), Description="Early Head Start", SortOrder=Convert.ToDecimal("3.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("ee8e3a83-e259-4666-8004-812cd1e3ec6b"), Description="State Preschool", SortOrder=Convert.ToDecimal("5.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("06068b25-f931-42a0-96c2-1233db8e978b"), Description="Public Preschool", SortOrder=Convert.ToDecimal("7.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("b9fd0139-7aa9-4483-b145-71cb89f39df1"), Description="Private Preschool", SortOrder=Convert.ToDecimal("9.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("5a7e0472-940e-45ba-a40f-006bebfe48d7"), Description="Early Childhood Special Education (619)", SortOrder=Convert.ToDecimal("11.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("cfa9a2d8-1ac6-4ec2-97fe-b39408935d51"), Description="Home Visiting", SortOrder=Convert.ToDecimal("13.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("5d2e2a51-ff9f-4f40-b72f-7b041b917477"), Description="Child Care", SortOrder=Convert.ToDecimal("15.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("6c3296c1-9c5d-48e1-ad85-bba68c28cc2a"), Description="Early Intervention Services Part C", SortOrder=Convert.ToDecimal("17.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("9553daa0-339d-424e-8aa3-96974fa514ef"), Description="Other", SortOrder=Convert.ToDecimal("19.00") },
            new RefEarlyChildhoodProgramEnrollmentType { Id=Guid.Parse("8a5ca8d5-6b5f-49db-8f53-2e68af425d4c"), Description="None", SortOrder=Convert.ToDecimal("21.00") },
       };
   }
}
