using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Visitor.I
{
    public class HtmlVisitor : IVisitor
    {
        private StringBuilder _stringBuilder = new StringBuilder();

        public void Visit(BoldText text)
        {
            _stringBuilder.Append($"<b>{text.Bold}</b>");
        }

        public void Visit(PlainText text)
        {
            _stringBuilder.Append(text.Text);
        }

        public void Visit(Hyperlink text)
        {
            _stringBuilder.Append($"<a href=\"{text.Url}\">{text.Label}</a>");
        }

        public override string ToString()
        {
            return _stringBuilder.ToString();
        }
    }
}
