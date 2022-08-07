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
        /// The complete <see cref="RefAssessmentSessionStaffRoleTypeModel"> List
         /// </summary>
        public static List<RefAssessmentSessionStaffRoleTypeModel> RefAssessmentSessionStaffRoleTypeList = new List<RefAssessmentSessionStaffRoleTypeModel>
        {
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("f35df55f-b3df-498b-afa8-454cff5d1670"), Code="Teacher", Description="Teacher", Definition="Teacher is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("0.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("9a7c6b84-e83e-4699-ae80-2433e448d811"), Code="Principal", Description="Principal", Definition="Principal is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("93634a49-697c-4209-9c29-07c1c3668839"), Code="Administrator", Description="Administrator", Definition="Administrator is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("d3e141d0-b4c5-4e0f-86e2-0af4d1f253bf"), Code="Proctor", Description="Proctor", Definition="Proctor is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("a2d90412-87f5-4d25-9e1b-818fc8cecffa"), Code="Observer", Description="Observer", Definition="Observer is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("de30600e-e6dc-4fc5-8134-4c7f8fef1b1a"), Code="Scorer", Description="Scorer", Definition="Scorer is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("33af43f1-71d5-4828-9d68-6edb80fe7e91"), Code="Registrar", Description="Registrar", Definition="Registrar is specified as the staff role the person served in related to the administration of an assessment session.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentSessionStaffRoleType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentSessionStaffRoleTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("f35df55f-b3df-498b-afa8-454cff5d1670"), Description="Teacher", SortOrder=Convert.ToDecimal("0.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("9a7c6b84-e83e-4699-ae80-2433e448d811"), Description="Principal", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("93634a49-697c-4209-9c29-07c1c3668839"), Description="Administrator", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("d3e141d0-b4c5-4e0f-86e2-0af4d1f253bf"), Description="Proctor", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("a2d90412-87f5-4d25-9e1b-818fc8cecffa"), Description="Observer", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("de30600e-e6dc-4fc5-8134-4c7f8fef1b1a"), Description="Scorer", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentSessionStaffRoleType { Id=Guid.Parse("33af43f1-71d5-4828-9d68-6edb80fe7e91"), Description="Registrar", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
