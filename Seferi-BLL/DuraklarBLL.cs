using Seferi_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seferi_BLL
{
	public class DuraklarBLL
	{


		public static SeferiEntities dataContext = new SeferiEntities();

		//public static Duraklar DurakEkle(Duraklar drk)
		//{
		//	Duraklar duraklar = new Duraklar();
		//	duraklar.DurakAdi = drk.DurakAdi;
		//	duraklar.Aciklama = drk.Aciklama;

		//	var duraks=dataContext.Duraklars.Add(duraklar);
		//	dataContext.SaveChanges();
		//	return duraks;
		//}


		public static Guzergahlar guzergah = new Guzergahlar();
		public static GuzergahDuraklari guzergahdurak = new GuzergahDuraklari();

		public static object  TumDuraklarıGetir()
		{
			
			return dataContext.Duraklars.ToList();
		}

        public static object InilenDurakGetir(int DurakID)
        {

            var durakid = dataContext.GuzergahDuraklaris.Where(x => x.DurakID == DurakID);
            var guzergahid = dataContext.GuzergahDuraklaris.Where(y => durakid.Any(x => x.GuzergahID == y.GuzergahID && x.Sira<y.Sira)).Select(
          y => new
          {
              
              y.DurakID,
              y.Duraklar.DurakAdi

          }
            );
            return guzergahid.ToList();
        }

		public static object GuzergahIsimGetir(int DurakID)
		{

			var durakid= dataContext.GuzergahDuraklaris.Where(x => x.DurakID == DurakID);
			var guzergahadi = dataContext.Guzergahlars.Where(y => durakid.Any(x => x.GuzergahID == y.GuzergahID)).Select(
		  y => new
		  {
			  y.GuzergahAdi,
			  y.GuzergahID

			}
			);

			return guzergahadi.ToList();
		}

		//public static List<GuzergahDuraklari> GuzergahlarlariGtir(int DurakID)
		//{
		//	return dataContext.GuzergahDuraklaris.Where(x => x.DurakID == DurakID).ToList();
			
		//}

		public static object SeferGetir(int GuzergahID)
		{

			return dataContext.Seferlers.Where(x => x.GuzergahID == GuzergahID).ToList();
			
		}


	}
}
