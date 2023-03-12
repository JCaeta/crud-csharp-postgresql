create table models_a (
	id bigserial not null primary key,
	name text
);

create table models_b (
	id bigserial not null primary key,
	name text
);

create table rel_mod_a_mod_b(
	id bigserial not null primary key,
	id_model_a int,
	id_model_b int,
	constraint fk_model_a foreign key(id_model_a) references models_a(id),
	constraint fk_model_b foreign key(id_model_b) references models_b(id)
);