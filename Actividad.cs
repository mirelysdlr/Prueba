using System;
using System.Collections.Generic;

namespace organizadordeventos.Infrastructure.Models;

    public class Actividad
    {
        public int Id { get; set; }
        public int EventoId { get; set; }
        public TimeSpan Hora { get; set; }
        public string Descripcion { get; set; }
    }

