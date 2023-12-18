using ExportExcelDynamicTest.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExportExcelDynamicTest.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "نام و نام خانوادگی")]
        public string FullName { get; set; }
        [Display(Name = "جنسیت")]
        public Gender Gender { get; set; }
        [Display(Name = "میزان حقوق")]
        public long Salary { get; set; }
        [Display(Name = "دارای فرزند")]
        public bool HasChild { get; set; }
        [Display(Name = "تاریخ استخدام")]
        public DateTime EnterDate { get; set; }
        [NotMapped]
        [Display(Name = "سن")]
        public int? Age { get; set; }
        [Display(Name = "زمان شروع شیفت")]
        public TimeSpan ShiftTime { get; set; }
    }
}
