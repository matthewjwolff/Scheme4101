// Define -- Parse tree node strategy for printing the special form define

using System;

namespace Tree
{
    public class Define : Special
    {
	public Define() { }

        public override void print(Node t, int n, bool p)
        {
            Printer.printDefine(t, n, p);
        }

        public override Node eval(Node t, Environment env)
        {
            Node variable = t.getCdr().getCar();
            if(variable.isPair())
            {
                //variable is of the form (decl params...), ex: (foo x y)
                Node declaration = variable.getCar();
                Node parameters = variable.getCdr();
                Cons lambda = new Cons(new Ident("lambda"),new Cons(parameters,t.getCdr().getCdr().getCar()));
                env.define(declaration,new Closure(lambda, env));
            }
            else
            {
                env.define(variable, t.getCdr().getCdr().getCar().eval(env));
            }
            return new StringLit("definition recorded");
        }
        /**
        Define:
        (define var value)
        (define (func params) ...eval list... )
           > (define func (lambda (params) ...eval list...))
        */
    }
}


