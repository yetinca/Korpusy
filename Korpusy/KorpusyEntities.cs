

namespace Korpusy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public partial class KorpusyEntities :DbContext
    {
        public KorpusyEntities()
            : base("name=KorpusyEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<t1> t1 { get; set; }
        public DbSet<SOFRep> SofRep { get; set; }
        public DbSet<SpecialOperations> SpecialOperations { get; set; }

    }
}
