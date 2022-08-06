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
        public static List<RefAeInstructionalProgramType> RefAeInstructionalProgramTypeList = new List<RefAeInstructionalProgramType> =
        {
            new RefAeInstructionalProgramType { Id=Guid.Parse("bc9d861d-6419-44bc-9654-d3dce4723210"), Code="A program of academic instruction and education services below the secondary level that increases an individual's ability to read, write, and speak in English and perform mathematics necessary to attain a secondary school diploma or its recognized equivalent, transition to postsecondary education or training, and obtain employment.", Description="ABE", Definition="", SortOrder=0 },
            new RefAeInstructionalProgramType { Id=Guid.Parse("da27e72b-1b50-4221-8f85-6cd8f0224c5f"), Code="A program of academic instruction and education services at the secondary level that increases an individual's ability to read, write, and perform mathematics necessary to attain a secondary school diploma or its recognized equivalent, transition to postsecondary education or training, and obtain employment.", Description="ASE", Definition="", SortOrder=0 },
            new RefAeInstructionalProgramType { Id=Guid.Parse("f0874105-d17a-4970-8055-50eba54590e9"), Code="A program of instruction designed to help eligible individuals who are English language learners (ELLs) achieve competence in reading, writing, speaking, and comprehension of the English language, and that leads to attainment of a secondary school diploma or its recognized equivalent and transition to postsecondary education and training or employment.", Description="ELA", Definition="", SortOrder=0 },
            new RefAeInstructionalProgramType { Id=Guid.Parse("3bd0b5d1-dfc1-4fb4-8ad6-fc560ef5ac18"), Code="A program of instruction funded under WIOA, Section 243, which includes education services provided to English language learners who are adults, including professionals with degrees and credentials in their native countries, that enables such adults to achieve competency in the English language and acquire the basic and more advanced skills needed to function effectively as parents, workers, and citizens in the United States. It includes instruction in literacy and English language acquisition and instruction on the rights and responsibilities of citizenship and civic participation and may include workforce training. In addition, the program must be provided in combination with Integrated Education and Training (IET).", Description="IEL", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAeInstructionalProgramType Pick List
         /// </summary>
        public static List<RefAeInstructionalProgramType> RefAeInstructionalProgramTypePickList = new List<RefAeInstructionalProgramType> =
        {
            new RefAeInstructionalProgramType { Id=Guid.Parse("bc9d861d-6419-44bc-9654-d3dce4723210"), Code="A program of academic instruction and education services below the secondary level that increases an individual's ability to read, write, and speak in English and perform mathematics necessary to attain a secondary school diploma or its recognized equivalent, transition to postsecondary education or training, and obtain employment.", SortOrder=0 },
            new RefAeInstructionalProgramType { Id=Guid.Parse("da27e72b-1b50-4221-8f85-6cd8f0224c5f"), Code="A program of academic instruction and education services at the secondary level that increases an individual's ability to read, write, and perform mathematics necessary to attain a secondary school diploma or its recognized equivalent, transition to postsecondary education or training, and obtain employment.", SortOrder=0 },
            new RefAeInstructionalProgramType { Id=Guid.Parse("f0874105-d17a-4970-8055-50eba54590e9"), Code="A program of instruction designed to help eligible individuals who are English language learners (ELLs) achieve competence in reading, writing, speaking, and comprehension of the English language, and that leads to attainment of a secondary school diploma or its recognized equivalent and transition to postsecondary education and training or employment.", SortOrder=0 },
            new RefAeInstructionalProgramType { Id=Guid.Parse("3bd0b5d1-dfc1-4fb4-8ad6-fc560ef5ac18"), Code="A program of instruction funded under WIOA, Section 243, which includes education services provided to English language learners who are adults, including professionals with degrees and credentials in their native countries, that enables such adults to achieve competency in the English language and acquire the basic and more advanced skills needed to function effectively as parents, workers, and citizens in the United States. It includes instruction in literacy and English language acquisition and instruction on the rights and responsibilities of citizenship and civic participation and may include workforce training. In addition, the program must be provided in combination with Integrated Education and Training (IET).", SortOrder=0 },
       };
   }
}
