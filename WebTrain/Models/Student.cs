using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTrain.Models;

public partial class Student
{
    public int Id { get; set; }

    [Required(ErrorMessage ="กรุณาป้อนชื่อนักเรียน")]
    [System.ComponentModel.DisplayName("ชื่อนักเรียน")]
    public string? Student1 { get; set; }

    [System.ComponentModel.DisplayName("คะแนน")]
    [Range (0,100, ErrorMessage = "กรุณาป้อนคะแนนสอบในช่วง0-100")]
    public string? Score { get; set; }

    [NotMapped]
    public string? Mail { get; set; }
}
