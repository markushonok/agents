# Naming Entities

Name entities after what they **are**, not what they **do**.

Names such as `Handler`, `Processor`, `Validator`, `Sorter`, and `Builder` are code smells when they merely describe performers of actions. Prefer names describing an entity, state, role, or result.

The `-er` suffix is fine when the word denotes an entity in its own right, such as `Computer`, `User`, `Player`, `Server`, or `Manager` as a job title.

# Naming Members

Name members after what they semantically represent, not after how they are implemented or what type they return.

Members may represent entities, states, results, or actions. Name non-action values descriptively and actions with verbs.

An action may itself be represented as a value, so member kind does not determine its naming. An action is named with a verb whether it is represented as a value or performed by evaluating the member.

If a member represents a non-action value, name that value even when obtaining it requires heavy computation, I/O, mutation, or other effects. Retrieval and implementation mechanics do not determine the name.

Prepositions may express the semantic relationship represented by a member. Prefer ordinary-language forms such as From, To, At, Of, With, Between, or By when they describe how the represented value relates to its arguments or context.