using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minefield
{
	public class mineInserter : MineProperties
	{
		public mineInserter()
		{
			MineInserter();
		}
		
		public int[] MineInserter()
		{
			int mayinLocation = 0;
			Random rnd2 = new Random();

			for (int i = 0; i < numberOfbombs; i++)
			{
				mayinLocation = rnd2.Next(84);
				int a = Array.IndexOf(locations, mayinLocation, 0, locations.Length) == -1 ? locations[i] = mayinLocation : i-- & rnd2.Next(numberOfbombs + 1);
			}
			return locations;
		}

		
		
	}
}