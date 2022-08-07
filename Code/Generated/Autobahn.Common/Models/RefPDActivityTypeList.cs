//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDActivityTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDActivityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDActivityTypeModel"> List
         /// </summary>
        public static List<RefPDActivityTypeModel> RefPDActivityTypeList = new List<RefPDActivityTypeModel>
        {
            new RefPDActivityType { Id=Guid.Parse("24351f24-8ffc-493a-a3bd-34f01435044b"), Code="CollegeCourse", Description="College Course", Definition="The type of professional development activity is a College Course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityType { Id=Guid.Parse("78b426bd-ae6f-401f-850b-edf3a584160c"), Code="Coaching", Description="Coaching", Definition="The type of professional development activity is Coaching.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDActivityType { Id=Guid.Parse("dcf138a3-c0c1-4684-acb6-27fab4de42bc"), Code="Mentoring", Description="Mentoring", Definition="The type of professional development activity is Mentoring.", SortOrder=Convert.ToDecimal("8.00") },
            new RefPDActivityType { Id=Guid.Parse("507d325b-9768-4229-8e5b-c8e213c64d3a"), Code="Consultation", Description="Consultation", Definition="The type of professional development activity is Consultation.", SortOrder=Convert.ToDecimal("10.00") },
            new RefPDActivityType { Id=Guid.Parse("2a844e2b-4193-4aca-a019-9761d9e5425c"), Code="P2P", Description="Person-to-Person", Definition="The type of professional development activity is Person-to-Person.", SortOrder=Convert.ToDecimal("12.00") },
            new RefPDActivityType { Id=Guid.Parse("f4aea479-da4f-422e-aa24-81abb98b0cb5"), Code="TechnicalAssistance", Description="Technical Assistance", Definition="The type of professional development activity is Technical Assistance.", SortOrder=Convert.ToDecimal("14.00") },
            new RefPDActivityType { Id=Guid.Parse("fa1b599b-3032-4066-9b1c-73790f9e57cb"), Code="Advisement", Description="Advisement", Definition="The type of professional development activity is Advisement.", SortOrder=Convert.ToDecimal("16.00") },
            new RefPDActivityType { Id=Guid.Parse("91bb2d48-3b02-4150-8320-cd930113e628"), Code="OneTimeWorkshopTraining", Description="One-time Workshop Training", Definition="The type of professional development activity is One-time Workshop Training.", SortOrder=Convert.ToDecimal("18.00") },
            new RefPDActivityType { Id=Guid.Parse("4ec21513-c5e0-4465-9edb-ea4c9dd7333e"), Code="SeriesOfWorkshopsTraining", Description="Series of Workshops Training", Definition="The type of professional development activity is Series of Workshops Training.", SortOrder=Convert.ToDecimal("19.00") },
            new RefPDActivityType { Id=Guid.Parse("f1e17fff-3e79-4dfb-bbd3-7250cd3464aa"), Code="Other", Description="Other", Definition="The type of professional development activity is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("20.00") },
        };

        /// <summary>
        /// The Reference RefPDActivityType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPDActivityTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPDActivityType { Id=Guid.Parse("24351f24-8ffc-493a-a3bd-34f01435044b"), Description="College Course", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityType { Id=Guid.Parse("78b426bd-ae6f-401f-850b-edf3a584160c"), Description="Coaching", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDActivityType { Id=Guid.Parse("dcf138a3-c0c1-4684-acb6-27fab4de42bc"), Description="Mentoring", SortOrder=Convert.ToDecimal("8.00") },
            new RefPDActivityType { Id=Guid.Parse("507d325b-9768-4229-8e5b-c8e213c64d3a"), Description="Consultation", SortOrder=Convert.ToDecimal("10.00") },
            new RefPDActivityType { Id=Guid.Parse("2a844e2b-4193-4aca-a019-9761d9e5425c"), Description="Person-to-Person", SortOrder=Convert.ToDecimal("12.00") },
            new RefPDActivityType { Id=Guid.Parse("f4aea479-da4f-422e-aa24-81abb98b0cb5"), Description="Technical Assistance", SortOrder=Convert.ToDecimal("14.00") },
            new RefPDActivityType { Id=Guid.Parse("fa1b599b-3032-4066-9b1c-73790f9e57cb"), Description="Advisement", SortOrder=Convert.ToDecimal("16.00") },
            new RefPDActivityType { Id=Guid.Parse("91bb2d48-3b02-4150-8320-cd930113e628"), Description="One-time Workshop Training", SortOrder=Convert.ToDecimal("18.00") },
            new RefPDActivityType { Id=Guid.Parse("4ec21513-c5e0-4465-9edb-ea4c9dd7333e"), Description="Series of Workshops Training", SortOrder=Convert.ToDecimal("19.00") },
            new RefPDActivityType { Id=Guid.Parse("f1e17fff-3e79-4dfb-bbd3-7250cd3464aa"), Description="Other", SortOrder=Convert.ToDecimal("20.00") },
       };
   }
}
