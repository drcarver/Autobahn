//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefExitOrWithdrawalTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefExitOrWithdrawalType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefExitOrWithdrawalType"> List
         /// </summary>
        public static List<RefExitOrWithdrawalType> RefExitOrWithdrawalTypeList = new List<RefExitOrWithdrawalType> =
        {
            new RefExitOrWithdrawalType { Id=Guid.Parse("5610ddb3-7c3c-474c-8c57-d4ba0bffc011"), Code="The student exited from membership in the educational institution and is in a different public school in the same local education agency.", Description="01907", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("b5c207da-cb2d-428a-a167-05daaf7f2c51"), Code="The student exited from membership in the educational institution and transferred to a public school in a different local education agency in the same state.", Description="01908", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("c0648dac-a592-4455-b269-4099ee445774"), Code="The student exited from membership in the educational institution and transferred to a public school in a different state.", Description="01909", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("3fdb3799-125c-4428-b819-9724e6b538d2"), Code="The student exited from membership in the educational institution and transferred to a private, non-religiously-affiliated school within the geographic boundaries as the same local education agency.", Description="01910", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("99163a3a-09b9-4dc4-b127-fc737c0475bf"), Code="The student exited from membership in the educational institution and transferred to a private, non-religiously-affiliated school within the geographic boundaries of a different LEA in the same state.", Description="01911", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("ee633c0c-6791-4180-af5f-53d892f5f05e"), Code="The student exited from membership in the educational institution and transferred to a private, non-religiously-affiliated school in a different state.", Description="01912", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("ac828a2f-40ac-4aaf-80b6-1ca4320086ed"), Code="The student exited from membership in the educational institution and transferred to a private, religiously-affiliated school within the geographic boundaries of the same local education agency.", Description="01913", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("bb068390-0af5-4510-bff0-f7f7211b135c"), Code="The student exited from membership in the educational institution and transferred to a private, religiously-affiliated school within the geographic boundaries of a different LEA in the same state.", Description="01914", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("b8bcd1f2-0b7f-4ea8-9a5d-4add56a1b764"), Code="The student exited from membership in the educational institution and transferred to a private, religiously-affiliated school in a different state.", Description="01915", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("e6726890-c1a3-4a6d-9e9a-0713d94b4a88"), Code="The student exited from membership in the educational institution and transferred to a school outside of the country.", Description="01916", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("85902cda-3d25-4583-8c69-64a64389e27f"), Code="The student exited from membership in the educational institution and transferred to an institution.", Description="01917", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("5da0cdda-77b7-4045-9f70-890c0895087f"), Code="The student exited from membership in the educational institution and transferred to home schooling.", Description="01918", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("a5efee3c-e614-4b0d-af85-6cdb98eded7a"), Code="The student exited from membership in the educational institution and transferred to a charter school in a different LEA in the same state.", Description="01919", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("546b7c84-c6f1-4d48-8b4d-7760d150ff39"), Code="The student exited from membership in the educational institution and graduated with regular, advanced, International Baccalaureate, or other type of diploma.", Description="01921", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("fa294b09-5571-46e5-9079-9d4cdaa8acbe"), Code="The student exited from membership in the educational institution and completed school with other credentials.", Description="01922", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("5fe4e6d2-7aa9-4e0f-9789-00f3965a6a5d"), Code="The student was withdrawn due to illness.", Description="01924", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("f1c019ef-e59a-4d2f-bef8-ce0cefdbca74"), Code="The student was expelled or involuntarily withdrawn.", Description="01925", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("9dbda322-e44f-48ec-a504-fc2d178b9396"), Code="The student reached maximum age for services.", Description="01926", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("a982308b-cd99-4db3-8278-0789a41e4fef"), Code="The student exited from membership in the educational institution and discontinued schooling.", Description="01927", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("618154aa-3d65-47fb-9386-8f2244bad891"), Code="The student exited from membership in the educational institution and completed grade 12, but did not meet all graduation requirements.", Description="01928", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("92211ed5-1f66-447c-af50-4582387a116a"), Code="The student exited from membership in the educational institution and enrolled in a postsecondary early admission program.", Description="01930", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("913322ee-270b-4ffe-a853-e6835205939a"), Code="The student exited from membership in the educational institution and the reason is presently unknown. It is expected this temporary option will be changed when the reason for exit has been determined.", Description="01931", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("d29932bd-0e72-47db-836a-f24497dfa278"), Code="The student exited from membership in the educational institution and the student is in the same LEA, receiving education services, but is not assigned to a particular school.", Description="03499", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("7e5b7d75-45cb-47eb-9ef7-c6c69cd533c4"), Code="The student exited from membership in the education institution for an extended period unrelated to any other existing exit code. It is expected the student will return to this school after the reason for the extended period has completed", Description="03502", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("293fb176-5ab4-4f7f-acf2-8e0afd06e55b"), Code="The student exited from membership in the educational institution and is enrolled in a foreign exchange program.", Description="03503", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("e57ffcad-97a0-4acd-819e-9ae11040d14f"), Code="The student was exited from membership in the educational institution for administrative or system requirements and will be reenrolled in the same educational institution with a new Enrollment Entry Date.", Description="03505", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("328a518f-7de9-4d2e-b115-7fb9cf695f2d"), Code="The student exited from membership in the educational institution and is in a charter school managed by the same local education agency.", Description="03508", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("b8b990b0-a2fd-48cb-8c58-20c58e379046"), Code="The student exited from membership in the educational institution and completed with a state-recognized equivalency certificate.", Description="03509", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("9f04b179-8caf-4343-9331-f6e4f29f3acc"), Code="The circumstances under which the student exited from membership in an educational institution is in a category not yet defined in CEDS.", Description="09999", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("d2c30bff-b39a-46e7-8bda-c3b7ccdbbace"), Code="The student officially withdrew and enrolled in an adult basic education, adult secondary education, or adult English as a Second Language program.", Description="73060", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("c4e8545c-7279-4f32-a131-78f91d3ca480"), Code="The student officially withdrew and enrolled in a workforce training program.", Description="73061", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("34e55992-e09c-4c93-b321-c8be7ccd9fa2"), Code="The student exited from membership in the educational institution due to death.", Description="73064", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("c895d88b-0662-493c-94ec-c81f6c06cf5e"), Code="The student exited from membership in the educational institution and is permanently incapacitated.", Description="73065", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("69e2dabf-6b2b-45d7-96e8-148ca7e0c74d"), Code="The student is expected to return to the same school at the beginning of the next school year.", Description="73062", Definition="", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("cebe9290-a264-4032-b00b-4f019442c7a8"), Code="The student exited from membership in the educational institution and transferred to a charter school in a different state.", Description="73063", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefExitOrWithdrawalType Pick List
         /// </summary>
        public static List<RefExitOrWithdrawalType> RefExitOrWithdrawalTypePickList = new List<RefExitOrWithdrawalType> =
        {
            new RefExitOrWithdrawalType { Id=Guid.Parse("5610ddb3-7c3c-474c-8c57-d4ba0bffc011"), Code="The student exited from membership in the educational institution and is in a different public school in the same local education agency.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("b5c207da-cb2d-428a-a167-05daaf7f2c51"), Code="The student exited from membership in the educational institution and transferred to a public school in a different local education agency in the same state.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("c0648dac-a592-4455-b269-4099ee445774"), Code="The student exited from membership in the educational institution and transferred to a public school in a different state.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("3fdb3799-125c-4428-b819-9724e6b538d2"), Code="The student exited from membership in the educational institution and transferred to a private, non-religiously-affiliated school within the geographic boundaries as the same local education agency.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("99163a3a-09b9-4dc4-b127-fc737c0475bf"), Code="The student exited from membership in the educational institution and transferred to a private, non-religiously-affiliated school within the geographic boundaries of a different LEA in the same state.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("ee633c0c-6791-4180-af5f-53d892f5f05e"), Code="The student exited from membership in the educational institution and transferred to a private, non-religiously-affiliated school in a different state.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("ac828a2f-40ac-4aaf-80b6-1ca4320086ed"), Code="The student exited from membership in the educational institution and transferred to a private, religiously-affiliated school within the geographic boundaries of the same local education agency.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("bb068390-0af5-4510-bff0-f7f7211b135c"), Code="The student exited from membership in the educational institution and transferred to a private, religiously-affiliated school within the geographic boundaries of a different LEA in the same state.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("b8bcd1f2-0b7f-4ea8-9a5d-4add56a1b764"), Code="The student exited from membership in the educational institution and transferred to a private, religiously-affiliated school in a different state.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("e6726890-c1a3-4a6d-9e9a-0713d94b4a88"), Code="The student exited from membership in the educational institution and transferred to a school outside of the country.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("85902cda-3d25-4583-8c69-64a64389e27f"), Code="The student exited from membership in the educational institution and transferred to an institution.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("5da0cdda-77b7-4045-9f70-890c0895087f"), Code="The student exited from membership in the educational institution and transferred to home schooling.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("a5efee3c-e614-4b0d-af85-6cdb98eded7a"), Code="The student exited from membership in the educational institution and transferred to a charter school in a different LEA in the same state.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("546b7c84-c6f1-4d48-8b4d-7760d150ff39"), Code="The student exited from membership in the educational institution and graduated with regular, advanced, International Baccalaureate, or other type of diploma.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("fa294b09-5571-46e5-9079-9d4cdaa8acbe"), Code="The student exited from membership in the educational institution and completed school with other credentials.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("5fe4e6d2-7aa9-4e0f-9789-00f3965a6a5d"), Code="The student was withdrawn due to illness.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("f1c019ef-e59a-4d2f-bef8-ce0cefdbca74"), Code="The student was expelled or involuntarily withdrawn.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("9dbda322-e44f-48ec-a504-fc2d178b9396"), Code="The student reached maximum age for services.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("a982308b-cd99-4db3-8278-0789a41e4fef"), Code="The student exited from membership in the educational institution and discontinued schooling.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("618154aa-3d65-47fb-9386-8f2244bad891"), Code="The student exited from membership in the educational institution and completed grade 12, but did not meet all graduation requirements.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("92211ed5-1f66-447c-af50-4582387a116a"), Code="The student exited from membership in the educational institution and enrolled in a postsecondary early admission program.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("913322ee-270b-4ffe-a853-e6835205939a"), Code="The student exited from membership in the educational institution and the reason is presently unknown. It is expected this temporary option will be changed when the reason for exit has been determined.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("d29932bd-0e72-47db-836a-f24497dfa278"), Code="The student exited from membership in the educational institution and the student is in the same LEA, receiving education services, but is not assigned to a particular school.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("7e5b7d75-45cb-47eb-9ef7-c6c69cd533c4"), Code="The student exited from membership in the education institution for an extended period unrelated to any other existing exit code. It is expected the student will return to this school after the reason for the extended period has completed", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("293fb176-5ab4-4f7f-acf2-8e0afd06e55b"), Code="The student exited from membership in the educational institution and is enrolled in a foreign exchange program.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("e57ffcad-97a0-4acd-819e-9ae11040d14f"), Code="The student was exited from membership in the educational institution for administrative or system requirements and will be reenrolled in the same educational institution with a new Enrollment Entry Date.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("328a518f-7de9-4d2e-b115-7fb9cf695f2d"), Code="The student exited from membership in the educational institution and is in a charter school managed by the same local education agency.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("b8b990b0-a2fd-48cb-8c58-20c58e379046"), Code="The student exited from membership in the educational institution and completed with a state-recognized equivalency certificate.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("9f04b179-8caf-4343-9331-f6e4f29f3acc"), Code="The circumstances under which the student exited from membership in an educational institution is in a category not yet defined in CEDS.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("d2c30bff-b39a-46e7-8bda-c3b7ccdbbace"), Code="The student officially withdrew and enrolled in an adult basic education, adult secondary education, or adult English as a Second Language program.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("c4e8545c-7279-4f32-a131-78f91d3ca480"), Code="The student officially withdrew and enrolled in a workforce training program.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("34e55992-e09c-4c93-b321-c8be7ccd9fa2"), Code="The student exited from membership in the educational institution due to death.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("c895d88b-0662-493c-94ec-c81f6c06cf5e"), Code="The student exited from membership in the educational institution and is permanently incapacitated.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("69e2dabf-6b2b-45d7-96e8-148ca7e0c74d"), Code="The student is expected to return to the same school at the beginning of the next school year.", SortOrder=0 },
            new RefExitOrWithdrawalType { Id=Guid.Parse("cebe9290-a264-4032-b00b-4f019442c7a8"), Code="The student exited from membership in the educational institution and transferred to a charter school in a different state.", SortOrder=0 },
       };
   }
}
