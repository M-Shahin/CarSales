namespace CarSalesDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehicleTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VehicleTypes (VehicleTypeName) VALUES ('Car')");
            Sql("INSERT INTO VehicleTypes (VehicleTypeName) VALUES ('Bike')");
            Sql("INSERT INTO VehicleTypes (VehicleTypeName) VALUES ('Boat')");
            Sql("INSERT INTO VehicleTypes (VehicleTypeName) VALUES ('Caravan')");
        }
        
        public override void Down()
        {
        }
    }
}
