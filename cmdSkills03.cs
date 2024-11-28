﻿namespace RevitAIbootcamp
{
    [Transaction(TransactionMode.Manual)]
    public class cmdSkills03 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Revit application and document variables
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            // Your Module 03 Skills code goes here
            // Delete the TaskDialog below and add your code
            TaskDialog.Show("Module 03 Skills", "Got Here!");


            return Result.Succeeded;
        }
    }

}
