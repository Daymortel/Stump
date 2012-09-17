using System.Data.Entity.ModelConfiguration;
using Castle.ActiveRecord;
using Stump.Server.BaseServer.Database.Interfaces;

namespace Stump.Server.AuthServer.Database
{
    public class LangTextUIConfiguration : EntityTypeConfiguration<LangTextUI>
    {
        public LangTextUIConfiguration()
        {
            ToTable("langs_ui");
        }
    }

    public partial class LangTextUI
    {
        // Primitive properties

        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string French
        {
            get;
            set;
        }
        public string English
        {
            get;
            set;
        }
        public string German
        {
            get;
            set;
        }
        public string Spanish
        {
            get;
            set;
        }
        public string Italian
        {
            get;
            set;
        }
        public string Japanish
        {
            get;
            set;
        }
        public string Dutsh
        {
            get;
            set;
        }
        public string Portugese
        {
            get;
            set;
        }
        public string Russish
        {
            get;
            set;
        }
    }
}