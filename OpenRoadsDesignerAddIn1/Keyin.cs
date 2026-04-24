/*--------------------------------------------------------------------------------------+
|
|     $Source: Keyin.cs $
|
+--------------------------------------------------------------------------------------*/

namespace OpenRoadsDesignerAddIn1
{
    /*=====================================================================================**/
    /* Required | Keyin Class            
    /*=====================================================================================**/
    // Interface between CommandTable.xml and AddIn.cs
    public sealed class Keyin
    {
        /*------------------------------------------------------------------------------------**/
        /* YouAddInName -> YourCommandGroup -> YourCommand1
        /*------------------------------------------------------------------------------------**/
        public static void YourCommand1Start(string unparsed)
        {
            AddIn.Instance().YourCommand1Action(false); //You can pass parameters in caller function from here
        }

        /*------------------------------------------------------------------------------------**/
        /* YouAddInName -> YourCommandGroup -> YourCommand2
        /*------------------------------------------------------------------------------------**/
        public static void YourCommand2Start(string unparsed)
        {
            AddIn.Instance().YourCommand2Action();
        }

        /*------------------------------------------------------------------------------------**/
        /* YouAddInName -> YourDirectCommand
        /*------------------------------------------------------------------------------------**/
        public static void YourDirectCommandStart(string unparsed)
        {
            AddIn.Instance().YourDirectCommandAction();
        }
    }
}

