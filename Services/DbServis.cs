using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErenSevindikFlightApp.Data;
using ErenSevindikFlightApp.Models;

public class DbServis
{
    private readonly AppDbContext _dbContext = new AppDbContext();

    public async Task<List<T>> GetAll<T>() where T : class
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public async Task<List<string>> GetSehirbyUlke(string ulke)
    {
        var SehirList = await _dbContext.Set<Lokasyon>()
                                    .Where(f => f.Ulke == ulke)
                                    .Select(f => f.Sehir)
                                    .Distinct()
                                    .ToListAsync();
        return SehirList;
    }

    public async Task<List<string>> GetHavaalanibySehir(string sehir)
    {
        var HavaalaniList = await _dbContext.Set<Lokasyon>()
                                    .Where(f => f.Sehir == sehir)
                                    .Select(f => f.Havaalani)
                                    .Distinct()
                                    .ToListAsync();
        return HavaalaniList;
    }


    public async Task<List<Lokasyon>> GetUcak(string Ulke, string Sehir, string Havaalani)
    {
        var UcakListele = await _dbContext.Lokasyon
                                 .Where(Lokasyon => Lokasyon.Ulke == Ulke && Lokasyon.Sehir == Sehir && Lokasyon.Havaalani == Havaalani )
                                 .ToListAsync();

        return UcakListele;
    }

    public Rezervasyon GetRezerveKoltukbylokasyonId(int lokasyon_id)
    {
        return _dbContext.Rezervasyon
                    .FirstOrDefault(f => f.LokasyonId == lokasyon_id);
    }

    public List<string> GetdoluKoltukNobylokasyonId(int lokasyon_id)
    {
        var KoltukNo= _dbContext.Rezervasyon
                              .Where(f => f.LokasyonId == lokasyon_id)
                              .Select(s => s.KoltukNo)
                              .ToList();
        return KoltukNo;
    }
}