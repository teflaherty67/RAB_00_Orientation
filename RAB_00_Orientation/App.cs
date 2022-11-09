#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;

#endregion

namespace RAB_00_Orientation
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            TaskDialog.Show("Greetings", "Entering Revit Add-in Bootcamp");

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            TaskDialog.Show("Goodbye", "Exiting Revit Add-in Bootcamp");

            return Result.Succeeded;
        }
    }
}
