using System;

using AdvancedTomatoService.Middleware;

namespace AdvancedTomatoService.TomatoData
{
	public class HistoryMiddleware : HistoryMiddlewareBase<TomatoHistory, TomatoEntry>
	{
		public HistoryMiddleware(IHistoryProvider<TomatoHistory, TomatoEntry> historyProvider) :
			base (historyProvider)
		{
			History = historyProvider.History;
		}

		private TomatoHistory History { get; }

		private IHistoryProvider<TomatoHistory, TomatoEntry> HistoryProvider { get; }

		/// <summary>Добавляет запись в историю.</summary>
		/// <param name="entry"></param>
		public override void AddEntry(TomatoEntry entry) => History.Add(entry);
	}
}
