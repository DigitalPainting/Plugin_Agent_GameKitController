using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WizardsCode.Plugin;
using WizardsCode.Validation;

namespace WizardsCode.Agent.GameKitController
{
    [CreateAssetMenu(fileName = "Agent_GameKitController_Profile", menuName = "Wizards Code/Agent/GameKitController")]
    public class Agent_GameKitController_Profile : AbstractPluginProfile
    {

        public AgentSettingSO agentSettings;
    }
}
