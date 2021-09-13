CREATE TABLE voter (
    id SERIAL PRIMARY KEY
);

CREATE TABLE referendum (
    id SERIAL PRIMARY KEY
);

CREATE TABLE question (
    id SERIAL PRIMARY KEY,
    referendum_id int references referendum(id)
);

CREATE TABLE vote (
    id SERIAL PRIMARY KEY,
    question_id int references question(id),
    voter_id int references voter(id),
    value boolean
);

CREATE INDEX vote_question_idx on vote(question_id);