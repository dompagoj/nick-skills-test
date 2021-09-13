# Voting

See **voting.sql**

The index is on question_id inside the vote table to quickly know the results of a given referendum question.

Also the "value" column in vote is boolean because the tasks says it can only ever be YES or NO but in reality I wouldn't
do this because likely we would need to support more options in the future, so the ideal type would be a native enum in postgres
or just a string in db-s which don't have enum support.

As for the privacy, two things come to mind, if we don't need the voter's personal information we could simply hash
his lets say OIB or some kind of UID, that way no one could know who the voter is but the voter himself could access
his voting history by providing his OIB which would again be hashed and queried for answers, this also wouldn't introduce
additional tables, if we need the info though, we could add another table for it linked to the voter which would maybe we
hidden behind a role of somekind.