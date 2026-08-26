# Decomposition

## Small Methods

Prefer methods that keep one behavior understandable without excessive structural depth or incidental detail.

A method whose body contains more than ten non-empty lines, excluding lines containing only braces, is a **light smell**. Length alone does not justify decomposition.

A control-flow nesting depth greater than two levels is a **moderate smell**. Prefer a shallow method whose behavior is expressed as a sequence of meaningful operations.

When complexity makes a method difficult to understand, apply the decomposition guidance rather than compressing the implementation or combining multiple operations into individual lines.

## Method Decomposition

Decompose complex behavior into semantically meaningful values and operations when doing so exposes the structure of the behavior.

Reuse is not required for decomposition. Extracting a method is valuable even when it has only one call site if the extracted method gives a meaningful name to a part of the implementation or isolates a distinct operation.

Do not extract methods merely to satisfy structural limits. Every extracted method must represent a meaningful abstraction and have a name that communicates its semantics.

Do not use method decomposition to keep an independently nameable concept inside an unrelated type.

## Exception Decomposition

When exception construction introduces implementation details that distract from the surrounding flow, extract it into a semantically named factory property or method.

Keep concise, self-explanatory exception construction inline when extraction would provide no additional semantic or abstraction value.

## Type Decomposition

Keep behavior together while it belongs to one cohesive concept. Introduce another type when part of an implementation represents an independently meaningful concept with its own role in the design or composition.

Reuse is not required. Do not keep an independently meaningful concept embedded in another type merely because it has one consumer.

An implementation exceeding approximately one hundred non-empty lines is a **light smell**. Size is a reason to inspect its cohesion, not a reason to decompose it.

A type extracted primarily to contain one operation or implementation fragment of another cohesive concept is a **moderate smell** when it has no clear independent conceptual role.

Splitting one cohesive implementation into separate types primarily to reduce its size or satisfy structural thresholds is a **strong smell**.

Stop decomposing when further extraction would turn operations or implementation details of one concept into artificial standalone concepts.

# Transparent Composition

The dependencies and mutable state of an object must remain explicit and controllable through composition. Construction must not hide state ownership, dependency observation, or derived values from the creator.

## Injectable State

Design ordinary types as immutable. Treat mutability as a separate responsibility represented by types specifically designed to own mutable state, such as `IRef<T>`, collections, and similar abstractions.

An ordinary type must not own mutable state directly. Mutable state on which its behavior depends must be supplied as a dependency, allowing the creator to own, share, and control that state independently.

## Transparent Construction

Instance construction must use primary constructors.

Construction exists only to supply an object with its dependencies and state. It must not compute derived values, observe dependencies, perform useful work, or cache values obtained from them.

Behavior and derived values must be expressed by members operating on the injected inputs.

## Aggregation Then Composition

Define the most general implementation first, with its dependencies exposed through the primary constructor.

More specific forms may then be composed by partially or fully supplying those dependencies through static factory properties or methods.

Composition must preserve the general injectable form. Callers must remain able to construct the object with explicitly supplied dependencies through its primary constructor.