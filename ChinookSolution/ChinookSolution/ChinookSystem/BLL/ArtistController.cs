using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Additional Namespaces
using System.ComponentModel; // for ODS
using ChinookSystem.Data.Entities;
using ChinookSystem.Data.POCOs;
using ChinookSystem.DAL;
#endregion
namespace ChinookSystem.BLL
{
    public class ArtistController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Artist> Artist_ListAll()
        {

            using (var context = new ChinookContext())
            {
                return context.Artists.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<ArtistAlbum> ArtistAlbums_Get(int year)
        {

            using (var context = new ChinookContext())
            {
                var results = from x in context.Albums
                              where x.ReleaseYear == year
                              orderby x.Artist.Name, x.Title
                              select new ArtistAlbum
                              {

                                  Name = x.Artist.Name,
                                  Title = x.Title
                              };

                return results.ToList();
            }
        }//eom
    }//eoc
}//eon

