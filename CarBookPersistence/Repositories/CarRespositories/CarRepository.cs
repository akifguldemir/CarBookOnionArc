﻿using CarBookApplication.Interfaces.CarInterfaces;
using CarbookDomain.Entities;
using CarBookPersistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBookPersistence.Repositories.CarRespositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x=>x.Brand).ToList();
            return values;
        }
    }
}
