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

		public static Duraklar DurakEkle(Duraklar drk)
		{
			Duraklar duraklar = new Duraklar();
			duraklar.DurakAdi = drk.DurakAdi;
			duraklar.Aciklama = drk.Aciklama;

			var duraks=dataContext.Duraklars.Add(duraklar);
			dataContext.SaveChanges();
			return duraks;
		}


	}
}
