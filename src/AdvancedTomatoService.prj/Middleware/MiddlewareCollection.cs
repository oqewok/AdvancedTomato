
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

using AdvancedTomatoService.TomatoData;

namespace AdvancedTomatoService.Middleware
{
	public class HistoryMiddlewareCollection<T> : IMiddlewareCollection<T> where T : class
	{
		public HistoryMiddlewareCollection()
		{

		}

		private readonly List<IHistoryMiddleware<TomatoHistory, TomatoEntry>> _services
			= new List<IHistoryMiddleware<TomatoHistory, TomatoEntry>>();

		private readonly object _syncRoot = new object();

		public void Attach(IMiddlewareCollection<T> middleware)
		{
			lock(_syncRoot)
			{

			}
		}

		public void Detach(IMiddlewareCollection<T> middleware)
		{
			lock(_syncRoot)
			{

			}
		}

		public bool TryGetService<TService>(out TService service)
		{
			lock(_syncRoot)
			{
				service = _services.OfType<TService>().FirstOrDefault();
			}
			return service != null;
		}
	}
}
