# Single Interface Principle

Design a concrete implementation around one primary conceptual interface.

Directly implementing several related conceptual interfaces is a **moderate smell** and usually indicates that a unifying interface is missing which represents the cohesive entity and is a subtype of those narrower interfaces.

For example, if an entity is both `IReadable` and `IWritable`, prefer defining `IFile: IReadable, IWritable` and making the concrete type a subtype of `IFile`.

Additional technical and orthogonal interfaces, such as `IEquatable<T>`, do not violate this principle.

# Public Members Implement Interfaces

Expose the public instance behavior of a concrete implementation through its interface contract.

A public instance member that represents behavior of the entity but exists only on the concrete implementation is a **moderate smell**.

Static members are not subject to this guidance.

Public instance members specific to a concrete implementation are allowed when they conceptually remain implementation details but are safe enough to expose publicly. Such an exception must not expand the abstract contract of the entity. A safe method overload is an example.

# Small Interface Principle

An interface whose effective contract contains more than four members is a **light smell**. Members inherited through its conceptual supertypes are included in the count.

The threshold is a reason to inspect the interface's responsibility and cohesion. Size alone does not justify decomposition.

# Inheritance from Classes

Inheritance from classes, including the use of abstract classes, is a **strong smell**.

Unlike interface subtyping, class inheritance is restricted to a single base class. A class can have only one direct base class. Choosing a base class occupies that single position in the class hierarchy and thereby limits further composition through class inheritance.

A base class also creates coupling to the class type construct: a contract expressed through class inheritance requires its implementations to be classes and therefore excludes a possible struct implementation. An interface imposes no such restriction and leaves the choice of implementation type open.

An implementation of Yegor Bugayenko's `Decorating envelope` pattern is an example of an exception.

# Sealing Classes Against Inheritance

A class that is not intended to be inherited in the current design must have the `sealed` modifier. The modifier documents the adopted design decision and explicitly communicates the class is not designed to be used as a base class.

If the need arises to derive from a sealed class, the class must be examined and, if necessary, adapted for use as a base class. Only after that should the `sealed` modifier be removed.

# Replaceable Runtime Type Knowledge

Behavior must be defined through declared abstractions rather than knowledge of concrete runtime types.

Runtime type introspection and downcasting may be used as low-level implementation mechanisms or optimizations, but must remain replaceable without changing the conceptual design.

Do not make an abstraction depend on discovering the concrete implementation of an object. A correct implementation through the declared contract must remain possible without runtime type checks or downcasts.

Branching on concrete runtime types to determine behavior is a **strong smell** and usually indicates that the required behavior is missing from the abstraction.

An instance generic method whose type parameter is used to inspect, interpret, or cast an otherwise untyped value is a **moderate smell**.