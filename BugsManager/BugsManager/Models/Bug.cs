﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace BugsManager.Models
{
    public partial class Bug
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; } = default!;

        [ForeignKey(nameof(ProjectId))]
        [InverseProperty("Bug")]
        public virtual Project Project { get; set; } = default!;
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Bug")]
        public virtual User User { get; set; } = default!;
    }
}