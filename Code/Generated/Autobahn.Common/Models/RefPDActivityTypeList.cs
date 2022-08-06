//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDActivityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDActivityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDActivityType"> List
         /// </summary>
        public static List<RefPDActivityType> RefPDActivityTypeList = new List<RefPDActivityType>
        {
            new RefPDActivityType { Id=Guid.Parse("c3c44b82-3eb2-4d66-b846-5e19f7612ead"), Code="CollegeCourse", Description="College Course", Definition="The type of professional development activity is a College Course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityType { Id=Guid.Parse("c04ef85e-8319-43bf-94e7-c6dc911448e6"), Code="Coaching", Description="Coaching", Definition="The type of professional development activity is Coaching.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDActivityType { Id=Guid.Parse("6ebf431d-942e-4081-973b-861c48bba0b6"), Code="Mentoring", Description="Mentoring", Definition="The type of professional development activity is Mentoring.", SortOrder=Convert.ToDecimal("8.00") },
            new RefPDActivityType { Id=Guid.Parse("0f200d30-6a41-4576-9df3-80c0322f0cfa"), Code="Consultation", Description="Consultation", Definition="The type of professional development activity is Consultation.", SortOrder=Convert.ToDecimal("10.00") },
            new RefPDActivityType { Id=Guid.Parse("6b01a1b9-dbdd-42b5-8ee8-76db6b7b1588"), Code="P2P", Description="Person-to-Person", Definition="The type of professional development activity is Person-to-Person.", SortOrder=Convert.ToDecimal("12.00") },
            new RefPDActivityType { Id=Guid.Parse("db231250-70d2-4061-aa38-64fa82bf7231"), Code="TechnicalAssistance", Description="Technical Assistance", Definition="The type of professional development activity is Technical Assistance.", SortOrder=Convert.ToDecimal("14.00") },
            new RefPDActivityType { Id=Guid.Parse("fb58a218-e24d-40e5-b6b4-8cdc13ab3657"), Code="Advisement", Description="Advisement", Definition="The type of professional development activity is Advisement.", SortOrder=Convert.ToDecimal("16.00") },
            new RefPDActivityType { Id=Guid.Parse("334f8181-7ff4-4596-976c-075ba185bee3"), Code="OneTimeWorkshopTraining", Description="One-time Workshop Training", Definition="The type of professional development activity is One-time Workshop Training.", SortOrder=Convert.ToDecimal("18.00") },
            new RefPDActivityType { Id=Guid.Parse("0860cc38-d915-44ef-afa4-136ea838b09a"), Code="SeriesOfWorkshopsTraining", Description="Series of Workshops Training", Definition="The type of professional development activity is Series of Workshops Training.", SortOrder=Convert.ToDecimal("19.00") },
            new RefPDActivityType { Id=Guid.Parse("be51d333-4c4c-4693-88a7-952bc1052347"), Code="Other", Description="Other", Definition="The type of professional development activity is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("20.00") },
        };

        /// <summary>
        /// The RefPDActivityType Pick List
         /// </summary>
        public static List<RefPDActivityType> RefPDActivityTypePickList = new List<RefPDActivityType>
        {
            new RefPDActivityType { Id=Guid.Parse("c3c44b82-3eb2-4d66-b846-5e19f7612ead"), Code="CollegeCourse", Description="College Course", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityType { Id=Guid.Parse("c04ef85e-8319-43bf-94e7-c6dc911448e6"), Code="Coaching", Description="Coaching", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDActivityType { Id=Guid.Parse("6ebf431d-942e-4081-973b-861c48bba0b6"), Code="Mentoring", Description="Mentoring", SortOrder=Convert.ToDecimal("8.00") },
            new RefPDActivityType { Id=Guid.Parse("0f200d30-6a41-4576-9df3-80c0322f0cfa"), Code="Consultation", Description="Consultation", SortOrder=Convert.ToDecimal("10.00") },
            new RefPDActivityType { Id=Guid.Parse("6b01a1b9-dbdd-42b5-8ee8-76db6b7b1588"), Code="P2P", Description="Person-to-Person", SortOrder=Convert.ToDecimal("12.00") },
            new RefPDActivityType { Id=Guid.Parse("db231250-70d2-4061-aa38-64fa82bf7231"), Code="TechnicalAssistance", Description="Technical Assistance", SortOrder=Convert.ToDecimal("14.00") },
            new RefPDActivityType { Id=Guid.Parse("fb58a218-e24d-40e5-b6b4-8cdc13ab3657"), Code="Advisement", Description="Advisement", SortOrder=Convert.ToDecimal("16.00") },
            new RefPDActivityType { Id=Guid.Parse("334f8181-7ff4-4596-976c-075ba185bee3"), Code="OneTimeWorkshopTraining", Description="One-time Workshop Training", SortOrder=Convert.ToDecimal("18.00") },
            new RefPDActivityType { Id=Guid.Parse("0860cc38-d915-44ef-afa4-136ea838b09a"), Code="SeriesOfWorkshopsTraining", Description="Series of Workshops Training", SortOrder=Convert.ToDecimal("19.00") },
            new RefPDActivityType { Id=Guid.Parse("be51d333-4c4c-4693-88a7-952bc1052347"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("20.00") },
       };
   }
}
