//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefInstructionLocationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefInstructionLocationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInstructionLocationType"> List
         /// </summary>
        public static List<RefInstructionLocationType> RefInstructionLocationTypeList = new List<RefInstructionLocationType>
        {
            new RefInstructionLocationType { Id=Guid.Parse("d611d645-f938-451c-a077-856b0564680a"), Code="00997", Description="Business", Definition="Business is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionLocationType { Id=Guid.Parse("14969471-3510-4d93-a651-9b58ce46223a"), Code="00752", Description="Community facility", Definition="Community facility is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionLocationType { Id=Guid.Parse("09e688e7-de61-4279-932b-3fbdb3b6d7db"), Code="00753", Description="Home of student", Definition="Home of student is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstructionLocationType { Id=Guid.Parse("2dad9e4c-52a6-46dc-8c09-138cf8cba14a"), Code="00754", Description="Hospital", Definition="Hospital is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("4.00") },
            new RefInstructionLocationType { Id=Guid.Parse("f84a149e-59b7-446b-a2dd-3187841fe410"), Code="03018", Description="Library/media center", Definition="Library/media center is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("5.00") },
            new RefInstructionLocationType { Id=Guid.Parse("506a3007-69df-4001-b49a-f9fcc69bed32"), Code="03506", Description="Mobile", Definition="Mobile is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("6.00") },
            new RefInstructionLocationType { Id=Guid.Parse("2f6659f7-86ef-46fb-aceb-84f9a669c99d"), Code="09999", Description="Other", Definition="The type of location at which instruction or service takes place is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("7.00") },
            new RefInstructionLocationType { Id=Guid.Parse("7a5bdc05-31e2-470f-b879-074e75f51885"), Code="00341", Description="Other K-12 educational institution", Definition="Other K-12 educational institution is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("8.00") },
            new RefInstructionLocationType { Id=Guid.Parse("a64e4511-de7f-41ca-a371-54a087b83a9a"), Code="00342", Description="Postsecondary facility", Definition="Postsecondary facility is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("9.00") },
            new RefInstructionLocationType { Id=Guid.Parse("3e7b6874-981a-4ed3-b62e-56eac7856405"), Code="00675", Description="School", Definition="School is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefInstructionLocationType Pick List
         /// </summary>
        public static List<RefInstructionLocationType> RefInstructionLocationTypePickList = new List<RefInstructionLocationType>
        {
            new RefInstructionLocationType { Id=Guid.Parse("d611d645-f938-451c-a077-856b0564680a"), Code="00997", Description="Business", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionLocationType { Id=Guid.Parse("14969471-3510-4d93-a651-9b58ce46223a"), Code="00752", Description="Community facility", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionLocationType { Id=Guid.Parse("09e688e7-de61-4279-932b-3fbdb3b6d7db"), Code="00753", Description="Home of student", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstructionLocationType { Id=Guid.Parse("2dad9e4c-52a6-46dc-8c09-138cf8cba14a"), Code="00754", Description="Hospital", SortOrder=Convert.ToDecimal("4.00") },
            new RefInstructionLocationType { Id=Guid.Parse("f84a149e-59b7-446b-a2dd-3187841fe410"), Code="03018", Description="Library/media center", SortOrder=Convert.ToDecimal("5.00") },
            new RefInstructionLocationType { Id=Guid.Parse("506a3007-69df-4001-b49a-f9fcc69bed32"), Code="03506", Description="Mobile", SortOrder=Convert.ToDecimal("6.00") },
            new RefInstructionLocationType { Id=Guid.Parse("2f6659f7-86ef-46fb-aceb-84f9a669c99d"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("7.00") },
            new RefInstructionLocationType { Id=Guid.Parse("7a5bdc05-31e2-470f-b879-074e75f51885"), Code="00341", Description="Other K-12 educational institution", SortOrder=Convert.ToDecimal("8.00") },
            new RefInstructionLocationType { Id=Guid.Parse("a64e4511-de7f-41ca-a371-54a087b83a9a"), Code="00342", Description="Postsecondary facility", SortOrder=Convert.ToDecimal("9.00") },
            new RefInstructionLocationType { Id=Guid.Parse("3e7b6874-981a-4ed3-b62e-56eac7856405"), Code="00675", Description="School", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
