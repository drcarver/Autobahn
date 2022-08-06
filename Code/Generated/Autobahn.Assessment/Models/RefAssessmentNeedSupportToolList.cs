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
        /// The complete <see cref="RefAssessmentNeedSupportTool"> List
         /// </summary>
        public static List<RefAssessmentNeedSupportTool> RefAssessmentNeedSupportToolList = new List<RefAssessmentNeedSupportTool>
        {
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("9119d5d8-1a62-4eb5-8498-231f43f019ab"), Code="Dictionary", Description="Dictionary", Definition="Dictionary is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("4807c23f-412e-49ca-a895-230f31e0adae"), Code="Calculator", Description="Calculator", Definition="Calculator is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("198f7853-c22d-4b8e-886f-ac1c12bdd9a9"), Code="NoteTaking", Description="Note taking", Definition="Note taking is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("38791bf1-c1db-4100-a585-9143cc917446"), Code="PeerInteraction", Description="Peer interaction", Definition="Peer interaction is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("a378aeee-0995-4a24-87dc-6809d81463e6"), Code="Thesaurus", Description="Thesaurus", Definition="Thesaurus is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("34855a3f-780f-43ba-b195-254a9d3a9b7b"), Code="Abacus", Description="Abacus", Definition="Abacus is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("f1ac00fd-7cda-4a40-9332-9a1aa7305446"), Code="SpellChecker", Description="Spell checker", Definition="Spell checker is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("b78e66d0-6bf5-49a1-8132-36998cf39bc2"), Code="Homophone", Description="Homophone checker", Definition="Homophone checker is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("4f3bc62c-5ee7-4e77-a6ef-37cdb0a9dbc3"), Code="MindMapping", Description="Mind mapping software", Definition="Mind mapping software is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("4adff626-2699-4ba7-a0ac-c785123ac454"), Code="OutlineTool", Description="Outline tool", Definition="Outline tool is specified as an assessment resource as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefAssessmentNeedSupportTool Pick List
         /// </summary>
        public static List<RefAssessmentNeedSupportTool> RefAssessmentNeedSupportToolPickList = new List<RefAssessmentNeedSupportTool>
        {
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("9119d5d8-1a62-4eb5-8498-231f43f019ab"), Code="Dictionary", Description="Dictionary", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("4807c23f-412e-49ca-a895-230f31e0adae"), Code="Calculator", Description="Calculator", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("198f7853-c22d-4b8e-886f-ac1c12bdd9a9"), Code="NoteTaking", Description="Note taking", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("38791bf1-c1db-4100-a585-9143cc917446"), Code="PeerInteraction", Description="Peer interaction", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("a378aeee-0995-4a24-87dc-6809d81463e6"), Code="Thesaurus", Description="Thesaurus", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("34855a3f-780f-43ba-b195-254a9d3a9b7b"), Code="Abacus", Description="Abacus", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("f1ac00fd-7cda-4a40-9332-9a1aa7305446"), Code="SpellChecker", Description="Spell checker", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("b78e66d0-6bf5-49a1-8132-36998cf39bc2"), Code="Homophone", Description="Homophone checker", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("4f3bc62c-5ee7-4e77-a6ef-37cdb0a9dbc3"), Code="MindMapping", Description="Mind mapping software", SortOrder=Convert.ToDecimal("9.00") },
            new RefAssessmentNeedSupportTool { Id=Guid.Parse("4adff626-2699-4ba7-a0ac-c785123ac454"), Code="OutlineTool", Description="Outline tool", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
