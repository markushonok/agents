# Overview

Shared engineering specification for coding agents used across multiple software projects.

The repository provides a single source of project-independent engineering instructions that can be referenced without duplicating them across individual repositories.

[`AGENTS.md`](./AGENTS.md) is the entry point to the specification.

# Installation

Add the repository to a project as a Git submodule:

```sh
git submodule add <repository-url> <path>
```

Reference the submodule specification from the project's root `AGENTS.md` so that agents discover and apply it:

```md
Follow the engineering specification in `<path>/AGENTS.md`.
```

Project-specific instructions in the root `AGENTS.md` may specialize or override the shared specification.