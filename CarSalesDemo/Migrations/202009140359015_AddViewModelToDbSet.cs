namespace CarSalesDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddViewModelToDbSet : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cars", newName: "Vehicles");
            AddColumn("dbo.Vehicles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Vehicles", "NumberOfDoors", c => c.Byte());
            AlterColumn("dbo.Vehicles", "NumberOfWheels", c => c.Byte());
            AlterColumn("dbo.Vehicles", "BodyTypeId", c => c.Byte());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "BodyTypeId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Vehicles", "NumberOfWheels", c => c.Byte(nullable: false));
            AlterColumn("dbo.Vehicles", "NumberOfDoors", c => c.Byte(nullable: false));
            DropColumn("dbo.Vehicles", "Discriminator");
            RenameTable(name: "dbo.Vehicles", newName: "Cars");
        }
    }
}
