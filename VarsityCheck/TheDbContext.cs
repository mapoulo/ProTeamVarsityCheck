namespace VarsityCheck
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using VarsityCheck.Models;

    public partial class TheDbContext : DbContext
    {
        public TheDbContext()
            : base("name=TheDbContext")
        {
        }

        public DbSet<Faculty> faculties { get; set; }
        public DbSet<University> universities { get; set; }
        public DbSet<UniversityFaculty> universityFaculties { get; set; }
        public DbSet<School> schools { get; set; }
        public DbSet<Diploma> diplomas { get; set; }
        public DbSet<Degree> degrees { get; set; }
        public DbSet<Field> fields { get; set; }
        public DbSet<FinancialAid> financialAids { get; set; }
        public DbSet<FinancialAidField> FinancialAidFields { get; set; }
        public DbSet<Certificate> certificates { get; set; }
        public DbSet<Learnership> learnerships { get; set; }
        public DbSet<Colleges> colleges { get; set; }
        public DbSet<LearnershipCertificate> LearnershipCertificate { get; set; }
        public DbSet<CollegeField> collegeFields { get; set; }
        public DbSet<GovernmentSector>  governmentSectors{ get; set; }
        public DbSet<GovernmentSectorField>  governmentSectorFields{ get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UniversityFaculty>()
                 .HasKey(uf => new { uf.FacultyId, uf.UniversityId });

            modelBuilder.Entity<UniversityFaculty>()
                .HasRequired(uf => uf.Universities)
                .WithMany(u => u.UniversityFacultyList)
                .HasForeignKey(uf => uf.UniversityId);

            modelBuilder.Entity<UniversityFaculty>()
               .HasRequired(uf => uf.Faculties)
               .WithMany(f => f.UniversityFacultyList)
               .HasForeignKey(uf => uf.FacultyId);

            modelBuilder.Entity<School>()
               .HasRequired(s => s.Faculties)
               .WithMany(fa => fa.SchoolsList)
               .HasForeignKey(s => s.FacultyId);

            modelBuilder.Entity<Diploma>()
              .Property(di => di.SchoolId)
              .IsOptional();

            modelBuilder.Entity<Diploma>()
                .HasOptional(di => di.Schools)
                .WithMany(s => s.diplomasList)
                .HasForeignKey(di => di.SchoolId);

            modelBuilder.Entity<Degree>()
              .HasRequired(de => de.Schools)
              .WithMany(s => s.degreesList)
              .HasForeignKey(de => de.SchoolId);

            modelBuilder.Entity<FinancialAidField>()
                .HasKey(faf => new { faf.FinancialAidId, faf.FieldId });

            modelBuilder.Entity<FinancialAidField>()
                .HasRequired(faf => faf.Field)
                .WithMany(f => f.FinancialAidFieldsList)
                .HasForeignKey(faf => faf.FieldId);

            modelBuilder.Entity<FinancialAidField>()
                .HasRequired(faf => faf.FinancialAid)
                .WithMany(fa => fa.FinancialAidFieldsList)
                .HasForeignKey(faf => faf.FinancialAidId);

            modelBuilder.Entity<CollegeField>()
                .HasKey(c => new { c.CollegeId, c.FieldId });


            modelBuilder.Entity<CollegeField>()
                .HasRequired(cf => cf.Field)
                .WithMany(co => co.CollegeFieldList)
                .HasForeignKey(cf => cf.FieldId);

            modelBuilder.Entity<CollegeField>()
                .HasRequired(cf => cf.Colleges)
                .WithMany(co => co.CollegeFieldList)
                .HasForeignKey(cf => cf.CollegeId);

            modelBuilder.Entity<Certificate>()
                .HasRequired(ce => ce.Field)
                .WithMany(fe => fe.CertificatesList)
                .HasForeignKey(ce => ce.FieldId);

            modelBuilder.Entity<LearnershipCertificate>()
                .HasKey(lc => new { lc.CertificateId, lc.LearnershipId });

            modelBuilder.Entity<LearnershipCertificate>()
                .HasRequired(lc => lc.Certificate)
                .WithMany(co => co.LearnershipCertificateList)
                .HasForeignKey(cf => cf.CertificateId);

            modelBuilder.Entity<LearnershipCertificate>()
                .HasRequired(lc => lc.Learnership)
                .WithMany(co => co.LearnershipCertificateList)
                .HasForeignKey(cf => cf.LearnershipId);

            modelBuilder.Entity<GovernmentSectorField>()
                .HasKey(g => new {g.GovernmentId, g.FieldId });

            modelBuilder.Entity<GovernmentSectorField>()
                .HasRequired(g => g.GovernmentSector)
                .WithMany(go => go.GovernmentSectorFieldsList)
                .HasForeignKey(g => g.GovernmentId);

            modelBuilder.Entity<GovernmentSectorField>()
                .HasRequired(g => g.Field)
                .WithMany(go => go.GovernmentSectorFieldsList)
                .HasForeignKey(g => g.FieldId);
                
                
        }
    }
}
