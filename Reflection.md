# Replaceable Introspection

Behavior must be defined through declared abstractions rather than knowledge of concrete runtime types.

Runtime type introspection and downcasting may be used as low-level implementation mechanisms or optimizations, but must remain replaceable without changing the conceptual design.

Do not make an abstraction depend on discovering the concrete implementation of an object. A correct implementation through the declared contract must remain possible without runtime type checks or downcasts.

Branching on concrete runtime types to determine behavior is a **strong smell** and usually indicates that the required behavior is missing from the abstraction.

An instance generic method whose type parameter is used to inspect, interpret, or cast an otherwise untyped value is a **moderate smell**.

# Replaceable Reflection

Reflection may be used as an implementation mechanism, but must not be an irreplaceable foundation of the design.

Anything implemented through reflection must remain expressible through ordinary code and declared abstractions without changing the conceptual design.

Reflection may automate repetitive implementation or composition work, such as discovering implementations, generating implementations of declared interfaces, or wiring dependencies through an IoC.

Do not use reflection to compensate for a missing abstraction or to make behavior depend on structural information that is available only through runtime type inspection.