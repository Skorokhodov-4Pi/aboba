﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CRB
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class CRBEntities : DbContext
{
    public CRBEntities()
        : base("name=CRBEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

    public virtual DbSet<Departments> Departments { get; set; }

    public virtual DbSet<Electronic_medical_card> Electronic_medical_card { get; set; }

    public virtual DbSet<MKB> MKB { get; set; }

    public virtual DbSet<OMS_policy> OMS_policy { get; set; }

    public virtual DbSet<Outcomes> Outcomes { get; set; }

    public virtual DbSet<Patient> Patient { get; set; }

    public virtual DbSet<Positions> Positions { get; set; }

    public virtual DbSet<Role> Role { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<Users> Users { get; set; }

    public virtual DbSet<OtchetPost2024> OtchetPost2024 { get; set; }

}

}

