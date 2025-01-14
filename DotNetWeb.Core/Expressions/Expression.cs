﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetWeb.Core.Expressions
{

    public abstract class Expression : Node
    {
        protected readonly Type type;

        public Token Token { get; }

        public Expression(Token token, Type type)
        {
            Token = token;
            this.type = type;
        }

        public abstract string Generate();
    }
}
