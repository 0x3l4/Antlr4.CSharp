using Antlr4.Runtime;

namespace Antlr4VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "int a = 5;";
            ICharStream inputStream = CharStreams.fromString(input);
            CSharpLexer lexer = new(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
            CSharpParser parser = new(commonTokenStream);
            CSharpParser.ExpressionContext expressionContext = parser.expression();


            ICSharpParserVisitor<string> visitor = new CSharpParserBaseVisitor<string>();

            Console.WriteLine(visitor.Visit(expressionContext));
        }
    }
}
