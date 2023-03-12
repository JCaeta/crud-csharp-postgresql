/*---------------------------------------------------------------------- Strategy ReadAllEntitiesA*/
select 
	models_a.id as mod_a_id,
	models_a.name as mod_a_name,
	models_b.id as mod_b_id,
	models_b.name as mod_b_name 
from models_a 
full join rel_mod_a_mod_b on models_a.id = rel_mod_a_mod_b.id_model_a  
full join models_b on models_b.id = rel_mod_a_mod_b.id_model_b;

/*---------------------------------------------------------------------- Strategy ReadEntityAOption2*/
select
    models_a.id as mod_a_id,
    models_a.name as mod_a_name,
    models_b.id as mod_b_id,
    models_b.name as mod_b_name
from models_a
    full join rel_mod_a_mod_b as relAB on models_a.id = relAB.id_model_a
    full join models_b on models_b.id = relAB.id_model_b 
where models_a.name = @name;

/*---------------------------------------------------------------------- Strategy ReadEntityAOption1*/
select
    models_a.id as mod_a_id,
    models_a.name as mod_a_name,
    models_b.id as mod_b_id,
    models_b.name as mod_b_name
from models_a
full join rel_mod_a_mod_b as relAB on models_a.id = relAB.id_model_a
full join models_b on models_b.id = relAB.id_model_b
where models_a.id in (
	select models_a.id 
	from models_a
	full join rel_mod_a_mod_b as relAB on models_a.id = relAB.id_model_a
	full join models_b on models_b.id = relAB.id_model_b
	where models_b.name = @name
);

