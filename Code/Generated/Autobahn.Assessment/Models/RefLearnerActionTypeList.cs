//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefLearnerActionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefLearnerActionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearnerActionType"> List
         /// </summary>
        public static List<RefLearnerActionType> RefLearnerActionTypeList = new List<RefLearnerActionType> =
        {
            new RefLearnerActionType { Id=Guid.Parse("5cde99c0-96c0-4c32-9fc6-786191348412"), Code="Indicates the activity provider has determined that the session was abnormally terminated either by an actor or due to a system failure.", Description="abandoned", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("90484b0e-244a-4d6e-a9fe-3c18a0e83413"), Code="Indicates the actor replied to a question, where the object is generally an activity representing the question. The text of the answer will often be included in the response inside result.", Description="answered", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("e320cbc1-71c4-4636-be1a-d6903e4a77a8"), Code="Indicates an inquiry by an actor with the expectation of a response or answer to a question.", Description="asked", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("4a9ace0e-0e8e-4d62-a31a-ee596b9da84e"), Code="Indicates the actor made an effort to access the object. An attempt statement without additional activities could be considered incomplete in some cases.", Description="attempted", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("2374de3d-3b4a-4dad-9fea-a9a6ce9cf393"), Code="Indicates the actor was present at a virtual or physical event or activity.", Description="attended", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("dd9567d7-804a-4615-8ce6-6e8c8480b0ee"), Code="Indicates the actor provided digital or written annotations on or about an object.", Description="commented", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("c9d66b84-a7a6-4539-9097-0348e72d170a"), Code="Indicates the actor finished or concluded the activity normally.", Description="completed", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("dcdbfc0c-61ee-45a3-b878-2dbbc709e61a"), Code="Indicates the actor intentionally departed from the activity or object.", Description="exited", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("57b64db5-f934-4007-82a3-934be18b4c85"), Code="Indicates the actor only encountered the object, and is applicable in situations where a specific achievement or completion is not required.", Description="experienced", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("8209d6b1-5ec5-4175-8f71-82f870011263"), Code="Indicates the actor did not successfully pass an activity to a level of predetermined satisfaction.", Description="failed", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("d90f6881-4d28-49b0-b37c-351db5fa90c3"), Code="Indicates the actor introduced an object into a physical or virtual location.", Description="imported", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("464edab4-60b0-4cb3-8ae9-1100d3b7f87c"), Code="Indicates the activity provider has determined that the actor successfully started an activity.", Description="initialized", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("5f4338c4-3750-4df1-b56d-e9118b81ce05"), Code="Indicates the actor engaged with a physical or virtual object.", Description="interacted", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("e763b772-1354-4bea-bae9-697c2f3d385b"), Code="Indicates the actor attempted to start an activity.", Description="launched", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("9bcd9f04-ab3c-45b3-9837-36ef0288d649"), Code="Indicates the actor gained access to a system or service by identifying and authenticating with the credentials provided by the actor.", Description="logged-in", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("b1d3463b-6fc4-4c04-be00-773e1b0ab430"), Code="Indicates the actor either lost or discontinued access to a system or service.", Description="logged-out", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("9bdb62a9-f1db-4b26-b255-30a972ac2bc1"), Code="Indicates the highest level of comprehension or competence the actor performed in an activity.", Description="mastered", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("9e7e0ace-ee3e-4b14-9e32-9cd04fba4d09"), Code="Indicates the actor successfully passed an activity to a level of predetermined satisfaction.", Description="passed", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("06c203c0-8bb5-4d52-b2b0-ad38ba2f8b05"), Code="Indicates the selected choices, favored options or settings of an actor in relation to an object or activity.", Description="preferred", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("e76cdc46-9d40-45b3-b391-2a5c5874e48e"), Code="Indicates a value of how much of an actor has advanced or moved through an activity.", Description="progressed", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("cd72e092-fbf8-4cae-af89-d80cce8efa5c"), Code="Indicates the actor is officially enrolled or inducted in an activity.", Description="registered", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("f2c21a0e-b1a6-4ad4-8f8a-49afd9e2238d"), Code="Indicates an actor reacted or replied to an object.", Description="responded", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("caead006-a8b3-4e85-b233-b85a9f16f978"), Code="Indicates the application has determined that the actor continued or reopened a suspended attempt on an activity.", Description="resumed", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("8a4e37a7-ffe0-441b-9312-056577250eb2"), Code="Indicates that the authority or activity provider determined the actor has fulfilled the criteria of the object or activity.", Description="satisfied", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("a7588857-d8fb-4a43-bf7c-b0b3ab5194a4"), Code="Indicates a numerical value related to an actor's performance on an activity.", Description="scored", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("8e3c6c0a-a3cd-4f6e-99c8-663782c2b714"), Code="Indicates the actor's intent to openly provide access to an object of common interest to other actors or groups.", Description="shared", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("91afafeb-d0b9-4853-96b2-c729d593295f"), Code="Indicates the status of a temporarily halted activity when an actor's intent is returning to the or object activity at a later time.", Description="suspended", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("e5152bd9-f675-46fc-9188-e8304a4aaa66"), Code="Indicates that the actor successfully ended an activity.", Description="terminated", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("2fed5939-609d-426e-91e8-3f10a16b4cef"), Code="A special reserved verb used by a LRS or application to mark a statement as invalid. See the xAPI specification for details on Voided statements.", Description="voided", Definition="", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("1505a9ee-36a8-4845-93a6-2f0a19878ba8"), Code="Indicates that the learning activity requirements were met by means other than completing the activity. A waived statement is used to indicate that the activity may be skipped by the actor.", Description="waived", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLearnerActionType Pick List
         /// </summary>
        public static List<RefLearnerActionType> RefLearnerActionTypePickList = new List<RefLearnerActionType> =
        {
            new RefLearnerActionType { Id=Guid.Parse("5cde99c0-96c0-4c32-9fc6-786191348412"), Code="Indicates the activity provider has determined that the session was abnormally terminated either by an actor or due to a system failure.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("90484b0e-244a-4d6e-a9fe-3c18a0e83413"), Code="Indicates the actor replied to a question, where the object is generally an activity representing the question. The text of the answer will often be included in the response inside result.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("e320cbc1-71c4-4636-be1a-d6903e4a77a8"), Code="Indicates an inquiry by an actor with the expectation of a response or answer to a question.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("4a9ace0e-0e8e-4d62-a31a-ee596b9da84e"), Code="Indicates the actor made an effort to access the object. An attempt statement without additional activities could be considered incomplete in some cases.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("2374de3d-3b4a-4dad-9fea-a9a6ce9cf393"), Code="Indicates the actor was present at a virtual or physical event or activity.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("dd9567d7-804a-4615-8ce6-6e8c8480b0ee"), Code="Indicates the actor provided digital or written annotations on or about an object.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("c9d66b84-a7a6-4539-9097-0348e72d170a"), Code="Indicates the actor finished or concluded the activity normally.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("dcdbfc0c-61ee-45a3-b878-2dbbc709e61a"), Code="Indicates the actor intentionally departed from the activity or object.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("57b64db5-f934-4007-82a3-934be18b4c85"), Code="Indicates the actor only encountered the object, and is applicable in situations where a specific achievement or completion is not required.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("8209d6b1-5ec5-4175-8f71-82f870011263"), Code="Indicates the actor did not successfully pass an activity to a level of predetermined satisfaction.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("d90f6881-4d28-49b0-b37c-351db5fa90c3"), Code="Indicates the actor introduced an object into a physical or virtual location.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("464edab4-60b0-4cb3-8ae9-1100d3b7f87c"), Code="Indicates the activity provider has determined that the actor successfully started an activity.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("5f4338c4-3750-4df1-b56d-e9118b81ce05"), Code="Indicates the actor engaged with a physical or virtual object.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("e763b772-1354-4bea-bae9-697c2f3d385b"), Code="Indicates the actor attempted to start an activity.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("9bcd9f04-ab3c-45b3-9837-36ef0288d649"), Code="Indicates the actor gained access to a system or service by identifying and authenticating with the credentials provided by the actor.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("b1d3463b-6fc4-4c04-be00-773e1b0ab430"), Code="Indicates the actor either lost or discontinued access to a system or service.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("9bdb62a9-f1db-4b26-b255-30a972ac2bc1"), Code="Indicates the highest level of comprehension or competence the actor performed in an activity.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("9e7e0ace-ee3e-4b14-9e32-9cd04fba4d09"), Code="Indicates the actor successfully passed an activity to a level of predetermined satisfaction.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("06c203c0-8bb5-4d52-b2b0-ad38ba2f8b05"), Code="Indicates the selected choices, favored options or settings of an actor in relation to an object or activity.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("e76cdc46-9d40-45b3-b391-2a5c5874e48e"), Code="Indicates a value of how much of an actor has advanced or moved through an activity.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("cd72e092-fbf8-4cae-af89-d80cce8efa5c"), Code="Indicates the actor is officially enrolled or inducted in an activity.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("f2c21a0e-b1a6-4ad4-8f8a-49afd9e2238d"), Code="Indicates an actor reacted or replied to an object.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("caead006-a8b3-4e85-b233-b85a9f16f978"), Code="Indicates the application has determined that the actor continued or reopened a suspended attempt on an activity.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("8a4e37a7-ffe0-441b-9312-056577250eb2"), Code="Indicates that the authority or activity provider determined the actor has fulfilled the criteria of the object or activity.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("a7588857-d8fb-4a43-bf7c-b0b3ab5194a4"), Code="Indicates a numerical value related to an actor's performance on an activity.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("8e3c6c0a-a3cd-4f6e-99c8-663782c2b714"), Code="Indicates the actor's intent to openly provide access to an object of common interest to other actors or groups.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("91afafeb-d0b9-4853-96b2-c729d593295f"), Code="Indicates the status of a temporarily halted activity when an actor's intent is returning to the or object activity at a later time.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("e5152bd9-f675-46fc-9188-e8304a4aaa66"), Code="Indicates that the actor successfully ended an activity.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("2fed5939-609d-426e-91e8-3f10a16b4cef"), Code="A special reserved verb used by a LRS or application to mark a statement as invalid. See the xAPI specification for details on Voided statements.", SortOrder=0 },
            new RefLearnerActionType { Id=Guid.Parse("1505a9ee-36a8-4845-93a6-2f0a19878ba8"), Code="Indicates that the learning activity requirements were met by means other than completing the activity. A waived statement is used to indicate that the activity may be skipped by the actor.", SortOrder=0 },
       };
   }
}
