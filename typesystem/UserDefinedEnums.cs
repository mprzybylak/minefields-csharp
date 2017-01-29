using System;
namespace typesystem
{
	public static class UserDefinedEnums
	{
		public static void example()
		{
			Console.WriteLine("User defined enums");
			enumInitalization();
			usefulMethods();
			Console.WriteLine();
		}

		private static void enumInitalization()
		{
			// it is worth to have value = 0, because default initalization inits enum to o
			CalendarSeason defaultSeason = new CalendarSeason();
			FootballPosition defaultPosition = new FootballPosition();
			Console.WriteLine("This enum have default value: {0}, this doesn't have default value: {1}", defaultSeason, defaultPosition);

			// initalization by assigning one of values
			CalendarSeason winter = CalendarSeason.Winter;
			Console.WriteLine("Direct assignment of enum value to variable: {0}", winter);

			// no one can stop us for assigning value outside of scope of enum but in scope of underlying data type
			CalendarSeason strageCalendarSeason = (typesystem.CalendarSeason)200;
			Console.WriteLine("Assignment of value 200 to CalendarSeason results with: {0}", strageCalendarSeason);
		}

		private static void usefulMethods()
		{
			// returning enum for given value
			String thirdCalendarSeason = Enum.GetName(typeof(CalendarSeason), 3);
			Console.WriteLine("Third value of CalendarSeason enum is: {0}", thirdCalendarSeason);

			// returning all values of enum
			foreach (CalendarSeason season in Enum.GetValues(typeof(CalendarSeason)))
			{
				Console.WriteLine("Iterate over all Calendar Seasons: {0}", season);
			}
		}
	}

	public enum CalendarSeason
	{
		// winter = 0, spring = 1, etc.
		Winter, Spring, Summer, Autumn
	}

	public enum FootballPosition
	{
		// GK = 1, DF = 2, etc.
		GK = 1, DF, MF, AT
	}

	// we can change underlying data type for enum (for example to save memory)
	public enum ByteFootballPosition : byte
	{
		GK, DF, MF, AT
	}
}
