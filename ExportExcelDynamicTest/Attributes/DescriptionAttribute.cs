using System;
using System.Resources;

namespace ExportExcelDynamicTest.Attributes
{
	public class DescriptionAttribute : Attribute
	{
		public DescriptionAttribute()
		{

		}

		private string discription;

		public string Description
		{
			get
			{
				if (ResourceType != null)
				{
					return new ResourceManager(this.ResourceType).GetString(discription);
				}
				else
				{
					return discription;
				}
			}
			set
			{
				discription = value;
			}
		}
		public Type ResourceType { get; set; }
	}
}
