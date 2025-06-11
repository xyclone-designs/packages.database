using System;

namespace XycloneDesigns.Database.SouthAfricanCensus.Structs
{
	public struct Uncertain
	{
		public static Uncertain<TTValue>? From<TTValue>(int? value)
		{
			return From<TTValue>(value.ToString());
		}
		public static Uncertain<TTValue>? From<TTValue>(string? str) 
		{
			if (str is null)
				return null;

			if (str == nameof(Uncertain<TTValue>.Unspecified))
				return new Uncertain<TTValue> { Unspecified = true };

			if (Enum.TryParse(str, out NotAvailables notavailable))
				return new Uncertain<TTValue> { NotAvailable = notavailable };

			return true switch
			{
				true when 
					typeof(TTValue) == typeof(int) && 
					int.TryParse(str, out int _int) &&
					_int is TTValue __int => new Uncertain<TTValue> { Value = __int },

				true when 
					typeof(TTValue) == typeof(bool) && 
					bool.TryParse(str, out bool _bool) &&
					_bool is TTValue __bool => new Uncertain<TTValue> { Value = __bool },

				true when 
					typeof(TTValue) == typeof(double) && 
					double.TryParse(str, out double _double) &&
					_double is TTValue __double => new Uncertain<TTValue> { Value = __double },

				true when 
					typeof(TTValue) == typeof(decimal) && 
					decimal.TryParse(str, out decimal _decimal) &&
					_decimal is TTValue __decimal => new Uncertain<TTValue> { Value = __decimal },

				true when 
					typeof(TTValue) == typeof(Enum) && 
					Enum.TryParse(typeof(TTValue), str, true, out object? _enum) && 
					_enum is TTValue __enum => new Uncertain<TTValue> { Value = __enum },

				_ => new Uncertain<TTValue> { },
			};
		}
	}
	public struct Uncertain<TValue> 
	{
		public TValue? Value { get; set; }
		public bool Unspecified { get; set; }
		public NotAvailables? NotAvailable { get; set; }

		public override string ToString()
		{
			if (Unspecified)
				return nameof(Unspecified);

			if (NotAvailable.HasValue)
				return NotAvailable.Value.ToString();

			return Value?.ToString() ?? string.Empty;
		}
	}
}