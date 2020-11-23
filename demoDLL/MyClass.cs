using System;
using mySuperNameSpace;


namespace demoDLL
{
    public class MyClass
    {
        private bool myBool;
        public string MyString = "hello China";

        public void MyFunction()
        {
            myBool = true;
            Console.WriteLine("test method");
        }
    }
}
