//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Teams
    {
        public int IdTeam { get; set; }
        public int IdDictTeams { get; set; }
        public int IdCountries { get; set; }
        public int IdDictFormations { get; set; }
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Pressing { get; set; }
        public int AttackLevel { get; set; }
        public int Aggression { get; set; }
        public Nullable<int> Played { get; set; }
        public Nullable<int> Won { get; set; }
        public Nullable<int> Drawn { get; set; }
        public Nullable<int> Lost { get; set; }
        public Nullable<int> GoalsFor { get; set; }
        public Nullable<int> GoalsAgainst { get; set; }
        public Nullable<int> Points { get; set; }
        public byte Active { get; set; }
    
        public virtual dictCountries dictCountries { get; set; }
        public virtual dictFormations dictFormations { get; set; }
        public virtual dictTeams dictTeams { get; set; }
        public virtual Users Users { get; set; }
    }
}
