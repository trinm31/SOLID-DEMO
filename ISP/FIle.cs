using System;

namespace ISP
{
    public class FIle:IFile
    {
        public void Read()
        {
            // code here
        }

        public void Write()
        {
            Console.WriteLine("Access Deny");
        }
    }
}