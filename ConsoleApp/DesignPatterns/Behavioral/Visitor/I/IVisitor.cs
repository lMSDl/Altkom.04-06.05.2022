using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Visitor.I
{
    public interface IVisitor
    {
        void Visit(BoldText text);
        void Visit(PlainText text);
        void Visit(Hyperlink text);
    }
}
