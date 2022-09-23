// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using Modelli;
using Modelli.Models;

string connectionstring = "Server=localhost\\SQLEXPRESS;Database=CONTATTI;Trusted_Connection=True";

DbContextOptionsBuilder<RubricaDbContext> optionsBuilder = new DbContextOptionsBuilder<RubricaDbContext>();
optionsBuilder.UseSqlServer(connectionstring);  // Microsoft.EntityFrameworkCore.SqlServer

using (RubricaDbContext context = new RubricaDbContext(optionsBuilder.Options))
{
    Contatto contatto = new Contatto();
    contatto.Nome = "Mario";
    contatto.Cognome = "Rossi";
    contatto.Numero = "3312897412";

    context.Contatti.Add(contatto);

    context.SaveChanges();
}
