using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPEksamensOpgave.Interfaces;
using OOPEksamensOpgave.Commands;
using OOPEksamensOpgave.Exeptions;

namespace OOPEksamensOpgave.Controller
{
    class TallySystemController : ITallySystemController
    {
        //skal modtage en command fra gennem et event
        //skal dele commands op i strings
        //skal aktivere commands
        private ITallySystem ts;
        private ITallySystemUI ui;

        private Dictionary<string, Action<string[]>> adminCommands = new();

        public TallySystemController(ITallySystem tS, ITallySystemUI tSUI)
        {
            ts = tS;
            ui = tSUI;
            ui.CommandEntered += ParseCommand;//adds CommandParser to observers to Command Entered Event

        }

        private void ReloadAdminCommands()
        {
            adminCommands = new Dictionary<string, Action<string[]>>();
            adminCommands.Add(":q", (command) => ui.Close());
            adminCommands.Add(":quit", (command) => ui.Close());
            adminCommands.Add(":activate", (command) => ts.GetProductByID(Convert.ToInt32(command[1])).IsActive = true);
            adminCommands.Add(":deactivate", (command) => ts.GetProductByID(Convert.ToInt32(command[1])).IsActive = false);
            adminCommands.Add(":crediton", (command) => ts.GetProductByID(Convert.ToInt32(command[1])).CanBeBoughtOnCredit = true);
            adminCommands.Add(":creditoff", (command) => ts.GetProductByID(Convert.ToInt32(command[1])).CanBeBoughtOnCredit = false);
            adminCommands.Add(":addcredits", (command) => ts.AddCreditsToAccount(ts.GetUserByUsername(command[1]), Convert.ToDecimal(command[2]))); // add credits
        }


        public void ParseCommand(string command)
        {
            string[] commands = command.Split();
            try
            {
                if (commands[0].First() == ':')
                {
                    ReloadAdminCommands();
                    adminCommands[commands[0]](commands);
                }
                else
                {
                    switch (commands.Length)
                    {
                        case 1: 
                            ui.DisplayUserInfo(ts.GetUserByUsername(commands[0])); 
                            break;
                        case >=2: 
                            UserBuysProductsCommand buyCommand = new UserBuysProductsCommand(ts, ui, commands);
                            buyCommand.Execute();
                            break;
                    }
                }
            }
            catch (InsufficientCreditsException e)
            {
                ui.DisplayInsufficientCash(e.User, e.Product);
            }
            catch (ArgumentNullException e)
            {
                ui.DisplayGeneralError(e.Message);
            }
            catch (NullReferenceException e)
            {
                ui.DisplayGeneralError(e.Message);
            }
            catch (ArgumentException e)
            {
                ui.DisplayGeneralError(e.Message);
            }
            catch (KeyNotFoundException e)
            {
                ui.DisplayAdminCommandNotFoundMessage(e.Source);
            }
            catch (ProductNotFoundException e)
            {
                ui.DisplayProductNotFound(e.ProductID);
            }
            catch(UserNotFoundException e)
            {
                ui.DisplayUserNotFound(e.Username);
            }
        }
    }
}
