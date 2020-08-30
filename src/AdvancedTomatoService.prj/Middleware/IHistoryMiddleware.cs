using System;
using System.Collections.Generic;
using System.Text;

using AdvancedTomatoService.TomatoData;

namespace AdvancedTomatoService.Middleware
{
	/// <summary>Промежуточный сервис работы с историей.</summary>
	/// <typeparam name="THistory">История.</typeparam>
	/// <typeparam name="TEntry">Запись в истории.</typeparam>
	public interface IHistoryMiddleware<THistory, TEntry>
		where THistory : class
		where TEntry : class
	{
		void AddEntry(TEntry entry);

		bool TryFindEntry(DateTime pointInTime, out TEntry emtry);

		void SaveHistory();

		THistory LoadHistory();
	}
}
