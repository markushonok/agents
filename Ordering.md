# General-to-Specific Order

Arrange members so that code is read from general behavior toward its implementation details.

When one member depends on another, prefer placing the dependent member before the member it uses. Entry points and externally used behavior therefore tend to appear before their supporting implementation.

The goal is to minimize backward navigation while reading: a reader should normally be able to continue downward into progressively more specific details rather than repeatedly return to earlier parts of the file.

Do not reorder members merely by visibility, member kind, or other syntactic categories when doing so would obscure the implementation structure.

# Semantic Locality

Keep strongly related members close to each other.

Members that form one local implementation fragment may remain adjacent even when a strict dependency ordering would place them elsewhere. Semantic locality takes precedence when separating the members would make the code harder to understand as a unit.

Nested and file-local types may be placed near the members that create or use them when this improves locality.

Ordering is intended to expose the structure of the implementation, not to enforce a total mechanical order. Where no meaningful dependency or locality relationship determines the position of two members, preserve the most natural existing order.
