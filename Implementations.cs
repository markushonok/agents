public static class ExceptionDecomposition
	{
		public static void SomeAlgorithm(int i)
			{
				if (i == 0) throw ZeroNumberException;
				throw new NotSupportedException();
			}

		public static Exception ZeroNumberException
			=> new
				(
					"When exception construction introduces"
					+ " implementation details that distract"
					+ " from the surrounding flow, extract"
					+ " it into a semantically named factory"
					+ " property or method."
				);
	}

public static class TransparentComposition
	{
		public interface IPlayer
			{
				int Health { get; }

				void Hurt();

				void Heal();
			}

		public sealed partial class Player
			{
				public static IPlayer New
					=> Player.With(health: 10);

				public static IPlayer With(int health)
					=> new Player(Ref.To(health));
			}

		public sealed partial class Player
			(
				IRef<int> health
			)
			: IPlayer
			{
				public int Health
					=> health.Value;

				public void Hurt()
					=> health.Value--;

				public void Heal()
					=> health.Value++;
			}
	}