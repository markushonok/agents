# Small Methods

Methods must be small in both length and structural depth.

A method whose body contains more than ten non-empty lines, excluding lines containing only braces, is a code smell.

A control-flow nesting depth greater than two levels is a code smell. Prefer a shallow method whose behavior is expressed as a sequence of operations.

When a method becomes too long or deeply nested, apply the decomposition principles rather than compressing the implementation or combining multiple operations into individual lines.

# Method Decomposition

Decompose complex behavior into small, semantically named methods representing meaningful values or operations.

Reuse is not required for decomposition. Extracting a method is valuable even when it has only one call site if the extracted method gives a meaningful name to a part of the implementation or isolates a distinct operation.

Do not extract methods merely to satisfy structural limits. Every extracted method must represent a meaningful abstraction and have a name that communicates its semantics.

Do not use method decomposition to keep an independently nameable concept inside an unrelated type.

# Exception Decomposition

When exception construction introduces implementation details that distract from the surrounding flow, extract it into a semantically named factory property or method.

Keep concise, self-explanatory exception construction inline when extraction would provide no additional semantic or abstraction value.

# Type Decomposition

Decompose implementations into cohesive, independently nameable concepts.

An implementation exceeding approximately one hundred non-empty lines is a code smell and requires re-evaluating its decomposition.

Reuse is not required. Do not keep an independently meaningful concept embedded in another type merely because it has one consumer.

Do not decompose merely to reduce size. Stop when further decomposition would split one cohesive concept into its individual operations or implementation details.

# Transparent Composition

The dependencies and mutable state of an object must remain explicit and controllable through composition. Construction must not hide state ownership, dependency observation, or derived values from the creator.

## Injectable State

Types, as a rule, must be immutable. Mutability is a separate responsibility and belongs to types specifically designed to represent mutable state, such as `IRef<T>`, collections, and similar abstractions.

An ordinary type must not own mutable state directly. Mutable state on which its behavior depends must be supplied as a dependency, allowing the creator to own, share, and control that state independently of the object that uses it.

## Transparent Construction

Instance construction must use primary constructors.

Construction exists only to supply an object with its dependencies and state. It must not compute derived values, observe dependencies, perform useful work, or cache values obtained from them.

Behavior and derived values must be expressed by members operating on the injected inputs.

## Aggregation Then Composition

Define the most general implementation first, with its dependencies exposed through the primary constructor.

More specific forms may then be composed by partially or fully supplying those dependencies through static factory properties or methods.

Composition must preserve the general injectable form. Callers must remain able to construct the object with explicitly supplied dependencies through its primary constructor.

# Replaceable Reflection

Reflection may be used as an implementation mechanism, but must not be an irreplaceable foundation of the design.

Anything implemented through reflection must remain expressible through ordinary code and declared abstractions without changing the conceptual design.

Reflection may automate repetitive implementation or composition work, such as discovering implementations, generating implementations of declared interfaces, or wiring dependencies through an IoC.

Do not use reflection to compensate for a missing abstraction or to make behavior depend on structural information that is available only through runtime type inspection.