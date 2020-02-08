namespace CFApproachExercise
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class TRM1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CFApproachExercise.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public TRM1(): base("TRM")
        {
            Database.SetInitializer<TRM1>(new DropCreateDatabaseIfModelChanges<TRM1>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<TrainingRequest> TrainingRequests { get; set; }
    }
    

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    public class User
    {
        [Column(name: "User ID")]
        [Key]
        public int UID { get; set; }
        [MaxLength(20)]
        [StringLength(20)]
        [Column(name: "Full Name")]
        public string FullName { get; set; }
        [MaxLength(10)]
        [StringLength(10)]
        [Column(name: "User Name")]
        public string UserName { get; set; }
        [MaxLength(8)]
        [StringLength(8)]
        [Column(name: "Password")]
        public string Password { get; set; }
    }
    public class TrainingRequest
    {
        [Key]
        [Column(name: "Training ID")]
        public int TID { get; set; }
        [MaxLength(30)]
        [StringLength(30)]
        [Column(name: "Required Name")]
        public string ReqName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [MaxLength(10)]
        [StringLength(10)]
        [Column(name: "Skill")]
        public string Skill { get; set; }
        [Column(name: "Owen ID")]
        public int OwenID { get; set; }
        [Column(name: "Executive ID")]
        public int? ExecutiveID { get; set; }
        [MaxLength(10)]
        [StringLength(10)]
        [Column(name: "Status")]
        public string Status { get; set; }

      
        public virtual User UID { get; set; }

    }
}
