using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minefield
{
	public static class MineIncrease
	{

		public static int MineIncreaseLevel(ZorlukSeviyesi zorluk)
		{
			switch (zorluk)
			{
				case ZorlukSeviyesi.Kolay:
					return 14;

				case ZorlukSeviyesi.Orta:
					return 20;

				case ZorlukSeviyesi.Zor:
					return 30;

				default:
					return 25;
			}
		}
	}
}
