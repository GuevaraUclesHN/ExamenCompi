﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetWeb.Core.Expressions
{
    public abstract class BinaryOperator : Expression
    {

        public BinaryOperator(Token token, TypedExpression leftExpression, TypedExpression rightExpression, Type type)
            : base(token, type)
        {
            LeftExpression = leftExpression;
            RightExpression = rightExpression;
        }

        public TypedExpression LeftExpression { get; }
        public TypedExpression RightExpression { get; }
    }
}
