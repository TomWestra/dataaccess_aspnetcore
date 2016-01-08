﻿using System;
using Xunit;

namespace Toolbox.DataAccess.UnitTests.Options.DataAccessOptionsTests
{
    public class InstantiationTests
    {
        [Fact]
        private void ConnectionStringIsInitialized()
        {
            var options = new DataAccessOptions();
            Assert.NotNull(options.ConnectionString);
        }

        [Fact]
        private void DefaultLazyLoadingEnabledIsFalse()
        {
            var options = new DataAccessOptions();
            Assert.False(options.LazyLoadingEnabled);
        }

        [Fact]
        private void DefaultDbConfigurationIsNull()
        {
            var options = new DataAccessOptions();
            Assert.Null(options.DbConfiguration);
        }
    }
}
