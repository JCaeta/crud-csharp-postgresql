/*---------------------------------------------------------------------- Strategy ReadAllEntitiesA*/
select 
	entities_a.id as ent_a_id,
	entities_a.name as ent_a_name,
	entities_b.id as ent_b_id,
	entities_b.name as ent_b_name 
from entities_a 
full join rel_entities_a_entities_b on entities_a.id = rel_entities_a_entities_b.id_entity_a  
full join entities_b on entities_b.id = rel_entities_a_entities_b.id_entity_b;


