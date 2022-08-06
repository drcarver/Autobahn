//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefDisciplineLengthDifferenceReasonList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefDisciplineLengthDifferenceReason Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDisciplineLengthDifferenceReason"> List
         /// </summary>
        public static List<RefDisciplineLengthDifferenceReason> RefDisciplineLengthDifferenceReasonList = new List<RefDisciplineLengthDifferenceReason>
        {
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("2a71e2ef-c6a5-41c3-8239-fa82327ebcb8"), Code="01", Description="No Difference", Definition="No Difference is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("35d91f24-a3af-4bd0-92f3-48dbf311a698"), Code="02", Description="Term Modified By District", Definition="Term Modified By District is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("491177ff-d6e4-4c43-bc91-1623ab6aae9e"), Code="03", Description="Term Modified By Court Order", Definition="Term Modified By Court Order is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("3.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("4e3a5931-e7f5-4a7e-8631-aed30b0a194f"), Code="04", Description="Term Modified By Mutual Agreement", Definition="Term Modified By Mutual Agreement is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("b876022b-3fba-4a45-b500-a9be68f3c063"), Code="05", Description="Student Completed Term Requirements Sooner Than Expected", Definition="Student Completed Term Requirements Sooner Than Expected is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("5.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("d360172d-f1dd-4dbe-bd5c-0574bfec266a"), Code="06", Description="Student Incarcerated", Definition="Student Incarcerated is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("6.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("5ddce1f6-19cf-4c13-81f3-b6704fdcd640"), Code="07", Description="Term Decreased Due To Extenuating Health-Related Circumstances", Definition="Term Decreased Due To Extenuating Health-Related Circumstances is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("7.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("fafa792a-7ded-43c0-8965-72d1b0e53756"), Code="08", Description="Student Withdrew From School", Definition="Student Withdrew From School is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("8.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("dc73983d-5a15-4960-b277-0b5a6800632e"), Code="09", Description="School Year Ended", Definition="School Year Ended is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("9.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("497b9592-6d0f-4254-9a03-d48a6706eee9"), Code="10", Description="Continuation Of Previous Year's Disciplinary Action Assignment", Definition="Continuation Of Previous Year's Disciplinary Action Assignment is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("10.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("91d4642e-b8ac-4eae-87e0-0031c334032c"), Code="11", Description="Term Modified By Placement Program Due To Student Behavior While In The Placement", Definition="Term Modified By Placement Program Due To Student Behavior While In The Placement is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("11.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("2da854e3-8c22-48b0-9410-f5b78e249c71"), Code="12", Description="Other", Definition="Other is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The RefDisciplineLengthDifferenceReason Pick List
         /// </summary>
        public static List<RefDisciplineLengthDifferenceReason> RefDisciplineLengthDifferenceReasonPickList = new List<RefDisciplineLengthDifferenceReason>
        {
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("2a71e2ef-c6a5-41c3-8239-fa82327ebcb8"), Code="01", Description="No Difference", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("35d91f24-a3af-4bd0-92f3-48dbf311a698"), Code="02", Description="Term Modified By District", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("491177ff-d6e4-4c43-bc91-1623ab6aae9e"), Code="03", Description="Term Modified By Court Order", SortOrder=Convert.ToDecimal("3.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("4e3a5931-e7f5-4a7e-8631-aed30b0a194f"), Code="04", Description="Term Modified By Mutual Agreement", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("b876022b-3fba-4a45-b500-a9be68f3c063"), Code="05", Description="Student Completed Term Requirements Sooner Than Expected", SortOrder=Convert.ToDecimal("5.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("d360172d-f1dd-4dbe-bd5c-0574bfec266a"), Code="06", Description="Student Incarcerated", SortOrder=Convert.ToDecimal("6.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("5ddce1f6-19cf-4c13-81f3-b6704fdcd640"), Code="07", Description="Term Decreased Due To Extenuating Health-Related Circumstances", SortOrder=Convert.ToDecimal("7.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("fafa792a-7ded-43c0-8965-72d1b0e53756"), Code="08", Description="Student Withdrew From School", SortOrder=Convert.ToDecimal("8.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("dc73983d-5a15-4960-b277-0b5a6800632e"), Code="09", Description="School Year Ended", SortOrder=Convert.ToDecimal("9.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("497b9592-6d0f-4254-9a03-d48a6706eee9"), Code="10", Description="Continuation Of Previous Year's Disciplinary Action Assignment", SortOrder=Convert.ToDecimal("10.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("91d4642e-b8ac-4eae-87e0-0031c334032c"), Code="11", Description="Term Modified By Placement Program Due To Student Behavior While In The Placement", SortOrder=Convert.ToDecimal("11.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("2da854e3-8c22-48b0-9410-f5b78e249c71"), Code="12", Description="Other", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
