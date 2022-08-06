//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMepEnrollmentTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMepEnrollmentType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepEnrollmentType"> List
         /// </summary>
        public static List<RefMepEnrollmentType> RefMepEnrollmentTypeList = new List<RefMepEnrollmentType> =
        {
            new RefMepEnrollmentType { Id=Guid.Parse("820d89c6-4ad3-40d3-bb94-317139069b43"), Code="Basic School Program is the type of school/migrant education project in which instruction and/or support services are provided.", Description="01", Definition="", SortOrder=0 },
            new RefMepEnrollmentType { Id=Guid.Parse("3f34ed42-6dec-45c4-8713-ef5759040f5c"), Code="Regular Term MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", Description="02", Definition="", SortOrder=0 },
            new RefMepEnrollmentType { Id=Guid.Parse("d0bbf9b7-2401-4777-b2a3-c83f94d1b8ea"), Code="Summer/Intersession MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", Description="03", Definition="", SortOrder=0 },
            new RefMepEnrollmentType { Id=Guid.Parse("a581a28e-b83e-4701-adf9-a9be270daf55"), Code="Year Round MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", Description="04", Definition="", SortOrder=0 },
            new RefMepEnrollmentType { Id=Guid.Parse("553c8aaf-2bf8-47ba-a190-4cf4c244dda1"), Code="Basic School Program and Regular-Term MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", Description="05", Definition="", SortOrder=0 },
            new RefMepEnrollmentType { Id=Guid.Parse("122a4531-6fc5-47d9-8dd5-fd2dd552d1fd"), Code="Residency Only (none of the above)", Description="06", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefMepEnrollmentType Pick List
         /// </summary>
        public static List<RefMepEnrollmentType> RefMepEnrollmentTypePickList = new List<RefMepEnrollmentType> =
        {
            new RefMepEnrollmentType { Id=Guid.Parse("820d89c6-4ad3-40d3-bb94-317139069b43"), Code="Basic School Program is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=0 },
            new RefMepEnrollmentType { Id=Guid.Parse("3f34ed42-6dec-45c4-8713-ef5759040f5c"), Code="Regular Term MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=0 },
            new RefMepEnrollmentType { Id=Guid.Parse("d0bbf9b7-2401-4777-b2a3-c83f94d1b8ea"), Code="Summer/Intersession MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=0 },
            new RefMepEnrollmentType { Id=Guid.Parse("a581a28e-b83e-4701-adf9-a9be270daf55"), Code="Year Round MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=0 },
            new RefMepEnrollmentType { Id=Guid.Parse("553c8aaf-2bf8-47ba-a190-4cf4c244dda1"), Code="Basic School Program and Regular-Term MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=0 },
            new RefMepEnrollmentType { Id=Guid.Parse("122a4531-6fc5-47d9-8dd5-fd2dd552d1fd"), Code="Residency Only (none of the above)", SortOrder=0 },
       };
   }
}
