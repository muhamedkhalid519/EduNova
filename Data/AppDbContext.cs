using EduNova.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace EduNova.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Attendance> Attendances { get; set; }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Lecture> Lectures { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Notice> Notices { get; set; }

        public DbSet<Meeting> Meetings { get; set; }

        public DbSet<MeetingParticipant> MeetingParticipants { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<SavedLecture> SavedLectures { get; set; }

        public DbSet<DownloadedLecture> DownloadedLectures { get; set; }

        public DbSet<EventReminder> EventReminders { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<Attendance>()
                .HasOne(a => a.User)
                .WithMany(u => u.Attendances)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            mb.Entity<Grade>()
                .HasOne(g => g.User)
                .WithMany(u => u.Grades)
                .HasForeignKey(g => g.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            mb.Entity<Grade>()
                .HasOne(g => g.Subject)
                .WithMany(s => s.Grades)
                .HasForeignKey(g => g.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Lecture>()
                .HasOne(l => l.Subject)
                .WithMany(s => s.Lectures)
                .HasForeignKey(l => l.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            mb.Entity<Instructor>()
                .HasMany(i => i.Subjects)
                .WithMany(s => s.Instructors);

            mb.Entity<Attendance>()
                .HasOne(a => a.Instructor)
                .WithMany(i => i.Attendances)
                .HasForeignKey(a => a.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Note>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notes)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            mb.Entity<Meeting>()
                .HasOne(m => m.CreatedByUser)
                .WithMany(u => u.CreatedMeetings)
                .HasForeignKey(m => m.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            mb.Entity<MeetingParticipant>()
                .HasOne(mp => mp.User)
                .WithMany(u => u.MeetingParticipants)
                .HasForeignKey(mp => mp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            mb.Entity<MeetingParticipant>()
                .HasOne(mp => mp.Meeting)
                .WithMany(m => m.Participants)
                .HasForeignKey(mp => mp.MeetingId)
                .OnDelete(DeleteBehavior.Cascade);

            mb.Entity<SavedLecture>()
                .HasOne(sl => sl.User)
                .WithMany(u => u.SavedLectures)
                .HasForeignKey(sl => sl.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            mb.Entity<SavedLecture>()
                .HasOne(sl => sl.Lecture)
                .WithMany(l => l.SavedLectures)
                .HasForeignKey(sl => sl.LectureId)
                .OnDelete(DeleteBehavior.Cascade);

            mb.Entity<DownloadedLecture>()
                .HasOne(dl => dl.User)
                .WithMany(u => u.DownloadedLectures)
                .HasForeignKey(dl => dl.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            mb.Entity<DownloadedLecture>()
                .HasOne(dl => dl.Lecture)
                .WithMany(l => l.DownloadedLectures)
                .HasForeignKey(dl => dl.LectureId)
                .OnDelete(DeleteBehavior.Cascade);

            mb.Entity<EventReminder>()
                .HasOne(er => er.User)
                .WithMany(u => u.EventReminders)
                .HasForeignKey(er => er.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            mb.Entity<EventReminder>()
                .HasOne(er => er.Event)
                .WithMany(e => e.Reminders)
                .HasForeignKey(er => er.EventId)
                .OnDelete(DeleteBehavior.Cascade);

            mb.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            mb.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            mb.Entity<Meeting>()
                .HasIndex(m => m.MeetingCode)
                .IsUnique();

            mb.Entity<SavedLecture>()
                .HasIndex(sl => new { sl.UserId, sl.LectureId })
                .IsUnique();

            mb.Entity<DownloadedLecture>()
                .HasIndex(dl => new { dl.UserId, dl.LectureId })
                .IsUnique();

            mb.Entity<MeetingParticipant>()
                .HasIndex(mp => new { mp.MeetingId, mp.UserId })
                .IsUnique();

            mb.Entity<EventReminder>()
                .HasIndex(er => new { er.UserId, er.EventId })
                .IsUnique();

            mb.Entity<Grade>()
                .Property(g => g.Score)
                .HasPrecision(5, 2);
        }


    }
}
