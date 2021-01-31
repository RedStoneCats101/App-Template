using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myAssistantDevAPI;

namespace App_Template
{
    public class App : app
    {
        /*
         * the method that is called when the app is loaded it must retern this; 
         */

        public override app LoadApp()
        {
            /*
             * this method adds the OnWordDectectedEvent hi to this app
             * the frest arg is the OnWordDectectedEvent that is regester
             * the second arg is the Keyword it will be called on
            */

            RegesterOnWordDectectedEvent(new hi(), "hi");

            /*
             * this reterns the app to myAssistant affter all events are regeterd and is simeler to the main method in a standerd program
             */

            return this;
        }

        /*
         * a class that incstends the class onWordDectectedEvent from the myAssistantDevAPI
         */

        class hi : onWordDectectedEvent
        {
            /*
             * the method from the myAssistantDevAPI that is called when the event is detected
             * the arg reslat is the string that was trigger the event
             */

            public override void onWordDectected(String result)
            {
                /*
                 * Say.say is a utilty method that speckes a string or int
                 * the frst arg is the String / int that is spockan
                 */

                Say.say("hi to you to");
            }
        }
    }
}
