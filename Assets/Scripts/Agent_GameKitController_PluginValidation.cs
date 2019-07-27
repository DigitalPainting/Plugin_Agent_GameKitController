using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WizardsCode.Validation;

namespace WizardsCode.Agent.GameKitController
{
    public class Agent_GameKitController_PluginValidation : ValidationTest<Agent_GameKitController_PluginManager>
    {
        public override ValidationTest<Agent_GameKitController_PluginManager> Instance => new Agent_GameKitController_PluginValidation();

        internal override Type ProfileType => typeof(Agent_GameKitController_Profile);
    }
}