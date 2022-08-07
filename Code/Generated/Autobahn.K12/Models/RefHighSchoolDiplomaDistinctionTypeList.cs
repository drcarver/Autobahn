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
        /// The complete <see cref="RefHighSchoolDiplomaDistinctionTypeModel"> List
         /// </summary>
        public static List<RefHighSchoolDiplomaDistinctionTypeModel> RefHighSchoolDiplomaDistinctionTypeList = new List<RefHighSchoolDiplomaDistinctionTypeModel>
        {
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("c2cdad86-e499-4918-aa2e-cffcf21b54b0"), Code="Minimum", Description="Minimum", Definition="Minimum is the distinction of the diploma or credential that is awarded to a student in recognition of their completion of the curricular requirements.", SortOrder=Convert.ToDecimal("1.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("75a2d914-7648-4837-b748-4806673924f0"), Code="Recommended", Description="Recommended", Definition="Recommended is the distinction of the diploma or credential that is awarded to a student in recognition of their completion of the curricular requirements.", SortOrder=Convert.ToDecimal("2.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("56b0dbcd-6622-4786-be4b-c2eadae8f967"), Code="Distinguished", Description="Distinguished", Definition="Distinguished is the distinction of the diploma or credential that is awarded to a student in recognition of their completion of the curricular requirements.", SortOrder=Convert.ToDecimal("3.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("f949f51d-1c1e-4e1d-8d29-24d831e0cf07"), Code="OpenEnrollment", Description="Open Enrollment", Definition="Open Enrollment is the distinction of the diploma or credential that is awarded to a student in recognition of their completion of the curricular requirements.", SortOrder=Convert.ToDecimal("4.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("2d0fd673-c4bc-4eae-908e-0ce4023bf9aa"), Code="MagnaCumLaude", Description="Magna cum laude", Definition="Magna cum laude is the distinction of the diploma or credential that is awarded to a student in recognition of their completion of the curricular requirements.", SortOrder=Convert.ToDecimal("5.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("32afa40f-4735-4673-87c2-7f3e52c56bb2"), Code="SummaCumLaude", Description="Summa cum laude", Definition="Summa cum laude is the distinction of the diploma or credential that is awarded to a student in recognition of their completion of the curricular requirements.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefHighSchoolDiplomaDistinctionType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefHighSchoolDiplomaDistinctionTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("c2cdad86-e499-4918-aa2e-cffcf21b54b0"), Description="Minimum", SortOrder=Convert.ToDecimal("1.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("75a2d914-7648-4837-b748-4806673924f0"), Description="Recommended", SortOrder=Convert.ToDecimal("2.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("56b0dbcd-6622-4786-be4b-c2eadae8f967"), Description="Distinguished", SortOrder=Convert.ToDecimal("3.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("f949f51d-1c1e-4e1d-8d29-24d831e0cf07"), Description="Open Enrollment", SortOrder=Convert.ToDecimal("4.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("2d0fd673-c4bc-4eae-908e-0ce4023bf9aa"), Description="Magna cum laude", SortOrder=Convert.ToDecimal("5.00") },
            new RefHighSchoolDiplomaDistinctionType { Id=Guid.Parse("32afa40f-4735-4673-87c2-7f3e52c56bb2"), Description="Summa cum laude", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
