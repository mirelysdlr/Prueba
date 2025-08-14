using System;
using System.Collections.Generic;

namespace organizadordeventos.Infrastructure.Models;

    public class Tarea
    {
        public int Id { get; set; }
        public int EventoId { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaLimite { get; set; }
        public bool Completada { get; set; }
    }

