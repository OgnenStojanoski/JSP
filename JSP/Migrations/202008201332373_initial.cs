namespace JSP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Capacity = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BusStops",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Bus_ID = c.Int(),
                        BusLine_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buses", t => t.Bus_ID)
                .ForeignKey("dbo.BusLines", t => t.BusLine_ID)
                .Index(t => t.Bus_ID)
                .Index(t => t.BusLine_ID);
            
            CreateTable(
                "dbo.BusLines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EndDestination_ID = c.Int(),
                        StartDestination_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BusStops", t => t.EndDestination_ID)
                .ForeignKey("dbo.BusStops", t => t.StartDestination_ID)
                .Index(t => t.EndDestination_ID)
                .Index(t => t.StartDestination_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "StartDestination_ID", "dbo.BusStops");
            DropForeignKey("dbo.Tickets", "EndDestination_ID", "dbo.BusStops");
            DropForeignKey("dbo.BusStops", "BusLine_ID", "dbo.BusLines");
            DropForeignKey("dbo.BusStops", "Bus_ID", "dbo.Buses");
            DropIndex("dbo.Tickets", new[] { "StartDestination_ID" });
            DropIndex("dbo.Tickets", new[] { "EndDestination_ID" });
            DropIndex("dbo.BusStops", new[] { "BusLine_ID" });
            DropIndex("dbo.BusStops", new[] { "Bus_ID" });
            DropTable("dbo.Tickets");
            DropTable("dbo.BusLines");
            DropTable("dbo.BusStops");
            DropTable("dbo.Buses");
        }
    }
}
