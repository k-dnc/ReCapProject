﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{Id=1, BrandName="Mercedes"},
                new Brand{Id=2, BrandName="BMW"},
                new Brand{Id=3, BrandName="Audi"},

            };
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b => b.Id == brand.Id);
            _brands.Remove(brandToDelete);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetById(int id)
        {
            return _brands.Where(b => b.Id == id).ToList();
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.Id == brand.Id);
            brandToUpdate.BrandName = brand.BrandName;
        }

    }
}
