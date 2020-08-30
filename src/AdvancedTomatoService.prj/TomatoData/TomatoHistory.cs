using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedTomatoService.TomatoData
{
	/// <summary>Описывает историю запущенных завершенных таймеров.</summary>
	public class TomatoHistory
	{
		private object _syncRoot = new object();

		private List<TomatoEntry> _entries;

		public TomatoHistory()
		{
			_entries = new List<TomatoEntry>();
		}

		/// <summary>Добавляет запись в историю.</summary>
		/// <param name="tomatoEntry"></param>
		public void Add(TomatoEntry tomatoEntry)
		{
			lock(_syncRoot)
			{
				_entries.Add(tomatoEntry);
			}
		}

		/// <summary>Пытается найти в истории запись, которая соответсвует заданному времени.</summary>
		/// <param name="periodInTime">Заданное время, отонсительно которого осуществляется поиск.</param>
		/// <param name="entryFound">Найденная запись, если она присутствует в истории, иначе <c>null</c>.</param>
		/// <returns>Результат поиска.</returns>
		public bool Find(DateTime pointInTime, out TomatoEntry entryFound)
		{
			lock(_syncRoot)
			{
				entryFound = _entries
					.Where(x => x.StartTime >= pointInTime
					&& x.StartTime + x.Duration < pointInTime)
					?.FirstOrDefault();
			}

			return entryFound != null;
		}
	}
}
