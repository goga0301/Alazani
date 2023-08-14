﻿using Alazani.Domain.Entities;
using Alazani.Domain.Repository.Base;

namespace Alazani.Domain.Repository;

public interface IProductRepository : IGenericRepository<Product,int>
{
}
