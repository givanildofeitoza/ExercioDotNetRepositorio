﻿using Busines.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Models
{
    public class Veiculo : Entity
    {
        public string Descricao { get; set; }
        public string Placa { get; set; }
        public EnumTipo Tipo { get; set; }
    }
}
