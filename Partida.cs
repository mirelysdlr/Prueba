using System;
using System.Collections.Generic;

namespace organizadordeventos.Infrastructure.Models;

    public class Partida
    {
        public int Id { get; set; }
        public int EventoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Presupuesto { get; set; }
        public decimal GastoActual { get; set; }
    }


