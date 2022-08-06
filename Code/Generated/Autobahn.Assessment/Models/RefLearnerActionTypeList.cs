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
        public static List<RefLearnerActionType> RefLearnerActionTypeList = new List<RefLearnerActionType>
        {
            new RefLearnerActionType { Id=Guid.Parse("55c5fd30-156c-45e5-abd1-1d99acf97f0b"), Code="abandoned", Description="Abandoned", Definition="Indicates the activity provider has determined that the session was abnormally terminated either by an actor or due to a system failure.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearnerActionType { Id=Guid.Parse("d06e3833-20db-4392-a077-b9d8a36eccbd"), Code="answered", Description="Answered", Definition="Indicates the actor replied to a question, where the object is generally an activity representing the question. The text of the answer will often be included in the response inside result.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearnerActionType { Id=Guid.Parse("938306a0-c39f-4375-8e53-2246f51cb8e5"), Code="asked", Description="Asked", Definition="Indicates an inquiry by an actor with the expectation of a response or answer to a question.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearnerActionType { Id=Guid.Parse("832208f1-bce3-43e0-b0b7-2b27d89d84fc"), Code="attempted", Description="Attempted", Definition="Indicates the actor made an effort to access the object. An attempt statement without additional activities could be considered incomplete in some cases.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearnerActionType { Id=Guid.Parse("1417a1f0-1d16-48ff-a97d-7855a2a5845d"), Code="attended", Description="Attended", Definition="Indicates the actor was present at a virtual or physical event or activity.", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearnerActionType { Id=Guid.Parse("2a643efa-f446-4ec3-bf10-dc74222706cc"), Code="commented", Description="Commented", Definition="Indicates the actor provided digital or written annotations on or about an object.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearnerActionType { Id=Guid.Parse("ae97d9f8-2120-4a25-b731-cb9e81c970a4"), Code="completed", Description="Completed", Definition="Indicates the actor finished or concluded the activity normally.", SortOrder=Convert.ToDecimal("7.00") },
            new RefLearnerActionType { Id=Guid.Parse("3a6bb69f-42c5-4776-92c5-1c7da2ce5669"), Code="exited", Description="Exited", Definition="Indicates the actor intentionally departed from the activity or object.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearnerActionType { Id=Guid.Parse("e1fa705a-42cd-40d3-9d72-221ea62bb1bb"), Code="experienced", Description="Experienced", Definition="Indicates the actor only encountered the object, and is applicable in situations where a specific achievement or completion is not required.", SortOrder=Convert.ToDecimal("9.00") },
            new RefLearnerActionType { Id=Guid.Parse("c4716585-85c8-4d2d-98e2-855bacfead6a"), Code="failed", Description="Failed", Definition="Indicates the actor did not successfully pass an activity to a level of predetermined satisfaction.", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearnerActionType { Id=Guid.Parse("84d6390e-e686-495c-8b50-3afed459073e"), Code="imported", Description="Imported", Definition="Indicates the actor introduced an object into a physical or virtual location.", SortOrder=Convert.ToDecimal("11.00") },
            new RefLearnerActionType { Id=Guid.Parse("39bc1dc2-d10f-4ede-b928-15124632b490"), Code="initialized", Description="Initialized", Definition="Indicates the activity provider has determined that the actor successfully started an activity.", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearnerActionType { Id=Guid.Parse("d3794cb3-097a-4fa2-816f-848e4b8dca72"), Code="interacted", Description="Interacted", Definition="Indicates the actor engaged with a physical or virtual object.", SortOrder=Convert.ToDecimal("13.00") },
            new RefLearnerActionType { Id=Guid.Parse("f2be648d-ffbb-487d-89e4-dde936376d39"), Code="launched", Description="Launched", Definition="Indicates the actor attempted to start an activity.", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearnerActionType { Id=Guid.Parse("72647476-fb35-46b5-a9e4-1195251aee31"), Code="logged-in", Description="Logged-In", Definition="Indicates the actor gained access to a system or service by identifying and authenticating with the credentials provided by the actor.", SortOrder=Convert.ToDecimal("15.00") },
            new RefLearnerActionType { Id=Guid.Parse("30a275bf-c45f-4926-be6d-470eed1d0758"), Code="logged-out", Description="Logged-Out", Definition="Indicates the actor either lost or discontinued access to a system or service.", SortOrder=Convert.ToDecimal("16.00") },
            new RefLearnerActionType { Id=Guid.Parse("e7621ad2-71b6-4cb7-8de7-444fca2a62b6"), Code="mastered", Description="Mastered", Definition="Indicates the highest level of comprehension or competence the actor performed in an activity.", SortOrder=Convert.ToDecimal("17.00") },
            new RefLearnerActionType { Id=Guid.Parse("2a2aa2c4-85d2-48bd-a43c-43231c033de1"), Code="passed", Description="Passed", Definition="Indicates the actor successfully passed an activity to a level of predetermined satisfaction.", SortOrder=Convert.ToDecimal("18.00") },
            new RefLearnerActionType { Id=Guid.Parse("a9e04f31-4564-4cf8-8540-5660fc9beb61"), Code="preferred", Description="Preferred", Definition="Indicates the selected choices, favored options or settings of an actor in relation to an object or activity.", SortOrder=Convert.ToDecimal("19.00") },
            new RefLearnerActionType { Id=Guid.Parse("6c4bfc6f-85d6-4132-9d99-cbee6bca751a"), Code="progressed", Description="Progressed", Definition="Indicates a value of how much of an actor has advanced or moved through an activity.", SortOrder=Convert.ToDecimal("20.00") },
            new RefLearnerActionType { Id=Guid.Parse("e7d84bca-9f33-4260-872a-07075d9710b7"), Code="registered", Description="Registered", Definition="Indicates the actor is officially enrolled or inducted in an activity.", SortOrder=Convert.ToDecimal("21.00") },
            new RefLearnerActionType { Id=Guid.Parse("1c44a050-7c54-4930-92fe-a4bdc443c11e"), Code="responded", Description="Responded", Definition="Indicates an actor reacted or replied to an object.", SortOrder=Convert.ToDecimal("22.00") },
            new RefLearnerActionType { Id=Guid.Parse("d5d82f7d-527d-4049-8a1c-0e51e9a5d03f"), Code="resumed", Description="Resumed", Definition="Indicates the application has determined that the actor continued or reopened a suspended attempt on an activity.", SortOrder=Convert.ToDecimal("23.00") },
            new RefLearnerActionType { Id=Guid.Parse("b5d7952c-813d-4d11-9781-1ddb03857cf7"), Code="satisfied", Description="Satisfied", Definition="Indicates that the authority or activity provider determined the actor has fulfilled the criteria of the object or activity.", SortOrder=Convert.ToDecimal("24.00") },
            new RefLearnerActionType { Id=Guid.Parse("d20b8b9c-417c-463d-b042-f4c2377b4828"), Code="scored", Description="Scored", Definition="Indicates a numerical value related to an actor's performance on an activity.", SortOrder=Convert.ToDecimal("25.00") },
            new RefLearnerActionType { Id=Guid.Parse("6d8445cb-49af-41fd-a7d9-52c25cdb5578"), Code="shared", Description="Shared", Definition="Indicates the actor's intent to openly provide access to an object of common interest to other actors or groups.", SortOrder=Convert.ToDecimal("26.00") },
            new RefLearnerActionType { Id=Guid.Parse("d362fd66-7477-4214-b08d-72cce7088dd2"), Code="suspended", Description="Suspended", Definition="Indicates the status of a temporarily halted activity when an actor's intent is returning to the or object activity at a later time.", SortOrder=Convert.ToDecimal("27.00") },
            new RefLearnerActionType { Id=Guid.Parse("d0ad09ad-b2dd-4751-8ce1-9e89309be5c0"), Code="terminated", Description="Terminated", Definition="Indicates that the actor successfully ended an activity.", SortOrder=Convert.ToDecimal("28.00") },
            new RefLearnerActionType { Id=Guid.Parse("90c4f030-a81b-4bd6-ac8b-5feaf6cdd9d5"), Code="voided", Description="Voided", Definition="A special reserved verb used by a LRS or application to mark a statement as invalid. See the xAPI specification for details on Voided statements.", SortOrder=Convert.ToDecimal("29.00") },
            new RefLearnerActionType { Id=Guid.Parse("fd47c52b-5d6b-4528-b6e3-65c304a01411"), Code="waived", Description="Waived", Definition="Indicates that the learning activity requirements were met by means other than completing the activity. A waived statement is used to indicate that the activity may be skipped by the actor.", SortOrder=Convert.ToDecimal("30.00") },
        };

        /// <summary>
        /// The RefLearnerActionType Pick List
         /// </summary>
        public static List<RefLearnerActionType> RefLearnerActionTypePickList = new List<RefLearnerActionType>
        {
            new RefLearnerActionType { Id=Guid.Parse("55c5fd30-156c-45e5-abd1-1d99acf97f0b"), Code="abandoned", Description="Abandoned", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearnerActionType { Id=Guid.Parse("d06e3833-20db-4392-a077-b9d8a36eccbd"), Code="answered", Description="Answered", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearnerActionType { Id=Guid.Parse("938306a0-c39f-4375-8e53-2246f51cb8e5"), Code="asked", Description="Asked", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearnerActionType { Id=Guid.Parse("832208f1-bce3-43e0-b0b7-2b27d89d84fc"), Code="attempted", Description="Attempted", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearnerActionType { Id=Guid.Parse("1417a1f0-1d16-48ff-a97d-7855a2a5845d"), Code="attended", Description="Attended", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearnerActionType { Id=Guid.Parse("2a643efa-f446-4ec3-bf10-dc74222706cc"), Code="commented", Description="Commented", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearnerActionType { Id=Guid.Parse("ae97d9f8-2120-4a25-b731-cb9e81c970a4"), Code="completed", Description="Completed", SortOrder=Convert.ToDecimal("7.00") },
            new RefLearnerActionType { Id=Guid.Parse("3a6bb69f-42c5-4776-92c5-1c7da2ce5669"), Code="exited", Description="Exited", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearnerActionType { Id=Guid.Parse("e1fa705a-42cd-40d3-9d72-221ea62bb1bb"), Code="experienced", Description="Experienced", SortOrder=Convert.ToDecimal("9.00") },
            new RefLearnerActionType { Id=Guid.Parse("c4716585-85c8-4d2d-98e2-855bacfead6a"), Code="failed", Description="Failed", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearnerActionType { Id=Guid.Parse("84d6390e-e686-495c-8b50-3afed459073e"), Code="imported", Description="Imported", SortOrder=Convert.ToDecimal("11.00") },
            new RefLearnerActionType { Id=Guid.Parse("39bc1dc2-d10f-4ede-b928-15124632b490"), Code="initialized", Description="Initialized", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearnerActionType { Id=Guid.Parse("d3794cb3-097a-4fa2-816f-848e4b8dca72"), Code="interacted", Description="Interacted", SortOrder=Convert.ToDecimal("13.00") },
            new RefLearnerActionType { Id=Guid.Parse("f2be648d-ffbb-487d-89e4-dde936376d39"), Code="launched", Description="Launched", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearnerActionType { Id=Guid.Parse("72647476-fb35-46b5-a9e4-1195251aee31"), Code="logged-in", Description="Logged-In", SortOrder=Convert.ToDecimal("15.00") },
            new RefLearnerActionType { Id=Guid.Parse("30a275bf-c45f-4926-be6d-470eed1d0758"), Code="logged-out", Description="Logged-Out", SortOrder=Convert.ToDecimal("16.00") },
            new RefLearnerActionType { Id=Guid.Parse("e7621ad2-71b6-4cb7-8de7-444fca2a62b6"), Code="mastered", Description="Mastered", SortOrder=Convert.ToDecimal("17.00") },
            new RefLearnerActionType { Id=Guid.Parse("2a2aa2c4-85d2-48bd-a43c-43231c033de1"), Code="passed", Description="Passed", SortOrder=Convert.ToDecimal("18.00") },
            new RefLearnerActionType { Id=Guid.Parse("a9e04f31-4564-4cf8-8540-5660fc9beb61"), Code="preferred", Description="Preferred", SortOrder=Convert.ToDecimal("19.00") },
            new RefLearnerActionType { Id=Guid.Parse("6c4bfc6f-85d6-4132-9d99-cbee6bca751a"), Code="progressed", Description="Progressed", SortOrder=Convert.ToDecimal("20.00") },
            new RefLearnerActionType { Id=Guid.Parse("e7d84bca-9f33-4260-872a-07075d9710b7"), Code="registered", Description="Registered", SortOrder=Convert.ToDecimal("21.00") },
            new RefLearnerActionType { Id=Guid.Parse("1c44a050-7c54-4930-92fe-a4bdc443c11e"), Code="responded", Description="Responded", SortOrder=Convert.ToDecimal("22.00") },
            new RefLearnerActionType { Id=Guid.Parse("d5d82f7d-527d-4049-8a1c-0e51e9a5d03f"), Code="resumed", Description="Resumed", SortOrder=Convert.ToDecimal("23.00") },
            new RefLearnerActionType { Id=Guid.Parse("b5d7952c-813d-4d11-9781-1ddb03857cf7"), Code="satisfied", Description="Satisfied", SortOrder=Convert.ToDecimal("24.00") },
            new RefLearnerActionType { Id=Guid.Parse("d20b8b9c-417c-463d-b042-f4c2377b4828"), Code="scored", Description="Scored", SortOrder=Convert.ToDecimal("25.00") },
            new RefLearnerActionType { Id=Guid.Parse("6d8445cb-49af-41fd-a7d9-52c25cdb5578"), Code="shared", Description="Shared", SortOrder=Convert.ToDecimal("26.00") },
            new RefLearnerActionType { Id=Guid.Parse("d362fd66-7477-4214-b08d-72cce7088dd2"), Code="suspended", Description="Suspended", SortOrder=Convert.ToDecimal("27.00") },
            new RefLearnerActionType { Id=Guid.Parse("d0ad09ad-b2dd-4751-8ce1-9e89309be5c0"), Code="terminated", Description="Terminated", SortOrder=Convert.ToDecimal("28.00") },
            new RefLearnerActionType { Id=Guid.Parse("90c4f030-a81b-4bd6-ac8b-5feaf6cdd9d5"), Code="voided", Description="Voided", SortOrder=Convert.ToDecimal("29.00") },
            new RefLearnerActionType { Id=Guid.Parse("fd47c52b-5d6b-4528-b6e3-65c304a01411"), Code="waived", Description="Waived", SortOrder=Convert.ToDecimal("30.00") },
       };
   }
}
