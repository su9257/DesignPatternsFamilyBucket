using UnityEngine;
using System.Collections;

namespace DesignPattern_Mediator
{
	public abstract class Mediator
	{
		public abstract void SendMessage(Group theColleague,string Message);
	}

	public class ConcreteMediator : Mediator
	{
		ConcreateGroup0 group0 = null;
		ConcreateGroup1 group1 = null;

		public void SetColleageu1(ConcreateGroup0 theColleague)
		{
			group0 = theColleague;
		}

		public void SetColleageu2(ConcreateGroup1 theColleague)
		{
			group1 = theColleague;
		}

		public override void SendMessage(Group theColleague, string Message)
		{
			if (group0 == theColleague)
				group1.ReceiveMessage(Message);

			if (group1 == theColleague)
				group0.ReceiveMessage(Message);
		}
	}

	public abstract class Group
	{
		protected Mediator mediator = null;
		public Group( Mediator mediator)
		{
			this.mediator = mediator;
		}
		public abstract void ReceiveMessage(string Message);

	}

	public class ConcreateGroup0 : Group
	{
		public ConcreateGroup0( Mediator theMediator) : base(theMediator){}
		public void Action()
		{
			mediator.SendMessage(this,nameof(ConcreateGroup0)+"发出消息");
		}

		public override void ReceiveMessage(string Message)
		{
			Debug.Log(nameof(ConcreateGroup0) + "收到：" + Message);
		}
	}	

	public class ConcreateGroup1 : Group
	{
		public ConcreateGroup1( Mediator theMediator) : base(theMediator){}
		
		public void Action()
		{
			mediator.SendMessage(this, nameof(ConcreateGroup1) + "发出消息");
		}

		public override void ReceiveMessage(string Message)
		{
			Debug.Log(nameof(ConcreateGroup1) +"收到："+ Message);
		}
	}	

}