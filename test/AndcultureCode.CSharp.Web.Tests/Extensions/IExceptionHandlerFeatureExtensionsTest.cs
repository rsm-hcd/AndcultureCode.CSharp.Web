using System;
using AndcultureCode.CSharp.Testing.Extensions;
using AndcultureCode.CSharp.Testing.Tests;
using AndcultureCode.CSharp.Web.Extensions;
using Microsoft.AspNetCore.Diagnostics;
using Moq;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace AndcultureCode.CSharp.Core.Tests.Unit.Extensions
{
    public class IExceptionHandlerFeatureExtensionsTest : BaseUnitTest
    {
        #region Setup

        public IExceptionHandlerFeatureExtensionsTest(ITestOutputHelper output) : base(output) { }

        #endregion Setup


        #region ToResult

        [Fact]
        public void ToResult_When_Feature_Is_Null_Returns_Null()
        {
            IExceptionHandlerFeatureExtensions.ToResult(feature: null).ShouldBeNull();
        }

        [Fact]
        public void ToResult_When_Feature_Error_Is_Null_Returns_Null()
        {
            // Arrange
            var feature = Mock.Of<IExceptionHandlerFeature>();

            // Act & Assert
            IExceptionHandlerFeatureExtensions.ToResult(feature).ShouldBeNull();
        }

        [Fact]
        public void ToResult_When_Feature_Error_Set_Returns_Result()
        {
            // Arrange
            var expected = new Exception(Random.String());
            var feature = Mock.Of<IExceptionHandlerFeature>(m => m.Error == expected);

            // Act
            var result = IExceptionHandlerFeatureExtensions.ToResult(feature);

            // Assert
            result.ShouldNotBeNull();
            result.ShouldHaveErrorsFor(expected.GetType().Name, exactCount: 1, containedInMessage: expected.Message);
        }

        #endregion ToResult
    }
}