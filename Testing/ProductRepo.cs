﻿using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Testing.Models;

namespace Testing
{
	public class ProductRepo : IProductRepo
	{
        private readonly IDbConnection _conn;

		public ProductRepo(IDbConnection conn)
		{
            _conn = conn;
		}

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM Products;");
        }
    }
}

