#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

#endregion

namespace RAB_00_Orientation
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            TaskDialog.Show("Test", "This is my first command add-in");

            TaskDialog.Show("Test", "This is a change I made to my first command add-in");

            TaskDialog.Show("Test", "This is yet another change I made to my first command add-in");
            
             TaskDialog.Show("Test", "This is a change I made in GitHub to my first command add-in");

            return Result.Succeeded;
        }
    }
}
