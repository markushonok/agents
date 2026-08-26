# Declaration Scope

Choose the declaration scope of a type according to the scope in which the represented concept meaningfully exists.

Declaration scope expresses where an already justified type belongs. It must not determine whether a concept deserves a separate type. Apply the decomposition guidance in `Composition.*` independently before choosing how the resulting type is declared.

Prefer the narrowest declaration scope that accurately represents the concept without hiding an independently meaningful scope.

## Nested Types

Use a nested type when the represented concept meaningfully exists only as part of its containing type.

Nesting is appropriate for implementation concepts whose identity, purpose, or useful scope depends on the containing type.

Do not nest an independently scoped concept merely to hide it, reduce the public surface, avoid another source file, or keep related declarations physically together.

Semantic locality in `Ordering.*` governs the placement of nested types within the containing declaration.

## File-Local Types

Use a `file` type when a declaration conceptually belongs to the implementation represented by one source file but must exist at namespace scope.

This is appropriate when language or implementation constraints require a top-level declaration for something that has no independently useful scope outside the file.

Do not use `file` merely to colocate an independently scoped type with another declaration or to avoid giving such a type an independently discoverable file.

# Accessibility

Accessibility must express the conceptual visibility of a declaration rather than compensate for an unsuitable abstraction or declaration scope.

State accessibility explicitly when it represents a meaningful design decision.

An access modifier may be omitted when the surrounding language construct already determines the intended accessibility and writing the modifier would provide no additional information.

Do not restrict accessibility merely because a concrete type or member would otherwise expose an abstraction that has not been designed appropriately. Resolve the abstraction boundary instead; see `Abstraction.*`.

## Assembly Accessibility

Using `internal` is a **moderate smell** when the assembly boundary has no corresponding conceptual role in the design.

An assembly-local declaration is appropriate when the concept itself belongs to an assembly-level implementation boundary.

Do not use `internal` merely to hide a concrete implementation, avoid exposing a suitable abstraction, or contain a type whose proper declaration scope has not been determined.

## Protected Accessibility

Protected accessibility must follow from the intentional inheritance design of the containing type.

Do not introduce protected surface merely as an implementation convenience. Class inheritance and extensibility are governed by `Abstraction.*`.

# File Placement

Source files are part of type discoverability.

Place an independently scoped top-level type in a source file whose name matches the type name.

Several independently scoped top-level types with different names in one source file are a **moderate smell** because they make those types less directly discoverable through the file structure.

Nested and file-local types do not require independently named files because their declaration scope explicitly communicates that they do not represent independently discoverable concepts.

Do not choose a primary type name for a file and place otherwise independent declarations beside it merely because they are related or currently used together.