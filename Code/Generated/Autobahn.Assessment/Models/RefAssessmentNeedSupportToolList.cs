//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedSupportToolList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedSupportTool Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedSupportToolModel"> List
         /// </summary>
        public static List<RefAssessmentNeedSupportToolModel> RefAssessmentNeedSupportToolList = new List<RefAssessmentNeedSupportToolModel>
        {
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("5ad55013-753a-4a40-95e7-33d04295af70"), Code="Dictionary", Description="Dictionary", Definition="Dictionary is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("0290d8c7-1940-4e75-ada0-702d5ebe5508"), Code="Calculator", Description="Calculator", Definition="Calculator is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("40152bdd-f559-4e9e-aaf3-58f58e3c8447"), Code="NoteTaking", Description="Note taking", Definition="Note taking is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("a88e193f-9eae-451d-bd9a-8de44842adab"), Code="PeerInteraction", Description="Peer interaction", Definition="Peer interaction is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("e4d73aa6-eae3-46f9-b0c6-95b17b073d56"), Code="Thesaurus", Description="Thesaurus", Definition="Thesaurus is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("16b7048f-7955-42dd-8b15-b63b1757ec4b"), Code="Abacus", Description="Abacus", Definition="Abacus is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("eb2cfba1-399a-42ff-b24d-eb01490355b3"), Code="SpellChecker", Description="Spell checker", Definition="Spell checker is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("f609e65a-1b93-4544-9f4e-3f47cedda0b3"), Code="Homophone", Description="Homophone checker", Definition="Homophone checker is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("0ce1aa83-73f7-41cd-8f27-9344e42e70e4"), Code="MindMapping", Description="Mind mapping software", Definition="Mind mapping software is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("5fa09b87-fda1-4635-8d47-572eb4a824bd"), Code="OutlineTool", Description="Outline tool", Definition="Outline tool is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentNeedSupportTool Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentNeedSupportToolViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("5ad55013-753a-4a40-95e7-33d04295af70"), Description="Dictionary", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("0290d8c7-1940-4e75-ada0-702d5ebe5508"), Description="Calculator", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("40152bdd-f559-4e9e-aaf3-58f58e3c8447"), Description="Note taking", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("a88e193f-9eae-451d-bd9a-8de44842adab"), Description="Peer interaction", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("e4d73aa6-eae3-46f9-b0c6-95b17b073d56"), Description="Thesaurus", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("16b7048f-7955-42dd-8b15-b63b1757ec4b"), Description="Abacus", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("eb2cfba1-399a-42ff-b24d-eb01490355b3"), Description="Spell checker", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("f609e65a-1b93-4544-9f4e-3f47cedda0b3"), Description="Homophone checker", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("0ce1aa83-73f7-41cd-8f27-9344e42e70e4"), Description="Mind mapping software", SortOrder=Convert.ToDecimal("9.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("5fa09b87-fda1-4635-8d47-572eb4a824bd"), Description="Outline tool", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
