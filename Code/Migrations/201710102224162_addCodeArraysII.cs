namespace Code.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCodeArraysII : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode5", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription5", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode6", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription6", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode7", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription7", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode8", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription8", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode9", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription9", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode10", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription10", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode11", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription11", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode12", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription12", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode13", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription13", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode14", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription14", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode15", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription15", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode16", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription16", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode17", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription17", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode18", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription18", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode19", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription19", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentCode20", c => c.String());
            AddColumn("dbo.DiagnosisCodes", "TreatmentDescription20", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription20");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode20");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription19");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode19");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription18");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode18");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription17");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode17");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription16");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode16");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription15");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode15");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription14");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode14");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription13");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode13");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription12");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode12");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription11");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode11");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription10");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode10");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription9");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode9");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription8");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode8");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription7");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode7");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription6");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode6");
            DropColumn("dbo.DiagnosisCodes", "TreatmentDescription5");
            DropColumn("dbo.DiagnosisCodes", "TreatmentCode5");
        }
    }
}
