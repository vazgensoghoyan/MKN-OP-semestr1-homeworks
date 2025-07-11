using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task4.Task4;

namespace Task4;

public class Tests
{
    private readonly TextWriter _standartOut = Console.Out;
    private StringWriter _stringWriter = new();

    [SetUp]
    public void Setup()
    {
        var stringWriter = new StringWriter();
        _stringWriter = stringWriter;
        Console.SetOut( _stringWriter );
    }

    [TearDown]
    public void TearDown()
    {
        Console.SetOut( _standartOut );
        _stringWriter.Close();
    }

    [Test]
    public void TestPrintFrame1()
    {
        PrintFrame( 5, 3, '+' );
        AssertOut( "+++++\n" +
                   "+   +\n" +
                   "+++++" );
    }

    [Test]
    public void TestPrintFrame2()
    {
        PrintFrame2( 5, 4 );
        AssertOut( "*****\n" +
                   "*   *\n" +
                   "*   *\n" +
                   "*****" );
    }

    [Test]
    public void TestGcd()
    {
        That( Gcd( 2, 3 ), Is.EqualTo( 1 ) );
        That( Gcd( 10, 20 ), Is.EqualTo( 10 ) );
        That( Gcd( 15, 20 ), Is.EqualTo( 5 ) );
        That( Gcd( 413100, 283935 ), Is.EqualTo( 15 ) );
    }

    [Test]
    public void TestExpTaylor()
    {
        That( ExpTaylor( 0.0, 10 ), Is.EqualTo( 1.0 ).Within( 1e-2 ) );
        That( ExpTaylor( 1.0, 10 ), Is.EqualTo( Math.E ).Within( 1e-2 ) );
        Double x = new Random().NextDouble();
        That( ExpTaylor( x, 1000 ), Is.EqualTo( Math.Exp( x ) ).Within( 1e-10 ) );
    }

    private void AssertOut( String expected )
    {
        String result =
            _stringWriter.ToString()
                         .Replace( "\r\n", "\n" )
                         .Trim();

        That( result, Is.EqualTo( expected ) );
    }

    [Test]
    public void MainTest()
    {
        Main( Array.Empty<String>() );
    }
}
