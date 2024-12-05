using System;

using System.Collections;

using System.Collections.Generic;

using System.Diagnostics;

using System.Globalization;

using System.Linq;

using System.Reflection;

using System.Runtime.CompilerServices;

using System.Runtime.InteropServices;

using System.Runtime.Versioning;

using System.Text;

using Microsoft.CodeAnalysis;


//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
namespace Microsoft.CodeAnalysis
{
}
namespace System.Runtime.CompilerServices
{
}
namespace Elements.Quantity
{
	public enum CompoundZeroHandling
	{
		LeaveAll,
		TrimBeginning,
		RemoveAny
	}
	public class CompoundFormatInfo<T> : ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantity<T>
	{
		public class Info : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public Unit<T> Unit
			{
				get
				{
					return (Unit<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Unit"), typeof(Unit<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Unit", value);
				}
			}

			public string OverrideUnitName
			{
				get
				{
					return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OverrideUnitName"), typeof(string));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OverrideUnitName", value);
				}
			}

			public string OverrideSeparator
			{
				get
				{
					return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OverrideSeparator"), typeof(string));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OverrideSeparator", value);
				}
			}

			public string OverrideNumberFormat
			{
				get
				{
					return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OverrideNumberFormat"), typeof(string));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OverrideNumberFormat", value);
				}
			}

			public CompoundZeroHandling? OverrideZeroHandling
			{
				get
				{
					return (CompoundZeroHandling?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OverrideZeroHandling"), typeof(CompoundZeroHandling?));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OverrideZeroHandling", value);
				}
			}

			public Info(Unit<T> unit, string overrideUnitName = null, string overrideSeparator = null, string overrideNumberFormat = null, CompoundZeroHandling? overrideZeroHandling = null)
			{
				Unit = unit;
				OverrideUnitName = overrideUnitName;
				OverrideSeparator = overrideSeparator;
				OverrideNumberFormat = overrideNumberFormat;
				OverrideZeroHandling = overrideZeroHandling;
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public Info(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private string defaultSeparator
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "defaultSeparator"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "defaultSeparator", value);
			}
		}

		private Info[] formatInfo
		{
			get
			{
				return (Info[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "formatInfo"), typeof(Info[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "formatInfo", value);
			}
		}

		public string LastNumberFormat
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LastNumberFormat"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LastNumberFormat", value);
			}
		}

		public string NumberFormat
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "NumberFormat"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "NumberFormat", value);
			}
		}

		public CompoundZeroHandling ZeroHandling
		{
			get
			{
				return (CompoundZeroHandling)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ZeroHandling"), typeof(CompoundZeroHandling));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ZeroHandling", value);
			}
		}

		public bool UseLongNames
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UseLongNames"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UseLongNames", value);
			}
		}

		public bool DiscardLastFraction
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DiscardLastFraction"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DiscardLastFraction", value);
			}
		}

		public int UnitCount => formatInfo.Length;

		public CompoundFormatInfo(string defaultSeparator, string lastNumberFormat, CompoundZeroHandling zeroHandling, bool useLongNames, bool discardLastFraction, params Info[] formatInfo)
			: this(defaultSeparator, lastNumberFormat, zeroHandling, useLongNames, discardLastFraction, (IEnumerable<Info>)formatInfo)
		{
		}

		public CompoundFormatInfo(string defaultSeparator, string lastNumberFormat, CompoundZeroHandling zeroHandling, bool useLongNames, bool discardLastFraction, IEnumerable<Info> formatInfo)
		{
			ZeroHandling = zeroHandling;
			UseLongNames = useLongNames;
			LastNumberFormat = lastNumberFormat;
			DiscardLastFraction = discardLastFraction;
			this.defaultSeparator = defaultSeparator;
			List<Info> list = new List<Info>(formatInfo);
			list.Sort((Info a, Info b) => a.Unit.CompareTo(b.Unit));
			list.Reverse();
			this.formatInfo = list.ToArray();
		}

		public Unit<T> GetUnit(int index)
		{
			return (Unit<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetUnit", index), typeof(Unit<T>));
		}

		public string GetSeparator(int index)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetSeparator", index), typeof(string));
		}

		public string GetUnitName(int index)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetUnitName", index), typeof(string));
		}

		public string GetNumberFormat(int index)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetNumberFormat", index), typeof(string));
		}

		public CompoundZeroHandling GetZeroHandling(int index)
		{
			return (CompoundZeroHandling)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetZeroHandling", index), typeof(CompoundZeroHandling));
		}

		public CompoundFormatInfo<T> OverrideLastNumberFormat(string format)
		{
			return (CompoundFormatInfo<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OverrideLastNumberFormat", format), typeof(CompoundFormatInfo<T>));
		}

		public CompoundFormatInfo<T> OverrideSeparator(string separator)
		{
			return (CompoundFormatInfo<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OverrideSeparator", separator), typeof(CompoundFormatInfo<T>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CompoundFormatInfo(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class SmartQuantityException : Exception, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public SmartQuantityException(string message, Exception innerException = null)
			: base(message, innerException)
		{
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public SmartQuantityException(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class UnitNameNotFoundException : SmartQuantityException, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public string UnitName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UnitName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UnitName", value);
			}
		}

		public UnitNameNotFoundException(string unitName, Exception innerException = null)
			: base("Specified unit name isn't defined by any of the units.", innerException)
		{
			UnitName = unitName;
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public UnitNameNotFoundException(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct QVector3<T> : ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantity<T>
	{
		public T x
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "x"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "x", value);
			}
		}

		public T y
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "y"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "y", value);
			}
		}

		public T z
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "z"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "z", value);
			}
		}

		public T SqrMagnitude => default(T).New(x.BaseValue * x.BaseValue + y.BaseValue * y.BaseValue + z.BaseValue * z.BaseValue);

		public T Magnitude => default(T).New(Math.Sqrt(SqrMagnitude.BaseValue));

		public QVector3<T> Normalized => this / Magnitude.BaseValue;

		public T this[int axis] => axis switch
		{
			0 => x, 
			1 => y, 
			2 => z, 
			_ => throw new Exception("Wrong QVector3 axis index. Must be between 0 and 2"), 
		};

		public static QVector3<T> Zero => new QVector3<T>(0.0, 0.0, 0.0);

		public static QVector3<T> One => new QVector3<T>(1.0, 1.0, 1.0);

		public QVector3(double x, double y, double z)
		{
			T val = default(T);
			this.x = val.New(x);
			this.y = val.New(y);
			this.z = val.New(z);
		}

		public QVector3(T x, T y, T z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public string FormatAs(Unit<T> unit, string formatNum = null, bool longName = false)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FormatAs", unit, formatNum, longName), typeof(string));
		}

		public string FormatAuto(string formatNum = null, bool longName = false, List<UnitGroup> unitGroups = null)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FormatAuto", formatNum, longName, unitGroups), typeof(string));
		}

		public static QVector3<T> operator +(QVector3<T> a, QVector3<T> b)
		{
			return new QVector3<T>(a.x.Add(b.x), a.y.Add(b.y), a.z.Add(b.z));
		}

		public static QVector3<T> operator -(QVector3<T> a, QVector3<T> b)
		{
			return new QVector3<T>(a.x.Subtract(b.x), a.y.Subtract(b.y), a.z.Subtract(b.z));
		}

		public static QVector3<T> operator *(QVector3<T> v, double n)
		{
			return new QVector3<T>(v.x.Multiply(n), v.y.Multiply(n), v.z.Multiply(n));
		}

		public static QVector3<T> operator /(QVector3<T> v, double n)
		{
			return new QVector3<T>(v.x.Divide(n), v.y.Divide(n), v.z.Divide(n));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public QVector3(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class SI<T> where T : struct, IQuantitySI<T>
	{
		public static UnitSI<T> Quecto
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Quecto"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Quecto", value);
			}
		}

		public static UnitSI<T> Ronto
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Ronto"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Ronto", value);
			}
		}

		public static UnitSI<T> Yocto
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Yocto"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Yocto", value);
			}
		}

		public static UnitSI<T> Zepto
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Zepto"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Zepto", value);
			}
		}

		public static UnitSI<T> Atto
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Atto"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Atto", value);
			}
		}

		public static UnitSI<T> Femto
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Femto"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Femto", value);
			}
		}

		public static UnitSI<T> Pico
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Pico"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Pico", value);
			}
		}

		public static UnitSI<T> Nano
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Nano"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Nano", value);
			}
		}

		public static UnitSI<T> Micro
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Micro"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Micro", value);
			}
		}

		public static UnitSI<T> Milli
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Milli"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Milli", value);
			}
		}

		public static UnitSI<T> Centi
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Centi"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Centi", value);
			}
		}

		public static UnitSI<T> Deci
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Deci"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Deci", value);
			}
		}

		public static UnitSI<T> Deca
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Deca"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Deca", value);
			}
		}

		public static UnitSI<T> Hecto
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Hecto"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Hecto", value);
			}
		}

		public static UnitSI<T> Kilo
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Kilo"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Kilo", value);
			}
		}

		public static UnitSI<T> Mega
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Mega"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Mega", value);
			}
		}

		public static UnitSI<T> Giga
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Giga"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Giga", value);
			}
		}

		public static UnitSI<T> Tera
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Tera"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Tera", value);
			}
		}

		public static UnitSI<T> Peta
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Peta"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Peta", value);
			}
		}

		public static UnitSI<T> Exa
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Exa"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Exa", value);
			}
		}

		public static UnitSI<T> Zetta
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Zetta"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Zetta", value);
			}
		}

		public static UnitSI<T> Yotta
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Yotta"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Yotta", value);
			}
		}

		public static UnitSI<T> Ronna
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Ronna"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Ronna", value);
			}
		}

		public static UnitSI<T> Quetta
		{
			get
			{
				return (UnitSI<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Quetta"), typeof(UnitSI<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Quetta", value);
			}
		}
	}
	public class UnitNonLinear<T> : Unit<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantity<T>
	{
		private Func<double, double> convertToFunc
		{
			get
			{
				return (Func<double, double>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "convertToFunc"), typeof(Func<double, double>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "convertToFunc", value);
			}
		}

		private Func<double, double> convertFromFunc
		{
			get
			{
				return (Func<double, double>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "convertFromFunc"), typeof(Func<double, double>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "convertFromFunc", value);
			}
		}

		public UnitNonLinear(Func<double, double> convertToFunc, Func<double, double> convertFromFunc, ICollection<UnitGroup> unitGroups, string[] shortNames, string[] longNames)
			: base(0.0, unitGroups, shortNames, longNames)
		{
			this.convertToFunc = convertToFunc;
			this.convertFromFunc = convertFromFunc;
		}

		public override T ConvertFrom(double val)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ConvertFrom", val), typeof(T));
		}

		public override double ConvertTo(T q)
		{
			return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ConvertTo", q), typeof(double));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public UnitNonLinear(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Acceleration : IQuantity<Acceleration>, IQuantity, IComparable<Acceleration>, IEquatable<Acceleration>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public double BaseValue
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BaseValue"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BaseValue", value);
			}
		}

		public static Unit<Acceleration> MetersPerSecondPerSecond
		{
			get
			{
				return (Unit<Acceleration>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "MetersPerSecondPerSecond"), typeof(Unit<Acceleration>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "MetersPerSecondPerSecond", value);
			}
		}

		double IQuantity.BaseValue => BaseValue;

		public Unit<Acceleration> DefaultUnit => MetersPerSecondPerSecond;

		public Acceleration(double baseValue = 0.0)
		{
			this = default(Acceleration);
			BaseValue = baseValue;
		}

		public bool Equals(Acceleration other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public int CompareTo(Acceleration other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public Acceleration New(double baseVal)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "New", baseVal), typeof(Acceleration));
		}

		public Acceleration Add(Acceleration q)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", q), typeof(Acceleration));
		}

		public Acceleration Subtract(Acceleration q)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", q), typeof(Acceleration));
		}

		public Acceleration Multiply(double n)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", n), typeof(Acceleration));
		}

		public Acceleration Multiply(Acceleration a, Ratio r)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", a, r), typeof(Acceleration));
		}

		public Acceleration Multiply(Ratio r, Acceleration a)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", r, a), typeof(Acceleration));
		}

		public Acceleration Divide(double n)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", n), typeof(Acceleration));
		}

		public Ratio Divide(Acceleration q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", q), typeof(Ratio));
		}

		public static Acceleration Parse(string str, Unit<Acceleration> defaultUnit = null)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Acceleration));
		}

		public static bool TryParse(string str, out Acceleration q, Unit<Acceleration> defaultUnit = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, q, defaultUnit), typeof(bool));
		}

		public static Acceleration operator +(Acceleration a, Acceleration b)
		{
			return a.Add(b);
		}

		public static Acceleration operator -(Acceleration a, Acceleration b)
		{
			return a.Subtract(b);
		}

		public static Acceleration operator *(Acceleration a, double n)
		{
			return a.Multiply(n);
		}

		public static Acceleration operator /(Acceleration a, double n)
		{
			return a.Divide(n);
		}

		public static Ratio operator /(Acceleration a, Acceleration b)
		{
			return a.Divide(b);
		}

		public static Acceleration operator -(Acceleration a)
		{
			return a.Multiply(-1.0);
		}

		public static Velocity operator *(Acceleration a, Time t)
		{
			return new Velocity(a.BaseValue * t.BaseValue);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Acceleration(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Angle : IQuantitySI<Angle>, IQuantitySI, IQuantity<Angle>, IQuantity, IComparable<Angle>, IEquatable<Angle>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public double BaseValue
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BaseValue"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BaseValue", value);
			}
		}

		public static Unit<Angle> Radian
		{
			get
			{
				return (Unit<Angle>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "Radian"), typeof(Unit<Angle>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "Radian", value);
			}
		}

		public static Unit<Angle> Degree
		{
			get
			{
				return (Unit<Angle>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "Degree"), typeof(Unit<Angle>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "Degree", value);
			}
		}

		public static Unit<Angle> ArcMinute
		{
			get
			{
				return (Unit<Angle>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "ArcMinute"), typeof(Unit<Angle>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "ArcMinute", value);
			}
		}

		public static Unit<Angle> ArcSecond
		{
			get
			{
				return (Unit<Angle>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "ArcSecond"), typeof(Unit<Angle>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "ArcSecond", value);
			}
		}

		public static CompoundFormatInfo<Angle> DegreeMinSec
		{
			get
			{
				return (CompoundFormatInfo<Angle>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "DegreeMinSec"), typeof(CompoundFormatInfo<Angle>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "DegreeMinSec", value);
			}
		}

		double IQuantity.BaseValue => BaseValue;

		public double SIPower => 1.0;

		public Unit<Angle> DefaultUnit => Radian;

		public Angle(double baseValue = 0.0)
		{
			this = default(Angle);
			BaseValue = baseValue;
		}

		public bool Equals(Angle other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public int CompareTo(Angle other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public IUnit[] GetCommonSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetCommonSIUnits"), typeof(IUnit[]));
		}

		public IUnit[] GetExludedSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetExludedSIUnits"), typeof(IUnit[]));
		}

		public Angle New(double baseVal)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "New", baseVal), typeof(Angle));
		}

		public Angle Add(Angle q)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", q), typeof(Angle));
		}

		public Angle Subtract(Angle q)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", q), typeof(Angle));
		}

		public Angle Multiply(double n)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", n), typeof(Angle));
		}

		public Angle Multiply(Angle a, Ratio r)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", a, r), typeof(Angle));
		}

		public Angle Multiply(Ratio r, Angle a)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", r, a), typeof(Angle));
		}

		public Angle Divide(double n)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", n), typeof(Angle));
		}

		public Ratio Divide(Angle q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", q), typeof(Ratio));
		}

		public static Angle Parse(string str, Unit<Angle> defaultUnit = null)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Angle));
		}

		public static bool TryParse(string str, out Angle q, Unit<Angle> defaultUnit = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, q, defaultUnit), typeof(bool));
		}

		public static Angle operator +(Angle a, Angle b)
		{
			return a.Add(b);
		}

		public static Angle operator -(Angle a, Angle b)
		{
			return a.Subtract(b);
		}

		public static Angle operator *(Angle a, double n)
		{
			return a.Multiply(n);
		}

		public static Angle operator /(Angle a, double n)
		{
			return a.Divide(n);
		}

		public static Ratio operator /(Angle a, Angle b)
		{
			return a.Divide(b);
		}

		public static Angle operator -(Angle a)
		{
			return a.Multiply(-1.0);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Angle(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Distance : IQuantitySI<Distance>, IQuantitySI, IQuantity<Distance>, IQuantity, IComparable<Distance>, IEquatable<Distance>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public double BaseValue
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BaseValue"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BaseValue", value);
			}
		}

		public static Unit<Distance> Meter
		{
			get
			{
				return (Unit<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Meter"), typeof(Unit<Distance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Meter", value);
			}
		}

		public static Unit<Distance> Angstrom
		{
			get
			{
				return (Unit<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Angstrom"), typeof(Unit<Distance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Angstrom", value);
			}
		}

		public static Unit<Distance> SolarRadius
		{
			get
			{
				return (Unit<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "SolarRadius"), typeof(Unit<Distance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "SolarRadius", value);
			}
		}

		public static Unit<Distance> AU
		{
			get
			{
				return (Unit<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "AU"), typeof(Unit<Distance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "AU", value);
			}
		}

		public static Unit<Distance> Lightyear
		{
			get
			{
				return (Unit<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Lightyear"), typeof(Unit<Distance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Lightyear", value);
			}
		}

		public static Unit<Distance> Lightsecond
		{
			get
			{
				return (Unit<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Lightsecond"), typeof(Unit<Distance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Lightsecond", value);
			}
		}

		public static Unit<Distance> Parsec
		{
			get
			{
				return (Unit<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Parsec"), typeof(Unit<Distance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Parsec", value);
			}
		}

		public static Unit<Distance> Thou
		{
			get
			{
				return (Unit<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Thou"), typeof(Unit<Distance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Thou", value);
			}
		}

		public static Unit<Distance> Inch
		{
			get
			{
				return (Unit<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Inch"), typeof(Unit<Distance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Inch", value);
			}
		}

		public static Unit<Distance> Foot
		{
			get
			{
				return (Unit<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Foot"), typeof(Unit<Distance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Foot", value);
			}
		}

		public static Unit<Distance> Yard
		{
			get
			{
				return (Unit<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Yard"), typeof(Unit<Distance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Yard", value);
			}
		}

		public static Unit<Distance> Mile
		{
			get
			{
				return (Unit<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Mile"), typeof(Unit<Distance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Mile", value);
			}
		}

		public static CompoundFormatInfo<Distance> FeetInches
		{
			get
			{
				return (CompoundFormatInfo<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "FeetInches"), typeof(CompoundFormatInfo<Distance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "FeetInches", value);
			}
		}

		double IQuantity.BaseValue => BaseValue;

		public double SIPower => 1.0;

		public Unit<Distance> DefaultUnit => Meter;

		public Distance(double baseValue = 0.0)
		{
			this = default(Distance);
			BaseValue = baseValue;
		}

		public bool Equals(Distance other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public int CompareTo(Distance other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public IUnit[] GetCommonSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetCommonSIUnits"), typeof(IUnit[]));
		}

		public IUnit[] GetExludedSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetExludedSIUnits"), typeof(IUnit[]));
		}

		public Distance New(double baseVal)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "New", baseVal), typeof(Distance));
		}

		public Distance Add(Distance q)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", q), typeof(Distance));
		}

		public Distance Subtract(Distance q)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", q), typeof(Distance));
		}

		public Distance Multiply(double n)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", n), typeof(Distance));
		}

		public Distance Multiply(Distance a, Ratio r)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", a, r), typeof(Distance));
		}

		public Distance Multiply(Ratio r, Distance a)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", r, a), typeof(Distance));
		}

		public Distance Divide(double n)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", n), typeof(Distance));
		}

		public Ratio Divide(Distance q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", q), typeof(Ratio));
		}

		public static Distance Parse(string str, Unit<Distance> defaultUnit = null)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Distance));
		}

		public static bool TryParse(string str, out Distance q, Unit<Distance> defaultUnit = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, q, defaultUnit), typeof(bool));
		}

		public static Distance operator +(Distance a, Distance b)
		{
			return a.Add(b);
		}

		public static Distance operator -(Distance a, Distance b)
		{
			return a.Subtract(b);
		}

		public static Distance operator *(Distance a, double n)
		{
			return a.Multiply(n);
		}

		public static Distance operator /(Distance a, double n)
		{
			return a.Divide(n);
		}

		public static Ratio operator /(Distance a, Distance b)
		{
			return a.Divide(b);
		}

		public static Distance operator -(Distance a)
		{
			return a.Multiply(-1.0);
		}

		public static Velocity operator /(Distance l, Time t)
		{
			return Velocity.MetersPerSecond * (l.BaseValue / t.BaseValue);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Distance(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IQuantity : ResoniteBridge.ResoniteBridgeValueHolder
	{
		double BaseValue { get; }

		string[] GetShortBaseNames();

		string[] GetLongBaseNames();
	}
	public interface IQuantity<T> : IQuantity, IComparable<T>, IEquatable<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantity<T>
	{
		Unit<T> DefaultUnit { get; }

		T New(double baseValue);

		T Add(T q);

		T Subtract(T q);

		T Multiply(double n);

		T Divide(double n);

		Ratio Divide(T q);
	}
	public interface IQuantitySI : ResoniteBridge.ResoniteBridgeValueHolder
	{
		double SIPower { get; }

		IUnit[] GetCommonSIUnits();

		IUnit[] GetExludedSIUnits();
	}
	public interface IQuantitySI<T> : IQuantitySI, IQuantity<T>, IQuantity, IComparable<T>, IEquatable<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantity<T>
	{
	}
	public class UnitSI<T> : Unit<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantitySI<T>
	{
		private static double SIPower
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitSI", ResoniteBridge.ResoniteBridgeValueType.Type), "SIPower"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitSI", ResoniteBridge.ResoniteBridgeValueType.Type), "SIPower", value);
			}
		}

		static UnitSI()
		{
			SIPower = default(T).SIPower;
		}

		public UnitSI(int nFactor, string shortPrefix, string longPrefix)
			: base(Math.Pow(Math.Pow(10.0, nFactor), SIPower), (ICollection<UnitGroup>)new UnitGroup[1] { UnitGroup.Metric }, new string[1] { " " + shortPrefix + "{0}" }, new string[1] { " " + longPrefix + "{0}" })
		{
			if (nFactor % 3 == 0)
			{
				UnitGroup.MetricThousands.RegisterUnit(this);
			}
		}

		public UnitSI(int nFactor, string[] shortPrefixes, string[] longPrefixes)
			: base(Math.Pow(Math.Pow(10.0, nFactor), SIPower), (ICollection<UnitGroup>)new UnitGroup[1] { UnitGroup.Metric }, shortPrefixes.Select((string p) => " " + p + "{0}").ToArray(), longPrefixes.Select((string p) => " " + p + "{0}").ToArray())
		{
			if (nFactor % 3 == 0)
			{
				UnitGroup.MetricThousands.RegisterUnit(this);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public UnitSI(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IUnit : IComparable<IUnit>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		double Ratio { get; }

		Type ValueType { get; }

		ICollection<string> GetUnitNames();
	}
	public class Unit<T> : IUnit, IComparable<IUnit>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantity<T>
	{
		private string[] shortNames
		{
			get
			{
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "shortNames"), typeof(string[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "shortNames", value);
			}
		}

		private string[] longNames
		{
			get
			{
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "longNames"), typeof(string[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "longNames", value);
			}
		}

		private static string shortBaseName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "shortBaseName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "shortBaseName", value);
			}
		}

		private static string longBaseName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "longBaseName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "longBaseName", value);
			}
		}

		public double Ratio
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Ratio"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Ratio", value);
			}
		}

		public Type ValueType => typeof(T);

		public int CompareTo(IUnit other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		public ICollection<string> GetUnitNames()
		{
			return (ICollection<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetUnitNames"), typeof(ICollection<string>));
		}

		public Unit(double baseRatio, ICollection<UnitGroup> unitGroups, string[] shortNames, string[] longNames)
		{
			Ratio = baseRatio;
			this.shortNames = shortNames;
			this.longNames = longNames;
			if (unitGroups == null)
			{
				return;
			}
			foreach (UnitGroup unitGroup in unitGroups)
			{
				unitGroup.RegisterUnit(this);
			}
		}

		public virtual double ConvertTo(T q)
		{
			return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ConvertTo", q), typeof(double));
		}

		public T ConvertFrom(T q)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ConvertFrom", q), typeof(T));
		}

		public virtual T ConvertFrom(double val)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ConvertFrom", val), typeof(T));
		}

		public static T Parse(string str, NumberStyles numberStyles, IFormatProvider formatProvider, Unit<T> defaultUnit = null)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, numberStyles, formatProvider, defaultUnit), typeof(T));
		}

		public static T Parse(string str, Unit<T> defaultUnit = null)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(T));
		}

		public static bool TryParse(string str, out T quantity, Unit<T> defaultUnit = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, quantity, defaultUnit), typeof(bool));
		}

		public static bool TryParse(string str, NumberStyles numberStyles, IFormatProvider formatProvider, out T quantity, Unit<T> defaultUnit = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, numberStyles, formatProvider, quantity, defaultUnit), typeof(bool));
		}

		private static bool ParseIntern(string str, NumberStyles numberStyles, IFormatProvider formatProvider, out T quantity, Unit<T> defaultUnit, bool throwOnFail)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "ParseIntern", str, numberStyles, formatProvider, quantity, defaultUnit, throwOnFail), typeof(bool));
		}

		private static IUnit GetUnitFromSubstring(string str, out int unitEndIndex, bool byLetter = false)
		{
			return (IUnit)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUnitFromSubstring", str, unitEndIndex, byLetter), typeof(IUnit));
		}

		private static int IndexOfNumberEnd(string str)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "IndexOfNumberEnd", str), typeof(int));
		}

		public string FormatAs(T q, string formatNum = null, bool longName = false, string overrideName = null)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FormatAs", q, formatNum, longName, overrideName), typeof(string));
		}

		public static T operator *(Unit<T> unit, double n)
		{
			return unit.ConvertFrom(n);
		}

		public static T operator *(double n, Unit<T> unit)
		{
			return unit.ConvertFrom(n);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Unit(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public delegate bool NumberTryParseHandler<T>(string str, NumberStyles numberStyles, IFormatProvider formatProvider, out T value);
	public static class QuantityHelper
	{
		public static CultureInfo Culture
		{
			get
			{
				return (CultureInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Culture"), typeof(CultureInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Culture", value);
			}
		}

		public static NumberTryParseHandler<double> CustomParser
		{
			get
			{
				return (NumberTryParseHandler<double>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CustomParser"), typeof(NumberTryParseHandler<double>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CustomParser", value);
			}
		}

		private static Dictionary<Type, List<IUnit>> unitCache
		{
			get
			{
				return (Dictionary<Type, List<IUnit>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "unitCache"), typeof(Dictionary<Type, List<IUnit>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "unitCache", value);
			}
		}

		private static Dictionary<Type, Dictionary<string, IUnit>> unitNameCache
		{
			get
			{
				return (Dictionary<Type, Dictionary<string, IUnit>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "unitNameCache"), typeof(Dictionary<Type, Dictionary<string, IUnit>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "unitNameCache", value);
			}
		}

		public static bool TryParse(string str, NumberStyles numberStyles, IFormatProvider formatProvider, out double value)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, numberStyles, formatProvider, value), typeof(bool));
		}

		public static double ConvertTo<T>(this T q, Unit<T> unit) where T : struct, IQuantity<T>
		{
			return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertTo", q, unit), typeof(double));
		}

		public static string FormatAs<T>(this T q, Unit<T> unit, string formatNum = null, bool longName = false, string overrideName = null) where T : struct, IQuantity<T>
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatAs", q, unit, formatNum, longName, overrideName), typeof(string));
		}

		public static string FormatAs<T>(this T q, string unitName, string formatNum = null, bool longName = false) where T : struct, IQuantity<T>
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatAs", q, unitName, formatNum, longName), typeof(string));
		}

		public static string FormatAuto<T>(this T q, string formatNum, bool longName, UnitGroup unitGroup, Unit<T> defaultUnit = null) where T : struct, IQuantity<T>
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatAuto", q, formatNum, longName, unitGroup, defaultUnit), typeof(string));
		}

		public static string FormatAuto<T>(this T q, string formatNum = null, bool longName = false, List<UnitGroup> groups = null, Unit<T> defaultUnit = null) where T : struct, IQuantity<T>
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatAuto", q, formatNum, longName, groups, defaultUnit), typeof(string));
		}

		public static string FormatCompound<T>(this T q, ICollection<Unit<T>> units, string separator = " ", CompoundZeroHandling zeroHandling = CompoundZeroHandling.RemoveAny, string lastNumberFormat = null, bool longNames = false, bool discardLastFraction = false) where T : struct, IQuantity<T>
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatCompound", q, units, separator, zeroHandling, lastNumberFormat, longNames, discardLastFraction), typeof(string));
		}

		public static string FormatCompound<T>(this T q, CompoundFormatInfo<T> formatInfo) where T : struct, IQuantity<T>
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatCompound", q, formatInfo), typeof(string));
		}

		public static IEnumerable<IUnit> GetUnits<T>()
		{
			return (IEnumerable<IUnit>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUnits"), typeof(IEnumerable<IUnit>));
		}

		public static Unit<T> SelectBestUnit<T>(this T q, List<UnitGroup> groups) where T : struct, IQuantity<T>
		{
			return (Unit<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SelectBestUnit", q, groups), typeof(Unit<T>));
		}

		private static bool ContainsUnit(IUnit unit, List<UnitGroup> groups)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ContainsUnit", unit, groups), typeof(bool));
		}

		public static IUnit GetUnitByName<T>(string name)
		{
			return (IUnit)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUnitByName", name), typeof(IUnit));
		}

		static QuantityHelper()
		{
			Culture = CultureInfo.InvariantCulture;
			unitCache = new Dictionary<Type, List<IUnit>>();
			unitNameCache = new Dictionary<Type, Dictionary<string, IUnit>>();
			Type[] types = typeof(QuantityHelper).Assembly.GetTypes();
			foreach (Type type in types)
			{
				if (!typeof(IQuantity).IsAssignableFrom(type) || !type.IsValueType)
				{
					continue;
				}
				IQuantity quantity = (IQuantity)Activator.CreateInstance(type);
				List<IUnit> list = new List<IUnit>();
				unitCache.Add(type, list);
				bool flag = false;
				Type[] interfaces = type.GetInterfaces();
				foreach (Type type2 in interfaces)
				{
					if (type2.IsGenericType && type2.GetGenericTypeDefinition() == typeof(IQuantitySI<>))
					{
						flag = true;
						break;
					}
				}
				BindingFlags bindingAttr = BindingFlags.Static | BindingFlags.Public;
				List<FieldInfo[]> list2 = new List<FieldInfo[]> { type.GetFields(bindingAttr) };
				if (flag)
				{
					IQuantitySI quantitySI = (IQuantitySI)quantity;
					IUnit[] commonSIUnits = quantitySI.GetCommonSIUnits();
					foreach (IUnit unit in commonSIUnits)
					{
						UnitGroup.Common.RegisterUnit(unit);
						UnitGroup.CommonMetric.RegisterUnit(unit);
					}
					commonSIUnits = quantitySI.GetExludedSIUnits();
					foreach (IUnit unit2 in commonSIUnits)
					{
						UnitGroup.Metric.RemoveUnit(unit2);
					}
					Type type3 = typeof(SI<>).MakeGenericType(type);
					list2.Add(type3.GetFields(bindingAttr));
				}
				foreach (FieldInfo[] item in list2)
				{
					foreach (FieldInfo fieldInfo in item)
					{
						if (typeof(IUnit).IsAssignableFrom(fieldInfo.FieldType))
						{
							list.Add((IUnit)fieldInfo.GetValue(null));
						}
					}
				}
				list.Sort();
				Dictionary<string, IUnit> dictionary = new Dictionary<string, IUnit>();
				unitNameCache.Add(type, dictionary);
				foreach (IUnit item2 in list)
				{
					foreach (string unitName in item2.GetUnitNames())
					{
						dictionary.Add(unitName.Trim(), item2);
					}
				}
			}
		}
	}
	public class UnitGroup : IEnumerable<IUnit>, IEnumerable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public struct Enumerator : IEnumerator<IUnit>, IDisposable, IEnumerator, ResoniteBridge.ResoniteBridgeValueHolder
		{
			private bool firstDone
			{
				get
				{
					return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "firstDone"), typeof(bool));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "firstDone", value);
				}
			}

			private Dictionary<Type, SortedSet<IUnit>>.Enumerator dictEnum
			{
				get
				{
					return (Dictionary<Type, SortedSet<IUnit>>.Enumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "dictEnum"), typeof(Dictionary<Type, SortedSet<IUnit>>.Enumerator));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "dictEnum", value);
				}
			}

			private SortedSet<IUnit>.Enumerator setEnum
			{
				get
				{
					return (SortedSet<IUnit>.Enumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "setEnum"), typeof(SortedSet<IUnit>.Enumerator));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "setEnum", value);
				}
			}

			public IUnit Current => setEnum.Current;

			object IEnumerator.Current => Current;

			public Enumerator(UnitGroup group)
			{
				dictEnum = group.units.GetEnumerator();
				setEnum = default(SortedSet<IUnit>.Enumerator);
				firstDone = false;
			}

			public void Dispose()
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
			}

			public bool MoveNext()
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MoveNext"), typeof(bool));
			}

			public void Reset()
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Reset");
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public Enumerator(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		public static List<UnitGroup> DefaultUnitGroups
		{
			get
			{
				return (List<UnitGroup>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "DefaultUnitGroups"), typeof(List<UnitGroup>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "DefaultUnitGroups", value);
			}
		}

		public static UnitGroup Common
		{
			get
			{
				return (UnitGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Common"), typeof(UnitGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Common", value);
			}
		}

		public static UnitGroup Metric
		{
			get
			{
				return (UnitGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Metric"), typeof(UnitGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Metric", value);
			}
		}

		public static UnitGroup MetricThousands
		{
			get
			{
				return (UnitGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "MetricThousands"), typeof(UnitGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "MetricThousands", value);
			}
		}

		public static UnitGroup CommonMetric
		{
			get
			{
				return (UnitGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "CommonMetric"), typeof(UnitGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "CommonMetric", value);
			}
		}

		public static UnitGroup Scientific
		{
			get
			{
				return (UnitGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Scientific"), typeof(UnitGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Scientific", value);
			}
		}

		public static UnitGroup Astronomical
		{
			get
			{
				return (UnitGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Astronomical"), typeof(UnitGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Astronomical", value);
			}
		}

		public static UnitGroup Molecular
		{
			get
			{
				return (UnitGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Molecular"), typeof(UnitGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Molecular", value);
			}
		}

		public static UnitGroup Meteorological
		{
			get
			{
				return (UnitGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Meteorological"), typeof(UnitGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Meteorological", value);
			}
		}

		public static UnitGroup Aviation
		{
			get
			{
				return (UnitGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Aviation"), typeof(UnitGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Aviation", value);
			}
		}

		public static UnitGroup Maritime
		{
			get
			{
				return (UnitGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Maritime"), typeof(UnitGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Maritime", value);
			}
		}

		public static UnitGroup Imperial
		{
			get
			{
				return (UnitGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Imperial"), typeof(UnitGroup));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Imperial", value);
			}
		}

		private Dictionary<Type, SortedSet<IUnit>> units
		{
			get
			{
				return (Dictionary<Type, SortedSet<IUnit>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "units"), typeof(Dictionary<Type, SortedSet<IUnit>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "units", value);
			}
		}

		static UnitGroup()
		{
			DefaultUnitGroups = new List<UnitGroup>();
			Common = new UnitGroup();
			Metric = new UnitGroup();
			MetricThousands = new UnitGroup();
			CommonMetric = new UnitGroup();
			Scientific = new UnitGroup();
			Astronomical = new UnitGroup();
			Molecular = new UnitGroup();
			Meteorological = new UnitGroup();
			Aviation = new UnitGroup();
			Maritime = new UnitGroup();
			Imperial = new UnitGroup();
			DefaultUnitGroups.Add(Common);
		}

		public void RegisterUnit(IUnit unit)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RegisterUnit", unit);
		}

		public void RemoveUnit(IUnit unit)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveUnit", unit);
		}

		public bool HasUnit(IUnit unit)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "HasUnit", unit), typeof(bool));
		}

		internal SortedSet<IUnit> GetSetForType(Type type, bool createIfNotExists = true)
		{
			return (SortedSet<IUnit>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetSetForType", type, createIfNotExists), typeof(SortedSet<IUnit>));
		}

		public Enumerator GetEnumerator()
		{
			return (Enumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(Enumerator));
		}

		IEnumerator<IUnit> IEnumerable<IUnit>.GetEnumerator()
		{
			return (IEnumerator<IUnit>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator<IUnit>));
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public UnitGroup(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Mass : IQuantitySI<Mass>, IQuantitySI, IQuantity<Mass>, IQuantity, IComparable<Mass>, IEquatable<Mass>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public double BaseValue
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BaseValue"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BaseValue", value);
			}
		}

		public static Unit<Mass> Gram
		{
			get
			{
				return (Unit<Mass>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Gram"), typeof(Unit<Mass>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Gram", value);
			}
		}

		public static Unit<Mass> Ton
		{
			get
			{
				return (Unit<Mass>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Ton"), typeof(Unit<Mass>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Ton", value);
			}
		}

		public static Unit<Mass> Grain
		{
			get
			{
				return (Unit<Mass>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Grain"), typeof(Unit<Mass>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Grain", value);
			}
		}

		public static Unit<Mass> Drachm
		{
			get
			{
				return (Unit<Mass>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Drachm"), typeof(Unit<Mass>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Drachm", value);
			}
		}

		public static Unit<Mass> Ounce
		{
			get
			{
				return (Unit<Mass>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Ounce"), typeof(Unit<Mass>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Ounce", value);
			}
		}

		public static Unit<Mass> Pound
		{
			get
			{
				return (Unit<Mass>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Pound"), typeof(Unit<Mass>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Pound", value);
			}
		}

		public static Unit<Mass> Stone
		{
			get
			{
				return (Unit<Mass>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Stone"), typeof(Unit<Mass>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Stone", value);
			}
		}

		public static Unit<Mass> Quarter
		{
			get
			{
				return (Unit<Mass>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Quarter"), typeof(Unit<Mass>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Quarter", value);
			}
		}

		public static Unit<Mass> HundredWeight
		{
			get
			{
				return (Unit<Mass>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "HundredWeight"), typeof(Unit<Mass>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "HundredWeight", value);
			}
		}

		public static Unit<Mass> ImperialTon
		{
			get
			{
				return (Unit<Mass>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "ImperialTon"), typeof(Unit<Mass>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "ImperialTon", value);
			}
		}

		public static Unit<Mass> Slug
		{
			get
			{
				return (Unit<Mass>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Slug"), typeof(Unit<Mass>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Slug", value);
			}
		}

		double IQuantity.BaseValue => BaseValue;

		public double SIPower => 1.0;

		public Unit<Mass> DefaultUnit => SI<Mass>.Kilo;

		public Mass(double baseValue = 0.0)
		{
			this = default(Mass);
			BaseValue = baseValue;
		}

		public bool Equals(Mass other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public int CompareTo(Mass other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public IUnit[] GetCommonSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetCommonSIUnits"), typeof(IUnit[]));
		}

		public IUnit[] GetExludedSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetExludedSIUnits"), typeof(IUnit[]));
		}

		public Mass New(double baseVal)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "New", baseVal), typeof(Mass));
		}

		public Mass Add(Mass q)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", q), typeof(Mass));
		}

		public Mass Subtract(Mass q)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", q), typeof(Mass));
		}

		public Mass Multiply(double n)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", n), typeof(Mass));
		}

		public Mass Multiply(Mass a, Ratio r)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", a, r), typeof(Mass));
		}

		public Mass Multiply(Ratio r, Mass a)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", r, a), typeof(Mass));
		}

		public Mass Divide(double n)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", n), typeof(Mass));
		}

		public Ratio Divide(Mass q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", q), typeof(Ratio));
		}

		public static Mass Parse(string str, Unit<Mass> defaultUnit = null)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Mass));
		}

		public static bool TryParse(string str, out Mass q, Unit<Mass> defaultUnit = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, q, defaultUnit), typeof(bool));
		}

		public static Mass operator +(Mass a, Mass b)
		{
			return a.Add(b);
		}

		public static Mass operator -(Mass a, Mass b)
		{
			return a.Subtract(b);
		}

		public static Mass operator *(Mass a, double n)
		{
			return a.Multiply(n);
		}

		public static Mass operator /(Mass a, double n)
		{
			return a.Divide(n);
		}

		public static Ratio operator /(Mass a, Mass b)
		{
			return a.Divide(b);
		}

		public static Mass operator -(Mass a)
		{
			return a.Multiply(-1.0);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Mass(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Ratio : IQuantity<Ratio>, IQuantity, IComparable<Ratio>, IEquatable<Ratio>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public double BaseValue
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BaseValue"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BaseValue", value);
			}
		}

		public static Unit<Ratio> RatioValue
		{
			get
			{
				return (Unit<Ratio>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "RatioValue"), typeof(Unit<Ratio>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "RatioValue", value);
			}
		}

		public static Unit<Ratio> Percent
		{
			get
			{
				return (Unit<Ratio>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "Percent"), typeof(Unit<Ratio>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "Percent", value);
			}
		}

		double IQuantity.BaseValue => BaseValue;

		public Unit<Ratio> DefaultUnit => RatioValue;

		public Ratio(double baseValue = 0.0)
		{
			this = default(Ratio);
			BaseValue = baseValue;
		}

		public bool Equals(Ratio other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public int CompareTo(Ratio other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public Ratio New(double baseVal)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "New", baseVal), typeof(Ratio));
		}

		public Ratio Add(Ratio q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", q), typeof(Ratio));
		}

		public Ratio Subtract(Ratio q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", q), typeof(Ratio));
		}

		public Ratio Multiply(double n)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", n), typeof(Ratio));
		}

		public Ratio Multiply(Ratio a, Ratio r)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", a, r), typeof(Ratio));
		}

		public Ratio Divide(double n)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", n), typeof(Ratio));
		}

		public Ratio Divide(Ratio q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", q), typeof(Ratio));
		}

		public static Ratio Parse(string str, Unit<Ratio> defaultUnit = null)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Ratio));
		}

		public static bool TryParse(string str, out Ratio q, Unit<Ratio> defaultUnit = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, q, defaultUnit), typeof(bool));
		}

		public static Ratio operator +(Ratio a, Ratio b)
		{
			return a.Add(b);
		}

		public static Ratio operator -(Ratio a, Ratio b)
		{
			return a.Subtract(b);
		}

		public static Ratio operator *(Ratio a, double n)
		{
			return a.Multiply(n);
		}

		public static Ratio operator /(Ratio a, double n)
		{
			return a.Divide(n);
		}

		public static Ratio operator /(Ratio a, Ratio b)
		{
			return a.Divide(b);
		}

		public static Ratio operator -(Ratio a)
		{
			return a.Multiply(-1.0);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Ratio(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Temperature : IQuantity<Temperature>, IQuantity, IComparable<Temperature>, IEquatable<Temperature>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public double BaseValue
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BaseValue"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BaseValue", value);
			}
		}

		public static Unit<Temperature> Kelvin
		{
			get
			{
				return (Unit<Temperature>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "Kelvin"), typeof(Unit<Temperature>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "Kelvin", value);
			}
		}

		public static Unit<Temperature> Celsius
		{
			get
			{
				return (Unit<Temperature>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "Celsius"), typeof(Unit<Temperature>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "Celsius", value);
			}
		}

		public static Unit<Temperature> Fahrenheit
		{
			get
			{
				return (Unit<Temperature>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "Fahrenheit"), typeof(Unit<Temperature>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "Fahrenheit", value);
			}
		}

		double IQuantity.BaseValue => BaseValue;

		public Unit<Temperature> DefaultUnit => Kelvin;

		public Temperature(double baseValue = 0.0)
		{
			this = default(Temperature);
			BaseValue = baseValue;
		}

		public bool Equals(Temperature other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public int CompareTo(Temperature other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public Temperature New(double baseVal)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "New", baseVal), typeof(Temperature));
		}

		public Temperature Add(Temperature q)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", q), typeof(Temperature));
		}

		public Temperature Subtract(Temperature q)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", q), typeof(Temperature));
		}

		public Temperature Multiply(double n)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", n), typeof(Temperature));
		}

		public Temperature Multiply(Temperature a, Ratio r)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", a, r), typeof(Temperature));
		}

		public Temperature Multiply(Ratio r, Temperature a)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", r, a), typeof(Temperature));
		}

		public Temperature Divide(double n)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", n), typeof(Temperature));
		}

		public Ratio Divide(Temperature q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", q), typeof(Ratio));
		}

		public static Temperature Parse(string str, Unit<Temperature> defaultUnit = null)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Temperature));
		}

		public static bool TryParse(string str, out Temperature q, Unit<Temperature> defaultUnit = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, q, defaultUnit), typeof(bool));
		}

		public static Temperature operator +(Temperature a, Temperature b)
		{
			return a.Add(b);
		}

		public static Temperature operator -(Temperature a, Temperature b)
		{
			return a.Subtract(b);
		}

		public static Temperature operator *(Temperature a, double n)
		{
			return a.Multiply(n);
		}

		public static Temperature operator /(Temperature a, double n)
		{
			return a.Divide(n);
		}

		public static Ratio operator /(Temperature a, Temperature b)
		{
			return a.Divide(b);
		}

		public static Temperature operator -(Temperature a)
		{
			return a.Multiply(-1.0);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Temperature(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Time : IQuantity<Time>, IQuantity, IComparable<Time>, IEquatable<Time>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public double BaseValue
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BaseValue"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BaseValue", value);
			}
		}

		public static Unit<Time> Millisecond
		{
			get
			{
				return (Unit<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Millisecond"), typeof(Unit<Time>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Millisecond", value);
			}
		}

		public static Unit<Time> Second
		{
			get
			{
				return (Unit<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Second"), typeof(Unit<Time>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Second", value);
			}
		}

		public static Unit<Time> Minute
		{
			get
			{
				return (Unit<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Minute"), typeof(Unit<Time>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Minute", value);
			}
		}

		public static Unit<Time> Hour
		{
			get
			{
				return (Unit<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Hour"), typeof(Unit<Time>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Hour", value);
			}
		}

		public static Unit<Time> Day
		{
			get
			{
				return (Unit<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Day"), typeof(Unit<Time>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Day", value);
			}
		}

		public static CompoundFormatInfo<Time> MinuteSecond
		{
			get
			{
				return (CompoundFormatInfo<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "MinuteSecond"), typeof(CompoundFormatInfo<Time>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "MinuteSecond", value);
			}
		}

		public static CompoundFormatInfo<Time> HourMinuteSecond
		{
			get
			{
				return (CompoundFormatInfo<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "HourMinuteSecond"), typeof(CompoundFormatInfo<Time>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "HourMinuteSecond", value);
			}
		}

		public static CompoundFormatInfo<Time> HourMinuteSecond_Trimmed
		{
			get
			{
				return (CompoundFormatInfo<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "HourMinuteSecond_Trimmed"), typeof(CompoundFormatInfo<Time>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "HourMinuteSecond_Trimmed", value);
			}
		}

		public static CompoundFormatInfo<Time> DayHourMinuteSecond_Long
		{
			get
			{
				return (CompoundFormatInfo<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "DayHourMinuteSecond_Long"), typeof(CompoundFormatInfo<Time>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "DayHourMinuteSecond_Long", value);
			}
		}

		public static CompoundFormatInfo<Time> DayHourMinute_Long
		{
			get
			{
				return (CompoundFormatInfo<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "DayHourMinute_Long"), typeof(CompoundFormatInfo<Time>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "DayHourMinute_Long", value);
			}
		}

		public static CompoundFormatInfo<Time> DayHourMinuteSecond_Trimmed
		{
			get
			{
				return (CompoundFormatInfo<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "DayHourMinuteSecond_Trimmed"), typeof(CompoundFormatInfo<Time>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "DayHourMinuteSecond_Trimmed", value);
			}
		}

		public static CompoundFormatInfo<Time> HourMinuteSecond_Symbol
		{
			get
			{
				return (CompoundFormatInfo<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "HourMinuteSecond_Symbol"), typeof(CompoundFormatInfo<Time>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "HourMinuteSecond_Symbol", value);
			}
		}

		public static CompoundFormatInfo<Time> StopWatch
		{
			get
			{
				return (CompoundFormatInfo<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "StopWatch"), typeof(CompoundFormatInfo<Time>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "StopWatch", value);
			}
		}

		double IQuantity.BaseValue => BaseValue;

		public Unit<Time> DefaultUnit => Second;

		public Time(double baseValue = 0.0)
		{
			this = default(Time);
			BaseValue = baseValue;
		}

		public bool Equals(Time other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public int CompareTo(Time other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public Time New(double baseVal)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "New", baseVal), typeof(Time));
		}

		public Time Add(Time q)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", q), typeof(Time));
		}

		public Time Subtract(Time q)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", q), typeof(Time));
		}

		public Time Multiply(double n)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", n), typeof(Time));
		}

		public Time Multiply(Time a, Ratio r)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", a, r), typeof(Time));
		}

		public Time Multiply(Ratio r, Time a)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", r, a), typeof(Time));
		}

		public Time Divide(double n)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", n), typeof(Time));
		}

		public Ratio Divide(Time q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", q), typeof(Ratio));
		}

		public static Time Parse(string str, Unit<Time> defaultUnit = null)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Time));
		}

		public static bool TryParse(string str, out Time q, Unit<Time> defaultUnit = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, q, defaultUnit), typeof(bool));
		}

		public static Time operator +(Time a, Time b)
		{
			return a.Add(b);
		}

		public static Time operator -(Time a, Time b)
		{
			return a.Subtract(b);
		}

		public static Time operator *(Time a, double n)
		{
			return a.Multiply(n);
		}

		public static Time operator /(Time a, double n)
		{
			return a.Divide(n);
		}

		public static Ratio operator /(Time a, Time b)
		{
			return a.Divide(b);
		}

		public static Time operator -(Time a)
		{
			return a.Multiply(-1.0);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Time(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Velocity : IQuantity<Velocity>, IQuantity, IComparable<Velocity>, IEquatable<Velocity>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public double BaseValue
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BaseValue"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BaseValue", value);
			}
		}

		public static Unit<Velocity> MetersPerSecond
		{
			get
			{
				return (Unit<Velocity>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "MetersPerSecond"), typeof(Unit<Velocity>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "MetersPerSecond", value);
			}
		}

		public static Unit<Velocity> KilometersPerHour
		{
			get
			{
				return (Unit<Velocity>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "KilometersPerHour"), typeof(Unit<Velocity>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "KilometersPerHour", value);
			}
		}

		public static Unit<Velocity> MilesPerHour
		{
			get
			{
				return (Unit<Velocity>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "MilesPerHour"), typeof(Unit<Velocity>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "MilesPerHour", value);
			}
		}

		public static Unit<Velocity> FeetPerSecond
		{
			get
			{
				return (Unit<Velocity>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "FeetPerSecond"), typeof(Unit<Velocity>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "FeetPerSecond", value);
			}
		}

		public static Unit<Velocity> Knots
		{
			get
			{
				return (Unit<Velocity>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "Knots"), typeof(Unit<Velocity>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "Knots", value);
			}
		}

		double IQuantity.BaseValue => BaseValue;

		public Unit<Velocity> DefaultUnit => MetersPerSecond;

		public Velocity(double baseValue = 0.0)
		{
			this = default(Velocity);
			BaseValue = baseValue;
		}

		public bool Equals(Velocity other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public int CompareTo(Velocity other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public Velocity New(double baseVal)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "New", baseVal), typeof(Velocity));
		}

		public Velocity Add(Velocity q)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", q), typeof(Velocity));
		}

		public Velocity Subtract(Velocity q)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", q), typeof(Velocity));
		}

		public Velocity Multiply(double n)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", n), typeof(Velocity));
		}

		public Velocity Multiply(Velocity a, Ratio r)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", a, r), typeof(Velocity));
		}

		public Velocity Multiply(Ratio r, Velocity a)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", r, a), typeof(Velocity));
		}

		public Velocity Divide(double n)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", n), typeof(Velocity));
		}

		public Ratio Divide(Velocity q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", q), typeof(Ratio));
		}

		public static Velocity Parse(string str, Unit<Velocity> defaultUnit = null)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Velocity));
		}

		public static bool TryParse(string str, out Velocity q, Unit<Velocity> defaultUnit = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, q, defaultUnit), typeof(bool));
		}

		public static Velocity operator +(Velocity a, Velocity b)
		{
			return a.Add(b);
		}

		public static Velocity operator -(Velocity a, Velocity b)
		{
			return a.Subtract(b);
		}

		public static Velocity operator *(Velocity a, double n)
		{
			return a.Multiply(n);
		}

		public static Velocity operator /(Velocity a, double n)
		{
			return a.Divide(n);
		}

		public static Ratio operator /(Velocity a, Velocity b)
		{
			return a.Divide(b);
		}

		public static Velocity operator -(Velocity a)
		{
			return a.Multiply(-1.0);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Velocity(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Current : IQuantitySI<Current>, IQuantitySI, IQuantity<Current>, IQuantity, IComparable<Current>, IEquatable<Current>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public double BaseValue
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BaseValue"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BaseValue", value);
			}
		}

		public static Unit<Current> Ampere
		{
			get
			{
				return (Unit<Current>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "Ampere"), typeof(Unit<Current>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "Ampere", value);
			}
		}

		double IQuantity.BaseValue => BaseValue;

		public double SIPower => 1.0;

		public Unit<Current> DefaultUnit => Ampere;

		public Current(double baseValue = 0.0)
		{
			this = default(Current);
			BaseValue = baseValue;
		}

		public bool Equals(Current other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public int CompareTo(Current other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public IUnit[] GetCommonSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetCommonSIUnits"), typeof(IUnit[]));
		}

		public IUnit[] GetExludedSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetExludedSIUnits"), typeof(IUnit[]));
		}

		public Current New(double baseVal)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "New", baseVal), typeof(Current));
		}

		public Current Add(Current q)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", q), typeof(Current));
		}

		public Current Subtract(Current q)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", q), typeof(Current));
		}

		public Current Multiply(double n)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", n), typeof(Current));
		}

		public Current Multiply(Current a, Ratio r)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", a, r), typeof(Current));
		}

		public Current Multiply(Ratio r, Current a)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", r, a), typeof(Current));
		}

		public Current Divide(double n)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", n), typeof(Current));
		}

		public Ratio Divide(Current q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", q), typeof(Ratio));
		}

		public static Current Parse(string str, Unit<Current> defaultUnit = null)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Current));
		}

		public static bool TryParse(string str, out Current q, Unit<Current> defaultUnit = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, q, defaultUnit), typeof(bool));
		}

		public static Current operator +(Current a, Current b)
		{
			return a.Add(b);
		}

		public static Current operator -(Current a, Current b)
		{
			return a.Subtract(b);
		}

		public static Current operator *(Current a, double n)
		{
			return a.Multiply(n);
		}

		public static Current operator /(Current a, double n)
		{
			return a.Divide(n);
		}

		public static Ratio operator /(Current a, Current b)
		{
			return a.Divide(b);
		}

		public static Current operator -(Current a)
		{
			return a.Multiply(-1.0);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Current(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Resistance : IQuantitySI<Resistance>, IQuantitySI, IQuantity<Resistance>, IQuantity, IComparable<Resistance>, IEquatable<Resistance>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public double BaseValue
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BaseValue"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BaseValue", value);
			}
		}

		public static Unit<Resistance> Ohm
		{
			get
			{
				return (Unit<Resistance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "Ohm"), typeof(Unit<Resistance>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "Ohm", value);
			}
		}

		double IQuantity.BaseValue => BaseValue;

		public double SIPower => 1.0;

		public Unit<Resistance> DefaultUnit => Ohm;

		public Resistance(double baseValue = 0.0)
		{
			this = default(Resistance);
			BaseValue = baseValue;
		}

		public bool Equals(Resistance other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public int CompareTo(Resistance other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public IUnit[] GetCommonSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetCommonSIUnits"), typeof(IUnit[]));
		}

		public IUnit[] GetExludedSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetExludedSIUnits"), typeof(IUnit[]));
		}

		public Resistance New(double baseVal)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "New", baseVal), typeof(Resistance));
		}

		public Resistance Add(Resistance q)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", q), typeof(Resistance));
		}

		public Resistance Subtract(Resistance q)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", q), typeof(Resistance));
		}

		public Resistance Multiply(double n)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", n), typeof(Resistance));
		}

		public Resistance Multiply(Resistance a, Ratio r)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", a, r), typeof(Resistance));
		}

		public Resistance Multiply(Ratio r, Resistance a)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", r, a), typeof(Resistance));
		}

		public Resistance Divide(double n)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", n), typeof(Resistance));
		}

		public Ratio Divide(Resistance q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", q), typeof(Ratio));
		}

		public static Resistance Parse(string str, Unit<Resistance> defaultUnit = null)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Resistance));
		}

		public static bool TryParse(string str, out Resistance q, Unit<Resistance> defaultUnit = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, q, defaultUnit), typeof(bool));
		}

		public static Resistance operator +(Resistance a, Resistance b)
		{
			return a.Add(b);
		}

		public static Resistance operator -(Resistance a, Resistance b)
		{
			return a.Subtract(b);
		}

		public static Resistance operator *(Resistance a, double n)
		{
			return a.Multiply(n);
		}

		public static Resistance operator /(Resistance a, double n)
		{
			return a.Divide(n);
		}

		public static Ratio operator /(Resistance a, Resistance b)
		{
			return a.Divide(b);
		}

		public static Resistance operator -(Resistance a)
		{
			return a.Multiply(-1.0);
		}

		public static Voltage operator *(Resistance r, Current i)
		{
			return new Voltage(r.BaseValue * i.BaseValue);
		}

		public static Voltage operator *(Current i, Resistance r)
		{
			return new Voltage(r.BaseValue * i.BaseValue);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Resistance(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Voltage : IQuantitySI<Voltage>, IQuantitySI, IQuantity<Voltage>, IQuantity, IComparable<Voltage>, IEquatable<Voltage>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public double BaseValue
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BaseValue"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BaseValue", value);
			}
		}

		public static Unit<Voltage> Volt
		{
			get
			{
				return (Unit<Voltage>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "Volt"), typeof(Unit<Voltage>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "Volt", value);
			}
		}

		double IQuantity.BaseValue => BaseValue;

		public double SIPower => 1.0;

		public Unit<Voltage> DefaultUnit => Volt;

		public Voltage(double baseValue = 0.0)
		{
			this = default(Voltage);
			BaseValue = baseValue;
		}

		public bool Equals(Voltage other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public int CompareTo(Voltage other)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTo", other), typeof(int));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public IUnit[] GetCommonSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetCommonSIUnits"), typeof(IUnit[]));
		}

		public IUnit[] GetExludedSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetExludedSIUnits"), typeof(IUnit[]));
		}

		public Voltage New(double baseVal)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "New", baseVal), typeof(Voltage));
		}

		public Voltage Add(Voltage q)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", q), typeof(Voltage));
		}

		public Voltage Subtract(Voltage q)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", q), typeof(Voltage));
		}

		public Voltage Multiply(double n)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", n), typeof(Voltage));
		}

		public Voltage Multiply(Voltage a, Ratio r)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", a, r), typeof(Voltage));
		}

		public Voltage Multiply(Ratio r, Voltage a)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", r, a), typeof(Voltage));
		}

		public Voltage Divide(double n)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", n), typeof(Voltage));
		}

		public Ratio Divide(Voltage q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Divide", q), typeof(Ratio));
		}

		public static Voltage Parse(string str, Unit<Voltage> defaultUnit = null)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Voltage));
		}

		public static bool TryParse(string str, out Voltage q, Unit<Voltage> defaultUnit = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", str, q, defaultUnit), typeof(bool));
		}

		public static Voltage operator +(Voltage a, Voltage b)
		{
			return a.Add(b);
		}

		public static Voltage operator -(Voltage a, Voltage b)
		{
			return a.Subtract(b);
		}

		public static Voltage operator *(Voltage a, double n)
		{
			return a.Multiply(n);
		}

		public static Voltage operator /(Voltage a, double n)
		{
			return a.Divide(n);
		}

		public static Ratio operator /(Voltage a, Voltage b)
		{
			return a.Divide(b);
		}

		public static Voltage operator -(Voltage a)
		{
			return a.Multiply(-1.0);
		}

		public static Current operator /(Voltage v, Resistance r)
		{
			return new Current(v.BaseValue / r.BaseValue);
		}

		public static Resistance operator /(Voltage v, Current c)
		{
			return new Resistance(v.BaseValue / c.BaseValue);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Voltage(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
}
