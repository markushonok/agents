# Engineering Specification

This repository contains general engineering principles, conventions, and quality criteria applied to projects that reference it.

These rules define the engineering philosophy adopted by this specification. Do not replace them with generally accepted practices, alternative interpretations of SOLID, DRY, Clean Code, or conventions of specific frameworks.

# Instruction Precedence

The rules of this repository are general defaults.

Project-specific instructions take precedence over them. More local project instructions may further specialize rules for individual subsystems.

# Paths

Documentation uses the following abstract paths:

* `<project>` — the root directory of the project being worked on.
* `<programming>` — the directory containing this specification's `AGENTS.md`.

# Interpretation of Rules

* A **principle** defines a fundamental preferred design direction.
* A **good practice** describes a preferred practical way to design or implement something.
* A **light smell** is a weak negative signal. By itself, it normally does not justify changing the design.
* A **moderate smell** is a meaningful negative signal that warrants deliberate re-evaluation of the decision.
* A **strong smell** is strong evidence of a poor design decision and should normally be avoided unless the specific context provides sufficient justification.
* Explicit prohibitions and mandatory requirements must be understood literally.

Smells are diagnostic guidance. Do not construct a design by mechanically eliminating smells or satisfying structural thresholds.

# Selecting Applicable Topics

Before editing code, identify the kinds of changes the task may require and read every topic whose `Read when` condition matches.

Re-evaluate the applicable topics whenever the implementation introduces a kind of change that was not expected during preparation. Read any newly applicable topic before continuing.

For an applicable topic, read its `<Topic>.md` as the primary normative source. Other files with the same stem may provide supporting material relevant to the topic.

Treat canonical examples as demonstrations of how the applicable principles compose in actual code and use them as a style reference when implementing similar code.

| Topic | Read when |
| --- | --- |
| `Abstraction.*` | Adding or changing an interface or inheritance relationship |
| `Composition.*` | Changing object construction, state ownership, or decomposition |
| `Concurrency.*` | Adding or changing synchronization, atomicity, or thread-safety guarantees |
| `Declaration.*` | Changing declaration scope, accessibility, nesting, or source-file placement |
| `Formatting.*` | Changing source layout, line wrapping, or structural formatting |
| `Naming.*` | Introducing or renaming a symbol |
| `Ordering.*` | Adding, removing, or reordering declarations within a type or top-level type declarations within a source file, or introducing or changing a dependency between such declarations |
| `Reflection.*` | Adding runtime type inspection, downcasting, or reflection |
| `Testing.*` | Changing observable behavior or fixing a defect |
| `META.*` | Changing this engineering specification |

A topic becomes applicable because of the implementation being performed, not only because of the wording of the original task.

# Change Completion

Before reporting the task as complete:

1. Inspect the complete diff.
2. Identify the topics applicable to the final diff.
3. Verify the diff against every applicable topic.
4. Resolve every violation or report it explicitly.
5. Run `<programming>/TrimEof.sh` from `<project>`.