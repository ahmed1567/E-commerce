﻿namespace Ecommerce.Shared;

public class BaseUser : BaseSettingEntity
{
    public string? Email { get; set; }
    public string? Address { get; set; }
    public string? Mobile { get; set; }
    public string? Password { get; set; }
}
