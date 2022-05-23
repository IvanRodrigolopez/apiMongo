using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Ng.Users
{
    public class User
    {
        public Vw.Respuestas.Result InsertUser(Vw.Users.VwUser user)
        {
            var result = new Vw.Respuestas.Result();
            try
            {
                user._id = MongoDB.Bson.ObjectId.GenerateNewId().ToString();
                user.Password = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(user.Password));
                result = new Dt.Mongo.MongoDbProvides().InsertUser(user);
                if (result.Resultado > 0)
                {
                    result.Mensaje = "Transaccion Aplicada";
                }
                return result;
            }
            catch (Exception e)
            {
                result.Resultado = -1;
                result.Mensaje=e.Message;
                return result;
            }
        }

        public IEnumerable<T> GetUserLogin<T>(string User, string Password)
        {
            try
            {
                //Password = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Password));
                var CollectionUser = new Dt.Mongo.MongoDbProvides().ConeccionUsers().GetCollection<T>("User");

                FilterDefinition<T> filter = Builders<T>.Filter.Eq("Usuario", User)
                    & Builders<T>.Filter.Eq("Password", Password);


                return CollectionUser.Find(filter).ToEnumerable();
            }
            catch { throw; }
        }
    }
}
