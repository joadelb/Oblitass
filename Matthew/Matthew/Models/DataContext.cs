﻿
namespace Matthew.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Matthew.Models.Fairy> Fairies { get; set; }
    }
}