using UnityEngine;
using System.Collections.Generic;

namespace DesignPattern_Visitor
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElement(this);
        }

        public void OperationA()
        {
            Debug.Log($"{nameof(ConcreteElementA)}：{nameof(OperationA)}");
        }
    }
    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElement(this);
        }

        public void OperationB()
        {
            Debug.Log($"{nameof(ConcreteElementB)}：{nameof(OperationB)}");
        }
    }

    public abstract class Visitor
    {
        public abstract void VisitConcreteElement(ConcreteElementA element);
        public abstract void VisitConcreteElement(ConcreteElementB element);
    }
    public class ConcreteVicitor : Visitor
    {
        public override void VisitConcreteElement(ConcreteElementA element)
        {
            element.OperationA();
        }
        public override void VisitConcreteElement(ConcreteElementB element)
        {
            element.OperationB();
        }
    }

    public class ObjectStructure
    {
        List<Element> context = new List<Element>();

        public ObjectStructure()
        {
            context.Add(new ConcreteElementA());
            context.Add(new ConcreteElementB());
        }

        public void RunVisitor(Visitor visitor)
        {
            for (int i = 0; i < context.Count; i++)
            {
                context[i].Accept(visitor);
            }
        }
    }

}
