using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebTrain.Models;

public partial class Employee
{
    [Key]
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly HireDate { get; set; }
}
