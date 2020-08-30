using System.Threading;
using System.Threading.Tasks;

namespace AdvancedTomatoService
{
	public class TimerThread
	{
		public TimerThread()
		{

		}

		private Thread _processingThread;

		public void Start()
		{
			_processingThread = new Thread(TimerThreadProc)
			{
				IsBackground = true,
				Name = "Timer Thread",
				Priority = ThreadPriority.Normal
			};
		}

		private void TimerThreadProc()
		{
			Task.Run(() => { }).Wait(1000);
		}
	}
}
