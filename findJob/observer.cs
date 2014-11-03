using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findJob
{
    class observer: Iobserver, IdisplayElement
    {
        private Isubject jobStation;
        private string newJob;
        public string nome;

        public observer(Isubject Jobstation)
        {
            this.jobStation = Jobstation;
            jobStation.registerObserver(this);
        }

        public void update(string jobString)
        {
            this.newJob=jobString;
            display();
        }

        public void display()
        {
            System.Console.WriteLine(this.nome+"legge l'annuncio"+ this.newJob);
          
            System.Console.ReadLine();
        }

    }
}
