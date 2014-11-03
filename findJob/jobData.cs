using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findJob
{
    class jobData : Isubject
    {
        private string newJob;
        ArrayList listObserver;

        public jobData()
        {
            listObserver = new ArrayList();

        }

        public void registerObserver(Iobserver o)
        {
            listObserver.Add(o);
        }

        public void removeObserver(Iobserver obs)
        {
            listObserver.Remove(obs);
        }

        public void notifyObservers()
        {
            int i;
            for (i = 0; i < listObserver.Count; i++)
            {
                observer obs = (observer)listObserver[i];
                obs.update(this.newJob);
            }
        }
        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(string news)
        {
            this.newJob = news;

            measurementsChanged();
        }



    }
}
