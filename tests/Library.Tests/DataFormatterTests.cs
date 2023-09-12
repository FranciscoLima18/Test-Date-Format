using Ucu.Poo.TestDateFormat;

namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void Test1()
    {
        // SEGUIR AAA (Explicación abajo)

        // Arrange
        string miFecha = "10/12/2024";
        string resultadoEsperado = "2024-12-10";

        // Act
        string resultadoObtenido = DateFormatter.ChangeFormat(miFecha);

        // Assert
        Assert.That(resultadoObtenido, Is.EqualTo(resultadoEsperado));
    }

    [Test]
    public void Test2()
    {
        // SEGUIR AAA (Explicación abajo)

        // Arrange
        string miFecha = "2024/12/10";


        // Assert
        Assert.Throws<Exception>(() => DateFormatter.ChangeFormat(miFecha));
    }

    [Test]
    public void Test3()
    {
        // SEGUIR AAA (Explicación abajo)

        // Arrange
        string miFecha = " ";


        // Assert
        Assert.Throws<Exception>(() => DateFormatter.ChangeFormat(miFecha));
    }
}