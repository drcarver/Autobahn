//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentSessionStaffRoleTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentSessionStaffRoleType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentSessionStaffRoleType"> List
         /// </summary>
        public static List<RefAssessmentSessionStaffRoleType> RefAssessmentSessionStaffRoleTypeList = new List<RefAssessmentSessionStaffRoleType>
        {
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("992c7909-0429-4944-89a5-05e6a5ab3f30"), Code="Teacher", Description="Teacher", Definition="Teacher is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("0.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("85b10465-659e-4a6d-8ace-a99a46dca0bd"), Code="Principal", Description="Principal", Definition="Principal is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("bbddf8e0-a09f-4b80-aee3-b8d4b202faeb"), Code="Administrator", Description="Administrator", Definition="Administrator is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("d8932a3b-347e-43ba-afe7-b449b1963eee"), Code="Proctor", Description="Proctor", Definition="Proctor is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("018ba777-63d7-47c9-957d-2ea8e2c7b533"), Code="Observer", Description="Observer", Definition="Observer is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("b8a44228-e7d2-4128-8764-96cbbb71ef70"), Code="Scorer", Description="Scorer", Definition="Scorer is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("a7846e42-72e3-497f-b9db-22ec7337f661"), Code="Registrar", Description="Registrar", Definition="Registrar is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The RefAssessmentSessionStaffRoleType Pick List
         /// </summary>
        public static List<RefAssessmentSessionStaffRoleType> RefAssessmentSessionStaffRoleTypePickList = new List<RefAssessmentSessionStaffRoleType>
        {
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("992c7909-0429-4944-89a5-05e6a5ab3f30"), Code="Teacher", Description="Teacher", SortOrder=Convert.ToDecimal("0.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("85b10465-659e-4a6d-8ace-a99a46dca0bd"), Code="Principal", Description="Principal", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("bbddf8e0-a09f-4b80-aee3-b8d4b202faeb"), Code="Administrator", Description="Administrator", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("d8932a3b-347e-43ba-afe7-b449b1963eee"), Code="Proctor", Description="Proctor", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("018ba777-63d7-47c9-957d-2ea8e2c7b533"), Code="Observer", Description="Observer", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("b8a44228-e7d2-4128-8764-96cbbb71ef70"), Code="Scorer", Description="Scorer", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("a7846e42-72e3-497f-b9db-22ec7337f661"), Code="Registrar", Description="Registrar", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
