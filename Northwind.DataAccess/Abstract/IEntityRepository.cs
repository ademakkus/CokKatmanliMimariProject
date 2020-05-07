﻿using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{

	public interface IEntityRepository<T>where T:class,IEntity,new()
	{

		List<T> GetAll(Expression<Func<T,bool>>filter=null);


		T Get(Expression<Func<T, bool>> filter);

		void Add(T entity);

		void Update(T entity);

		void Delete(T entity);


	}



	/* public interface IEntityRepository
	{

		List<Product> GetAll();


		Product Get(int id);

		void Add(Product product);

		void Update(Product product);

		void Delete(Product product);
	*

	}*/
}
