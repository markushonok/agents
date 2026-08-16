# Naming Entities

Name entities after what they **are**, not what they **do**.

Names such as `Handler`, `Processor`, `Validator`, `Sorter`, and `Builder` are code smells when they merely describe performers of actions. Prefer names describing an entity, state, role, or result.

The `-er` suffix is fine when the word denotes an entity in its own right, such as `Computer`, `User`, `Player`, `Server`, or `Manager` as a job title.

# Naming Members

Name members after the value they represent, regardless of member kind or implementation.

Values may represent entities, states, results, or actions. Name entities and results descriptively, and actions with verbs. An action is itself a value, so a property may also be named `Call`, `Save`, or `Close`.

If a member semantically represents a value, name that value even when getting it requires heavy computation, I/O, or other effects. Use a verb only when the represented value is itself an action, regardless of whether obtaining that action is pure or impure.

Follow ordinary language: “I used my phone to contact my current manager,” not “I used my GetPhone to contact my GetCurrentManager.”

Base names on semantics, not on retrieval, computation, or implementation mechanics.