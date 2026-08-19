public static class NamingMembersA
	{
		public interface IVector3D
			{
				float X { get; }

				float Y { get; }

				float Z { get; }
			}

		extension(IVector3D source)
			{
				public IVector3D Inverse
					=> throw new NotImplementedException();

				public IVector3D ScaledBy(float number)
					=> throw new NotImplementedException();
			}

		public interface IPlanet
			{
				string Code { get; }
			}

		public interface IRocketCalculator
			{
				IAsyncEnumerable<IVector3D> TrajectoryBetween
					(
						IPlanet start,
						IPlanet finish,
						CancellationToken cancel = default
					);
			}
	}

public static class NamingMembersB
	{
		public interface IMatchTask<in T>
			{
				Task Match(T outcomes);
			}

		public interface IAccountAddHook
			{
				void Complete(object tokens);

				void LoseUsernameRace();

				void ErrorWith(string message);
			}

		public interface IAccountRemoveHook
			{
				void Complete();

				void ErrorWith(string message);
			}

		public interface IAccountDb
			{
				IMatchTask<IAccountAddHook> Add
					(
						string username,
						string password,
						CancellationToken cancel = default
					);

				IMatchTask<IAccountRemoveHook> Remove
					(
						string username,
						CancellationToken cancel = default
					);
			}
	}