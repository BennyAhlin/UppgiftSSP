
using System.Runtime.CompilerServices;

namespace UppgiftSSP;

public enum Menu
{
    PvP,
    Bot,

}



public static class MenuExtension
{

    public static string MenuOption(this Menu self)
    {

         switch (self)
        {
            case Menu.Bot:     //Return 1
               return "pve";
            case Menu.PvP:    //Return 2
                return "pvp";
        }
        throw new Exception();  //Crash

    }





















}