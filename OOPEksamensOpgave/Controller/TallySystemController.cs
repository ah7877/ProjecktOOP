using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPEksamensOpgave.Interfaces;

namespace OOPEksamensOpgave.Controller
{
    class TallySystemController : ITallySystemController
    {
        /*
         exeptions used
            catch(InsufficientCreditsException e)
            {
                Call UI func
            }
            catch(ArgumentNullException e)
            {
                Call UI func
            }
            catch(InsufficientCreditsException e)
            {
                Call UI func
            }
            catch(NullReferenceException e)
            {
                Call UI func
            }
            catch(ArgumentException e)
            {
                Call UI func
            }
         */
        private ITallySystem _tS;
        private ITallySystemUI _tSUI;

        public TallySystemController(ITallySystem tS, ITallySystemUI tSUI)
        {
            TS = tS;
            TSUI = tSUI;
        }

        public ITallySystem TS
        {
            get { return _tS; }
            set { _tS = value; }
        } 

        public ITallySystemUI TSUI
        {
            get { return _tSUI; }
            set { _tSUI = value; }
        }

        public void ParseCommand(string command)
        {
            //splits the command up
            //checks the command
            //executes
            switch(command)
            {
                case ":q": break;
            }
        }
    }
}
