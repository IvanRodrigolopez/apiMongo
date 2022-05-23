using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Prueba.Dt.Mongo
{
    public class MongoDbProvides
    {
        public IMongoDatabase ConeccionUsers()
        {
            var dbClient = new MongoClient("mongodb://127.0.0.1:27017");

            IMongoDatabase db = dbClient.GetDatabase("Pruebas");

            return db;
        }

        public Vw.Respuestas.Result InsertUser(Vw.Users.VwUser user)
        {
            var result = new Vw.Respuestas.Result();
            try
            {
                var User = this.ConeccionUsers().GetCollection<BsonDocument>("User");
                user._id = MongoDB.Bson.ObjectId.GenerateNewId().ToString();

                User.InsertOne(user.ToBsonDocument());
                result.Resultado = 1;
                result.Mensaje = "El Usuario Fue Insertado Correctamente";
                return result;
            }
            catch (Exception ex)
            {
                result.Resultado = -1;
                result.Mensaje = ex.Message;
                //Console.WriteLine(ex.Message);
                return result;
            }
        }

       
    }
}
