﻿using System;
using System.Collections.Generic;

namespace CRUD_Entity.Models.DB;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime Date { get; set; }
}
