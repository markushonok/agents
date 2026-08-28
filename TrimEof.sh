#!/usr/bin/env bash

set -euo pipefail

root="$(git rev-parse --show-toplevel)"
cd "$root"

trim()
	{
		local file="$1"

		[ -f "$file" ] && [ ! -L "$file" ] || return

		# Skip binary files.
		grep -Iq -- '' "$file" || return

		perl -0pi -e 's/(?:\r\n|\r|\n)+\z//' -- "$file"
	}

while IFS= read -r -d '' file; do
	trim "$file"
done < <(
	git diff --name-only -z --diff-filter=ACMR
	git diff --cached --name-only -z --diff-filter=ACMR
	git ls-files --others --exclude-standard -z
)