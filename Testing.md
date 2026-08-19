# Behavioral Propositions

Tests specify observable behavior of the system.

Each test must represent one coherent executable proposition about behavior rather than verify a particular implementation, member, or incidental call sequence.

Several observations or assertions may establish one proposition. Keep them in one test when they are jointly necessary to establish that proposition.

Separate independently meaningful propositions when combining them would make it unclear what behavior a failure disproves.

# Stable Test Boundaries

Test through the narrowest stable behavioral boundary that expresses the proposition clearly.

A test may exercise one member, one type, or several collaborating types. Production structure does not determine the test boundary.

Prefer behavior that forms part of the meaningful contract over incidental implementation details. A refactoring that preserves the specified behavior should not require changing the test.

Unit, component, integration, and similar categories are descriptive. Do not change the behavioral boundary merely to fit a category.

Organize test files around cohesive areas of behavior rather than production files, types, interfaces, or members.

# Test Representation

Use xUnit as the test framework.

Define tests as static methods in static classes.

Name each test after the behavioral proposition it establishes. Use a concise declarative name such as:

* `AddedAccountExists`
* `RemovedAccountCannotAuthenticate`
* `AwaitingDoesNotMatch`
* `OperationRunsOnce`

Do not encode setup, execution steps, implementation paths, or assertions into names through mechanical `Method_Scenario_Result`, `Given_When_Then`, or similar structures.

Use Shouldly for assertions.

Write assertions so that the proposition being established is apparent from the test body.

Prefer domain-relevant assertions over lower-level comparisons when an existing assertion expresses the proposition directly.

Introduce custom assertions when they express a recurring domain-level proposition more clearly than generic Shouldly assertions. Do not create wrappers that merely restate existing assertions.

# Test Environment

Each test method owns its test-specific state.

Construct the system under test, its dependencies, and mutable supporting objects within the test method or in objects created by it.

Do not store mutable test state in static fields or shared instances.

When a test needs an implementation of an abstraction, prefer a small explicit test implementation declared near the tests that use it over a dynamically configured mock.

Test support types such as fakes and builders exist only to make behavioral propositions clear and executable. Keep them local to the behavioral area that uses them unless they represent a genuinely shared testing concept.

Reusable support declarations may construct or represent mutable objects, but every mutable instance must remain owned by an individual test method.

# Change Verification

When implementing a behavioral change, determine the expected propositions from the requested behavior and existing contract before using the implementation as evidence of what should happen.

Treat existing tests as executable parts of the behavioral specification.

For non-trivial behavior that can be checked automatically, prefer verification through tests over successful compilation or inspection alone.

A test created while implementing or debugging a change may be used as a development instrument. Preserve it when it specifies stable expected behavior or protects against a meaningful regression.

A defect whose expected behavior can be expressed deterministically is a strong reason to add a regression test.

Do not preserve tests merely to increase coverage or record temporary implementation details.

Do not change an existing behavioral expectation merely to make a new implementation pass unless the requested change intentionally changes that behavior.