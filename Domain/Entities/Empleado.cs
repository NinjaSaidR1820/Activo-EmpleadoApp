﻿using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Empleado
    {

        public int Id { get; set; }
        public int CodigoEmpleado { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public Estado Estado { get; set; }
        public List<Activo> ActivoEmpleado { get; set; }



    }
}
