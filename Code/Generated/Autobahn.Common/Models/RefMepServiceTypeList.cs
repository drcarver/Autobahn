//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMepServiceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMepServiceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepServiceType"> List
         /// </summary>
        public static List<RefMepServiceType> RefMepServiceTypeList = new List<RefMepServiceType> =
        {
            new RefMepServiceType { Id=Guid.Parse("61a6f99d-4cae-4f43-9c5c-df852bad48e2"), Code="Counseling Services provided as part of a Migrant Education Program.", Description="CounselingServices", Definition="", SortOrder=0 },
            new RefMepServiceType { Id=Guid.Parse("daa06554-d13b-447e-885a-532eb8e27382"), Code="High School Accrual provided as part of a Migrant Education Program.", Description="HighSchoolAccrual", Definition="", SortOrder=0 },
            new RefMepServiceType { Id=Guid.Parse("4926ecd5-c118-4d2a-8b8b-a9a5f1840abe"), Code="Instructional Services provided as part of a Migrant Education Program.", Description="InstructionalServices", Definition="", SortOrder=0 },
            new RefMepServiceType { Id=Guid.Parse("5a7009bc-be50-4559-9a6c-c000c136e241"), Code="Mathematics Instruction provided as part of a Migrant Education Program.", Description="MathematicsInstruction", Definition="", SortOrder=0 },
            new RefMepServiceType { Id=Guid.Parse("8dd3c965-0cfc-4250-b7a2-fedefc8645a4"), Code="Reading Instruction provided as part of a Migrant Education Program.", Description="ReadingInstruction", Definition="", SortOrder=0 },
            new RefMepServiceType { Id=Guid.Parse("c4848820-0aab-42f1-9c1f-be774caa77ee"), Code="Referral Services provided as part of a Migrant Education Program.", Description="ReferralServices", Definition="", SortOrder=0 },
            new RefMepServiceType { Id=Guid.Parse("ace3b3eb-99cf-4994-b40b-c7ffdfcb6e16"), Code="Support Services provided as part of a Migrant Education Program.", Description="SupportServices", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefMepServiceType Pick List
         /// </summary>
        public static List<RefMepServiceType> RefMepServiceTypePickList = new List<RefMepServiceType> =
        {
            new RefMepServiceType { Id=Guid.Parse("61a6f99d-4cae-4f43-9c5c-df852bad48e2"), Code="Counseling Services provided as part of a Migrant Education Program.", SortOrder=0 },
            new RefMepServiceType { Id=Guid.Parse("daa06554-d13b-447e-885a-532eb8e27382"), Code="High School Accrual provided as part of a Migrant Education Program.", SortOrder=0 },
            new RefMepServiceType { Id=Guid.Parse("4926ecd5-c118-4d2a-8b8b-a9a5f1840abe"), Code="Instructional Services provided as part of a Migrant Education Program.", SortOrder=0 },
            new RefMepServiceType { Id=Guid.Parse("5a7009bc-be50-4559-9a6c-c000c136e241"), Code="Mathematics Instruction provided as part of a Migrant Education Program.", SortOrder=0 },
            new RefMepServiceType { Id=Guid.Parse("8dd3c965-0cfc-4250-b7a2-fedefc8645a4"), Code="Reading Instruction provided as part of a Migrant Education Program.", SortOrder=0 },
            new RefMepServiceType { Id=Guid.Parse("c4848820-0aab-42f1-9c1f-be774caa77ee"), Code="Referral Services provided as part of a Migrant Education Program.", SortOrder=0 },
            new RefMepServiceType { Id=Guid.Parse("ace3b3eb-99cf-4994-b40b-c7ffdfcb6e16"), Code="Support Services provided as part of a Migrant Education Program.", SortOrder=0 },
       };
   }
}
