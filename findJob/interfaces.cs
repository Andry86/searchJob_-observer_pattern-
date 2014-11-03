using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findJob
{
    interface Isubject
    {
        void registerObserver(Iobserver o);
        void removeObserver(Iobserver o);
        void notifyObservers();
    }


    public interface Iobserver
    {
         void update(string temp);
    }

    public interface IdisplayElement
    {
         void display();
    }
}
