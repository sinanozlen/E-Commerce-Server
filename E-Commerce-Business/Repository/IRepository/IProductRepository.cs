﻿using E_Commerce_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Business.Repository.IRepository
{
    public interface IProductRepository
    {
        public Task<ProductDTO> Create(ProductDTO objDTO);
        public Task<ProductDTO> Update(ProductDTO objDTO);

        public Task<int> Delete(int id);

        public Task<ProductDTO> GetById(int id);

        public Task<IEnumerable<ProductDTO>> GetAll();
    }
}
