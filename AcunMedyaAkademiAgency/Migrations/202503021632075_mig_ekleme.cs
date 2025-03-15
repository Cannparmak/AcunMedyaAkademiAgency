namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_ekleme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaID = c.Int(nullable: false, identity: true),
                        Icon = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.SocialMediaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialMedias");
        }
    }
}
