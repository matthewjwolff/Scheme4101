using System;

namespace Tree
{
    public class NothingNode : Node
    {
        private static NothingNode instance = new NothingNode();
        private NothingNode() { }
        public static NothingNode getInstance()
        {
            return instance;
        }
        public override void print(int n)
        {
            
        }
        public override void print(int n, bool p)
        {
            
        }
    }
}
