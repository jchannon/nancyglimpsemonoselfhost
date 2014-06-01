using System;
using Nancy;

namespace GlimpseConsole
{
	public class HomeModule : NancyModule
	{
		public HomeModule ()
		{
			Get ["/"] = _ => "Hello";
		}
	}
}

