﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public interface IDeserializa
    {
        public string DeserializarXml();
        public string DeserializarJson();
    }
}
