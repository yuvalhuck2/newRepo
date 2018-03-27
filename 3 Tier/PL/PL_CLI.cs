using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend;
using BL;

namespace PL
{
    public class PL_CLI : IPL
    {
        private IBL itsBL;

        public PL_CLI(IBL bl)
        {
            itsBL = bl;
        }

        private void DisplayResult(List<Product> prod)
        {
            foreach (Product p in prod)
            {
                Console.WriteLine(p.Name + " " + p.Type);
            }
        }

        private string ReceiveCmd()
        {
            //add here error checking and parsing
            return Console.ReadLine();
        }


        public void Run()
        {
            List<Product> q;
            string cmd;

            while (true)
            {
                cmd = ReceiveCmd();

                q = itsBL.FindProductByName(cmd);

                DisplayResult(q);
            }
        }
    }
}
