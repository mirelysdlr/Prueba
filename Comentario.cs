using System;
using System.Collections.Generic;

namespace organizadordeventos.Infrastructure.Models;

    public class Comentario
    {
        public int Id { get; set; }
        public int EventoId { get; set; }
        public string Texto { get; set; }
        public DateTime CreatedAt { get; set; }
    }
