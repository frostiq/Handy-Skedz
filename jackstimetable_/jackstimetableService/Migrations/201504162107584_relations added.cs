namespace JackstimetableService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relationsadded : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "jackstimetable.Schedules", name: "StudyGroup_Id", newName: "StudyGroupId");
            RenameColumn(table: "jackstimetable.StudyGroups", name: "School_Id", newName: "SchoolId");
            RenameColumn(table: "jackstimetable.Schools", name: "City_Id", newName: "CityId");
            RenameColumn(table: "jackstimetable.Schools", name: "SchoolType_Id", newName: "SchoolTypeId");
            RenameColumn(table: "jackstimetable.Cities", name: "Country_Id", newName: "CountryId");
            RenameColumn(table: "jackstimetable.Users", name: "City_Id", newName: "CityId");
            RenameIndex(table: "jackstimetable.Cities", name: "IX_Country_Id", newName: "IX_CountryId");
            RenameIndex(table: "jackstimetable.Schedules", name: "IX_StudyGroup_Id", newName: "IX_StudyGroupId");
            RenameIndex(table: "jackstimetable.StudyGroups", name: "IX_School_Id", newName: "IX_SchoolId");
            RenameIndex(table: "jackstimetable.Schools", name: "IX_SchoolType_Id", newName: "IX_SchoolTypeId");
            RenameIndex(table: "jackstimetable.Schools", name: "IX_City_Id", newName: "IX_CityId");
            RenameIndex(table: "jackstimetable.Users", name: "IX_City_Id", newName: "IX_CityId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "jackstimetable.Users", name: "IX_CityId", newName: "IX_City_Id");
            RenameIndex(table: "jackstimetable.Schools", name: "IX_CityId", newName: "IX_City_Id");
            RenameIndex(table: "jackstimetable.Schools", name: "IX_SchoolTypeId", newName: "IX_SchoolType_Id");
            RenameIndex(table: "jackstimetable.StudyGroups", name: "IX_SchoolId", newName: "IX_School_Id");
            RenameIndex(table: "jackstimetable.Schedules", name: "IX_StudyGroupId", newName: "IX_StudyGroup_Id");
            RenameIndex(table: "jackstimetable.Cities", name: "IX_CountryId", newName: "IX_Country_Id");
            RenameColumn(table: "jackstimetable.Users", name: "CityId", newName: "City_Id");
            RenameColumn(table: "jackstimetable.Cities", name: "CountryId", newName: "Country_Id");
            RenameColumn(table: "jackstimetable.Schools", name: "SchoolTypeId", newName: "SchoolType_Id");
            RenameColumn(table: "jackstimetable.Schools", name: "CityId", newName: "City_Id");
            RenameColumn(table: "jackstimetable.StudyGroups", name: "SchoolId", newName: "School_Id");
            RenameColumn(table: "jackstimetable.Schedules", name: "StudyGroupId", newName: "StudyGroup_Id");
        }
    }
}
