// BuiltIn -- the data structure for built-in functions

// Class BuiltIn is used for representing the value of built-in functions
// such as +.  Populate the initial environment with
// (name, new BuiltIn(name)) pairs.

// The object-oriented style for implementing built-in functions would be
// to include the C# methods for implementing a Scheme built-in in the
// BuiltIn object.  This could be done by writing one subclass of class
// BuiltIn for each built-in function and implementing the method apply
// appropriately.  This requires a large number of classes, though.
// Another alternative is to program BuiltIn.apply() in a functional
// style by writing a large if-then-else chain that tests the name of
// the function symbol.

using System;

namespace Tree
{
    public class BuiltIn : Node
    {
        private Node symbol;            // the Ident for the built-in function

        public BuiltIn(Node s)		{ symbol = s; }

        public Node getSymbol()		{ return symbol; }

        // TODO: The method isProcedure() should be defined in
        // class Node to return false.
        public override bool isProcedure()	{ return true; }

        public override void print(int n)
        {
            // there got to be a more efficient way to print n spaces
            for (int i = 0; i < n; i++)
                Console.Write(' ');
            Console.Write("#{Built-in Procedure ");
            if (symbol != null)
                symbol.print(-Math.Abs(n));
            Console.Write('}');
            if (n >= 0)
                Console.WriteLine();
        }

        // TODO: The method apply() should be defined in class Node
        // to report an error.  It should be overridden only in classes
        // BuiltIn and Closure.
        public override Node apply (Node args)
        {
            Node arg1 = args.getCar();
            Node arg2 = args.getCdr();

            if (symbol.getName().Equals("symbol?"))
            {
                return BoolLit.getInstance(symbol.isSymbol());
            }
            else if (symbol.getName().Equals("number?"))
            {
                return BoolLit.getInstance(symbol.isNumber());
            }
            else if (symbol.getName().Equals("b+"))
            {
                IntLit num1 = (IntLit)arg1;
                IntLit num2 = (IntLit)arg2.getCar();
                return new IntLit(num1.getValue() + num2.getValue());     
            }
            else if (symbol.getName().Equals("b-"))
            {
                IntLit num1 = (IntLit)arg1;
                IntLit num2 = (IntLit)arg2.getCar();
                return new IntLit(num1.getValue() - num2.getValue());
            }
            else if (symbol.getName().Equals("b*"))
            {
                IntLit num1 = (IntLit)arg1;
                IntLit num2 = (IntLit)arg2.getCar();
                return new IntLit(num1.getValue() * num2.getValue());
            }
            else if (symbol.getName().Equals("b/"))
            {
                IntLit num1 = (IntLit)arg1;
                IntLit num2 = (IntLit)arg2.getCar();
                return new IntLit(num1.getValue() / num2.getValue());
            }
            else if (symbol.getName().Equals("b="))
            {
                IntLit num1 = (IntLit)arg1;
                IntLit num2 = (IntLit)arg2.getCar();
                return BoolLit.getInstance(num1.getValue() == num2.getValue());
            }
            else if (symbol.getName().Equals("b<"))
            {
                IntLit num1 = (IntLit)arg1;
                IntLit num2 = (IntLit)arg2.getCar();
                return BoolLit.getInstance((num1.getValue() < num2.getValue());
            }
            else if (symbol.getName().Equals("car"))
            {
                return arg1;
            }
            else if (symbol.getName().Equals("cdr"))
            {
                return arg2;
            }
            else if (symbol.getName().Equals("cons"))
            {
                arg1 = new Cons(getCar(), getCdr());
                return arg1;
            }
            else if (symbol.getName().Equals("set-car!"))
            {
                arg1.setCar(arg2);
                return arg1;
            }
            else if (symbol.getName().Equals("set-cdr!"))
            {
                arg1.setCdr(arg2);
                return arg1;
            }
            else if (symbol.getName().Equals("null?"))
            {
                arg1.isNull();
                return arg1;
            }
            else if (symbol.getName().Equals("pair?"))
            {
                arg1.isPair();
                return arg1;
            }
            else if (symbol.getName().Equals("eq?"))
            {
               
            }
            else if (symbol.getName().Equals("procedure?"))
            {

            }
            else if (symbol.getName().Equals("read"))
            {

            }
            else if (symbol.getName().Equals("write"))
            {

            }
            else if (symbol.getName().Equals("display"))
            {

            }
            else if (symbol.getName().Equals("newline"))
            {
                
            }
            else if (symbol.getName().Equals("eval"))
            {
                return arg1;
            }
            else if (symbol.getName().Equals("apply"))
            {
                return arg1.apply(arg2);
            }
            else if (symbol.getName().Equals("interaction-environment"))
            {

            }
            else return new StringLit("Error: Builtin[" + symbol.getName() + "].apply not yet implemented");
    	}
    }    
}

