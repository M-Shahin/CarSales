namespace CarSalesDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteVehicleTypePopulation : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM VehicleTypes WHERE VehicleTypeName = 'Car'");
            Sql("DELETE FROM VehicleTypes WHERE VehicleTypeName = 'Bike'");
            Sql("DELETE FROM VehicleTypes WHERE VehicleTypeName = 'Boat'");
            Sql("DELETE FROM VehicleTypes WHERE VehicleTypeName = 'Caravan'");
        }
        
        public override void Down()
        {
        }
    }
}
