# GIT

Amending the 'A' commit is easily done with rebase, (if it were the last commit aka B --amend would be better)

**git rebase -i @~2** // to pick the last two commits

using **e (edit)** for commit A and leaving B as pick

remove the typo

run **git rebase --continue**

done

B shouldn't be the same hash as before because rebasing actually creates brand new commits
