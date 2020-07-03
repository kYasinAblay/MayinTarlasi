using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minefield
{
	public class TryCatch
	{
		public TryCatch()
		{

		}
		public void Trycatch(Action _action)
		{
			try
			{
				_action();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);

			}
		}
	}
}
