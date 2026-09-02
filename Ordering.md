# General-to-Specific Order

An ordering scope is either the declarations within a type or the top-level type declarations that share a source file.

Within an ordering scope, arrange declarations so that code is read from general behavior toward its implementation details.

Nested type declarations participate in the same ordering as other declarations within their containing type.

When one declaration depends on another in the same ordering scope, prefer placing the dependent declaration before the declaration it uses.

The goal is to minimize backward navigation while reading: a reader should normally be able to continue downward into progressively more specific details rather than repeatedly return to earlier parts of the file.

Do not reorder declarations merely by visibility, declaration kind, or other syntactic categories when doing so would obscure the implementation structure.

# Semantic Locality

Keep declarations that form one local implementation fragment close together, even when strict dependency ordering would place them elsewhere. Semantic locality takes precedence when separating them would make the code harder to understand as a unit.

Nested and file-local types may be placed near the declarations that create or use them when this improves locality.

Ordering is intended to expose the structure of the implementation, not to enforce a total mechanical order. Where no meaningful dependency or locality relationship determines the position of two declarations, preserve the most natural existing order.