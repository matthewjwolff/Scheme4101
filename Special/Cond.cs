// Cond -- Parse tree node strategy for printing the special form cond

using System;

namespace Tree
{
    public class Cond : Special
    {
	public Cond() { }

        public override void print(Node t, int n, bool p)
        { 
            Printer.printCond(t, n, p);
        }

        public override Node eval(Node t, Environment env)
        {
            Node clauseList = t.getCdr();
            Node clause = clauseList.getCar();
            while(clause != Nil.getInstance())
            {
                Node predicate = clause.getCar().eval(env);
                if(predicate == BoolLit.getInstance(true) || predicate.getName() == "else")
                {
                    Node expressionList = clause.getCdr();
                    //evaluate all expressions and return the result of the last evaluation
                    Node lastEval = expressionList.getCar().eval(env);
                    //If there are more expressions to evaluate
                    while(expressionList.getCdr() != Nil.getInstance())
                    {
                        expressionList = expressionList.getCdr();
                        lastEval = expressionList.getCar().eval(env);
                    }
                    return lastEval;
                }
                clauseList = clauseList.getCdr();
                clause = clauseList.getCar();
            }
            //Does not yet handle else's
            return Nil.getInstance();
        }
    }
}


