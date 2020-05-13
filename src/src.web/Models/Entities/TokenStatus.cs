﻿using System.Collections.Generic;

namespace src.web.Models.Entities
{
    public class TokenStatus
    {
        public TokenStatus()
        {
            Tokens = new HashSet<Token>();
        }
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Token> Tokens { get; set; }
    }
}
