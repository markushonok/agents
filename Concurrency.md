# Thread Safety as a Responsibility

Treat thread safety as a separate responsibility when concurrency guarantees can be added or removed without changing the conceptual behavior of an implementation.

Do not make an implementation thread-safe merely because it may be accessed concurrently in the future. Introduce synchronization when the actual composition requires a concurrency guarantee.

An implementation that is already safe to share because it is immutable, stateless, or otherwise free from conflicting access does not require synchronization merely to make thread safety explicit.

# Synchronization by Composition

When synchronization is orthogonal to the underlying behavior, prefer adding it through composition around an unsynchronized implementation, such as a decorator that serializes access.

Preserve the unsynchronized form so callers that do not require the concurrency guarantee are not forced to depend on synchronization policy or pay its cost.

Using `lock`, `Monitor`, `SemaphoreSlim`, `Interlocked`, concurrent collections, or similar synchronization mechanisms directly inside an implementation whose conceptual responsibility does not involve concurrency is a **moderate smell**.

Do not require every implementation of a general abstraction to be thread-safe unless concurrency is part of that abstraction's conceptual contract.

# Intrinsic Concurrency

Synchronization belongs inside an implementation when it is intrinsic to that implementation's role or algorithm rather than an orthogonal policy applied to otherwise complete behavior.

Synchronization primitives are appropriate when they implement the type's own concurrent or atomic semantics, preserve an invariant that cannot be maintained at an outer composition boundary, or form an essential part of the chosen algorithm.

Do not extract synchronization merely to remove concurrency primitives from an implementation when doing so would change the algorithm, weaken its guarantees, or create an artificial standalone concept.

# Atomicity Boundaries

Thread safety of individual operations does not make a sequence of operations atomic.

When a required concurrency guarantee spans several observations or mutations, represent that guarantee at a boundary that covers the complete operation. Prefer a semantically meaningful compound operation or another abstraction whose contract includes the required atomicity over independently synchronized calls.

A synchronization decorator is not enough when it releases its synchronization boundary between calls that must behave as one atomic operation.