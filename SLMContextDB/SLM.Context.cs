﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLMContextDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ErrorTableApp> ErrorTableApp { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<dictCountries> dictCountries { get; set; }
        public virtual DbSet<dictFormations> dictFormations { get; set; }
        public virtual DbSet<dictPersons> dictPersons { get; set; }
        public virtual DbSet<dictPositions> dictPositions { get; set; }
        public virtual DbSet<dictTeams> dictTeams { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<dictTeamsPlayers> dictTeamsPlayers { get; set; }
        public virtual DbSet<TeamsPlayer> TeamsPlayer { get; set; }
    }
}
