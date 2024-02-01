using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labW03.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace labW03.Data;
public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }

    private static List<City> GetCities()
    {
        List<City> cities = new List<City>() {
            new City() {
                CityId = 1,
                CityName = "Calgary",
                Population = 1336000,
                ProvinceCode = "AB"
            },
            new City() {
                CityId = 2,
                CityName = "Edmonton",
                Population = 981000,
                ProvinceCode = "AB"
            },
            new City() {
                CityId = 3,
                CityName = "Red Deer",
                Population = 100418,
                ProvinceCode = "AB"
            },
            new City() {
                CityId = 4,
                CityName = "Lethbridge",
                Population = 101482,
                ProvinceCode = "AB"
            },
            new City() {
                CityId = 5,
                CityName = "Vancouver",
                Population = 631000,
                ProvinceCode = "BC"
            },
            new City() {
                CityId = 6,
                CityName = "Victoria",
                Population = 92000,
                ProvinceCode = "BC"
            },
            new City() {
                CityId = 7,
                CityName = "Richmond",
                Population = 198000,
                ProvinceCode = "BC"
            },
            new City() {
                CityId = 8,
                CityName = "Burnaby",
                Population = 233000,
                ProvinceCode = "BC"
            },
            new City() {
                CityId = 9,
                CityName = "Surrey",
                Population = 517000,
                ProvinceCode = "BC"
            },
            new City() {
                CityId = 10,
                CityName = "Coquitlam",
                Population = 139000,
                ProvinceCode = "BC"
            },
            new City() {
                CityId = 11,
                CityName = "Halifax",
                Population = 403000,
                ProvinceCode = "NS"
            },
            new City() {
                CityId = 12,
                CityName = "Sydney",
                Population = 29000,
                ProvinceCode = "NS"
            },
            new City() {
                CityId = 13,
                CityName = "Truro",
                Population = 12000,
                ProvinceCode = "NS"
            },
            new City() {
                CityId = 14,
                CityName = "New Glasgow",
                Population = 9500,
                ProvinceCode = "NS"
            },
            new City() {
                CityId = 15,
                CityName = "Montreal",
                Population = 1700000,
                ProvinceCode = "QC"
            },
            new City() {
                CityId = 16,
                CityName = "Quebec City",
                Population = 531000,
                ProvinceCode = "QC"
            },
            new City() {
                CityId = 17,
                CityName = "Laval",
                Population = 422000,
                ProvinceCode = "QC"
            },
            new City() {
                CityId = 18,
                CityName = "Gatineau",
                Population = 276000,
                ProvinceCode = "QC"
            },
            new City() {
                CityId = 19,
                CityName = "Iqaluit",
                Population = 7740,
                ProvinceCode = "NU"
            },
            new City() {
                CityId = 20,
                CityName = "Rankin Inlet",
                Population = 2764,
                ProvinceCode = "NU"
            },
            new City() {
                CityId = 21,
                CityName = "Arviat",
                Population = 2318,
                ProvinceCode = "NU"
            },
        };
        return cities;
    }

    private static List<Province> GetProvinces()
    {
        List<Province> provinces = new List<Province>(){
            new Province() {
                ProvinceCode = "AB", 
                ProvinceName = "Alberta"
            },
            new Province() {
                ProvinceCode = "BC", 
                ProvinceName = "British Columbia"
            },
            new Province() {
                ProvinceCode = "NS", 
                ProvinceName = "Nova Scotia"
            },
            new Province() {
                ProvinceCode = "QC", 
                ProvinceName = "Quebec"
            },
            new Province() {
                ProvinceCode = "NU", 
                ProvinceName = "Nunavut"
            },
        };
        return provinces;
    }
}
