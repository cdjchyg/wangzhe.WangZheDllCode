using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Action_bt_WrapperAI_Monster_BTMonsterBossPassive_node164 : Action
	{
		private bool method_p0;

		public Action_bt_WrapperAI_Monster_BTMonsterBossPassive_node164()
		{
			this.method_p0 = true;
		}

		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((ObjAgent)pAgent).SetMonsterEnduranceDown(this.method_p0);
			return EBTStatus.BT_FAILURE;
		}
	}
}
