/*--------------------------------------------------------------------------------------+
|
|     $Source: AddIn.cs $
|
+--------------------------------------------------------------------------------------*/

using Bentley.CifNET.GeometryModel.SDK;
using System;
using System.Collections.Generic;

namespace OpenRoadsDesignerAddIn1
{
    /*=====================================================================================**/
    /* Required | Implementation of Addin Class            
    /*=====================================================================================**/
    [Bentley.MstnPlatformNET.AddInAttribute(MdlTaskID = "AddIn")]
    public sealed class AddIn : Bentley.MstnPlatformNET.AddIn
    {
        private static AddIn s_ordAddIn = null;

        public AddIn(System.IntPtr mdlDesc)
            : base(mdlDesc)
        {
            s_ordAddIn = this;
        }

        protected override int Run(string[] commandLine)
        {
            Bentley.CifNET.SDK.Edit.ConsensusConnectionEdit sdkCon = Bentley.CifNET.SDK.Edit.ConsensusConnectionEdit.GetActive();

            Bentley.CifNET.GeometryModel.SDK.GeometricModel geomModel = sdkCon.GetActiveGeometricModel();

            List<CorridorObject> corridorObjects = new List<CorridorObject>();

            foreach (Corridor corridor in geomModel.Corridors)
            {
                CorridorObject corridorObject = new CorridorObject()
                {
                    Name = corridor.Name,
                    Description = corridor.FeatureName,
                    AlignmentName = corridor.CorridorAlignment.Name
                };
                corridorObjects.Add(corridorObject);
            }

            File.WriteAllLines("CorridorObjects.csv", corridorObjects.Select(co => $"{co.Name},{co.Description},{co.AlignmentName}"));

            return 0;
        }

        internal static AddIn Instance()
        {
            return s_ordAddIn;
        }


        /*=====================================================================================**/
        /* Functions Mapped to Commands           
        /*=====================================================================================**/

        /* YourAddInName -> YourCommandGroup -> YourCommand1
        /*------------------------------------------------------------------------------------**/
        internal void YourCommand1Action(bool valueToTest)
        {
            if (valueToTest)
            {
                // DO SOMETHING
            }
            else
            {
                // DO SOMETHING ELSE
            }
        }

        /* YourAddInName -> YourCommandGroup -> YourCommand2
        /*--------------+---------------+---------------+---------------+---------------+------*/
        internal void YourCommand2Action()
        {
            // DO SOMETHING
        }

        /* YourAddInName -> YourDirectCommand
        /*--------------+---------------+---------------+---------------+---------------+------*/
        internal void YourDirectCommandAction()
        {
            // DO SOMETHING

            #region Access most commonly required objects like Alignment, Corridor etc.

            //In case, DGN already have Civil Objects like Alignment or Corridor then please use below code to get GeometricModel
            #region Get Active Geometric Model (Civil objects present in DGN)

            //Get Active Model from DGN
            Bentley.DgnPlatformNET.DgnModel activeModel = Bentley.MstnPlatformNET.Session.Instance.GetActiveDgnModel();
            //Get Connection from Active Model
            Bentley.CifNET.SDK.ConsensusConnection con = new Bentley.CifNET.SDK.ConsensusConnection(activeModel);
            //Get Connection from Active Model
            Bentley.CifNET.GeometryModel.SDK.GeometricModel geomModel = con.GetActiveGeometricModel();

            #endregion

            //In case, DGN is EMPTY or do not have any Civil Objects like Alignment or Corridor then please use below code to get GeometricModel
            #region Get Or Create Geometric Model (No Civil Objects in DGN)

            //Get Active Connection
            Bentley.CifNET.SDK.Edit.ConsensusConnectionEdit conEdit = Bentley.CifNET.SDK.Edit.ConsensusConnectionEdit.GetActive();
            //Get Connection from Active Model or Create New one in case of Blank DGN 
            Bentley.CifNET.GeometryModel.SDK.GeometricModel geomModelEdit = Bentley.CifNET.GeometryModel.SDK.Edit.ConsensusConnectionExtensions.GetOrCreateGeometricModel(conEdit);

            #endregion

            //List All AlignMents
            foreach (Alignment al in geomModel.Alignments)
            {
                //Do Something with Alignment
            }


            //List All Corridors
            foreach (Corridor cor in geomModel.Corridors)
            {
                //Do Something with Corridor
            }

            //AND SO ON


            #endregion

        }

    }
}
