# Single Interface Principle

A concrete implementation, as a rule, must implement one primary conceptual interface. If a type directly implements several related interfaces, this usually means that a unifying interface is missing that represents a cohesive entity and is a subtype of those narrower interfaces.

For example, if an entity is both `IReadable` and `IWritable`, it is preferable to define `IFile: IReadable, IWritable`, and the concrete type must be a subtype of `IFile`.

Additional technical and orthogonal interfaces, such as `IEquatable<T>`, do not violate this principle.

# Public Members Implement Interfaces

Public instance members of a concrete implementation, as a rule, must implement an interface contract.

If an instance member is part of the public behavior of an entity, it must be declared in the corresponding interface rather than exist only on the concrete type.

Static members are not subject to this rule.

Public instance members specific to a concrete implementation are allowed if they conceptually remain implementation details but are safe enough to expose publicly. Such an exception must not expand the abstract contract of the entity and requires deliberate justification. A safe method overload is an example of an exception.

# Small Interface Principle

Interfaces must be small and represent the minimal cohesive contract of an entity.

An interface whose effective contract contains more than four members is a code smell. Members of all interfaces it is a subtype of are included in the count as well.

Exceeding this threshold requires re-evaluating the interface's responsibility and the possibility of decomposing it.

# Inheritance from Classes

Inheritance from classes, including the use of abstract classes, is a code smell.

Unlike interface subtyping, class inheritance is restricted to a single base class. A class can have only one direct base class. Choosing a base class occupies that single position in the class hierarchy and thereby limits further composition through class inheritance.

A base class also creates coupling to the class type construct: a contract expressed through class inheritance requires its implementations to be classes and therefore excludes a possible struct implementation. An interface imposes no such restriction and leaves the choice of implementation type open. An interface does not impose such a restriction and leaves the choice of implementation construct open.

An implementation of Yegor Bugayenko's `Decorating envelope` pattern is an example of an exception.

# Sealing Classes Against Inheritance

A class that is not intended to be inherited in the current design must have the `sealed` modifier. The modifier documents the adopted design decision and explicitly communicates the class is not designed to be used as a base class.

If the need arises to derive from a sealed class, the class must be examined and, if necessary, adapted for use as a base class. Only after that should the `sealed` modifier be removed.

# Replaceable Runtime Type Knowledge

Behavior must be defined through declared abstractions rather than knowledge of concrete runtime types.

Runtime type introspection and downcasting may be used as low-level implementation mechanisms or optimizations, but must remain replaceable without changing the conceptual design.

Do not make an abstraction depend on discovering the concrete implementation of an object. A correct implementation through the declared contract must remain possible without runtime type checks or downcasts.

Branching on concrete runtime types to determine behavior is a code smell and usually indicates that the required behavior is missing from the abstraction.

An instance generic method whose type parameter is used to inspect, interpret, or cast an otherwise untyped value is a code smell. Signatures such as `Method<T>(object)` often indicate that static type information has been erased and is being reconstructed through runtime type knowledge.