using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haken.ManagedHeap
{
	class Program
	{
		static void Main(string[] args)
		{
			const int count = 20;

			for (int i = 0; i < count; i++)
			{
				MyClass newInstance = new MyClass();
			}

			Debugger.Break();
		}
	}

	public class MyClass
	{
		private byte[] pole = new byte[1024];
	}
}
