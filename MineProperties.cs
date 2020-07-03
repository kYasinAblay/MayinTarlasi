using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minefield
{
	public class MineProperties
	{
		public static int X = 3, Y = 3;
		protected Random rnd { get; set; }
		public static int numberOfbombs { get; set; }
		public static int matrisX = 10;
		public static int matrisY = 10;
		public static int[] locations;

		public int k = 0;
		public int sayac = 0;

		
		public ZorlukSeviyesi zorluk { get; set; }


		public bool varmi = false, isReduced = false;

		public int numberBombs { get; set; }
		public int skor { get; set; }

	}
}
