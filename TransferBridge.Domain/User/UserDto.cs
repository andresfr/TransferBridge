﻿namespace TransferBridge.Domain.User;

using System.ComponentModel.DataAnnotations;

public class UserDto
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Direction { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public long IdentificationNumber { get; set; }
}