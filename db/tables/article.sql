CREATE TABLE public.article (

       id bigserial NOT NULL,

       code TEXT NOT NULL,

       name TEXT NOT NULL,

       description TEXT not NULL,

       price decimal NOT NULL,

       count bigint NULL,

       created_date timestamp NOT NULL,

       updated_date timestamp NULL,

       CONSTRAINT article_pkey PRIMARY KEY (id)

);