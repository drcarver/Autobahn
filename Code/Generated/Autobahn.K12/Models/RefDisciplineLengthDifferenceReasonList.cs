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
        /// The complete <see cref="RefDisciplineLengthDifferenceReasonModel"> List
         /// </summary>
        public static List<RefDisciplineLengthDifferenceReasonModel> RefDisciplineLengthDifferenceReasonList = new List<RefDisciplineLengthDifferenceReasonModel>
        {
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("fd25c5a8-b700-47a4-a9f0-b3757783fec3"), Code="01", Description="No Difference", Definition="No Difference is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("de1f1133-d511-42a3-817b-45f11145074e"), Code="02", Description="Term Modified By District", Definition="Term Modified By District is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("0022c3e3-48b5-41db-9829-197009ac630a"), Code="03", Description="Term Modified By Court Order", Definition="Term Modified By Court Order is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("3.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("47c58c5d-6e75-478e-98a6-907d612634c7"), Code="04", Description="Term Modified By Mutual Agreement", Definition="Term Modified By Mutual Agreement is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("59a03c73-71b5-4d21-b0de-98bffca92f43"), Code="05", Description="Student Completed Term Requirements Sooner Than Expected", Definition="Student Completed Term Requirements Sooner Than Expected is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("5.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("b1079ccd-5b29-41a2-91b0-a41423c97fc9"), Code="06", Description="Student Incarcerated", Definition="Student Incarcerated is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("6.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("6632bf61-4e13-460b-a55e-0cf0276bc9c1"), Code="07", Description="Term Decreased Due To Extenuating Health-Related Circumstances", Definition="Term Decreased Due To Extenuating Health-Related Circumstances is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("7.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("23441546-9661-45a1-98c8-01e1caae25a2"), Code="08", Description="Student Withdrew From School", Definition="Student Withdrew From School is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("8.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("952c4db1-859e-4cc5-b459-b85b132dc346"), Code="09", Description="School Year Ended", Definition="School Year Ended is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("9.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("529ac217-e5df-4bec-b068-8a1aca501f99"), Code="10", Description="Continuation Of Previous Year's Disciplinary Action Assignment", Definition="Continuation Of Previous Year's Disciplinary Action Assignment is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("10.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("eee7594e-62e2-4c44-82ad-724f326b15d5"), Code="11", Description="Term Modified By Placement Program Due To Student Behavior While In The Placement", Definition="Term Modified By Placement Program Due To Student Behavior While In The Placement is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("11.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("1e7f8a06-35e3-4e67-87f8-cbfdc2899b37"), Code="12", Description="Other", Definition="Other is the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The Reference RefDisciplineLengthDifferenceReason Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefDisciplineLengthDifferenceReasonViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("fd25c5a8-b700-47a4-a9f0-b3757783fec3"), Description="No Difference", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("de1f1133-d511-42a3-817b-45f11145074e"), Description="Term Modified By District", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("0022c3e3-48b5-41db-9829-197009ac630a"), Description="Term Modified By Court Order", SortOrder=Convert.ToDecimal("3.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("47c58c5d-6e75-478e-98a6-907d612634c7"), Description="Term Modified By Mutual Agreement", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("59a03c73-71b5-4d21-b0de-98bffca92f43"), Description="Student Completed Term Requirements Sooner Than Expected", SortOrder=Convert.ToDecimal("5.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("b1079ccd-5b29-41a2-91b0-a41423c97fc9"), Description="Student Incarcerated", SortOrder=Convert.ToDecimal("6.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("6632bf61-4e13-460b-a55e-0cf0276bc9c1"), Description="Term Decreased Due To Extenuating Health-Related Circumstances", SortOrder=Convert.ToDecimal("7.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("23441546-9661-45a1-98c8-01e1caae25a2"), Description="Student Withdrew From School", SortOrder=Convert.ToDecimal("8.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("952c4db1-859e-4cc5-b459-b85b132dc346"), Description="School Year Ended", SortOrder=Convert.ToDecimal("9.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("529ac217-e5df-4bec-b068-8a1aca501f99"), Description="Continuation Of Previous Year's Disciplinary Action Assignment", SortOrder=Convert.ToDecimal("10.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("eee7594e-62e2-4c44-82ad-724f326b15d5"), Description="Term Modified By Placement Program Due To Student Behavior While In The Placement", SortOrder=Convert.ToDecimal("11.00") },
            new RefDisciplineLengthDifferenceReason { Id=Guid.Parse("1e7f8a06-35e3-4e67-87f8-cbfdc2899b37"), Description="Other", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
