//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefPredominantCalendarSystemList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefPredominantCalendarSystem Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPredominantCalendarSystemModel"> List
         /// </summary>
        public static List<RefPredominantCalendarSystemModel> RefPredominantCalendarSystemList = new List<RefPredominantCalendarSystemModel>
        {
            new RefPredominantCalendarSystem { Id=Guid.Parse("304a55bc-5ecd-4f97-88e3-10e39fa6d314"), Code="Semester", Description="Semester ", Definition="The institution structures most of its courses for the academic year by Semester.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("14858237-e6c2-4c91-ae79-bfd791a540d6"), Code="Quarter", Description="Quarter ", Definition="The institution structures most of its courses for the academic year by Quarter.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("bffbe3f3-159f-4bbf-9ad9-bb007b7a13f1"), Code="Trimester", Description="Trimester", Definition="The institution structures most of its courses for the academic year by Trimester.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("8a3234a1-aef2-4a68-a617-d3ca17b71ab3"), Code="4-1-4", Description="4-1-4 or similar plan", Definition="The institution structures most of its courses for the academic year by 4-1-4 or similar plan.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("a4f3c2a1-0d75-43bf-9338-c75f6971f0ef"), Code="Other", Description="Other academic plan", Definition="The institution structures most of its courses for the academic year by an academic plan not yet defined in CEDS.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("eb284d3e-df50-47de-b3b4-36bb79b2845f"), Code="DiffersByProgram", Description="Differs by program", Definition="The method by which an institution structures most of its courses for the academic year differs by program.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("4457ef3f-7d61-4d93-9437-1430be3753c9"), Code="ContinuousBasis", Description="Continuous basis", Definition="The institution structures most of its courses for the academic year on a continuous basis.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefPredominantCalendarSystem Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPredominantCalendarSystemViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPredominantCalendarSystem { Id=Guid.Parse("304a55bc-5ecd-4f97-88e3-10e39fa6d314"), Description="Semester ", SortOrder=Convert.ToDecimal("1.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("14858237-e6c2-4c91-ae79-bfd791a540d6"), Description="Quarter ", SortOrder=Convert.ToDecimal("2.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("bffbe3f3-159f-4bbf-9ad9-bb007b7a13f1"), Description="Trimester", SortOrder=Convert.ToDecimal("3.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("8a3234a1-aef2-4a68-a617-d3ca17b71ab3"), Description="4-1-4 or similar plan", SortOrder=Convert.ToDecimal("4.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("a4f3c2a1-0d75-43bf-9338-c75f6971f0ef"), Description="Other academic plan", SortOrder=Convert.ToDecimal("5.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("eb284d3e-df50-47de-b3b4-36bb79b2845f"), Description="Differs by program", SortOrder=Convert.ToDecimal("6.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("4457ef3f-7d61-4d93-9437-1430be3753c9"), Description="Continuous basis", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
