using ResoniteBridge;
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Unit"), typeof(Unit<T>)) is Unit<T> __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to Unit<T>");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Unit", value);
				}
			}

			public System.String OverrideUnitName
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OverrideUnitName"), typeof(System.String)) is System.String __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to string");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OverrideUnitName", value);
				}
			}

			public System.String OverrideSeparator
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OverrideSeparator"), typeof(System.String)) is System.String __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to string");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OverrideSeparator", value);
				}
			}

			public System.String OverrideNumberFormat
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OverrideNumberFormat"), typeof(System.String)) is System.String __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to string");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OverrideNumberFormat", value);
				}
			}

			public CompoundZeroHandling? OverrideZeroHandling
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OverrideZeroHandling"), typeof(CompoundZeroHandling)) is CompoundZeroHandling __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to CompoundZeroHandling");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OverrideZeroHandling", value);
				}
			}

			public Info(Unit<T> unit, System.String overrideUnitName = null, System.String overrideSeparator = null, System.String overrideNumberFormat = null, CompoundZeroHandling? overrideZeroHandling = null)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Info", ResoniteBridge.ResoniteBridgeValueType.Type), unit, overrideUnitName, overrideSeparator, overrideNumberFormat, overrideZeroHandling);
			}

			public ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return __backing;
				}
				set
				{
					__backing = value;
				}
			}

			public Info(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public Info()
			{
			}
		}

		public System.String defaultSeparator
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "defaultSeparator"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "defaultSeparator", value);
			}
		}

		public Info[] formatInfo
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "formatInfo"), typeof(Info[])) is Info[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Info[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "formatInfo", value);
			}
		}

		public System.String LastNumberFormat
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastNumberFormat"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastNumberFormat", value);
			}
		}

		public System.String NumberFormat
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NumberFormat"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NumberFormat", value);
			}
		}

		public CompoundZeroHandling ZeroHandling
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ZeroHandling"), typeof(CompoundZeroHandling)) is CompoundZeroHandling __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CompoundZeroHandling");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ZeroHandling", value);
			}
		}

		public System.Boolean UseLongNames
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseLongNames"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UseLongNames", value);
			}
		}

		public System.Boolean DiscardLastFraction
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DiscardLastFraction"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DiscardLastFraction", value);
			}
		}

		public System.Int32 UnitCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UnitCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public CompoundFormatInfo(System.String defaultSeparator, System.String lastNumberFormat, CompoundZeroHandling zeroHandling, System.Boolean useLongNames, System.Boolean discardLastFraction, params Info[] formatInfo)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "CompoundFormatInfo", ResoniteBridge.ResoniteBridgeValueType.Type), defaultSeparator, lastNumberFormat, zeroHandling, useLongNames, discardLastFraction, formatInfo);
		}

		public CompoundFormatInfo(System.String defaultSeparator, System.String lastNumberFormat, CompoundZeroHandling zeroHandling, System.Boolean useLongNames, System.Boolean discardLastFraction, IEnumerable<Info> formatInfo)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "CompoundFormatInfo", ResoniteBridge.ResoniteBridgeValueType.Type), defaultSeparator, lastNumberFormat, zeroHandling, useLongNames, discardLastFraction, formatInfo);
		}

		public Unit<T> GetUnit(System.Int32 index)
		{
			return (Unit<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUnit", index), typeof(Unit<T>));
		}

		public System.String GetSeparator(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSeparator", index), typeof(System.String));
		}

		public System.String GetUnitName(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUnitName", index), typeof(System.String));
		}

		public System.String GetNumberFormat(System.Int32 index)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNumberFormat", index), typeof(System.String));
		}

		public CompoundZeroHandling GetZeroHandling(System.Int32 index)
		{
			return (CompoundZeroHandling)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetZeroHandling", index), typeof(CompoundZeroHandling));
		}

		public CompoundFormatInfo<T> OverrideLastNumberFormat(System.String format)
		{
			return (CompoundFormatInfo<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OverrideLastNumberFormat", format), typeof(CompoundFormatInfo<T>));
		}

		public CompoundFormatInfo<T> OverrideSeparator(System.String separator)
		{
			return (CompoundFormatInfo<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OverrideSeparator", separator), typeof(CompoundFormatInfo<T>));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CompoundFormatInfo(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public CompoundFormatInfo()
		{
		}
	}
	public class SmartQuantityException : Exception, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public SmartQuantityException(System.String message, Exception innerException = null)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SmartQuantityException", ResoniteBridge.ResoniteBridgeValueType.Type), message, innerException);
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SmartQuantityException(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SmartQuantityException()
		{
		}
	}
	public class UnitNameNotFoundException : SmartQuantityException, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String UnitName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UnitName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UnitName", value);
			}
		}

		public UnitNameNotFoundException(System.String unitName, Exception innerException = null)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitNameNotFoundException", ResoniteBridge.ResoniteBridgeValueType.Type), unitName, innerException);
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public UnitNameNotFoundException(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public UnitNameNotFoundException()
		{
		}
	}
	public struct QVector3<T> : ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantity<T>
	{
		public T x
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "x"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "x", value);
			}
		}

		public T y
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "y"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "y", value);
			}
		}

		public T z
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "z"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "z", value);
			}
		}

		public T SqrMagnitude
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SqrMagnitude"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
		}

		public T Magnitude
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Magnitude"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
		}

		public QVector3<T> Normalized
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Normalized"), typeof(QVector3<T>)) is QVector3<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to QVector3<T>");
				}
			}
		}

		public T this[System.Int32 axis] => axis switch
		{
			0 => x, 
			1 => y, 
			2 => z, 
			_ => throw new Exception("Wrong QVector3 axis index. Must be between 0 and 2"), 
		};

		public static QVector3<T> Zero
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), "Zero"), typeof(QVector3<T>)) is QVector3<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to QVector3<T>");
				}
			}
		}

		public static QVector3<T> One
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), "One"), typeof(QVector3<T>)) is QVector3<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to QVector3<T>");
				}
			}
		}

		public QVector3(System.Double x, System.Double y, System.Double z)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), x, y, z);
		}

		public QVector3(T x, T y, T z)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), x, y, z);
		}

		public System.String FormatAs(Unit<T> unit, System.String formatNum = null, System.Boolean longName = false)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FormatAs", unit, formatNum, longName), typeof(System.String));
		}

		public System.String FormatAuto(System.String formatNum = null, System.Boolean longName = false, List<UnitGroup> unitGroups = null)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FormatAuto", formatNum, longName, unitGroups), typeof(System.String));
		}

		public static QVector3<T> operator +(QVector3<T> a, QVector3<T> b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(QVector3<T>)) is QVector3<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to QVector3<T>");
			}
		}

		public static QVector3<T> operator -(QVector3<T> a, QVector3<T> b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(QVector3<T>)) is QVector3<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to QVector3<T>");
			}
		}

		public static QVector3<T> operator *(QVector3<T> v, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", v, n), typeof(QVector3<T>)) is QVector3<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to QVector3<T>");
			}
		}

		public static QVector3<T> operator /(QVector3<T> v, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", v, n), typeof(QVector3<T>)) is QVector3<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to QVector3<T>");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public QVector3(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public QVector3()
		{
		}
	}
	public static class SI<T> where T : struct, IQuantitySI<T>
	{
		public static UnitSI<T> Quecto
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Quecto"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Ronto"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Yocto"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Zepto"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Atto"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Femto"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Pico"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Nano"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Micro"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Milli"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Centi"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Deci"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Deca"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Hecto"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Kilo"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Mega"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Giga"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Tera"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Peta"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Exa"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Zetta"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Yotta"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Ronna"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Quetta"), typeof(UnitSI<T>)) is UnitSI<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitSI<T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "SI", ResoniteBridge.ResoniteBridgeValueType.Type), "Quetta", value);
			}
		}
	}
	public class UnitNonLinear<T> : Unit<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantity<T>
	{
		public Func<double, double> convertToFunc
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "convertToFunc"), typeof(Func<double, double>)) is Func<double, double> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Func<double, double>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "convertToFunc", value);
			}
		}

		public Func<double, double> convertFromFunc
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "convertFromFunc"), typeof(Func<double, double>)) is Func<double, double> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Func<double, double>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "convertFromFunc", value);
			}
		}

		public UnitNonLinear(Func<double, double> convertToFunc, Func<double, double> convertFromFunc, ICollection<UnitGroup> unitGroups, string[] shortNames, string[] longNames)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitNonLinear", ResoniteBridge.ResoniteBridgeValueType.Type), convertToFunc, convertFromFunc, unitGroups, shortNames, longNames);
		}

		public override T ConvertFrom(System.Double val)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConvertFrom", val), typeof(T));
		}

		public override System.Double ConvertTo(T q)
		{
			return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConvertTo", q), typeof(System.Double));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public UnitNonLinear(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public UnitNonLinear()
		{
		}
	}
	public struct Acceleration : IQuantity<Acceleration>, IQuantity, IComparable<Acceleration>, IEquatable<Acceleration>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Double BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BaseValue", value);
			}
		}

		public static Unit<Acceleration> MetersPerSecondPerSecond
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "MetersPerSecondPerSecond"), typeof(Unit<Acceleration>)) is Unit<Acceleration> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Acceleration>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "MetersPerSecondPerSecond", value);
			}
		}

		System.Double IQuantity.BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public Unit<Acceleration> DefaultUnit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Acceleration>)) is Unit<Acceleration> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Acceleration>");
				}
			}
		}

		public Acceleration(System.Double baseValue = 0.0)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), baseValue);
		}

		public System.Boolean Equals(Acceleration other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Int32 CompareTo(Acceleration other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public Acceleration New(System.Double baseVal)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Acceleration));
		}

		public Acceleration Add(Acceleration q)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Acceleration));
		}

		public Acceleration Subtract(Acceleration q)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Acceleration));
		}

		public Acceleration Multiply(System.Double n)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Acceleration));
		}

		public Acceleration Multiply(Acceleration a, Ratio r)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Acceleration));
		}

		public Acceleration Multiply(Ratio r, Acceleration a)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Acceleration));
		}

		public Acceleration Divide(System.Double n)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Acceleration));
		}

		public Ratio Divide(Acceleration q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio));
		}

		public static Acceleration Parse(System.String str, Unit<Acceleration> defaultUnit = null)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Acceleration));
		}

		public static System.Boolean TryParse(System.String str, out Acceleration q, Unit<Acceleration> defaultUnit = null)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, defaultUnit), typeof(System.Boolean));
			q = (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(Acceleration));
			return __finalResult;
		}

		public static Acceleration operator +(Acceleration a, Acceleration b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Acceleration)) is Acceleration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Acceleration");
			}
		}

		public static Acceleration operator -(Acceleration a, Acceleration b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Acceleration)) is Acceleration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Acceleration");
			}
		}

		public static Acceleration operator *(Acceleration a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Acceleration)) is Acceleration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Acceleration");
			}
		}

		public static Acceleration operator /(Acceleration a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Acceleration)) is Acceleration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Acceleration");
			}
		}

		public static Ratio operator /(Acceleration a, Acceleration b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Acceleration operator -(Acceleration a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Acceleration)) is Acceleration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Acceleration");
			}
		}

		public static Velocity operator *(Acceleration a, Time t)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, t), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Acceleration(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Acceleration()
		{
		}
	}
	public struct Angle : IQuantitySI<Angle>, IQuantitySI, IQuantity<Angle>, IQuantity, IComparable<Angle>, IEquatable<Angle>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Double BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BaseValue", value);
			}
		}

		public static Unit<Angle> Radian
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "Radian"), typeof(Unit<Angle>)) is Unit<Angle> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Angle>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "Degree"), typeof(Unit<Angle>)) is Unit<Angle> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Angle>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "ArcMinute"), typeof(Unit<Angle>)) is Unit<Angle> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Angle>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "ArcSecond"), typeof(Unit<Angle>)) is Unit<Angle> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Angle>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "DegreeMinSec"), typeof(CompoundFormatInfo<Angle>)) is CompoundFormatInfo<Angle> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CompoundFormatInfo<Angle>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "DegreeMinSec", value);
			}
		}

		System.Double IQuantity.BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public System.Double SIPower
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public Unit<Angle> DefaultUnit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Angle>)) is Unit<Angle> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Angle>");
				}
			}
		}

		public Angle(System.Double baseValue = 0.0)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), baseValue);
		}

		public System.Boolean Equals(Angle other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Int32 CompareTo(Angle other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public IUnit[] GetCommonSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCommonSIUnits"), typeof(IUnit[]));
		}

		public IUnit[] GetExludedSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExludedSIUnits"), typeof(IUnit[]));
		}

		public Angle New(System.Double baseVal)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Angle));
		}

		public Angle Add(Angle q)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Angle));
		}

		public Angle Subtract(Angle q)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Angle));
		}

		public Angle Multiply(System.Double n)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Angle));
		}

		public Angle Multiply(Angle a, Ratio r)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Angle));
		}

		public Angle Multiply(Ratio r, Angle a)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Angle));
		}

		public Angle Divide(System.Double n)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Angle));
		}

		public Ratio Divide(Angle q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio));
		}

		public static Angle Parse(System.String str, Unit<Angle> defaultUnit = null)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Angle));
		}

		public static System.Boolean TryParse(System.String str, out Angle q, Unit<Angle> defaultUnit = null)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, defaultUnit), typeof(System.Boolean));
			q = (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(Angle));
			return __finalResult;
		}

		public static Angle operator +(Angle a, Angle b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Angle)) is Angle __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Angle");
			}
		}

		public static Angle operator -(Angle a, Angle b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Angle)) is Angle __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Angle");
			}
		}

		public static Angle operator *(Angle a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Angle)) is Angle __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Angle");
			}
		}

		public static Angle operator /(Angle a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Angle)) is Angle __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Angle");
			}
		}

		public static Ratio operator /(Angle a, Angle b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Angle operator -(Angle a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Angle)) is Angle __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Angle");
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Angle(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Angle()
		{
		}
	}
	public struct Distance : IQuantitySI<Distance>, IQuantitySI, IQuantity<Distance>, IQuantity, IComparable<Distance>, IEquatable<Distance>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Double BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BaseValue", value);
			}
		}

		public static Unit<Distance> Meter
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Meter"), typeof(Unit<Distance>)) is Unit<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Distance>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Angstrom"), typeof(Unit<Distance>)) is Unit<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Distance>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "SolarRadius"), typeof(Unit<Distance>)) is Unit<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Distance>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "AU"), typeof(Unit<Distance>)) is Unit<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Distance>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Lightyear"), typeof(Unit<Distance>)) is Unit<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Distance>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Lightsecond"), typeof(Unit<Distance>)) is Unit<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Distance>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Parsec"), typeof(Unit<Distance>)) is Unit<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Distance>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Thou"), typeof(Unit<Distance>)) is Unit<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Distance>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Inch"), typeof(Unit<Distance>)) is Unit<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Distance>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Foot"), typeof(Unit<Distance>)) is Unit<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Distance>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Yard"), typeof(Unit<Distance>)) is Unit<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Distance>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Mile"), typeof(Unit<Distance>)) is Unit<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Distance>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "FeetInches"), typeof(CompoundFormatInfo<Distance>)) is CompoundFormatInfo<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CompoundFormatInfo<Distance>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "FeetInches", value);
			}
		}

		System.Double IQuantity.BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public System.Double SIPower
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public Unit<Distance> DefaultUnit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Distance>)) is Unit<Distance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Distance>");
				}
			}
		}

		public Distance(System.Double baseValue = 0.0)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), baseValue);
		}

		public System.Boolean Equals(Distance other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Int32 CompareTo(Distance other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public IUnit[] GetCommonSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCommonSIUnits"), typeof(IUnit[]));
		}

		public IUnit[] GetExludedSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExludedSIUnits"), typeof(IUnit[]));
		}

		public Distance New(System.Double baseVal)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Distance));
		}

		public Distance Add(Distance q)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Distance));
		}

		public Distance Subtract(Distance q)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Distance));
		}

		public Distance Multiply(System.Double n)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Distance));
		}

		public Distance Multiply(Distance a, Ratio r)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Distance));
		}

		public Distance Multiply(Ratio r, Distance a)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Distance));
		}

		public Distance Divide(System.Double n)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Distance));
		}

		public Ratio Divide(Distance q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio));
		}

		public static Distance Parse(System.String str, Unit<Distance> defaultUnit = null)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Distance));
		}

		public static System.Boolean TryParse(System.String str, out Distance q, Unit<Distance> defaultUnit = null)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, defaultUnit), typeof(System.Boolean));
			q = (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(Distance));
			return __finalResult;
		}

		public static Distance operator +(Distance a, Distance b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Distance)) is Distance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Distance");
			}
		}

		public static Distance operator -(Distance a, Distance b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Distance)) is Distance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Distance");
			}
		}

		public static Distance operator *(Distance a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Distance)) is Distance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Distance");
			}
		}

		public static Distance operator /(Distance a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Distance)) is Distance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Distance");
			}
		}

		public static Ratio operator /(Distance a, Distance b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Distance operator -(Distance a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Distance)) is Distance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Distance");
			}
		}

		public static Velocity operator /(Distance l, Time t)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", l, t), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Distance(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Distance()
		{
		}
	}
	public interface IQuantity : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Double BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		string[] GetShortBaseNames();

		string[] GetLongBaseNames();
	}
	public interface IQuantity<T> : IQuantity, IComparable<T>, IEquatable<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantity<T>
	{
		Unit<T> DefaultUnit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<T>)) is Unit<T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<T>");
				}
			}
		}

		T New(System.Double baseValue);

		T Add(T q);

		T Subtract(T q);

		T Multiply(System.Double n);

		T Divide(System.Double n);

		Ratio Divide(T q);
	}
	public interface IQuantitySI : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Double SIPower
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		IUnit[] GetCommonSIUnits();

		IUnit[] GetExludedSIUnits();
	}
	public interface IQuantitySI<T> : IQuantitySI, IQuantity<T>, IQuantity, IComparable<T>, IEquatable<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantity<T>
	{
	}
	public class UnitSI<T> : Unit<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantitySI<T>
	{
		public static System.Double SIPower
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitSI", ResoniteBridge.ResoniteBridgeValueType.Type), "SIPower"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitSI", ResoniteBridge.ResoniteBridgeValueType.Type), "SIPower", value);
			}
		}

		static UnitSI()
		{
		}

		public UnitSI(System.Int32 nFactor, System.String shortPrefix, System.String longPrefix)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitSI", ResoniteBridge.ResoniteBridgeValueType.Type), nFactor, shortPrefix, longPrefix);
		}

		public UnitSI(System.Int32 nFactor, string[] shortPrefixes, string[] longPrefixes)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitSI", ResoniteBridge.ResoniteBridgeValueType.Type), nFactor, shortPrefixes, longPrefixes);
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public UnitSI(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public UnitSI()
		{
		}
	}
	public interface IUnit : IComparable<IUnit>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Double Ratio
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Ratio"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		Type ValueType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		ICollection<string> GetUnitNames();
	}
	public class Unit<T> : IUnit, IComparable<IUnit>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantity<T>
	{
		public string[] shortNames
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "shortNames"), typeof(string[])) is string[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "shortNames", value);
			}
		}

		public string[] longNames
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "longNames"), typeof(string[])) is string[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "longNames", value);
			}
		}

		public static System.String shortBaseName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "shortBaseName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "shortBaseName", value);
			}
		}

		public static System.String longBaseName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "longBaseName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "longBaseName", value);
			}
		}

		public System.Double Ratio
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Ratio"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Ratio", value);
			}
		}

		public Type ValueType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
		}

		public System.Int32 CompareTo(IUnit other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
		}

		public ICollection<string> GetUnitNames()
		{
			return (ICollection<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUnitNames"), typeof(ICollection<string>));
		}

		public Unit(System.Double baseRatio, ICollection<UnitGroup> unitGroups, string[] shortNames, string[] longNames)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), baseRatio, unitGroups, shortNames, longNames);
		}

		public virtual System.Double ConvertTo(T q)
		{
			return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConvertTo", q), typeof(System.Double));
		}

		public T ConvertFrom(T q)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConvertFrom", q), typeof(T));
		}

		public virtual T ConvertFrom(System.Double val)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConvertFrom", val), typeof(T));
		}

		public static T Parse(System.String str, NumberStyles numberStyles, IFormatProvider formatProvider, Unit<T> defaultUnit = null)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, numberStyles, formatProvider, defaultUnit), typeof(T));
		}

		public static T Parse(System.String str, Unit<T> defaultUnit = null)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(T));
		}

		public static System.Boolean TryParse(System.String str, out T quantity, Unit<T> defaultUnit = null)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, defaultUnit), typeof(System.Boolean));
			quantity = (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(T));
			return __finalResult;
		}

		public static System.Boolean TryParse(System.String str, NumberStyles numberStyles, IFormatProvider formatProvider, out T quantity, Unit<T> defaultUnit = null)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, numberStyles, formatProvider, defaultUnit), typeof(System.Boolean));
			quantity = (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(T));
			return __finalResult;
		}

		public static System.Boolean ParseIntern(System.String str, NumberStyles numberStyles, IFormatProvider formatProvider, out T quantity, Unit<T> defaultUnit, System.Boolean throwOnFail)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "ParseIntern", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, numberStyles, formatProvider, defaultUnit, throwOnFail), typeof(System.Boolean));
			quantity = (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(T));
			return __finalResult;
		}

		public static IUnit GetUnitFromSubstring(System.String str, out System.Int32 unitEndIndex, System.Boolean byLetter = false)
		{
			IUnit __finalResult = (IUnit)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUnitFromSubstring", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, byLetter), typeof(IUnit));
			unitEndIndex = (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(System.Int32));
			return __finalResult;
		}

		public static System.Int32 IndexOfNumberEnd(System.String str)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "IndexOfNumberEnd", str), typeof(System.Int32));
		}

		public System.String FormatAs(T q, System.String formatNum = null, System.Boolean longName = false, System.String overrideName = null)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FormatAs", q, formatNum, longName, overrideName), typeof(System.String));
		}

		public static T operator *(Unit<T> unit, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", unit, n), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public static T operator *(System.Double n, Unit<T> unit)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", n, unit), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Unit(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Unit()
		{
		}
	}
	public delegate System.Boolean NumberTryParseHandler<T>(System.String str, NumberStyles numberStyles, IFormatProvider formatProvider, out T value);
	public static class QuantityHelper
	{
		public static CultureInfo Culture
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Culture"), typeof(CultureInfo)) is CultureInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CultureInfo");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CustomParser"), typeof(NumberTryParseHandler<double>)) is NumberTryParseHandler<double> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NumberTryParseHandler<double>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CustomParser", value);
			}
		}

		public static Dictionary<Type, List<IUnit>> unitCache
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "unitCache"), typeof(Dictionary<Type, List<IUnit>>)) is Dictionary<Type, List<IUnit>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<Type, List<IUnit>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "unitCache", value);
			}
		}

		public static Dictionary<Type, Dictionary<string, IUnit>> unitNameCache
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "unitNameCache"), typeof(Dictionary<Type, Dictionary<string, IUnit>>)) is Dictionary<Type, Dictionary<string, IUnit>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<Type, Dictionary<string, IUnit>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "unitNameCache", value);
			}
		}

		public static System.Boolean TryParse(System.String str, NumberStyles numberStyles, IFormatProvider formatProvider, out System.Double value)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, numberStyles, formatProvider), typeof(System.Boolean));
			value = (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(System.Double));
			return __finalResult;
		}

		public static System.Double ConvertTo<T>(this T q, Unit<T> unit) where T : struct, IQuantity<T>
		{
			return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertTo", q, unit), typeof(System.Double));
		}

		public static System.String FormatAs<T>(this T q, Unit<T> unit, System.String formatNum = null, System.Boolean longName = false, System.String overrideName = null) where T : struct, IQuantity<T>
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatAs", q, unit, formatNum, longName, overrideName), typeof(System.String));
		}

		public static System.String FormatAs<T>(this T q, System.String unitName, System.String formatNum = null, System.Boolean longName = false) where T : struct, IQuantity<T>
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatAs", q, unitName, formatNum, longName), typeof(System.String));
		}

		public static System.String FormatAuto<T>(this T q, System.String formatNum, System.Boolean longName, UnitGroup unitGroup, Unit<T> defaultUnit = null) where T : struct, IQuantity<T>
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatAuto", q, formatNum, longName, unitGroup, defaultUnit), typeof(System.String));
		}

		public static System.String FormatAuto<T>(this T q, System.String formatNum = null, System.Boolean longName = false, List<UnitGroup> groups = null, Unit<T> defaultUnit = null) where T : struct, IQuantity<T>
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatAuto", q, formatNum, longName, groups, defaultUnit), typeof(System.String));
		}

		public static System.String FormatCompound<T>(this T q, ICollection<Unit<T>> units, System.String separator = " ", CompoundZeroHandling zeroHandling = CompoundZeroHandling.RemoveAny, System.String lastNumberFormat = null, System.Boolean longNames = false, System.Boolean discardLastFraction = false) where T : struct, IQuantity<T>
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatCompound", q, units, separator, zeroHandling, lastNumberFormat, longNames, discardLastFraction), typeof(System.String));
		}

		public static System.String FormatCompound<T>(this T q, CompoundFormatInfo<T> formatInfo) where T : struct, IQuantity<T>
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatCompound", q, formatInfo), typeof(System.String));
		}

		public static IEnumerable<IUnit> GetUnits<T>()
		{
			return (IEnumerable<IUnit>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUnits"), typeof(IEnumerable<IUnit>));
		}

		public static Unit<T> SelectBestUnit<T>(this T q, List<UnitGroup> groups) where T : struct, IQuantity<T>
		{
			return (Unit<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SelectBestUnit", q, groups), typeof(Unit<T>));
		}

		public static System.Boolean ContainsUnit(IUnit unit, List<UnitGroup> groups)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ContainsUnit", unit, groups), typeof(System.Boolean));
		}

		public static IUnit GetUnitByName<T>(System.String name)
		{
			return (IUnit)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUnitByName", name), typeof(IUnit));
		}

		static QuantityHelper()
		{
		}
	}
	public class UnitGroup : IEnumerable<IUnit>, IEnumerable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public struct Enumerator : IEnumerator<IUnit>, IDisposable, IEnumerator, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public System.Boolean firstDone
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "firstDone"), typeof(System.Boolean)) is System.Boolean __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to bool");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "firstDone", value);
				}
			}

			public Dictionary<Type, SortedSet<IUnit>>.Enumerator dictEnum
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dictEnum"), typeof(Dictionary<Type, SortedSet<IUnit>>.Enumerator)) is Dictionary<Type, SortedSet<IUnit>>.Enumerator __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to Dictionary<Type, SortedSet<IUnit>>.Enumerator");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "dictEnum", value);
				}
			}

			public SortedSet<IUnit>.Enumerator setEnum
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "setEnum"), typeof(SortedSet<IUnit>.Enumerator)) is SortedSet<IUnit>.Enumerator __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to SortedSet<IUnit>.Enumerator");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "setEnum", value);
				}
			}

			public IUnit Current
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Current"), typeof(IUnit)) is IUnit __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IUnit");
					}
				}
			}

			System.Object IEnumerator.Current
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Current"), typeof(System.Object)) is System.Object __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to object");
					}
				}
			}

			public Enumerator(UnitGroup group)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Enumerator", ResoniteBridge.ResoniteBridgeValueType.Type), group);
			}

			public void Dispose()
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
			}

			public System.Boolean MoveNext()
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MoveNext"), typeof(System.Boolean));
			}

			public void Reset()
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
			}

			public ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return __backing;
				}
				set
				{
					__backing = value;
				}
			}

			public Enumerator(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public Enumerator()
			{
			}
		}

		public static List<UnitGroup> DefaultUnitGroups
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "DefaultUnitGroups"), typeof(List<UnitGroup>)) is List<UnitGroup> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<UnitGroup>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Common"), typeof(UnitGroup)) is UnitGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitGroup");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Metric"), typeof(UnitGroup)) is UnitGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitGroup");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "MetricThousands"), typeof(UnitGroup)) is UnitGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitGroup");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "CommonMetric"), typeof(UnitGroup)) is UnitGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitGroup");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Scientific"), typeof(UnitGroup)) is UnitGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitGroup");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Astronomical"), typeof(UnitGroup)) is UnitGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitGroup");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Molecular"), typeof(UnitGroup)) is UnitGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitGroup");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Meteorological"), typeof(UnitGroup)) is UnitGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitGroup");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Aviation"), typeof(UnitGroup)) is UnitGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitGroup");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Maritime"), typeof(UnitGroup)) is UnitGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitGroup");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Imperial"), typeof(UnitGroup)) is UnitGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UnitGroup");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "Imperial", value);
			}
		}

		public Dictionary<Type, SortedSet<IUnit>> units
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "units"), typeof(Dictionary<Type, SortedSet<IUnit>>)) is Dictionary<Type, SortedSet<IUnit>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<Type, SortedSet<IUnit>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "units", value);
			}
		}

		static UnitGroup()
		{
		}

		public void RegisterUnit(IUnit unit)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterUnit", unit);
		}

		public void RemoveUnit(IUnit unit)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveUnit", unit);
		}

		public System.Boolean HasUnit(IUnit unit)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasUnit", unit), typeof(System.Boolean));
		}

		public SortedSet<IUnit> GetSetForType(Type type, System.Boolean createIfNotExists = true)
		{
			return (SortedSet<IUnit>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSetForType", type, createIfNotExists), typeof(SortedSet<IUnit>));
		}

		public Enumerator GetEnumerator()
		{
			return (Enumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEnumerator"), typeof(Enumerator));
		}

		IEnumerator<IUnit> IEnumerable<IUnit>.GetEnumerator()
		{
			return (IEnumerator<IUnit>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IEnumerable<IUnit>.GetEnumerator"), typeof(IEnumerator<IUnit>));
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IEnumerable.GetEnumerator"), typeof(IEnumerator));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public UnitGroup(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public UnitGroup()
		{
		}
	}
	public struct Mass : IQuantitySI<Mass>, IQuantitySI, IQuantity<Mass>, IQuantity, IComparable<Mass>, IEquatable<Mass>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Double BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BaseValue", value);
			}
		}

		public static Unit<Mass> Gram
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Gram"), typeof(Unit<Mass>)) is Unit<Mass> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Mass>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Ton"), typeof(Unit<Mass>)) is Unit<Mass> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Mass>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Grain"), typeof(Unit<Mass>)) is Unit<Mass> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Mass>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Drachm"), typeof(Unit<Mass>)) is Unit<Mass> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Mass>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Ounce"), typeof(Unit<Mass>)) is Unit<Mass> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Mass>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Pound"), typeof(Unit<Mass>)) is Unit<Mass> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Mass>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Stone"), typeof(Unit<Mass>)) is Unit<Mass> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Mass>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Quarter"), typeof(Unit<Mass>)) is Unit<Mass> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Mass>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "HundredWeight"), typeof(Unit<Mass>)) is Unit<Mass> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Mass>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "ImperialTon"), typeof(Unit<Mass>)) is Unit<Mass> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Mass>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Slug"), typeof(Unit<Mass>)) is Unit<Mass> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Mass>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Slug", value);
			}
		}

		System.Double IQuantity.BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public System.Double SIPower
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public Unit<Mass> DefaultUnit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Mass>)) is Unit<Mass> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Mass>");
				}
			}
		}

		public Mass(System.Double baseValue = 0.0)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), baseValue);
		}

		public System.Boolean Equals(Mass other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Int32 CompareTo(Mass other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public IUnit[] GetCommonSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCommonSIUnits"), typeof(IUnit[]));
		}

		public IUnit[] GetExludedSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExludedSIUnits"), typeof(IUnit[]));
		}

		public Mass New(System.Double baseVal)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Mass));
		}

		public Mass Add(Mass q)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Mass));
		}

		public Mass Subtract(Mass q)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Mass));
		}

		public Mass Multiply(System.Double n)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Mass));
		}

		public Mass Multiply(Mass a, Ratio r)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Mass));
		}

		public Mass Multiply(Ratio r, Mass a)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Mass));
		}

		public Mass Divide(System.Double n)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Mass));
		}

		public Ratio Divide(Mass q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio));
		}

		public static Mass Parse(System.String str, Unit<Mass> defaultUnit = null)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Mass));
		}

		public static System.Boolean TryParse(System.String str, out Mass q, Unit<Mass> defaultUnit = null)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, defaultUnit), typeof(System.Boolean));
			q = (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(Mass));
			return __finalResult;
		}

		public static Mass operator +(Mass a, Mass b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Mass)) is Mass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Mass");
			}
		}

		public static Mass operator -(Mass a, Mass b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Mass)) is Mass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Mass");
			}
		}

		public static Mass operator *(Mass a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Mass)) is Mass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Mass");
			}
		}

		public static Mass operator /(Mass a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Mass)) is Mass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Mass");
			}
		}

		public static Ratio operator /(Mass a, Mass b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Mass operator -(Mass a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Mass)) is Mass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Mass");
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Mass(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Mass()
		{
		}
	}
	public struct Ratio : IQuantity<Ratio>, IQuantity, IComparable<Ratio>, IEquatable<Ratio>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Double BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BaseValue", value);
			}
		}

		public static Unit<Ratio> RatioValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "RatioValue"), typeof(Unit<Ratio>)) is Unit<Ratio> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Ratio>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "Percent"), typeof(Unit<Ratio>)) is Unit<Ratio> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Ratio>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "Percent", value);
			}
		}

		System.Double IQuantity.BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public Unit<Ratio> DefaultUnit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Ratio>)) is Unit<Ratio> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Ratio>");
				}
			}
		}

		public Ratio(System.Double baseValue = 0.0)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), baseValue);
		}

		public System.Boolean Equals(Ratio other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Int32 CompareTo(Ratio other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public Ratio New(System.Double baseVal)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Ratio));
		}

		public Ratio Add(Ratio q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Ratio));
		}

		public Ratio Subtract(Ratio q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Ratio));
		}

		public Ratio Multiply(System.Double n)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Ratio));
		}

		public Ratio Multiply(Ratio a, Ratio r)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Ratio));
		}

		public Ratio Divide(System.Double n)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Ratio));
		}

		public Ratio Divide(Ratio q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio));
		}

		public static Ratio Parse(System.String str, Unit<Ratio> defaultUnit = null)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Ratio));
		}

		public static System.Boolean TryParse(System.String str, out Ratio q, Unit<Ratio> defaultUnit = null)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, defaultUnit), typeof(System.Boolean));
			q = (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(Ratio));
			return __finalResult;
		}

		public static Ratio operator +(Ratio a, Ratio b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Ratio operator -(Ratio a, Ratio b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Ratio operator *(Ratio a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Ratio operator /(Ratio a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Ratio operator /(Ratio a, Ratio b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Ratio operator -(Ratio a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Ratio(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Ratio()
		{
		}
	}
	public struct Temperature : IQuantity<Temperature>, IQuantity, IComparable<Temperature>, IEquatable<Temperature>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Double BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BaseValue", value);
			}
		}

		public static Unit<Temperature> Kelvin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "Kelvin"), typeof(Unit<Temperature>)) is Unit<Temperature> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Temperature>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "Celsius"), typeof(Unit<Temperature>)) is Unit<Temperature> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Temperature>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "Fahrenheit"), typeof(Unit<Temperature>)) is Unit<Temperature> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Temperature>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "Fahrenheit", value);
			}
		}

		System.Double IQuantity.BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public Unit<Temperature> DefaultUnit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Temperature>)) is Unit<Temperature> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Temperature>");
				}
			}
		}

		public Temperature(System.Double baseValue = 0.0)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), baseValue);
		}

		public System.Boolean Equals(Temperature other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Int32 CompareTo(Temperature other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public Temperature New(System.Double baseVal)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Temperature));
		}

		public Temperature Add(Temperature q)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Temperature));
		}

		public Temperature Subtract(Temperature q)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Temperature));
		}

		public Temperature Multiply(System.Double n)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Temperature));
		}

		public Temperature Multiply(Temperature a, Ratio r)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Temperature));
		}

		public Temperature Multiply(Ratio r, Temperature a)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Temperature));
		}

		public Temperature Divide(System.Double n)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Temperature));
		}

		public Ratio Divide(Temperature q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio));
		}

		public static Temperature Parse(System.String str, Unit<Temperature> defaultUnit = null)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Temperature));
		}

		public static System.Boolean TryParse(System.String str, out Temperature q, Unit<Temperature> defaultUnit = null)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, defaultUnit), typeof(System.Boolean));
			q = (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(Temperature));
			return __finalResult;
		}

		public static Temperature operator +(Temperature a, Temperature b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Temperature)) is Temperature __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Temperature");
			}
		}

		public static Temperature operator -(Temperature a, Temperature b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Temperature)) is Temperature __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Temperature");
			}
		}

		public static Temperature operator *(Temperature a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Temperature)) is Temperature __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Temperature");
			}
		}

		public static Temperature operator /(Temperature a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Temperature)) is Temperature __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Temperature");
			}
		}

		public static Ratio operator /(Temperature a, Temperature b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Temperature operator -(Temperature a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Temperature)) is Temperature __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Temperature");
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Temperature(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Temperature()
		{
		}
	}
	public struct Time : IQuantity<Time>, IQuantity, IComparable<Time>, IEquatable<Time>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Double BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BaseValue", value);
			}
		}

		public static Unit<Time> Millisecond
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Millisecond"), typeof(Unit<Time>)) is Unit<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Time>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Second"), typeof(Unit<Time>)) is Unit<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Time>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Minute"), typeof(Unit<Time>)) is Unit<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Time>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Hour"), typeof(Unit<Time>)) is Unit<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Time>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Day"), typeof(Unit<Time>)) is Unit<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Time>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "MinuteSecond"), typeof(CompoundFormatInfo<Time>)) is CompoundFormatInfo<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CompoundFormatInfo<Time>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "HourMinuteSecond"), typeof(CompoundFormatInfo<Time>)) is CompoundFormatInfo<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CompoundFormatInfo<Time>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "HourMinuteSecond_Trimmed"), typeof(CompoundFormatInfo<Time>)) is CompoundFormatInfo<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CompoundFormatInfo<Time>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "DayHourMinuteSecond_Long"), typeof(CompoundFormatInfo<Time>)) is CompoundFormatInfo<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CompoundFormatInfo<Time>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "DayHourMinute_Long"), typeof(CompoundFormatInfo<Time>)) is CompoundFormatInfo<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CompoundFormatInfo<Time>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "DayHourMinuteSecond_Trimmed"), typeof(CompoundFormatInfo<Time>)) is CompoundFormatInfo<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CompoundFormatInfo<Time>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "HourMinuteSecond_Symbol"), typeof(CompoundFormatInfo<Time>)) is CompoundFormatInfo<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CompoundFormatInfo<Time>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "StopWatch"), typeof(CompoundFormatInfo<Time>)) is CompoundFormatInfo<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CompoundFormatInfo<Time>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "StopWatch", value);
			}
		}

		System.Double IQuantity.BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public Unit<Time> DefaultUnit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Time>)) is Unit<Time> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Time>");
				}
			}
		}

		public Time(System.Double baseValue = 0.0)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), baseValue);
		}

		public System.Boolean Equals(Time other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Int32 CompareTo(Time other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public Time New(System.Double baseVal)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Time));
		}

		public Time Add(Time q)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Time));
		}

		public Time Subtract(Time q)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Time));
		}

		public Time Multiply(System.Double n)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Time));
		}

		public Time Multiply(Time a, Ratio r)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Time));
		}

		public Time Multiply(Ratio r, Time a)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Time));
		}

		public Time Divide(System.Double n)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Time));
		}

		public Ratio Divide(Time q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio));
		}

		public static Time Parse(System.String str, Unit<Time> defaultUnit = null)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Time));
		}

		public static System.Boolean TryParse(System.String str, out Time q, Unit<Time> defaultUnit = null)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, defaultUnit), typeof(System.Boolean));
			q = (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(Time));
			return __finalResult;
		}

		public static Time operator +(Time a, Time b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Time)) is Time __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Time");
			}
		}

		public static Time operator -(Time a, Time b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Time)) is Time __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Time");
			}
		}

		public static Time operator *(Time a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Time)) is Time __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Time");
			}
		}

		public static Time operator /(Time a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Time)) is Time __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Time");
			}
		}

		public static Ratio operator /(Time a, Time b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Time operator -(Time a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Time)) is Time __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Time");
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Time(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Time()
		{
		}
	}
	public struct Velocity : IQuantity<Velocity>, IQuantity, IComparable<Velocity>, IEquatable<Velocity>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Double BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BaseValue", value);
			}
		}

		public static Unit<Velocity> MetersPerSecond
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "MetersPerSecond"), typeof(Unit<Velocity>)) is Unit<Velocity> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Velocity>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "KilometersPerHour"), typeof(Unit<Velocity>)) is Unit<Velocity> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Velocity>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "MilesPerHour"), typeof(Unit<Velocity>)) is Unit<Velocity> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Velocity>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "FeetPerSecond"), typeof(Unit<Velocity>)) is Unit<Velocity> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Velocity>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "Knots"), typeof(Unit<Velocity>)) is Unit<Velocity> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Velocity>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "Knots", value);
			}
		}

		System.Double IQuantity.BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public Unit<Velocity> DefaultUnit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Velocity>)) is Unit<Velocity> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Velocity>");
				}
			}
		}

		public Velocity(System.Double baseValue = 0.0)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), baseValue);
		}

		public System.Boolean Equals(Velocity other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Int32 CompareTo(Velocity other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public Velocity New(System.Double baseVal)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Velocity));
		}

		public Velocity Add(Velocity q)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Velocity));
		}

		public Velocity Subtract(Velocity q)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Velocity));
		}

		public Velocity Multiply(System.Double n)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Velocity));
		}

		public Velocity Multiply(Velocity a, Ratio r)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Velocity));
		}

		public Velocity Multiply(Ratio r, Velocity a)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Velocity));
		}

		public Velocity Divide(System.Double n)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Velocity));
		}

		public Ratio Divide(Velocity q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio));
		}

		public static Velocity Parse(System.String str, Unit<Velocity> defaultUnit = null)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Velocity));
		}

		public static System.Boolean TryParse(System.String str, out Velocity q, Unit<Velocity> defaultUnit = null)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, defaultUnit), typeof(System.Boolean));
			q = (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(Velocity));
			return __finalResult;
		}

		public static Velocity operator +(Velocity a, Velocity b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public static Velocity operator -(Velocity a, Velocity b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public static Velocity operator *(Velocity a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public static Velocity operator /(Velocity a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public static Ratio operator /(Velocity a, Velocity b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Velocity operator -(Velocity a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Velocity(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Velocity()
		{
		}
	}
	public struct Current : IQuantitySI<Current>, IQuantitySI, IQuantity<Current>, IQuantity, IComparable<Current>, IEquatable<Current>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Double BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BaseValue", value);
			}
		}

		public static Unit<Current> Ampere
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "Ampere"), typeof(Unit<Current>)) is Unit<Current> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Current>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "Ampere", value);
			}
		}

		System.Double IQuantity.BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public System.Double SIPower
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public Unit<Current> DefaultUnit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Current>)) is Unit<Current> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Current>");
				}
			}
		}

		public Current(System.Double baseValue = 0.0)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), baseValue);
		}

		public System.Boolean Equals(Current other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Int32 CompareTo(Current other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public IUnit[] GetCommonSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCommonSIUnits"), typeof(IUnit[]));
		}

		public IUnit[] GetExludedSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExludedSIUnits"), typeof(IUnit[]));
		}

		public Current New(System.Double baseVal)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Current));
		}

		public Current Add(Current q)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Current));
		}

		public Current Subtract(Current q)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Current));
		}

		public Current Multiply(System.Double n)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Current));
		}

		public Current Multiply(Current a, Ratio r)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Current));
		}

		public Current Multiply(Ratio r, Current a)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Current));
		}

		public Current Divide(System.Double n)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Current));
		}

		public Ratio Divide(Current q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio));
		}

		public static Current Parse(System.String str, Unit<Current> defaultUnit = null)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Current));
		}

		public static System.Boolean TryParse(System.String str, out Current q, Unit<Current> defaultUnit = null)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, defaultUnit), typeof(System.Boolean));
			q = (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(Current));
			return __finalResult;
		}

		public static Current operator +(Current a, Current b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public static Current operator -(Current a, Current b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public static Current operator *(Current a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public static Current operator /(Current a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public static Ratio operator /(Current a, Current b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Current operator -(Current a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Current(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Current()
		{
		}
	}
	public struct Resistance : IQuantitySI<Resistance>, IQuantitySI, IQuantity<Resistance>, IQuantity, IComparable<Resistance>, IEquatable<Resistance>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Double BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BaseValue", value);
			}
		}

		public static Unit<Resistance> Ohm
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "Ohm"), typeof(Unit<Resistance>)) is Unit<Resistance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Resistance>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "Ohm", value);
			}
		}

		System.Double IQuantity.BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public System.Double SIPower
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public Unit<Resistance> DefaultUnit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Resistance>)) is Unit<Resistance> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Resistance>");
				}
			}
		}

		public Resistance(System.Double baseValue = 0.0)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), baseValue);
		}

		public System.Boolean Equals(Resistance other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Int32 CompareTo(Resistance other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public IUnit[] GetCommonSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCommonSIUnits"), typeof(IUnit[]));
		}

		public IUnit[] GetExludedSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExludedSIUnits"), typeof(IUnit[]));
		}

		public Resistance New(System.Double baseVal)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Resistance));
		}

		public Resistance Add(Resistance q)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Resistance));
		}

		public Resistance Subtract(Resistance q)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Resistance));
		}

		public Resistance Multiply(System.Double n)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Resistance));
		}

		public Resistance Multiply(Resistance a, Ratio r)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Resistance));
		}

		public Resistance Multiply(Ratio r, Resistance a)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Resistance));
		}

		public Resistance Divide(System.Double n)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Resistance));
		}

		public Ratio Divide(Resistance q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio));
		}

		public static Resistance Parse(System.String str, Unit<Resistance> defaultUnit = null)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Resistance));
		}

		public static System.Boolean TryParse(System.String str, out Resistance q, Unit<Resistance> defaultUnit = null)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, defaultUnit), typeof(System.Boolean));
			q = (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(Resistance));
			return __finalResult;
		}

		public static Resistance operator +(Resistance a, Resistance b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public static Resistance operator -(Resistance a, Resistance b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public static Resistance operator *(Resistance a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public static Resistance operator /(Resistance a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public static Ratio operator /(Resistance a, Resistance b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Resistance operator -(Resistance a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public static Voltage operator *(Resistance r, Current i)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", r, i), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public static Voltage operator *(Current i, Resistance r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", i, r), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Resistance(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Resistance()
		{
		}
	}
	public struct Voltage : IQuantitySI<Voltage>, IQuantitySI, IQuantity<Voltage>, IQuantity, IComparable<Voltage>, IEquatable<Voltage>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Double BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BaseValue", value);
			}
		}

		public static Unit<Voltage> Volt
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "Volt"), typeof(Unit<Voltage>)) is Unit<Voltage> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Voltage>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "Volt", value);
			}
		}

		System.Double IQuantity.BaseValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public System.Double SIPower
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
		}

		public Unit<Voltage> DefaultUnit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Voltage>)) is Unit<Voltage> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Unit<Voltage>");
				}
			}
		}

		public Voltage(System.Double baseValue = 0.0)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), baseValue);
		}

		public System.Boolean Equals(Voltage other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Int32 CompareTo(Voltage other)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32));
		}

		public string[] GetShortBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[]));
		}

		public string[] GetLongBaseNames()
		{
			return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[]));
		}

		public IUnit[] GetCommonSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCommonSIUnits"), typeof(IUnit[]));
		}

		public IUnit[] GetExludedSIUnits()
		{
			return (IUnit[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExludedSIUnits"), typeof(IUnit[]));
		}

		public Voltage New(System.Double baseVal)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Voltage));
		}

		public Voltage Add(Voltage q)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Voltage));
		}

		public Voltage Subtract(Voltage q)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Voltage));
		}

		public Voltage Multiply(System.Double n)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Voltage));
		}

		public Voltage Multiply(Voltage a, Ratio r)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Voltage));
		}

		public Voltage Multiply(Ratio r, Voltage a)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Voltage));
		}

		public Voltage Divide(System.Double n)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Voltage));
		}

		public Ratio Divide(Voltage q)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio));
		}

		public static Voltage Parse(System.String str, Unit<Voltage> defaultUnit = null)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Voltage));
		}

		public static System.Boolean TryParse(System.String str, out Voltage q, Unit<Voltage> defaultUnit = null)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", out ResoniteBridge.ResoniteBridgeValue[] __outVars, str, defaultUnit), typeof(System.Boolean));
			q = (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(Voltage));
			return __finalResult;
		}

		public static Voltage operator +(Voltage a, Voltage b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public static Voltage operator -(Voltage a, Voltage b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public static Voltage operator *(Voltage a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public static Voltage operator /(Voltage a, System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public static Ratio operator /(Voltage a, Voltage b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Voltage operator -(Voltage a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public static Current operator /(Voltage v, Resistance r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", v, r), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public static Resistance operator /(Voltage v, Current c)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", v, c), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Voltage(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public Voltage()
		{
		}
	}
}
