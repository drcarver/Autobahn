//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   RefAeInstructionalProgramTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The list of RefAeInstructionalProgramType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAeInstructionalProgramType"> List
         /// </summary>
        public static List<RefAeInstructionalProgramType> RefAeInstructionalProgramTypeList = new List<RefAeInstructionalProgramType>
        {
            new RefAeInstructionalProgramType { Id=Guid.Parse("98f03cbc-38be-48f2-bcbd-f526ebea7a1e"), Code="ABE", Description="Adult Basic Education", Definition="A program of academic instruction and education services below the secondary level that increases an individual's ability to read, write, and speak in English and perform mathematics necessary to attain a secondary school diploma or its recognized equivalent, transition to postsecondary education or training, and obtain employment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeInstructionalProgramType { Id=Guid.Parse("d390eb5e-496b-408d-876e-a9a4d0f4fe12"), Code="ASE", Description="Adult Secondary Education", Definition="A program of academic instruction and education services at the secondary level that increases an individual's ability to read, write, and perform mathematics necessary to attain a secondary school diploma or its recognized equivalent, transition to postsecondary education or training, and obtain employment.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeInstructionalProgramType { Id=Guid.Parse("10eedcb1-1ddf-4b29-a8ed-a634e606978c"), Code="ELA", Description="English as a Second Language/English Language Acquisition Program", Definition="A program of instruction designed to help eligible individuals who are English language learners (ELLs) achieve competence in reading, writing, speaking, and comprehension of the English language, and that leads to attainment of a secondary school diploma or its recognized equivalent and transition to postsecondary education and training or employment.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeInstructionalProgramType { Id=Guid.Parse("e452bfc6-57f5-4b89-917f-fae754537603"), Code="IEL", Description="Integrated English Literacy and Civics Education", Definition="A program of instruction funded under WIOA, Section 243, which includes education services provided to English language learners who are adults, including professionals with degrees and credentials in their native countries, that enables such adults to achieve competency in the English language and acquire the basic and more advanced skills needed to function effectively as parents, workers, and citizens in the United States. It includes instruction in literacy and English language acquisition and instruction on the rights and responsibilities of citizenship and civic participation and may include workforce training. In addition, the program must be provided in combination with Integrated Education and Training (IET).", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefAeInstructionalProgramType Pick List
         /// </summary>
        public static List<RefAeInstructionalProgramType> RefAeInstructionalProgramTypePickList = new List<RefAeInstructionalProgramType>
        {
            new RefAeInstructionalProgramType { Id=Guid.Parse("98f03cbc-38be-48f2-bcbd-f526ebea7a1e"), Code="ABE", Description="Adult Basic Education", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeInstructionalProgramType { Id=Guid.Parse("d390eb5e-496b-408d-876e-a9a4d0f4fe12"), Code="ASE", Description="Adult Secondary Education", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeInstructionalProgramType { Id=Guid.Parse("10eedcb1-1ddf-4b29-a8ed-a634e606978c"), Code="ELA", Description="English as a Second Language/English Language Acquisition Program", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeInstructionalProgramType { Id=Guid.Parse("e452bfc6-57f5-4b89-917f-fae754537603"), Code="IEL", Description="Integrated English Literacy and Civics Education", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
