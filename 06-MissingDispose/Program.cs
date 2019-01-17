using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haken.MissingDispose
{
	class Program
	{
		static void Main(string[] args)
		{
			var bitmap1 = new Bitmap(4096, 4096);
			var bitmap2 = new Bitmap(4096, 4096);
			var bitmap3 = new Bitmap(4096, 4096);

			// bitmap1.Dispose();
			// bitmap2.Dispose();
			// bitmap3.Dispose();

			bitmap1 = null;
			bitmap2 = null;
			bitmap3 = null;
			GC.Collect();

			Debugger.Break();

			GC.WaitForPendingFinalizers();
			
			Debugger.Break();
		}
	}
}
