namespace JackstimetableService.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class DbContextchanged : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("jackstimetable.StudyGroupDtoUserDtoes");
            RenameTable(name: "jackstimetable.StudyGroupDtoUserDtoes", newName: "UserDtoStudyGroupDtoes");
            CreateTable(
                "jackstimetable.Schedules",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Id")
                                },
                            }),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Version")
                                },
                            }),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "CreatedAt")
                                },
                            }),
                        UpdatedAt = c.DateTimeOffset(precision: 7,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "UpdatedAt")
                                },
                            }),
                        Deleted = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ServiceTableColumn",
                                    new AnnotationValues(oldValue: null, newValue: "Deleted")
                                },
                            }),
                        StudyGroup_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id, null, false)
                .ForeignKey("jackstimetable.StudyGroups", t => t.StudyGroup_Id)
                .Index(t => t.CreatedAt, clustered: true)
                .Index(t => t.StudyGroup_Id);
            
            AddPrimaryKey("jackstimetable.UserDtoStudyGroupDtoes", new[] { "UserDto_Id", "StudyGroupDto_Id" });
        }
        
        public override void Down()
        {
            DropForeignKey("jackstimetable.Schedules", "StudyGroup_Id", "jackstimetable.StudyGroups");
            DropIndex("jackstimetable.Schedules", new[] { "StudyGroup_Id" });
            DropIndex("jackstimetable.Schedules", new[] { "CreatedAt" });
            DropPrimaryKey("jackstimetable.UserDtoStudyGroupDtoes");
            DropTable("jackstimetable.Schedules",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "CreatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "CreatedAt" },
                        }
                    },
                    {
                        "Deleted",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Deleted" },
                        }
                    },
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Id" },
                        }
                    },
                    {
                        "UpdatedAt",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "UpdatedAt" },
                        }
                    },
                    {
                        "Version",
                        new Dictionary<string, object>
                        {
                            { "ServiceTableColumn", "Version" },
                        }
                    },
                });
            AddPrimaryKey("jackstimetable.UserDtoStudyGroupDtoes", new[] { "StudyGroupDto_Id", "UserDto_Id" });
            RenameTable(name: "jackstimetable.UserDtoStudyGroupDtoes", newName: "StudyGroupDtoUserDtoes");
        }
    }
}
