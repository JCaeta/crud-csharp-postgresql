using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using crud_csharp_postgresql.Models;

namespace crud_csharp_postgresql.Persistence.Repositories
{
    public class ModelARepository<ModelA> : IRepository<ModelA>
    where ModelA : crud_csharp_postgresql.Models.ModelA
    {
        private NpgsqlConnection connection;
        private IReadStrategy<ModelA> readStrategy;

        public ModelARepository(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public ModelA create(ModelA item)
        {
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    using (var command = new NpgsqlCommand("INSERT INTO models_a (name) VALUES (@name) returning id;", connection, transaction))
                    {
                        command.Parameters.AddWithValue("@name", item.Name);
                        item.Id = System.Int32.Parse(command.ExecuteScalar().ToString());
                    }

                    if (item.ModelsB != null)
                    {
                        foreach (var modelB in item.ModelsB)
                        {
                            using (var command = new NpgsqlCommand("INSERT INTO rel_mod_a_mod_b (id_model_a, id_model_b) VALUES (@id_model_a, @id_model_b);", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@id_model_a", item.Id);
                                command.Parameters.AddWithValue("@id_model_b", modelB.Id);
                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();
                    return item;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public bool delete(ModelA item)
        {
            bool result = false;
            using (NpgsqlTransaction transaction = this.connection.BeginTransaction())
            {
                try
                {
                    string query1 = "delete from rel_mod_a_mod_b where id_model_a = " + item.Id;
                    string query2 = "delete from models_a where id = " + item.Id;
                    string fullQuery = query1 + ";" + query2 + ";";
                    NpgsqlCommand executor = new NpgsqlCommand(fullQuery, this.connection, transaction);
                    var reader = executor.ExecuteReader();
                    reader.Close();
                    transaction.Commit();
                    result = true;
                }catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
            return result;
        }

        public void setReadStrategy(IReadStrategy<ModelA> readStrategy)
        {
            this.readStrategy = readStrategy;
        }

        public List<ModelA> read(ModelA filter)
        {
            return this.readStrategy.read(this.connection);
        }

        public ModelA readOne(ModelA filter)
        {
            throw new NotImplementedException();
        }

        public bool update(ModelA item)
        {
            bool result = false;

            // Create queries
            string query1 = "delete from rel_mod_a_mod_b where id_model_a = " + item.Id + ";";
            string query2 = "update models_a set name = '" + item.Name + "' where id = " + item.Id + ";";
            string query3 = "";
            foreach(ModelB modelB in item.ModelsB)
            {
                string qry = "insert into rel_mod_a_mod_b(id_model_a, id_model_b) values (" + item.Id + ", " + modelB.Id + ");";
                query3 += qry;
            }
            
            using(NpgsqlTransaction transaction = this.connection.BeginTransaction())
            {
                try
                {
                    NpgsqlCommand executor = new NpgsqlCommand(query1 + query2 + query3, this.connection, transaction);
                    NpgsqlDataReader r = executor.ExecuteReader();
                    r.Close();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
            return result;
        }
    }
}
