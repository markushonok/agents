# Engineering Specification

This repository contains general engineering principles, conventions, and quality criteria applied to projects that reference it.

These rules define the engineering philosophy adopted by this specification. Do not replace them with generally accepted practices, alternative interpretations of SOLID, DRY, Clean Code, or conventions of specific frameworks.

# Instruction Precedence

The rules of this repository are general defaults.

Project-specific instructions take precedence over them. More local project instructions may further specialize rules for individual subsystems.

# Interpretation of Rules

* A **principle** defines a fundamental preferred design direction.
* A **good practice** describes a preferred practical way to design or implement something.
* A **light smell** is a weak negative signal. By itself, it normally does not justify changing the design.
* A **moderate smell** is a meaningful negative signal that warrants deliberate re-evaluation of the decision.
* A **strong smell** is strong evidence of a poor design decision and should normally be avoided unless the specific context provides sufficient justification.
* Explicit prohibitions and mandatory requirements must be understood literally.

Smells are diagnostic guidance. Do not construct a design by mechanically eliminating smells or satisfying structural thresholds.

# Navigation

Do not load all documentation unnecessarily. Read only the documents relevant to the current task.

Topic-specific documentation may have a companion `.cs` file with the same name containing canonical examples. When reading a topic-specific document, read its companion example file if one exists.

Treat canonical examples as demonstrations of how the applicable principles compose in actual code and use them as a style reference when implementing similar code.

* `Abstractions.md` — working with interfaces, abstractions, subtyping, and inheritance.
* `EditingByAgents.md` — rules for editing agent documentation.
* `Naming.md` — principles and rules for naming entities and their members.
* `Implementations.md` — principles and rules for structuring implementations, decomposition, and implementation details.
* `Ordering.md` — principles and rules for member ordering, implementation reading flow, and semantic locality.
* `Testing.md` — principles and rules for behavioral specification, test organization, assertions, and development verification.
