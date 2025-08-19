using System;
using System.Collections.Generic;

namespace webCinestar_webForm_1808.Controllers
{
    public class CinestarController
    {
        Db db = new Db("cnCinestar");

        internal object getCines()
        {
            db.Sentecial("sp_getCines");
            return db.getDataTable();
        }

        internal object getPeliculas(string id)
        {
            db.Sentecial("sp_getPeliculas "+ (id == "cartelera" ? 1 : 2));
            return db.getDataTable();
        }

        internal object getPelicula(String id)
        {
            db.Sentecial("sp_getPelicula " + (id == "cartelera" ? 1 : 2));
            return db.getDataTable();
        }
    }
}