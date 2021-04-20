using System;
using System.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace LibraryProject.Models
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<BookingRecords> BookingRecords { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BooksGenres> BooksGenres { get; set; }
        public virtual DbSet<CategoriesShelfs> CategoriesShelfs { get; set; }
        public virtual DbSet<Copies> Copies { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<LendingBooks> LendingBooks { get; set; }
        public virtual DbSet<Librarians> Librarians { get; set; }
        public virtual DbSet<Readers> Readers { get; set; }
        public virtual DbSet<ReadersShelfs> ReadersShelfs { get; set; }

        // IWebHostEnvironment _appEnvironment;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Программирование\\Diploma\\LibraryProject\\LibraryDB_SQL\\LibraryDB.mdf;Integrated Security=True;Connect Timeout=60;User Instance=True
                optionsBuilder.UseSqlServer("Server=wpl37.hosting.reg.ru;Database=u1345199_LibraryDB;User ID=u1345199_sa;Password=sa_21Ivan;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SurnameNp)
                    .IsRequired()
                    .HasColumnName("SurnameNP")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<BookingRecords>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BookingDate).HasColumnType("date");

                entity.Property(e => e.DateOfCompletion).HasColumnType("date");

                entity.Property(e => e.IdBook).HasColumnName("idBook");

                entity.Property(e => e.IdReader).HasColumnName("idReader");

                entity.HasOne(d => d.IdBookNavigation)
                    .WithMany(p => p.BookingRecords)
                    .HasForeignKey(d => d.IdBook)
                    .HasConstraintName("FK__BookingRe__idBoo__300424B4");

                entity.HasOne(d => d.IdReaderNavigation)
                    .WithMany(p => p.BookingRecords)
                    .HasForeignKey(d => d.IdReader)
                    .HasConstraintName("FK__BookingRe__idRea__2F10007B");
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoverImgUrl)
                    .HasColumnName("CoverImgURL")
                    .HasMaxLength(1200)
                    .HasDefaultValueSql("('https://clck.ru/TSSWH')");

                entity.Property(e => e.DescriptionBook).HasMaxLength(3000);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.YearOfIssue).HasMaxLength(10);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK__Books__AuthorId__1BFD2C07");
            });

            modelBuilder.Entity<BooksGenres>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.GenreId })
                    .HasName("PK__BooksGen__CDD89250844F4FA2");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BooksGenres)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BooksGenr__BookI__1FCDBCEB");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.BooksGenres)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BooksGenr__Genre__20C1E124");
            });

            modelBuilder.Entity<CategoriesShelfs>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(160);
            });

            modelBuilder.Entity<Copies>(entity =>
            {
                entity.HasKey(e => e.IdCopy)
                    .HasName("PK__Copies__80B32CEFBBCA7110");

                entity.HasIndex(e => e.IdBook)
                    .HasName("UQ__Copies__D80547A09694B8E4")
                    .IsUnique();

                entity.Property(e => e.IdCopy).HasColumnName("idCopy");

                entity.Property(e => e.IdBook).HasColumnName("idBook");

                entity.HasOne(d => d.IdBookNavigation)
                    .WithOne(p => p.Copies)
                    .HasForeignKey<Copies>(d => d.IdBook)
                    .HasConstraintName("FK__Copies__idBook__24927208");
            });

            modelBuilder.Entity<Genres>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasColumnName("genreName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LendingBooks>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActualReturnDate).HasColumnType("date");

                entity.Property(e => e.DateOfIssue).HasColumnType("date");

                entity.Property(e => e.ExpectedDateOfReturn).HasColumnType("date");

                entity.Property(e => e.IdCopy).HasColumnName("idCopy");

                entity.Property(e => e.IdLibrarian).HasColumnName("idLibrarian");

                entity.Property(e => e.IdReader).HasColumnName("idReader");

                entity.HasOne(d => d.IdCopyNavigation)
                    .WithMany(p => p.LendingBooks)
                    .HasForeignKey(d => d.IdCopy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LendingBo__idCop__33D4B598");

                entity.HasOne(d => d.IdLibrarianNavigation)
                    .WithMany(p => p.LendingBooks)
                    .HasForeignKey(d => d.IdLibrarian)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LendingBo__idLib__32E0915F");

                entity.HasOne(d => d.IdReaderNavigation)
                    .WithMany(p => p.LendingBooks)
                    .HasForeignKey(d => d.IdReader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LendingBo__idRea__34C8D9D1");
            });

            modelBuilder.Entity<Librarians>(entity =>
            {
                entity.HasIndex(e => e.CodeLibrarian)
                    .HasName("UQ__Libraria__6BF1F378D28C8B6D")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeLibrarian)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.NameLibrarian)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PatronymicLibrarian)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SurnameLibrarian)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Readers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdressReader)
                    .IsRequired()
                    .HasMaxLength(324);

                entity.Property(e => e.EmailReader)
                    .IsRequired()
                    .HasMaxLength(254);

                entity.Property(e => e.LoginReader)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.NameReader)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PasswordReader)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.PatronymicReader)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PhoneNumberReader)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.PhotoReaderUrl)
                    .IsRequired()
                    .HasColumnName("PhotoReaderURL")
                    .HasMaxLength(1200);

                entity.Property(e => e.SurnameReader)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ReadersShelfs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdBook).HasColumnName("idBook");

                entity.Property(e => e.IdCategoryShelf).HasColumnName("idCategoryShelf");

                entity.Property(e => e.IdReader).HasColumnName("idReader");

                entity.HasOne(d => d.IdBookNavigation)
                    .WithMany(p => p.ReadersShelfs)
                    .HasForeignKey(d => d.IdBook)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReadersSh__idBoo__3B75D760");

                entity.HasOne(d => d.IdCategoryShelfNavigation)
                    .WithMany(p => p.ReadersShelfs)
                    .HasForeignKey(d => d.IdCategoryShelf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReadersSh__idCat__3C69FB99");

                entity.HasOne(d => d.IdReaderNavigation)
                    .WithMany(p => p.ReadersShelfs)
                    .HasForeignKey(d => d.IdReader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReadersSh__idRea__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
