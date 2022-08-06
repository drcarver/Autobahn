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
        /// The complete <see cref="RefPredominantCalendarSystem"> List
         /// </summary>
        public static List<RefPredominantCalendarSystem> RefPredominantCalendarSystemList = new List<RefPredominantCalendarSystem>
        {
            new RefPredominantCalendarSystem { Id=Guid.Parse("e44b84e8-677f-4738-b8de-1895613fbe17"), Code="Semester", Description="Semester ", Definition="The institution structures most of its courses for the academic year by Semester.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("35b183ca-59b1-421b-bc21-a1db740a97a4"), Code="Quarter", Description="Quarter ", Definition="The institution structures most of its courses for the academic year by Quarter.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("07148183-9691-43b7-a11e-c2fe643cce1a"), Code="Trimester", Description="Trimester", Definition="The institution structures most of its courses for the academic year by Trimester.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("3fd4156d-0777-403f-9e4c-6e93017da9ff"), Code="4-1-4", Description="4-1-4 or similar plan", Definition="The institution structures most of its courses for the academic year by 4-1-4 or similar plan.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("1014a379-457f-4b65-9d7f-14cc235732ae"), Code="Other", Description="Other academic plan", Definition="The institution structures most of its courses for the academic year by an academic plan not yet defined in CEDS.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("f27b44cd-dc09-47dd-971b-00fdcffc0d4a"), Code="DiffersByProgram", Description="Differs by program", Definition="The method by which an institution structures most of its courses for the academic year differs by program.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("e9c8fc1f-39d3-4e9a-a57f-585df441584b"), Code="ContinuousBasis", Description="Continuous basis", Definition="The institution structures most of its courses for the academic year on a continuous basis.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefPredominantCalendarSystem Pick List
         /// </summary>
        public static List<RefPredominantCalendarSystem> RefPredominantCalendarSystemPickList = new List<RefPredominantCalendarSystem>
        {
            new RefPredominantCalendarSystem { Id=Guid.Parse("e44b84e8-677f-4738-b8de-1895613fbe17"), Code="Semester", Description="Semester ", SortOrder=Convert.ToDecimal("1.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("35b183ca-59b1-421b-bc21-a1db740a97a4"), Code="Quarter", Description="Quarter ", SortOrder=Convert.ToDecimal("2.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("07148183-9691-43b7-a11e-c2fe643cce1a"), Code="Trimester", Description="Trimester", SortOrder=Convert.ToDecimal("3.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("3fd4156d-0777-403f-9e4c-6e93017da9ff"), Code="4-1-4", Description="4-1-4 or similar plan", SortOrder=Convert.ToDecimal("4.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("1014a379-457f-4b65-9d7f-14cc235732ae"), Code="Other", Description="Other academic plan", SortOrder=Convert.ToDecimal("5.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("f27b44cd-dc09-47dd-971b-00fdcffc0d4a"), Code="DiffersByProgram", Description="Differs by program", SortOrder=Convert.ToDecimal("6.00") },
            new RefPredominantCalendarSystem { Id=Guid.Parse("e9c8fc1f-39d3-4e9a-a57f-585df441584b"), Code="ContinuousBasis", Description="Continuous basis", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
