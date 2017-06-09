﻿using System.Collections.Generic;
using NHibernate.Criterion;

namespace Server.Framework
{
    public class Repository<T> where T: class
    {
		public Repository(string databaseFile)
		{
			NHibernateHelper.DatabaseFile = databaseFile;
		}

		public List<T> GetAll()
		{
             using (var session = NHibernateHelper.OpenSession())
             {
	             var returnList = session.CreateCriteria<T>().List<T>();
	             return returnList as List<T>;
             }
		}

		public void Delete (T entity)
		{
			using (var session = NHibernateHelper.OpenSession())
			{
				using (var transaction = session.BeginTransaction())
				{
					session.Delete(entity);
					transaction.Commit();
				}
			}
		}

		public void Save(T entity)
		{
			using (var session = NHibernateHelper.OpenSession())
			{
				using (var transaction = session.BeginTransaction())
				{
					session.Save(entity);
					transaction.Commit();
				}
			}
		}

		public T GetById(int id)
		{
			using (var session = NHibernateHelper.OpenSession())
			{
				T result = session.CreateCriteria<T>().Add(Restrictions.Eq("Id", id)).UniqueResult<T>();
				return result;
			}
		}

		public List<T> GetByProperty(string property, object value)
		{
			using (var session = NHibernateHelper.OpenSession())
			{
				var returnList = session.CreateCriteria<T>().Add(Restrictions.Eq(property, value)).List<T>();
				return returnList as List<T>;
			}
		}

		public List<T> GetByPropertyIgnoreCase(string property, object value)
		{
			using (var session = NHibernateHelper.OpenSession())
			{
				var returnList = session.CreateCriteria<T>().Add(Restrictions.Eq(property, value).IgnoreCase()).List<T>();
				return returnList as List<T>;
			}
		}
	}
}