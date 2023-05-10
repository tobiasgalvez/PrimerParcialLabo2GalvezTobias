using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Fire
    {
        public static async Task<string> AddAsync()
        {
            FirestoreDb db = FirestoreDb.Create("nuevo-proyecto-43a01");

            // Create a document with a random ID in the "users" collection.
            CollectionReference collection = db.Collection("users");

            var docRef = db.Document("jugadores/nAjehOlk4fFR3IeH2Xar");
            var doc = await docRef.GetSnapshotAsync();

            Console.WriteLine(doc.GetValue<string>("nombre"));

            return doc.GetValue<string>("nombre");
        }
    }
}

