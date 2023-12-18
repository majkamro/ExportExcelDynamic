using ExportExcelDynamicTest.Attributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace ExportExcelDynamicTest.Extensions
{
	public static class EnumExtensions
	{
		/// <summary>
		///     A generic extension method that aids in reflecting 
		///     and retrieving any attribute that is applied to an `Enum`.
		/// </summary>
		public static TAttribute GetAttribute<TAttribute>(this Enum enumValue)
				  where TAttribute : Attribute
		{
			return enumValue.GetType()
				.GetMember(enumValue.ToString())
				.First()
				.GetCustomAttribute<TAttribute>();
		}

		public static DisplayAttribute GetDisplayAttribute(this Enum value)
		{
			return (value == null) || (value.GetAttribute<DisplayAttribute>() == null) ? new DisplayAttribute() : value.GetAttribute<DisplayAttribute>();
		}

		public static string ToDescription(this Enum value)
		{
			var displayAttribute = value.GetDisplayAttribute();
			return displayAttribute.GetName();
		}
	}

}
