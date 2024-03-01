﻿namespace Core.QuickExtend.Tests.ArrayExtentions;

internal class ContainsTests
{
    [Test]
    public void ContainsElement_Should_ReturnTrue_When_ElementExists()
    {
        // Arrange
        int[] array = { 1, 2, 3, 4, 5 };
        int element = 3;

        // Act
        bool result = array.ContainsElement(element);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void ContainsElement_Should_ReturnFalse_When_ElementDoesNotExist()
    {
        // Arrange
        int[] array = { 1, 2, 3, 4, 5 };
        int element = 6;

        // Act
        bool result = array.ContainsElement(element);

        // Assert
        Assert.IsFalse(result);
    }
}