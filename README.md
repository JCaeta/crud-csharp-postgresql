## Documentation
https://caetaworks.web.app/blog/crud-postgresql-csharp

## How to use

1. Create a database in PostgreSQL.
2. Create the following tables using the provided queries:

```sql
CREATE TABLE models_a (
	id bigserial NOT NULL PRIMARY KEY,
	name text
);

CREATE TABLE models_b (
	id bigserial NOT NULL PRIMARY KEY,
	name text
);

CREATE TABLE rel_mod_a_mod_b (
	id bigserial NOT NULL PRIMARY KEY,
	id_model_a int,
	id_model_b int,
	CONSTRAINT fk_model_a FOREIGN KEY(id_model_a) REFERENCES models_a(id),
	CONSTRAINT fk_model_b FOREIGN KEY(id_model_b) REFERENCES models_b(id)
);
```

3. Execute the repository's code
- At the very first you will get a error message if you don't have the database information configured
![image](https://user-images.githubusercontent.com/63880187/224522345-879bb2b0-a323-4b1b-8bb3-1c9cce9dd52b.png)
- Click Ok and continue


4. Configure database information
- Go to "configure" option

![image](https://user-images.githubusercontent.com/63880187/224522381-0e1df33a-37fb-4299-bb9b-4c893275f501.png)

![image](https://user-images.githubusercontent.com/63880187/224522426-d416f0de-bcfc-4af3-9032-53db36420f5f.png)

5. Search for your PostgreSQL database information

![image](https://user-images.githubusercontent.com/63880187/224522475-3bb9eea6-3541-4fa9-b77b-2f61021e4e29.png)

6. Enter the information and press ok

![image](https://user-images.githubusercontent.com/63880187/224522505-5d2d2ad8-a1d6-410d-a7e3-b8c613a42681.png)

![image](https://user-images.githubusercontent.com/63880187/224522531-172f4ae7-e511-4f4a-ac97-8a114a9dd845.png)
