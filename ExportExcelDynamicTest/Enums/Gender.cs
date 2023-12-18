using System.ComponentModel.DataAnnotations;

namespace ExportExcelDynamicTest.Enums
{
    public enum Gender : byte
    {
        [Display(Name ="مرد")]
        Male,
        [Display(Name = "زن")]
        Female
    }

}
