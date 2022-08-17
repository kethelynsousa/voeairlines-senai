using Microsoft.EntityFrameworkCore;
using VoeAirlinesSenai.Entities;

namespace VoeAirlinesSenai.Contexts;

public class VoeAirlinesContext:DbContext{
public DbSet<Aeronave> Aeronaves =>Set<Aeronave>();
public DbSet<Manutencao> Manutencoes =>Set<Manutencao>();
    
}
