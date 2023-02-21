using System;
using System.IO;

namespace com.venkat.framework.core
{

	public sealed class ISettings
	{
		private static IProperties Properties = LoadFromPropertiesFile();

		public static IProperties Instance
		{
			get
			{				
				return Properties;
			}
		}

		private static IProperties LoadFromPropertiesFile()
		{
			IProperties Properties = null;
			FrameworkParameters FrameworkParameter = FrameworkParameters.Instance;
			if (FrameworkParameter.RelativePath == null)
			{
				String RelativePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
				FrameworkParameter.RelativePath = RelativePath;
			}

			if (FrameworkParameter.RelativePath == null)
			{
				throw new FrameworkException("FrameworkParameters.relativePath is not set!");
			}
			try
			{
				Properties = new IProperties(FrameworkParameter.RelativePath + Util.FileSeparator + "GlobalSettings.config");
					                       
			}
			catch (FileNotFoundException e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
				throw new FrameworkException("FileNotFoundException while loading the Global Settings file");
			}
			catch (IOException e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
				throw new FrameworkException("IOException while loading the Global Settings file");
			}
			return Properties;
		}

	}
}
