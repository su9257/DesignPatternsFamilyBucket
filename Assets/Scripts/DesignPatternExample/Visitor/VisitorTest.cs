using UnityEngine;
using System.Collections;
using DesignPattern_Visitor;

public class VisitorTest : MonoBehaviour
{

    void Start()
    {
        ObjectStructure structure = new ObjectStructure();

        structure.RunVisitor(new ConcreteVicitor());
    }

}
