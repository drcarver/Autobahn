//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIndividualizedProgramTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIndividualizedProgramType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIndividualizedProgramTypeModel"> List
         /// </summary>
        public static List<RefIndividualizedProgramTypeModel> RefIndividualizedProgramTypeList = new List<RefIndividualizedProgramTypeModel>
        {
            new RefIndividualizedProgramType { Id=Guid.Parse("9241eb51-1aff-4e7a-8fe3-db31103acc1a"), Code="05978", Description="504 plan", Definition="This type of individualized program developed for the student is a 504 plan.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("58383ed0-0eb0-44ac-ad97-ecf333205bb4"), Code="89600", Description="College and Career Ready Learning Plan", Definition="This type of individualized program developed for the student is a College and Career Ready Learning Plan.", SortOrder=Convert.ToDecimal("1.50") },
            new RefIndividualizedProgramType { Id=Guid.Parse("427b9bf7-2b65-4876-a11c-8fc1765bde54"), Code="05980", Description="GIEP - Individualized education program for gifted student", Definition="This type of individualized program developed for the student is a GIEP - Individualized education program for gifted student.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("375973a9-d18f-4dbf-95a6-a40ce89e12b0"), Code="02196", Description="Individualized education program (IEP)", Definition="This type of individualized program developed for the student is an individualized education program (IEP).", SortOrder=Convert.ToDecimal("3.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("f0cb73a0-6f4e-469b-9b1c-7f71b4ad1fe1"), Code="02198", Description="Individualized family service plan (IFSP)", Definition="This type of individualized program developed for the student is an individualized family service plan (IFSP).", SortOrder=Convert.ToDecimal("4.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("66009703-f10a-498e-a673-d170f77ffbf9"), Code="02197", Description="Individualized learning program (ILP)", Definition="This type of individualized program developed for the student is an individualized learning program (ILP).", SortOrder=Convert.ToDecimal("5.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("821535b5-08d6-4714-bb87-677117d6161c"), Code="05982", Description="Individualized transition plan", Definition="This type of individualized program developed for the student is an individualized transition plan.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("cc920f99-d785-4628-af0f-a2fb1eccfefa"), Code="02349", Description="English learner", Definition="This type of individualized program developed for the student is an English learner.", SortOrder=Convert.ToDecimal("7.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("efc3f921-e4ed-4e10-806f-1740ba5307d0"), Code="05981", Description="Literacy plan", Definition="This type of individualized program developed for the student is a literacy plan.", SortOrder=Convert.ToDecimal("8.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("9e4b97e0-50b2-4402-a7e8-7965c7ce3079"), Code="05979", Description="Student intervention/support plan", Definition="This type of individualized program developed for the student is a student intervention/support plan.", SortOrder=Convert.ToDecimal("9.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("e862fca6-5e20-4252-9916-88a8ceddcf5c"), Code="09999", Description="Other", Definition="This type of individualized program developed for the student is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefIndividualizedProgramType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIndividualizedProgramTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIndividualizedProgramType { Id=Guid.Parse("9241eb51-1aff-4e7a-8fe3-db31103acc1a"), Description="504 plan", SortOrder=Convert.ToDecimal("1.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("58383ed0-0eb0-44ac-ad97-ecf333205bb4"), Description="College and Career Ready Learning Plan", SortOrder=Convert.ToDecimal("1.50") },
            new RefIndividualizedProgramType { Id=Guid.Parse("427b9bf7-2b65-4876-a11c-8fc1765bde54"), Description="GIEP - Individualized education program for gifted student", SortOrder=Convert.ToDecimal("2.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("375973a9-d18f-4dbf-95a6-a40ce89e12b0"), Description="Individualized education program (IEP)", SortOrder=Convert.ToDecimal("3.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("f0cb73a0-6f4e-469b-9b1c-7f71b4ad1fe1"), Description="Individualized family service plan (IFSP)", SortOrder=Convert.ToDecimal("4.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("66009703-f10a-498e-a673-d170f77ffbf9"), Description="Individualized learning program (ILP)", SortOrder=Convert.ToDecimal("5.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("821535b5-08d6-4714-bb87-677117d6161c"), Description="Individualized transition plan", SortOrder=Convert.ToDecimal("6.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("cc920f99-d785-4628-af0f-a2fb1eccfefa"), Description="English learner", SortOrder=Convert.ToDecimal("7.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("efc3f921-e4ed-4e10-806f-1740ba5307d0"), Description="Literacy plan", SortOrder=Convert.ToDecimal("8.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("9e4b97e0-50b2-4402-a7e8-7965c7ce3079"), Description="Student intervention/support plan", SortOrder=Convert.ToDecimal("9.00") },
            new RefIndividualizedProgramType { Id=Guid.Parse("e862fca6-5e20-4252-9916-88a8ceddcf5c"), Description="Other", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
