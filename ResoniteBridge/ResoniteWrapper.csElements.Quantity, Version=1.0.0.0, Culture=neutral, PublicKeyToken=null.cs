using ResoniteBridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
					return (Unit<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Unit"), typeof(Unit<T>));
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
					return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OverrideUnitName"), typeof(System.String));
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
					return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OverrideSeparator"), typeof(System.String));
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
					return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OverrideNumberFormat"), typeof(System.String));
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
					return (CompoundZeroHandling?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OverrideZeroHandling"), typeof(ResoniteBridge.ResoniteBridgeValue));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OverrideZeroHandling", value);
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

		private System.String defaultSeparator
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "defaultSeparator"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "defaultSeparator", value);
			}
		}

		private Info[] formatInfo
		{
			get
			{
				return (Info[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "formatInfo"), typeof(Info[]));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastNumberFormat"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NumberFormat"), typeof(System.String));
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
				return (CompoundZeroHandling)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ZeroHandling"), typeof(CompoundZeroHandling));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseLongNames"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DiscardLastFraction"), typeof(System.Boolean));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UnitCount"), typeof(System.Int32));
			}
		}

		public Unit<T> GetUnit(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUnit", index), typeof(Unit<T>)) is Unit<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Unit<T>");
			}
		}

		public System.String GetSeparator(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSeparator", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.String GetUnitName(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUnitName", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.String GetNumberFormat(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNumberFormat", index), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public CompoundZeroHandling GetZeroHandling(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetZeroHandling", index), typeof(CompoundZeroHandling)) is CompoundZeroHandling __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to CompoundZeroHandling");
			}
		}

		public CompoundFormatInfo<T> OverrideLastNumberFormat(System.String format)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OverrideLastNumberFormat", format), typeof(CompoundFormatInfo<T>)) is CompoundFormatInfo<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to CompoundFormatInfo<T>");
			}
		}

		public CompoundFormatInfo<T> OverrideSeparator(System.String separator)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OverrideSeparator", separator), typeof(CompoundFormatInfo<T>)) is CompoundFormatInfo<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to CompoundFormatInfo<T>");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	public class SmartQuantityException : Exception, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UnitName"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UnitName", value);
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "x"), typeof(T));
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
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "y"), typeof(T));
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
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "z"), typeof(T));
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
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SqrMagnitude"), typeof(T));
			}
		}

		public T Magnitude
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Magnitude"), typeof(T));
			}
		}

		public QVector3<T> Normalized
		{
			get
			{
				return (QVector3<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Normalized"), typeof(QVector3<T>));
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
				return (QVector3<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), "Zero"), typeof(QVector3<T>));
			}
		}

		public static QVector3<T> One
		{
			get
			{
				return (QVector3<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), "One"), typeof(QVector3<T>));
			}
		}

		public System.String FormatAs(Unit<T> unit, System.String formatNum = null, System.Boolean longName = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FormatAs", unit, formatNum, longName), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.String FormatAuto(System.String formatNum = null, System.Boolean longName = false, List<UnitGroup> unitGroups = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FormatAuto", formatNum, longName, unitGroups), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static QVector3<T> operator +(QVector3<T> a, QVector3<T> b)
		{
			return (QVector3<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(QVector3<T>));
		}

		public static QVector3<T> operator -(QVector3<T> a, QVector3<T> b)
		{
			return (QVector3<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(QVector3<T>));
		}

		public static QVector3<T> operator *(QVector3<T> v, System.Double n)
		{
			return (QVector3<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", v, n), typeof(QVector3<T>));
		}

		public static QVector3<T> operator /(QVector3<T> v, System.Double n)
		{
			return (QVector3<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QVector3", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", v, n), typeof(QVector3<T>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (Func<double, double>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "convertToFunc"), typeof(Func<double, double>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "convertToFunc", value);
			}
		}

		private Func<double, double> convertFromFunc
		{
			get
			{
				return (Func<double, double>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "convertFromFunc"), typeof(Func<double, double>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "convertFromFunc", value);
			}
		}

		public override T ConvertFrom(System.Double val)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConvertFrom", val), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public override System.Double ConvertTo(T q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConvertTo", q), typeof(System.Double)) is System.Double __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to double");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double));
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
				return (Unit<Acceleration>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "MetersPerSecondPerSecond"), typeof(Unit<Acceleration>));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double));
			}
		}

		public Unit<Acceleration> DefaultUnit
		{
			get
			{
				return (Unit<Acceleration>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Acceleration>));
			}
		}

		public System.Boolean Equals(Acceleration other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Int32 CompareTo(Acceleration other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public string[] GetShortBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public string[] GetLongBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public Acceleration New(System.Double baseVal)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Acceleration)) is Acceleration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Acceleration");
			}
		}

		public Acceleration Add(Acceleration q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Acceleration)) is Acceleration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Acceleration");
			}
		}

		public Acceleration Subtract(Acceleration q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Acceleration)) is Acceleration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Acceleration");
			}
		}

		public Acceleration Multiply(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Acceleration)) is Acceleration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Acceleration");
			}
		}

		public Acceleration Multiply(Acceleration a, Ratio r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Acceleration)) is Acceleration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Acceleration");
			}
		}

		public Acceleration Multiply(Ratio r, Acceleration a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Acceleration)) is Acceleration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Acceleration");
			}
		}

		public Acceleration Divide(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Acceleration)) is Acceleration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Acceleration");
			}
		}

		public Ratio Divide(Acceleration q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Acceleration Parse(System.String str, Unit<Acceleration> defaultUnit = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Acceleration)) is Acceleration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Acceleration");
			}
		}

		public static Acceleration operator +(Acceleration a, Acceleration b)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Acceleration));
		}

		public static Acceleration operator -(Acceleration a, Acceleration b)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Acceleration));
		}

		public static Acceleration operator *(Acceleration a, System.Double n)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Acceleration));
		}

		public static Acceleration operator /(Acceleration a, System.Double n)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Acceleration));
		}

		public static Ratio operator /(Acceleration a, Acceleration b)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio));
		}

		public static Acceleration operator -(Acceleration a)
		{
			return (Acceleration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Acceleration));
		}

		public static Velocity operator *(Acceleration a, Time t)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Acceleration", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, t), typeof(Velocity));
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double));
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

		System.Double IQuantity.BaseValue
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double));
			}
		}

		public System.Double SIPower
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double));
			}
		}

		public Unit<Angle> DefaultUnit
		{
			get
			{
				return (Unit<Angle>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Angle>));
			}
		}

		public System.Boolean Equals(Angle other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Int32 CompareTo(Angle other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public string[] GetShortBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public string[] GetLongBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public IUnit[] GetCommonSIUnits()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCommonSIUnits"), typeof(IUnit[])) is IUnit[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IUnit[]");
			}
		}

		public IUnit[] GetExludedSIUnits()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExludedSIUnits"), typeof(IUnit[])) is IUnit[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IUnit[]");
			}
		}

		public Angle New(System.Double baseVal)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Angle)) is Angle __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Angle");
			}
		}

		public Angle Add(Angle q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Angle)) is Angle __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Angle");
			}
		}

		public Angle Subtract(Angle q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Angle)) is Angle __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Angle");
			}
		}

		public Angle Multiply(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Angle)) is Angle __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Angle");
			}
		}

		public Angle Multiply(Angle a, Ratio r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Angle)) is Angle __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Angle");
			}
		}

		public Angle Multiply(Ratio r, Angle a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Angle)) is Angle __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Angle");
			}
		}

		public Angle Divide(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Angle)) is Angle __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Angle");
			}
		}

		public Ratio Divide(Angle q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Angle Parse(System.String str, Unit<Angle> defaultUnit = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Angle)) is Angle __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Angle");
			}
		}

		public static Angle operator +(Angle a, Angle b)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Angle));
		}

		public static Angle operator -(Angle a, Angle b)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Angle));
		}

		public static Angle operator *(Angle a, System.Double n)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Angle));
		}

		public static Angle operator /(Angle a, System.Double n)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Angle));
		}

		public static Ratio operator /(Angle a, Angle b)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio));
		}

		public static Angle operator -(Angle a)
		{
			return (Angle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Angle", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Angle));
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double));
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

		System.Double IQuantity.BaseValue
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double));
			}
		}

		public System.Double SIPower
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double));
			}
		}

		public Unit<Distance> DefaultUnit
		{
			get
			{
				return (Unit<Distance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Distance>));
			}
		}

		public System.Boolean Equals(Distance other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Int32 CompareTo(Distance other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public string[] GetShortBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public string[] GetLongBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public IUnit[] GetCommonSIUnits()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCommonSIUnits"), typeof(IUnit[])) is IUnit[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IUnit[]");
			}
		}

		public IUnit[] GetExludedSIUnits()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExludedSIUnits"), typeof(IUnit[])) is IUnit[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IUnit[]");
			}
		}

		public Distance New(System.Double baseVal)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Distance)) is Distance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Distance");
			}
		}

		public Distance Add(Distance q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Distance)) is Distance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Distance");
			}
		}

		public Distance Subtract(Distance q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Distance)) is Distance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Distance");
			}
		}

		public Distance Multiply(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Distance)) is Distance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Distance");
			}
		}

		public Distance Multiply(Distance a, Ratio r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Distance)) is Distance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Distance");
			}
		}

		public Distance Multiply(Ratio r, Distance a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Distance)) is Distance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Distance");
			}
		}

		public Distance Divide(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Distance)) is Distance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Distance");
			}
		}

		public Ratio Divide(Distance q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Distance Parse(System.String str, Unit<Distance> defaultUnit = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Distance)) is Distance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Distance");
			}
		}

		public static Distance operator +(Distance a, Distance b)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Distance));
		}

		public static Distance operator -(Distance a, Distance b)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Distance));
		}

		public static Distance operator *(Distance a, System.Double n)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Distance));
		}

		public static Distance operator /(Distance a, System.Double n)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Distance));
		}

		public static Ratio operator /(Distance a, Distance b)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio));
		}

		public static Distance operator -(Distance a)
		{
			return (Distance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Distance));
		}

		public static Velocity operator /(Distance l, Time t)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Distance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", l, t), typeof(Velocity));
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double));
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
				return (Unit<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<T>));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double));
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
		private static System.Double SIPower
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitSI", ResoniteBridge.ResoniteBridgeValueType.Type), "SIPower"), typeof(System.Double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "UnitSI", ResoniteBridge.ResoniteBridgeValueType.Type), "SIPower", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	public interface IUnit : IComparable<IUnit>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Double Ratio
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Ratio"), typeof(System.Double));
			}
		}

		Type ValueType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueType"), typeof(Type));
			}
		}

		ICollection<string> GetUnitNames();
	}
	public class Unit<T> : IUnit, IComparable<IUnit>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IQuantity<T>
	{
		private string[] shortNames
		{
			get
			{
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "shortNames"), typeof(string[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "shortNames", value);
			}
		}

		private string[] longNames
		{
			get
			{
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "longNames"), typeof(string[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "longNames", value);
			}
		}

		private static System.String shortBaseName
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "shortBaseName"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "shortBaseName", value);
			}
		}

		private static System.String longBaseName
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "longBaseName"), typeof(System.String));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Ratio"), typeof(System.Double));
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
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValueType"), typeof(Type));
			}
		}

		public System.Int32 CompareTo(IUnit other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public ICollection<string> GetUnitNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUnitNames"), typeof(ICollection<string>)) is ICollection<string> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ICollection<string>");
			}
		}

		public virtual System.Double ConvertTo(T q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConvertTo", q), typeof(System.Double)) is System.Double __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to double");
			}
		}

		public T ConvertFrom(T q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConvertFrom", q), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public virtual T ConvertFrom(System.Double val)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConvertFrom", val), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public static T Parse(System.String str, NumberStyles numberStyles, IFormatProvider formatProvider, Unit<T> defaultUnit = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, numberStyles, formatProvider, defaultUnit), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public static T Parse(System.String str, Unit<T> defaultUnit = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		private static System.Int32 IndexOfNumberEnd(System.String str)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "IndexOfNumberEnd", str), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public System.String FormatAs(T q, System.String formatNum = null, System.Boolean longName = false, System.String overrideName = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FormatAs", q, formatNum, longName, overrideName), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static T operator *(Unit<T> unit, System.Double n)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", unit, n), typeof(T));
		}

		public static T operator *(System.Double n, Unit<T> unit)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Unit", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", n, unit), typeof(T));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	public delegate bool NumberTryParseHandler<T>(System.String str, NumberStyles numberStyles, IFormatProvider formatProvider, out T value);
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

		public static System.Double ConvertTo<T>(this T q, Unit<T> unit) where T : struct, IQuantity<T>
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertTo", q, unit), typeof(System.Double)) is System.Double __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to double");
			}
		}

		public static System.String FormatAs<T>(this T q, Unit<T> unit, System.String formatNum = null, System.Boolean longName = false, System.String overrideName = null) where T : struct, IQuantity<T>
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatAs", q, unit, formatNum, longName, overrideName), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String FormatAs<T>(this T q, System.String unitName, System.String formatNum = null, System.Boolean longName = false) where T : struct, IQuantity<T>
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatAs", q, unitName, formatNum, longName), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String FormatAuto<T>(this T q, System.String formatNum, System.Boolean longName, UnitGroup unitGroup, Unit<T> defaultUnit = null) where T : struct, IQuantity<T>
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatAuto", q, formatNum, longName, unitGroup, defaultUnit), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String FormatAuto<T>(this T q, System.String formatNum = null, System.Boolean longName = false, List<UnitGroup> groups = null, Unit<T> defaultUnit = null) where T : struct, IQuantity<T>
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatAuto", q, formatNum, longName, groups, defaultUnit), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String FormatCompound<T>(this T q, ICollection<Unit<T>> units, System.String separator = " ", CompoundZeroHandling zeroHandling = CompoundZeroHandling.RemoveAny, System.String lastNumberFormat = null, System.Boolean longNames = false, System.Boolean discardLastFraction = false) where T : struct, IQuantity<T>
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatCompound", q, units, separator, zeroHandling, lastNumberFormat, longNames, discardLastFraction), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String FormatCompound<T>(this T q, CompoundFormatInfo<T> formatInfo) where T : struct, IQuantity<T>
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FormatCompound", q, formatInfo), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static IEnumerable<IUnit> GetUnits<T>()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUnits"), typeof(IEnumerable<IUnit>)) is IEnumerable<IUnit> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerable<IUnit>");
			}
		}

		public static Unit<T> SelectBestUnit<T>(this T q, List<UnitGroup> groups) where T : struct, IQuantity<T>
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SelectBestUnit", q, groups), typeof(Unit<T>)) is Unit<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Unit<T>");
			}
		}

		private static System.Boolean ContainsUnit(IUnit unit, List<UnitGroup> groups)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ContainsUnit", unit, groups), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static IUnit GetUnitByName<T>(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "QuantityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUnitByName", name), typeof(IUnit)) is IUnit __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IUnit");
			}
		}
	}
	public class UnitGroup : IEnumerable<IUnit>, IEnumerable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public struct Enumerator : IEnumerator<IUnit>, IDisposable, IEnumerator, ResoniteBridge.ResoniteBridgeValueHolder
		{
			private System.Boolean firstDone
			{
				get
				{
					return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "firstDone"), typeof(System.Boolean));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "firstDone", value);
				}
			}

			private Dictionary<Type, ResoniteBridge.ResoniteBridgeValue>.Enumerator dictEnum
			{
				get
				{
					return (Dictionary<Type, ResoniteBridge.ResoniteBridgeValue>.Enumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "dictEnum"), typeof(Dictionary<Type, ResoniteBridge.ResoniteBridgeValue>.Enumerator));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "dictEnum", value);
				}
			}

			private ResoniteBridge.ResoniteBridgeValue setEnum
			{
				get
				{
					return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "setEnum"), typeof(ResoniteBridge.ResoniteBridgeValue));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "setEnum", value);
				}
			}

			public IUnit Current
			{
				get
				{
					return (IUnit)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Current"), typeof(IUnit));
				}
			}

			System.Object IEnumerator.Current
			{
				get
				{
					return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Current"), typeof(System.Object));
				}
			}

			public void Dispose()
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
			}

			public System.Boolean MoveNext()
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MoveNext"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}

			public void Reset()
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

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

		private Dictionary<Type, ResoniteBridge.ResoniteBridgeValue> units
		{
			get
			{
				return (Dictionary<Type, ResoniteBridge.ResoniteBridgeValue>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "units"), typeof(Dictionary<Type, ResoniteBridge.ResoniteBridgeValue>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "units", value);
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasUnit", unit), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		internal ResoniteBridge.ResoniteBridgeValue GetSetForType(Type type, System.Boolean createIfNotExists = true)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSetForType", type, createIfNotExists), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to SortedSet<IUnit>");
			}
		}

		public Enumerator GetEnumerator()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEnumerator"), typeof(Enumerator)) is Enumerator __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Enumerator");
			}
		}

		IEnumerator<IUnit> IEnumerable<IUnit>.GetEnumerator()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEnumerator"), typeof(IEnumerator<IUnit>)) is IEnumerator<IUnit> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerator<IUnit>");
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEnumerator"), typeof(IEnumerator)) is IEnumerator __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerator");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
	}
	public struct Mass : IQuantitySI<Mass>, IQuantitySI, IQuantity<Mass>, IQuantity, IComparable<Mass>, IEquatable<Mass>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Double BaseValue
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double));
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

		System.Double IQuantity.BaseValue
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double));
			}
		}

		public System.Double SIPower
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double));
			}
		}

		public Unit<Mass> DefaultUnit
		{
			get
			{
				return (Unit<Mass>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Mass>));
			}
		}

		public System.Boolean Equals(Mass other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Int32 CompareTo(Mass other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public string[] GetShortBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public string[] GetLongBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public IUnit[] GetCommonSIUnits()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCommonSIUnits"), typeof(IUnit[])) is IUnit[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IUnit[]");
			}
		}

		public IUnit[] GetExludedSIUnits()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExludedSIUnits"), typeof(IUnit[])) is IUnit[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IUnit[]");
			}
		}

		public Mass New(System.Double baseVal)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Mass)) is Mass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Mass");
			}
		}

		public Mass Add(Mass q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Mass)) is Mass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Mass");
			}
		}

		public Mass Subtract(Mass q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Mass)) is Mass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Mass");
			}
		}

		public Mass Multiply(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Mass)) is Mass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Mass");
			}
		}

		public Mass Multiply(Mass a, Ratio r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Mass)) is Mass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Mass");
			}
		}

		public Mass Multiply(Ratio r, Mass a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Mass)) is Mass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Mass");
			}
		}

		public Mass Divide(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Mass)) is Mass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Mass");
			}
		}

		public Ratio Divide(Mass q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Mass Parse(System.String str, Unit<Mass> defaultUnit = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Mass)) is Mass __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Mass");
			}
		}

		public static Mass operator +(Mass a, Mass b)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Mass));
		}

		public static Mass operator -(Mass a, Mass b)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Mass));
		}

		public static Mass operator *(Mass a, System.Double n)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Mass));
		}

		public static Mass operator /(Mass a, System.Double n)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Mass));
		}

		public static Ratio operator /(Mass a, Mass b)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio));
		}

		public static Mass operator -(Mass a)
		{
			return (Mass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Mass", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Mass));
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double));
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

		System.Double IQuantity.BaseValue
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double));
			}
		}

		public Unit<Ratio> DefaultUnit
		{
			get
			{
				return (Unit<Ratio>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Ratio>));
			}
		}

		public System.Boolean Equals(Ratio other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Int32 CompareTo(Ratio other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public string[] GetShortBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public string[] GetLongBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public Ratio New(System.Double baseVal)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public Ratio Add(Ratio q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public Ratio Subtract(Ratio q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public Ratio Multiply(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public Ratio Multiply(Ratio a, Ratio r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public Ratio Divide(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public Ratio Divide(Ratio q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Ratio Parse(System.String str, Unit<Ratio> defaultUnit = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Ratio operator +(Ratio a, Ratio b)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Ratio));
		}

		public static Ratio operator -(Ratio a, Ratio b)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Ratio));
		}

		public static Ratio operator *(Ratio a, System.Double n)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Ratio));
		}

		public static Ratio operator /(Ratio a, System.Double n)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Ratio));
		}

		public static Ratio operator /(Ratio a, Ratio b)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio));
		}

		public static Ratio operator -(Ratio a)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Ratio", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Ratio));
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double));
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

		System.Double IQuantity.BaseValue
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double));
			}
		}

		public Unit<Temperature> DefaultUnit
		{
			get
			{
				return (Unit<Temperature>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Temperature>));
			}
		}

		public System.Boolean Equals(Temperature other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Int32 CompareTo(Temperature other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public string[] GetShortBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public string[] GetLongBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public Temperature New(System.Double baseVal)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Temperature)) is Temperature __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Temperature");
			}
		}

		public Temperature Add(Temperature q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Temperature)) is Temperature __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Temperature");
			}
		}

		public Temperature Subtract(Temperature q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Temperature)) is Temperature __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Temperature");
			}
		}

		public Temperature Multiply(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Temperature)) is Temperature __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Temperature");
			}
		}

		public Temperature Multiply(Temperature a, Ratio r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Temperature)) is Temperature __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Temperature");
			}
		}

		public Temperature Multiply(Ratio r, Temperature a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Temperature)) is Temperature __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Temperature");
			}
		}

		public Temperature Divide(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Temperature)) is Temperature __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Temperature");
			}
		}

		public Ratio Divide(Temperature q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Temperature Parse(System.String str, Unit<Temperature> defaultUnit = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Temperature)) is Temperature __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Temperature");
			}
		}

		public static Temperature operator +(Temperature a, Temperature b)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Temperature));
		}

		public static Temperature operator -(Temperature a, Temperature b)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Temperature));
		}

		public static Temperature operator *(Temperature a, System.Double n)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Temperature));
		}

		public static Temperature operator /(Temperature a, System.Double n)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Temperature));
		}

		public static Ratio operator /(Temperature a, Temperature b)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio));
		}

		public static Temperature operator -(Temperature a)
		{
			return (Temperature)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Temperature", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Temperature));
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double));
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

		System.Double IQuantity.BaseValue
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double));
			}
		}

		public Unit<Time> DefaultUnit
		{
			get
			{
				return (Unit<Time>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Time>));
			}
		}

		public System.Boolean Equals(Time other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Int32 CompareTo(Time other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public string[] GetShortBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public string[] GetLongBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public Time New(System.Double baseVal)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Time)) is Time __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Time");
			}
		}

		public Time Add(Time q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Time)) is Time __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Time");
			}
		}

		public Time Subtract(Time q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Time)) is Time __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Time");
			}
		}

		public Time Multiply(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Time)) is Time __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Time");
			}
		}

		public Time Multiply(Time a, Ratio r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Time)) is Time __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Time");
			}
		}

		public Time Multiply(Ratio r, Time a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Time)) is Time __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Time");
			}
		}

		public Time Divide(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Time)) is Time __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Time");
			}
		}

		public Ratio Divide(Time q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Time Parse(System.String str, Unit<Time> defaultUnit = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Time)) is Time __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Time");
			}
		}

		public static Time operator +(Time a, Time b)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Time));
		}

		public static Time operator -(Time a, Time b)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Time));
		}

		public static Time operator *(Time a, System.Double n)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Time));
		}

		public static Time operator /(Time a, System.Double n)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Time));
		}

		public static Ratio operator /(Time a, Time b)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio));
		}

		public static Time operator -(Time a)
		{
			return (Time)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Time", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Time));
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double));
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

		System.Double IQuantity.BaseValue
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double));
			}
		}

		public Unit<Velocity> DefaultUnit
		{
			get
			{
				return (Unit<Velocity>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Velocity>));
			}
		}

		public System.Boolean Equals(Velocity other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Int32 CompareTo(Velocity other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public string[] GetShortBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public string[] GetLongBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public Velocity New(System.Double baseVal)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public Velocity Add(Velocity q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public Velocity Subtract(Velocity q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public Velocity Multiply(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public Velocity Multiply(Velocity a, Ratio r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public Velocity Multiply(Ratio r, Velocity a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public Velocity Divide(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public Ratio Divide(Velocity q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Velocity Parse(System.String str, Unit<Velocity> defaultUnit = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Velocity)) is Velocity __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Velocity");
			}
		}

		public static Velocity operator +(Velocity a, Velocity b)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Velocity));
		}

		public static Velocity operator -(Velocity a, Velocity b)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Velocity));
		}

		public static Velocity operator *(Velocity a, System.Double n)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Velocity));
		}

		public static Velocity operator /(Velocity a, System.Double n)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Velocity));
		}

		public static Ratio operator /(Velocity a, Velocity b)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio));
		}

		public static Velocity operator -(Velocity a)
		{
			return (Velocity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Velocity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Velocity));
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double));
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
				return (Unit<Current>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "Ampere"), typeof(Unit<Current>));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double));
			}
		}

		public System.Double SIPower
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double));
			}
		}

		public Unit<Current> DefaultUnit
		{
			get
			{
				return (Unit<Current>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Current>));
			}
		}

		public System.Boolean Equals(Current other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Int32 CompareTo(Current other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public string[] GetShortBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public string[] GetLongBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public IUnit[] GetCommonSIUnits()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCommonSIUnits"), typeof(IUnit[])) is IUnit[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IUnit[]");
			}
		}

		public IUnit[] GetExludedSIUnits()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExludedSIUnits"), typeof(IUnit[])) is IUnit[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IUnit[]");
			}
		}

		public Current New(System.Double baseVal)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public Current Add(Current q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public Current Subtract(Current q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public Current Multiply(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public Current Multiply(Current a, Ratio r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public Current Multiply(Ratio r, Current a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public Current Divide(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public Ratio Divide(Current q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Current Parse(System.String str, Unit<Current> defaultUnit = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Current)) is Current __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Current");
			}
		}

		public static Current operator +(Current a, Current b)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Current));
		}

		public static Current operator -(Current a, Current b)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Current));
		}

		public static Current operator *(Current a, System.Double n)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Current));
		}

		public static Current operator /(Current a, System.Double n)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Current));
		}

		public static Ratio operator /(Current a, Current b)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio));
		}

		public static Current operator -(Current a)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Current", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Current));
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double));
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
				return (Unit<Resistance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "Ohm"), typeof(Unit<Resistance>));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double));
			}
		}

		public System.Double SIPower
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double));
			}
		}

		public Unit<Resistance> DefaultUnit
		{
			get
			{
				return (Unit<Resistance>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Resistance>));
			}
		}

		public System.Boolean Equals(Resistance other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Int32 CompareTo(Resistance other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public string[] GetShortBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public string[] GetLongBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public IUnit[] GetCommonSIUnits()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCommonSIUnits"), typeof(IUnit[])) is IUnit[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IUnit[]");
			}
		}

		public IUnit[] GetExludedSIUnits()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExludedSIUnits"), typeof(IUnit[])) is IUnit[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IUnit[]");
			}
		}

		public Resistance New(System.Double baseVal)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public Resistance Add(Resistance q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public Resistance Subtract(Resistance q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public Resistance Multiply(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public Resistance Multiply(Resistance a, Ratio r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public Resistance Multiply(Ratio r, Resistance a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public Resistance Divide(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public Ratio Divide(Resistance q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Resistance Parse(System.String str, Unit<Resistance> defaultUnit = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Resistance)) is Resistance __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Resistance");
			}
		}

		public static Resistance operator +(Resistance a, Resistance b)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Resistance));
		}

		public static Resistance operator -(Resistance a, Resistance b)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Resistance));
		}

		public static Resistance operator *(Resistance a, System.Double n)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Resistance));
		}

		public static Resistance operator /(Resistance a, System.Double n)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Resistance));
		}

		public static Ratio operator /(Resistance a, Resistance b)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio));
		}

		public static Resistance operator -(Resistance a)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Resistance));
		}

		public static Voltage operator *(Resistance r, Current i)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", r, i), typeof(Voltage));
		}

		public static Voltage operator *(Current i, Resistance r)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Resistance", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", i, r), typeof(Voltage));
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BaseValue"), typeof(System.Double));
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
				return (Unit<Voltage>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "Volt"), typeof(Unit<Voltage>));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseValue"), typeof(System.Double));
			}
		}

		public System.Double SIPower
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SIPower"), typeof(System.Double));
			}
		}

		public Unit<Voltage> DefaultUnit
		{
			get
			{
				return (Unit<Voltage>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUnit"), typeof(Unit<Voltage>));
			}
		}

		public System.Boolean Equals(Voltage other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Int32 CompareTo(Voltage other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public string[] GetShortBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetShortBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public string[] GetLongBaseNames()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLongBaseNames"), typeof(string[])) is string[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string[]");
			}
		}

		public IUnit[] GetCommonSIUnits()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCommonSIUnits"), typeof(IUnit[])) is IUnit[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IUnit[]");
			}
		}

		public IUnit[] GetExludedSIUnits()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExludedSIUnits"), typeof(IUnit[])) is IUnit[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IUnit[]");
			}
		}

		public Voltage New(System.Double baseVal)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "New", baseVal), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public Voltage Add(Voltage q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Add", q), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public Voltage Subtract(Voltage q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Subtract", q), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public Voltage Multiply(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", n), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public Voltage Multiply(Voltage a, Ratio r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", a, r), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public Voltage Multiply(Ratio r, Voltage a)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Multiply", r, a), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public Voltage Divide(System.Double n)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", n), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public Ratio Divide(Voltage q)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Divide", q), typeof(Ratio)) is Ratio __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Ratio");
			}
		}

		public static Voltage Parse(System.String str, Unit<Voltage> defaultUnit = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", str, defaultUnit), typeof(Voltage)) is Voltage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Voltage");
			}
		}

		public static Voltage operator +(Voltage a, Voltage b)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Addition", a, b), typeof(Voltage));
		}

		public static Voltage operator -(Voltage a, Voltage b)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Subtraction", a, b), typeof(Voltage));
		}

		public static Voltage operator *(Voltage a, System.Double n)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Multiply", a, n), typeof(Voltage));
		}

		public static Voltage operator /(Voltage a, System.Double n)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, n), typeof(Voltage));
		}

		public static Ratio operator /(Voltage a, Voltage b)
		{
			return (Ratio)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", a, b), typeof(Ratio));
		}

		public static Voltage operator -(Voltage a)
		{
			return (Voltage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_UnaryNegation", a), typeof(Voltage));
		}

		public static Current operator /(Voltage v, Resistance r)
		{
			return (Current)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", v, r), typeof(Current));
		}

		public static Resistance operator /(Voltage v, Current c)
		{
			return (Resistance)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Quantity", "Voltage", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Division", v, c), typeof(Resistance));
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

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
