namespace CarSalesDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateVehicleTypePopulation : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VehicleTypes (VehicleTypeName) VALUES ('Create Car')");
            Sql("INSERT INTO VehicleTypes (VehicleTypeName) VALUES ('Create Bike')");
            Sql("INSERT INTO VehicleTypes (VehicleTypeName) VALUES ('Create Boat')");
            Sql("INSERT INTO VehicleTypes (VehicleTypeName) VALUES ('Create Caravan')");
        }
        
        public override void Down()
        {
        }
    }
}
