using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTomatoService.TomatoData
{
	/// <summary>Запись о временном отрезке работы.</summary>
	public class TomatoEntry
	{
		public TomatoEntry(DateTime start, TimeSpan duration)
		{
			StartTime = start;
			Duration  = duration;
		}

		public DateTime StartTime { get; set; }

		public TimeSpan Duration { get; set; }
	}
}
