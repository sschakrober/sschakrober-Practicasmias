﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Empleados.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Antiguedad { get; set; }
        public int Edad { get; set; }
    }

    public class EmpleadoDBContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
    }
}