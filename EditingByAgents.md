# Editing Agent Documentation

Agent documentation defines rules that an agent can apply when working with the repository. When changing it, clarity, consistency, and the ability to apply each rule unambiguously must be preserved.

# Rule Content

Each rule must describe one verifiable norm: what is required, prohibited, allowed, or considered a code smell. Do not combine multiple independent requirements in one item.

Use terminology already adopted in the repository. If a new term is necessary, define it in the document before its first normative use.

Distinguish principles, code smells, anti-patterns, recommendations, and mandatory requirements. Do not strengthen wording without an explicit basis: a recommendation must not turn into a prohibition, and a code smell into an unconditional restriction.

Add rationale when it helps to understand the boundaries of a rule or make a decision in a non-standard situation. It must not replace the rule itself.

# Documentation Structure

Place a rule in the narrowest document to which it applies. Put general rules in `AGENTS.MD`, and topic-specific rules in a topic-specific document.

Maintain navigation in `AGENTS.MD`: each topical document must be listed with a brief description of its area of application.

Do not duplicate a rule in multiple documents. If a rule depends on another document, add a brief reference or explicitly state its scope.

# Change and Verification

Make the minimal changes necessary for the request. Preserve the language, heading style, and adopted list format in the edited document.

After the change, reread the affected documents in full or in relevant context and verify that the new rule does not contradict existing ones, has a clear scope, and is reflected in navigation.
