﻿using System;
using System.Collections.Generic;

namespace DesignPatterns2.Cap2
{
    public class Piano
    {
        public void Tocar(IList<INota> musica)
        {
            foreach(var nota in musica)
                Console.Beep(nota.Frequencia,800);
        }
    }
}
