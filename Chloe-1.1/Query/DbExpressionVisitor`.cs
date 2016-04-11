﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chloe.Query.DbExpressions;

namespace Chloe.Query
{
    public abstract class DbExpressionVisitor<T>
    {
        public abstract T Visit(DbEqualExpression exp);
        public abstract T Visit(DbNotEqualExpression exp);
        // +
        public abstract T Visit(DbAddExpression exp);
        // -
        public abstract T Visit(DbSubtractExpression exp);
        // *
        public abstract T Visit(DbMultiplyExpression exp);
        // /
        public abstract T Visit(DbDivideExpression exp);
        // <
        public abstract T Visit(DbLessThanExpression exp);
        // <=
        public abstract T Visit(DbLessThanOrEqualExpression exp);
        // >
        public abstract T Visit(DbGreaterThanExpression exp);
        // >=
        public abstract T Visit(DbGreaterThanOrEqualExpression exp);
        public abstract T Visit(DbAndExpression exp);
        public abstract T Visit(DbOrExpression exp);
        public abstract T Visit(DbConstantExpression exp);
        public abstract T Visit(DbMemberExpression exp);
        public abstract T Visit(DbNotExpression exp);
        public abstract T Visit(DbConvertExpression exp);
        public abstract T Visit(DbCaseWhenExpression exp);
        public abstract T Visit(DbMethodCallExpression exp);
        public abstract T Visit(DbTableExpression exp);
        public abstract T Visit(DbDerivedTableExpression exp);
        public abstract T Visit(DbColumnExpression exp);
        public abstract T Visit(DbColumnAccessExpression exp);
        public abstract T Visit(DbParameterExpression exp);
        public abstract T Visit(DbSubQueryExpression exp);
        public abstract T Visit(DbSqlQueryExpression exp);
        public abstract T Visit(DbFromTableExpression exp);
        public abstract T Visit(DbJoinTableExpression exp);
        public abstract T Visit(DbOrderSegmentExpression exp);

    }

}
