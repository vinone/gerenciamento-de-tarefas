using System;
using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace WebTasks.Data
{
	public class DataAccessProvider : IDisposable
	{
		private readonly string _connectionString;
		private ISessionFactory _sessionFactory;

		public ISessionFactory SessionFactory
		{
			get { return _sessionFactory ?? (_sessionFactory = CreateSessionFactory()); }
		}

		public DataAccessProvider(string connectionString)
		{
			_connectionString = connectionString;
		}

		private ISessionFactory CreateSessionFactory()
		{
			return Fluently
					.Configure()
						.Database(MySQLConfiguration.Standard
					          	.ConnectionString(_connectionString))
							.Mappings(m => m.FluentMappings
					          .AddFromAssembly(Assembly.GetExecutingAssembly()))
									.BuildSessionFactory();
		}

		public void Dispose()
		{
			SessionFactory
				.GetCurrentSession()
				.Dispose();
		}
	}
}