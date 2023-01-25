using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Controls;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Agreement> Agreement { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=dashboard_contract;Username=postgres;Password=AzmovlHype");
    }
}

public class User
{
    [Key]
    public int user_id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
}

public class Agreement
{
    [Key]
    public int agreement_id { get; set; }
    public int codeAgreement { get; set; }
    public int numberAgreement { get; set; }
    public DateTime dateAgreement { get; set; }
    public DateTime dateSrokAgreement { get; set; }
    public DateTime dateEndAgreement { get; set; }
    public string? nameAgreement { get; set; }
    public string? countryAgreement { get; set; }
    public string? areaAgreement { get; set; }
    public string? typeAgreement { get; set; }
    public string? relationshipsAgreement { get; set; }
    public string? statusMMZAgreement { get; set; }
    public string? statusAgreement { get; set; }
    public int sumAgreement { get; set; }
    public int countsAgreement { get; set; }
    public int sumTransAgreement { get; set; }
    public string? nameProduct { get; set; }
    public int typePayement { get; set; }
    public int dayDatePayement { get; set; }
    public int dayAgreement { get; set; }
    public int dayDateOfShipment { get; set; }
}