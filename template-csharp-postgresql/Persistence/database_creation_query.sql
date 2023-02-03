create table entities_a (
	id bigserial not null primary key,
	name text
);

create table entities_b (
	id bigserial not null primary key,
	name text
);

create table rel_entities_a_entities_b(
	id_rel_entity_a_entity_b bigserial not null primary key,
	id_entity_a int,
	id_entity_b int,
	constraint fk_entity_a foreign key(id_entity_a) references entities_a(id),
	constraint fk_entity_b foreign key(id_entity_b) references entities_b(id)
);