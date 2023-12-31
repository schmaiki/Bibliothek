﻿using System.ComponentModel.DataAnnotations;

namespace Bibliothek.API.Models.Buch;

public class Sprache
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = String.Empty;
}