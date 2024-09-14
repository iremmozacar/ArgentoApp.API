using System;

namespace ArgentoApp.Shared.DTOs;

public class CategoryUpdateDto
{
    public string Name { get; set; }
    public bool IsActive { get; set; } = true;
    public string Description { get; set; }
}
