namespace AdvancedTomatoService.Middleware
{
	/// <summary>Коллекция дополнительных сервисов приложения.</summary>
	public interface IMiddlewareCollection
	{
		/// <summary>Пытается запосить сервис указанного типа <typeparamref name="TService"/> у приложения.</summary>
		/// <typeparam name="TService">Тип запрашиваемого сервиса.</typeparam>
		/// <param name="service">Ранее зарегистрированный сервис, иначе <c>null</c>.</param>
		/// <returns>Результат получения сервиса приложения</returns>
		bool TryGetService<TService>(out TService service);
	}

	/// <summary>Коллекция дополнительных сервисов приложения.</summary>
	public interface IMiddlewareCollection<T> : IMiddlewareCollection
	{
		/// <summary>Добавляет дополнительный сервис в приложение.</summary>
		/// <param name="middleware">Добавляемый дополнительный сервис.</param>
		void Attach(IMiddlewareCollection<T> middleware);

		/// <summary>Удаляет дополнительный сервис из приложения.</summary>
		/// <param name="middleware">Удаляетмый дополнительный сервис.</param>
		void Detach(IMiddlewareCollection<T> middleware);
	}
}