namespace CarSalesDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeVehicleTypeToListTypefromIEnumarable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VehicleTypes", "VehicleType_Id", c => c.Int());
            CreateIndex("dbo.VehicleTypes", "VehicleType_Id");
            AddForeignKey("dbo.VehicleTypes", "VehicleType_Id", "dbo.VehicleTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VehicleTypes", "VehicleType_Id", "dbo.VehicleTypes");
            DropIndex("dbo.VehicleTypes", new[] { "VehicleType_Id" });
            DropColumn("dbo.VehicleTypes", "VehicleType_Id");
        }
    }
}
