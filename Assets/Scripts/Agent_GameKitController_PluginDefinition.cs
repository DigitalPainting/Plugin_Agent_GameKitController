using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WizardsCode.Plugin;

namespace WizardsCode.Agent.GameKitController
{
    public class Agent_GameKitController_PluginDefinition : AbstractPluginDefinition
    {
        public override PluginCategory GetCategory()
        {
            return PluginCategory.Agent;
        }

        public override Type GetManagerType()
        {
            return typeof(Agent_GameKitController_PluginManager);
        }

        public override string GetPluginImplementationClassName()
        {
            return "playerCharactersManager";
        }

        public override Type GetProfileTypeName()
        {
            return typeof(Agent_GameKitController_Profile);
        }

        public override string GetReadableName()
        {
            return "Game Kit Controller (Two Cube Studios)";
        }

        public override string GetURL()
        {
            return "https://assetstore.unity.com/packages/templates/systems/game-kit-controller-40995";
        }
    }
}
