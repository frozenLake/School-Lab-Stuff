using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06
{
	static class Global
	{
		private static bool _loggedIn = false;

		public static bool loggedIn
		{
			get { return _loggedIn; }
			set { _loggedIn = value; }
		}
	}
}
