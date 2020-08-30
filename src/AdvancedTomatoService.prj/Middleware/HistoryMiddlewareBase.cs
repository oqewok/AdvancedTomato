using System;
using System.Collections.Generic;
using System.Text;

using AdvancedTomatoService.Middleware;
using AdvancedTomatoService.TomatoData;

namespace AdvancedTomatoService
{
	public abstract class HistoryMiddlewareBase<THistory, TEntry>
		: IHistoryMiddleware<THistory, TEntry>
		where THistory : class
		where TEntry : class
	{
		public HistoryMiddlewareBase(IHistoryProvider<THistory, TEntry> historyProvider)
		{
			HistoryProvider = historyProvider;
		}

		private THistory History { get; }

		private IHistoryProvider<THistory, TEntry> HistoryProvider { get; }

		public abstract void AddEntry(TEntry entry);

		public virtual THistory LoadHistory() => HistoryProvider.LoadHistory();

		public virtual void SaveHistory() => HistoryProvider.SaveHistory(History);

		public virtual bool TryFindEntry(DateTime pointInTime, out TEntry entry)
			=> HistoryProvider.TryFindEntry(pointInTime, out entry);
	}
}
