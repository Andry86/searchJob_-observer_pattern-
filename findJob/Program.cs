using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findJob
{
    class Program
    {
        static void Main(string[] args)
        {
            jobData job = new jobData();
            observer utenteUno = new observer(job);
            observer andrea = new observer(job);
            utenteUno.nome="Mario";
            andrea.nome = "andrea";
            job.setMeasurements("cercasi informatico");
        }
    }
}
