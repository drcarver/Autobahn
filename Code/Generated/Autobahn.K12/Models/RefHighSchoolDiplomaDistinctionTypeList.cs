//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefHighSchoolDiplomaDistinctionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefHighSchoolDiplomaDistinctionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefHighSchoolDiplomaDistinctionType"> List
         /// </summary>
        public static List<RefHighSchoolDiplomaDistinctionType> RefHighSchoolDiplomaDistinctionTypeList = new List<RefHighSchoolDiplomaDistinctionType>
        {
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("84e84a56-89bb-4233-b607-8677fefe372c"), Code="Minimum", Description="Minimum", Definition="Minimum is the distinction of the diploma or credential that is awarded to a student in recognition of their completion of the curricular requirements.", SortOrder=Convert.ToDecimal("1.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("6fd54123-0f5d-4283-b82e-826fe37ecfca"), Code="Recommended", Description="Recommended", Definition="Recommended is the distinction of the diploma or credential that is awarded to a student in recognition of their completion of the curricular requirements.", SortOrder=Convert.ToDecimal("2.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("3455d0bd-259c-4360-ab02-778eab009e9f"), Code="Distinguished", Description="Distinguished", Definition="Distinguished is the distinction of the diploma or credential that is awarded to a student in recognition of their completion of the curricular requirements.", SortOrder=Convert.ToDecimal("3.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("bbb13c84-2697-4d12-b82e-8e30622c1b3b"), Code="OpenEnrollment", Description="Open Enrollment", Definition="Open Enrollment is the distinction of the diploma or credential that is awarded to a student in recognition of their completion of the curricular requirements.", SortOrder=Convert.ToDecimal("4.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("29566461-9b72-407a-8df2-b23c98167bb8"), Code="MagnaCumLaude", Description="Magna cum laude", Definition="Magna cum laude is the distinction of the diploma or credential that is awarded to a student in recognition of their completion of the curricular requirements.", SortOrder=Convert.ToDecimal("5.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("3125a014-0f65-44ce-8491-c5c259b6a241"), Code="SummaCumLaude", Description="Summa cum laude", Definition="Summa cum laude is the distinction of the diploma or credential that is awarded to a student in recognition of their completion of the curricular requirements.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefHighSchoolDiplomaDistinctionType Pick List
         /// </summary>
        public static List<RefHighSchoolDiplomaDistinctionType> RefHighSchoolDiplomaDistinctionTypePickList = new List<RefHighSchoolDiplomaDistinctionType>
        {
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("84e84a56-89bb-4233-b607-8677fefe372c"), Code="Minimum", Description="Minimum", SortOrder=Convert.ToDecimal("1.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("6fd54123-0f5d-4283-b82e-826fe37ecfca"), Code="Recommended", Description="Recommended", SortOrder=Convert.ToDecimal("2.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("3455d0bd-259c-4360-ab02-778eab009e9f"), Code="Distinguished", Description="Distinguished", SortOrder=Convert.ToDecimal("3.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("bbb13c84-2697-4d12-b82e-8e30622c1b3b"), Code="OpenEnrollment", Description="Open Enrollment", SortOrder=Convert.ToDecimal("4.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("29566461-9b72-407a-8df2-b23c98167bb8"), Code="MagnaCumLaude", Description="Magna cum laude", SortOrder=Convert.ToDecimal("5.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("3125a014-0f65-44ce-8491-c5c259b6a241"), Code="SummaCumLaude", Description="Summa cum laude", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
