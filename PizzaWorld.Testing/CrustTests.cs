﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Testing
{
    public class CrustTests
    {
        [Fact]
        private void Test_CrustExists()
        {
            var sut = new CrustTypes();

            var actual = sut;

            Assert.IsType<CrustTypes>(actual);
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_Hasinfo()
        {
            var sut = new CrustTypes();

            var actual = sut;

            Assert.IsType<double>(actual.Price);
            Assert.NotNull(actual.ToString());
        }

    }
}
