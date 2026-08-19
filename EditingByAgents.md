# Editing Agent Documentation

Agent documentation teaches an agent how engineering decisions are made in the repository. When changing it, preserve clarity, consistency, and enough context to recognize when and how the guidance applies.

# Guidance Content

Describe engineering guidance in terms that allow an agent to recognize the applicable situation and choose the preferred design.

Use terminology already adopted in the repository. If a new term is necessary, define it before its first normative use.

Distinguish principles, good practices, light smells, moderate smells, strong smells, and mandatory requirements. Do not strengthen guidance without an explicit basis.

Prefer positive guidance that explains how to construct a fitting design. Use smells as diagnostic signals that help evaluate a decision, not as the primary means of deriving a design by elimination.

Add rationale, boundaries, trade-offs, and canonical examples when they help distinguish the preferred solution from other plausible designs.

# Documentation Structure

Place guidance in the narrowest document to which it applies.

Maintain navigation in `AGENTS.MD`: each topical document must be listed with a brief description of its area of application.

Do not duplicate guidance in multiple documents. If a rule depends on another document, add a brief reference or explicitly state its scope.

# Change and Verification

Make the minimal changes necessary for the request. Preserve the language, heading style, and adopted list format in the edited document.

After the change, reread the affected documents in full or in relevant context and verify that the new rule does not contradict existing ones, has a clear scope, and is reflected in navigation.
