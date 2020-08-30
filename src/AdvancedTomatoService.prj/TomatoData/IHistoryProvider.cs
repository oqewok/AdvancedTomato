using System;

namespace AdvancedTomatoService.TomatoData
{
	public interface IHistoryProvider<THistory, TEnrty>
		where THistory : class
		where TEnrty : class
	{
		bool TryFindEntry(DateTime pointInTime, out TEnrty entry);

		THistory History { get; }

		void SaveHistory(THistory history);

		THistory LoadHistory();
	}
}