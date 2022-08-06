//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefWageVerificationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefWageVerification Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefWageVerification"> List
         /// </summary>
        public static List<RefWageVerification> RefWageVerificationList = new List<RefWageVerification> =
        {
            new RefWageVerification { Id=Guid.Parse("be6989f6-d14f-4b08-90b3-b98b075d282b"), Code="The wage information has been verified.", Description="01", Definition="", SortOrder=0 },
            new RefWageVerification { Id=Guid.Parse("18dcc6e3-933c-42c6-b979-80071dd746f5"), Code="The wage information has NOT been verified.", Description="02", Definition="", SortOrder=0 },
            new RefWageVerification { Id=Guid.Parse("75ea5abe-0038-4507-a66b-eb3cb15eebce"), Code="Wage data not present.", Description="03", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefWageVerification Pick List
         /// </summary>
        public static List<RefWageVerification> RefWageVerificationPickList = new List<RefWageVerification> =
        {
            new RefWageVerification { Id=Guid.Parse("be6989f6-d14f-4b08-90b3-b98b075d282b"), Code="The wage information has been verified.", SortOrder=0 },
            new RefWageVerification { Id=Guid.Parse("18dcc6e3-933c-42c6-b979-80071dd746f5"), Code="The wage information has NOT been verified.", SortOrder=0 },
            new RefWageVerification { Id=Guid.Parse("75ea5abe-0038-4507-a66b-eb3cb15eebce"), Code="Wage data not present.", SortOrder=0 },
       };
   }
}
