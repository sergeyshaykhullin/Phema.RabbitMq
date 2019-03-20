namespace Phema.RabbitMQ
{
	public static class RabbitMQExchangeBindingBuilderExtensions
	{
		/// <summary>
		///   Sets exchange to exchange routing key
		/// </summary>
		public static IRabbitMQExchangeBindingBuilder WithRoutingKey(
			this IRabbitMQExchangeBindingBuilder builder,
			string routingKey)
		{
			builder.Metadata.RoutingKey = routingKey;

			return builder;
		}

		/// <summary>
		///   Sets nowait for exchange to exchange declaration
		/// </summary>
		public static IRabbitMQExchangeBindingBuilder NoWait(
			this IRabbitMQExchangeBindingBuilder builder)
		{
			builder.Metadata.NoWait = true;

			return builder;
		}

		/// <summary>
		///   Sets RabbitMQ arguments. Allow multiple
		/// </summary>
		public static IRabbitMQExchangeBindingBuilder WithArgument<TValue>(
			this IRabbitMQExchangeBindingBuilder builder,
			string argument,
			TValue value)
		{
			builder.Metadata.Arguments.Add(argument, value);

			return builder;
		}
	}
}