﻿namespace calories_api.domain;

public class UpdateMealRequest
{
    public string? Text { get; set; }
    public double NumberOfCalories { get; set; }
    public DateTime DateTime { get; set; } = DateTime.UtcNow;
}