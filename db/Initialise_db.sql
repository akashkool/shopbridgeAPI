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

INSERT INTO public.article
(code, "name", description, price, count, created_date, updated_date)
VALUES('sdfuh57838f84', 'Nescafe Coffee - 50 Gram', '50 Gram Nescafe Coffee', 50, 500, now(), now()),
('sdfuh5722238f84', 'Green Tea - 50 Gram', '50 Gram Green Tea', 600, 500, now(), now());
