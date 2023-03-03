﻿using System;
using Microsoft.AspNetCore.Identity;

namespace application_infrastructure.Entities;

public class SearchHistoryDTO
{
    public Guid Id { get; set; }

    public String? Query { get; set; }

    public List<string>? Results { get; set; }
}