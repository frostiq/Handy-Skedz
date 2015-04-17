namespace JackstimetableService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CitiesandCountrieschangedScheduledataadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("jackstimetable.Schedules", "Data", c => c.String());
            AlterColumn("jackstimetable.Cities", "Name", c => c.String(maxLength: 50));
            AlterColumn("jackstimetable.Countries", "Name", c => c.String(maxLength: 50));
            CreateIndex("jackstimetable.Cities", "Name", unique: true);
            CreateIndex("jackstimetable.Countries", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("jackstimetable.Countries", new[] { "Name" });
            DropIndex("jackstimetable.Cities", new[] { "Name" });
            AlterColumn("jackstimetable.Countries", "Name", c => c.String());
            AlterColumn("jackstimetable.Cities", "Name", c => c.String());
            DropColumn("jackstimetable.Schedules", "Data");
        }
    }
}
