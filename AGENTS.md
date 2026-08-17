# Engineering Specification

This repository contains general engineering principles, conventions, and quality criteria applied to projects that reference it.

These rules define the engineering philosophy adopted by this specification. Do not replace them with generally accepted practices, alternative interpretations of SOLID, DRY, Clean Code, or conventions of specific frameworks.

# Instruction Precedence

The rules of this repository are general defaults.

Project-specific instructions take precedence over them. More local project instructions may further specialize rules for individual subsystems.

# Interpretation of Rules

* A **principle** defines the preferred design direction.
* A **code smell** is not a prohibition, but requires stopping to re-evaluate the decision. Any deviation requires deliberate justification.
* An **antipattern** should be avoided unless more specific project requirements explicitly justify the opposite.
* The phrase **"as a rule"** establishes a strong default that allows justified exceptions.
* Explicit prohibitions and mandatory requirements must be understood literally.

Do not turn code smells into unconditional restrictions.

# Navigation

Do not load all documentation unnecessarily. Read only the documents relevant to the current task.

Topic-specific documentation may have a companion `.cs` file with the same name containing canonical examples. When reading a topic-specific document, read its companion example file if one exists.

Treat canonical examples as demonstrations of how the applicable principles compose in actual code and use them as a style reference when implementing similar code.

* `Abstractions.md` — working with interfaces, abstractions, subtyping, and inheritance.
* `EditingByAgents.md` — rules for editing agent documentation.
* `Naming.md` — principles and rules for naming entities and their members.
* `Implementations.md` — principles and rules for structuring implementations, decomposition, and implementation details.
* `Ordering.md` — principles and rules for member ordering, implementation reading flow, and semantic locality.
